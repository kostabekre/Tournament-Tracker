using TrackerLibrary.DataAccess;
using System.Configuration;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {

        public const string PrizesFile = "PrizeModels.csv";
        public const string PeopleFile = "PersonModels.csv";
        public const string TeamFile = "TeamModels.csv";
        public const string TournamentFile = "TournamentModels.csv";
        public const string MatchupFile = "MatchupModels.csv";
        public const string MatchupEntryFile = "MatchupEntryModels.csv";

        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DatabaseType databaseType)
        {
            switch (databaseType)
            {
                case DatabaseType.SQL:
                    // TODO: set up the sql Connector properly
                    var sql = new SqlConnector();
                    Connection = sql;
                    break;
                case DatabaseType.TextFile:
                    // TODO: set up the text Connector properly
                    var text = new TextConnector();
                    Connection = text;
                    break;
                default:
                    break;
            }
        }

        public static string GetCnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
        
        public static string AppKeyLookup(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
