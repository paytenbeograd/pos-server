namespace PosServer.Core
{
    public class AppSettings
    {
        public ConnectionStrings ConnectionStrings { get; set; }
    }

    public class ConnectionStrings
    {
        public string PosServer { get; set; }

    }
}
