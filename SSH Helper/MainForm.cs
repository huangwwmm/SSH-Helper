using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Renci.SshNet;
using Renci.SshNet.Common;

namespace SSH_Helper
{
    public partial class MainForm : Form
    {
        private StringBuilder m_CommandResultCache;
        private SshClient[] m_Clients;
        private Config[] m_Configs;

        private SshClient m_CurrentClient;
        private Config m_CurrentConfig;

        private ToolTip m_FunctionTooltip;
        private Button[] m_FunctionButtons;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Initialize()
        {
            m_Configs = LitJson.JsonMapper.ToObject<Config[]>(File.ReadAllText("config.json"));
            m_Clients = new SshClient[m_Configs.Length];

            m_ServersComboBox.SelectedValueChanged -= OnServersComboBox_SelectedValueChanged;
            m_ServersComboBox.Items.Clear();
            for (int iConfig = 0; iConfig < m_Configs.Length; iConfig++)
            {
                Config iterConfig = m_Configs[iConfig];
                m_ServersComboBox.Items.Add(string.Format("{0} : {1}", iterConfig.Name, iterConfig.Host));
            }
            m_ServersComboBox.SelectedValueChanged += OnServersComboBox_SelectedValueChanged;

            m_FunctionsPanel.Controls.Clear();
            m_ConnectButton.Enabled = false;
            m_DisconnectButton.Enabled = false;
        }

        private void Destory()
        {
            m_CurrentClient = null;
            m_CurrentConfig = null;

            for (int iClient = 0; iClient < m_Clients.Length; iClient++)
            {
                SshClient iterClient = m_Clients[iClient];
                if (iterClient != null && iterClient.IsConnected)
                {
                    iterClient.Disconnect();
                }
            }
            m_Clients = null;

            m_Configs = null;
        }

        private void OnMainForm_Shown(object sender, EventArgs e)
        {
            m_FunctionTooltip = new ToolTip
            {
                AutoPopDelay = 0,
                InitialDelay = 1000,
                ReshowDelay = 500,
                ShowAlways = true
            };

            m_CommandResultCache = new StringBuilder();

            Initialize();
        }

        private void OnMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Destory();

            m_CommandResultCache = null;
        }

        private void OnConnectButton_Click(object sender, EventArgs e)
        {
            if (!m_CurrentClient.IsConnected)
            {
                try
                {
                    m_CurrentClient.Connect();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Client Connect Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            UpdateDisplay();
        }

        private void OnDisconnectButton_Click(object sender, EventArgs e)
        {
            if (m_CurrentClient.IsConnected)
            {
                m_CurrentClient.Disconnect();
            }

            UpdateDisplay();
        }

        private void OnServersComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            int index = m_ServersComboBox.SelectedIndex;
            m_CurrentConfig = m_Configs[index];
            m_CurrentClient = m_Clients[index];
            if (m_CurrentClient == null)
            {
                m_CurrentClient = new SshClient(new ConnectionInfo(m_CurrentConfig.Host
                    , m_CurrentConfig.Port
                    , m_CurrentConfig.User
                    , new PasswordAuthenticationMethod(m_CurrentConfig.User
                        , m_CurrentConfig.Passwd)));
                m_Clients[index] = m_CurrentClient;
            }

            m_FunctionsPanel.Controls.Clear();
            m_FunctionButtons = new Button[m_CurrentConfig.Functions.Length];
            for (int iFunction = 0; iFunction < m_CurrentConfig.Functions.Length; iFunction++)
            {
                Function iterFunction = m_CurrentConfig.Functions[iFunction];
                Button iterButton = CreateFunctionTemplateButton();
                iterButton.Text = iterFunction.Name;
                iterButton.Tag = iFunction;
                iterButton.Click += OnFunctionButton_Click;
                if (!string.IsNullOrEmpty(iterFunction.Remarks))
                {
                    m_FunctionTooltip.SetToolTip(iterButton, iterFunction.Remarks);
                }
                m_FunctionButtons[iFunction] = iterButton;
            }

            UpdateDisplay();
        }

        private void OnFunctionButton_Click(object sender, EventArgs e)
        {
            if (!m_CurrentClient.IsConnected)
            {
                MessageBox.Show("Already disconnect!", "Already disconnect!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UpdateDisplay();
                return;
            }

            int index = (int)((Button)sender).Tag;
            Function function = m_CurrentConfig.Functions[index];
            m_CommandResultCache.Clear();
            SshCommand command = m_CurrentClient.CreateCommand("");
            for (int iCommand = 0; iCommand < function.Commands.Length; iCommand++)
            {
                command.Execute(function.Commands[iCommand]);
                m_CommandResultCache.AppendLine("# " + command.CommandText);
                m_CommandResultCache.AppendLine(command.Result);
                if (!string.IsNullOrEmpty(command.Error))
                {
                    m_CommandResultCache.AppendLine("Error:");
                    m_CommandResultCache.AppendLine(command.Error);
                }
            }

            MessageBox.Show(m_CommandResultCache.ToString(), "Function Result!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateDisplay()
        {
            bool isConnected = m_CurrentClient.IsConnected;
            m_ConnectButton.Enabled = !isConnected;
            m_DisconnectButton.Enabled = isConnected;

            for (int iFunction = 0; iFunction < m_FunctionButtons.Length; iFunction++)
            {
                Button iterButton = m_FunctionButtons[iFunction];
                iterButton.Enabled = isConnected;
            }
        }

        private Button CreateFunctionTemplateButton()
        {
            Button button = new Button();
            button.Margin = new Padding(6);
            button.Size = new System.Drawing.Size(334, 43);
            button.UseVisualStyleBackColor = true;
            m_FunctionsPanel.Controls.Add(button);
            return button;
        }

        private void OnReloadConfigButton_Click(object sender, EventArgs e)
        {
            Destory();
            Initialize();
        }
    }
}
