using TrackerLibrary.DataAccess;
using System.Configuration;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                // TODO: set up the sql Connector properly
                var sql = new SqlConnector();
                Connections.Add(sql);
            }

            if (textFiles)
            {
                // TODO: set up the text Connector properly
                var text = new TextConnector();
                Connections.Add(text);
            }
        }

        public static string GetCnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
