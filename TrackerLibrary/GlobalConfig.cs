namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; }

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                // TODO: create the SQL connection
                throw new NotImplementedException();
            }

            if (textFiles)
            {
                // TODO: create the Text connection
                throw new NotImplementedException();
            }
        }
    }
}
