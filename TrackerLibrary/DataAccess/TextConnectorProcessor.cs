using System.Configuration;
using System.Drawing;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {

        static TextConnectorProcessor()
        {
            if(!Directory.Exists(GetAppFolder())) Directory.CreateDirectory(GetAppFolder());
        }
        /// <summary>
        /// Return the full path when you give short file name.
        /// </summary>
        /// <remarks>I implemented to make it cross-platform rather using Tim's solution</remarks>
        /// <param name="fileName">the short file name in the appication folder.</param>
        /// <returns>the full path to the file.</returns>
        public static string FullFilePath(this string fileName) => 
                GetAppFolder()
                + Path.DirectorySeparatorChar 
                + fileName;

        public static string GetAppFolder() =>
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                + Path.DirectorySeparatorChar
                + ConfigurationManager.AppSettings["ProjectName"];

        /// <summary>
        /// Reads the file and returns the content.
        /// </summary>
        /// <param name="fullFileName">the full file path.</param>
        /// <returns>If file not exists, returns empty list, else returns List of strings.</returns>
        public static List<string> LoadFile(this string fullFileName)
        {
            if (!File.Exists(fullFileName))
            {
                return new List<string>();
            }
            return File.ReadAllLines(fullFileName).ToList();
        }

        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            var output = new List<PrizeModel>();

            foreach(var line in lines)
            {
                string[] cols = line.Split(',');

                var p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount= decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);

                output.Add(p);
            }

            return output;
        }

        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            var output = new List<PersonModel>();

            foreach(var line in lines)
            {
                string[] cols = line.Split(',');

                 var p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress= cols[3];
                p.CellphoneNumber = cols[4];

                output.Add(p);
            }

            return output;
        }
        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string peopleFileName)
        {
            //id, team name, list of ids separated by the pipe
            var output = new List<TeamModel>();
            var people = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModels();

            foreach (var line in lines)
            {
                string[] cols = line.Split(',');

                var t = new TeamModel();
                t.Id = int.Parse(cols[0]);
                t.TeamName = cols[1];

                string[] personIds = cols[2].Split("|");

                foreach (string id in personIds)
                {
                    t.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
                }

                output.Add(t);
            }

            return output;

        }
        
        public static List<TournamentModel> ConvertToTournamentModels(this List<string> lines, 
            string teamFileName, 
            string peopleFileName, 
            string prizesFileName, 
            string tournamentFileName)
        {
            //id,TournamentName,EntryFee,(id|id|id - EnteredTeams),(id|id|id - Prizes),(Rounds - id^id^id|id^id^id|id^id^id)
            var output = new List<TournamentModel>();
            var teams = teamFileName.FullFilePath().LoadFile().ConvertToTeamModels(peopleFileName);
            var prizes = prizesFileName.FullFilePath().LoadFile().ConvertToPrizeModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                var tm = new TournamentModel();
                tm.Id = int.Parse(cols[0]);
                tm.TournamentName = cols[1];
                tm.EntryFee = decimal.Parse(cols[2]);

                string[] teamIds = cols[3].Split("|");

                foreach (string id in teamIds)
                {
                    tm.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());
                }

                string[] prizeIds = cols[4].Split("|");
                foreach(string id in prizeIds)
                {
                    tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
                }

                //TODO - Capture rounds information
                output.Add(tm);
            }
            return output;
        }

        public static void SaveToPrizesFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in models)
            {
                lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToPeopleFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (var p in models)
            {
                lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.CellphoneNumber}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);

        }

        public static void SaveToTeamFile(this List<TeamModel> models, string fileName)
        {
            var lines = new List<string>();

            foreach (TeamModel t in models)
            {
                lines.Add($"{t.Id},{t.TeamName},{ConvertPeopleListToString(t.TeamMembers)}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToTournamentFile(this List<TournamentModel> models, string tournamentFileName)
        {
            var lines = new List<string>();

            foreach(TournamentModel tm in models)
            {
                lines.Add($"{tm.Id}," +
                    $"{tm.TournamentName}," +
                    $"{tm.EntryFee}," +
                    $"{ConvertTeamListToString(tm.EnteredTeams)}," +
                    $"{ConvertPrizeListToString(tm.Prizes)}," +
                    $"{ConvertRoundListToString(tm.Rounds)}");
            }

            File.WriteAllLines(tournamentFileName.FullFilePath(), lines);
        }

        private static string ConvertRoundListToString(List<List<MatchupModel>> rounds)
        {
            string output = "";

            if(rounds.Count == 0)
            {
                return "";
            }

            foreach (List<MatchupModel> round in rounds)
            {
                output += $"{ConvertMatchupListToString(round)}|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;


        }
        private static string ConvertMatchupListToString(List<MatchupModel> matchups)
        {
            string output = "";

            if(matchups.Count == 0)
            {
                return "";
            }

            foreach (var matchup in matchups)
            {
                output += $"{matchup.Id}^";
            }

            output = output.Substring(0, output.Length - 1);

            return output;


        }
        private static string ConvertPrizeListToString(List<PrizeModel> prizes)
        {
            string output = "";

            if(prizes.Count == 0)
            {
                return "";
            }

            foreach (var prize in prizes)
            {
                output += $"{prize.Id}|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;

        }
        private static string ConvertTeamListToString(List<TeamModel> teams)
        {
            string output = "";

            if(teams.Count == 0)
            {
                return "";
            }

            foreach (var team in teams)
            {
                output += $"{team.Id}|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }
        private static string ConvertPeopleListToString(List<PersonModel> people)
        {
            string output = "";

            if (people.Count == 0)
            {
                return "";
            }

            foreach (PersonModel person in people)
            {
                output += $"{person.Id}|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }

    }
}
