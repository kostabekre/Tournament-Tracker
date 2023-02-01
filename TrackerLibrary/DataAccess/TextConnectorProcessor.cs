using System.Configuration;
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

        public static List<PrizeModel> ConvertToPirzeModels(this List<string> lines)
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

        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in models)
            {
                lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }
}
