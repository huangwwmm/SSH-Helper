namespace SSH_Helper
{
    [System.Serializable]
    public class Config
    {
        public string Name;
        public string Host;
        public int Port;
        public string User;
        public string Passwd;
        public Function[] Functions;
    }

	[System.Serializable]
    public class Function
    {
        public string Name;
        public string Remarks;
        public string[] Commands;
    }
}
