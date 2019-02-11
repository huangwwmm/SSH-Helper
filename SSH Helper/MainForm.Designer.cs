namespace SSH_Helper
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Panel panel1;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
            this.m_ServersComboBox = new System.Windows.Forms.ComboBox();
            this.m_DisconnectButton = new System.Windows.Forms.Button();
            this.m_ConnectButton = new System.Windows.Forms.Button();
            this.m_ReloadConfigButton = new System.Windows.Forms.Button();
            this.m_FunctionsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            this.m_FunctionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(this.m_ServersComboBox);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(6);
            panel1.Name = "panel1";
            panel1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 4);
            panel1.Size = new System.Drawing.Size(1163, 62);
            panel1.TabIndex = 2;
            // 
            // m_ServersComboBox
            // 
            this.m_ServersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_ServersComboBox.Font = new System.Drawing.Font("SimSun", 9.75F);
            this.m_ServersComboBox.FormattingEnabled = true;
            this.m_ServersComboBox.IntegralHeight = false;
            this.m_ServersComboBox.ItemHeight = 26;
            this.m_ServersComboBox.Location = new System.Drawing.Point(12, 18);
            this.m_ServersComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.m_ServersComboBox.Name = "m_ServersComboBox";
            this.m_ServersComboBox.Size = new System.Drawing.Size(469, 34);
            this.m_ServersComboBox.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(this.m_DisconnectButton);
            flowLayoutPanel1.Controls.Add(this.m_ConnectButton);
            flowLayoutPanel1.Controls.Add(this.m_ReloadConfigButton);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new System.Drawing.Point(587, 2);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(576, 56);
            flowLayoutPanel1.TabIndex = 4;
            flowLayoutPanel1.WrapContents = false;
            // 
            // m_DisconnectButton
            // 
            this.m_DisconnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_DisconnectButton.Font = new System.Drawing.Font("SimSun", 9.75F);
            this.m_DisconnectButton.Location = new System.Drawing.Point(390, 8);
            this.m_DisconnectButton.Margin = new System.Windows.Forms.Padding(6, 8, 6, 6);
            this.m_DisconnectButton.Name = "m_DisconnectButton";
            this.m_DisconnectButton.Size = new System.Drawing.Size(180, 46);
            this.m_DisconnectButton.TabIndex = 1;
            this.m_DisconnectButton.TabStop = false;
            this.m_DisconnectButton.Text = "Disconnect";
            this.m_DisconnectButton.UseVisualStyleBackColor = true;
            this.m_DisconnectButton.Click += new System.EventHandler(this.OnDisconnectButton_Click);
            // 
            // m_ConnectButton
            // 
            this.m_ConnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_ConnectButton.Font = new System.Drawing.Font("SimSun", 9.75F);
            this.m_ConnectButton.Location = new System.Drawing.Point(218, 8);
            this.m_ConnectButton.Margin = new System.Windows.Forms.Padding(6, 8, 6, 6);
            this.m_ConnectButton.Name = "m_ConnectButton";
            this.m_ConnectButton.Size = new System.Drawing.Size(160, 46);
            this.m_ConnectButton.TabIndex = 3;
            this.m_ConnectButton.TabStop = false;
            this.m_ConnectButton.Text = "Connect";
            this.m_ConnectButton.UseVisualStyleBackColor = true;
            this.m_ConnectButton.Click += new System.EventHandler(this.OnConnectButton_Click);
            // 
            // m_ReloadConfigButton
            // 
            this.m_ReloadConfigButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_ReloadConfigButton.Font = new System.Drawing.Font("SimSun", 8F);
            this.m_ReloadConfigButton.Location = new System.Drawing.Point(6, 8);
            this.m_ReloadConfigButton.Margin = new System.Windows.Forms.Padding(6, 8, 6, 6);
            this.m_ReloadConfigButton.Name = "m_ReloadConfigButton";
            this.m_ReloadConfigButton.Size = new System.Drawing.Size(200, 46);
            this.m_ReloadConfigButton.TabIndex = 4;
            this.m_ReloadConfigButton.TabStop = false;
            this.m_ReloadConfigButton.Text = "Reload Config";
            this.m_ReloadConfigButton.UseVisualStyleBackColor = true;
            this.m_ReloadConfigButton.Click += new System.EventHandler(this.OnReloadConfigButton_Click);
            // 
            // m_FunctionsPanel
            // 
            this.m_FunctionsPanel.AutoScroll = true;
            this.m_FunctionsPanel.Controls.Add(this.button5);
            this.m_FunctionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_FunctionsPanel.Location = new System.Drawing.Point(0, 62);
            this.m_FunctionsPanel.Name = "m_FunctionsPanel";
            this.m_FunctionsPanel.Size = new System.Drawing.Size(1163, 322);
            this.m_FunctionsPanel.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 6);
            this.button5.Margin = new System.Windows.Forms.Padding(6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(334, 43);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 384);
            this.Controls.Add(this.m_FunctionsPanel);
            this.Controls.Add(panel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnMainForm_FormClosed);
            this.Shown += new System.EventHandler(this.OnMainForm_Shown);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            this.m_FunctionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox m_ServersComboBox;
        private System.Windows.Forms.Button m_DisconnectButton;
        private System.Windows.Forms.Button m_ConnectButton;
        private System.Windows.Forms.FlowLayoutPanel m_FunctionsPanel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button m_ReloadConfigButton;
    }
}

