using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.Models.Static_Resources
{
    static class HighScoresClass
    {
        /// <summary>
        /// List of all users to get highscores
        /// </summary>
        private static List<UserInfo> users = new List<UserInfo>();
        /// <summary>
        /// All addition high scores
        /// </summary>
        private static List<KeyValuePair<string, int>> additionHighScores = new List<KeyValuePair<string, int>>();
        /// <summary>
        /// All subtraction high scores
        /// </summary>
        private static List<KeyValuePair<string, int>> subtractionHighScores = new List<KeyValuePair<string, int>>();
        /// <summary>
        /// All multiplication high scores
        /// </summary>
        private static List<KeyValuePair<string, int>> multiplicationHighScores = new List<KeyValuePair<string, int>>();
        /// <summary>
        /// All division high scores
        /// </summary>
        private static List<KeyValuePair<string, int>> divisionHighScores = new List<KeyValuePair<string, int>>();


        /// <summary>
        /// Loads all users and adds them here
        /// </summary>
        private static void loadUsers()
        {
            users.Clear();
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            // Pulls all the files from this directoyr
            string[] files = Directory.GetFiles(appData, "*.gameInfo", SearchOption.TopDirectoryOnly);

            try
            {
                // For all of our users we'll add them to our list
                for (int x = 0; x < files.Count(); x++)
                {
                    string path = Path.Combine(appData, files[x]);
                    if (File.Exists(path))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        FileStream stream = new FileStream(path, FileMode.Open);

                        UserInfo oldSave = formatter.Deserialize(stream) as UserInfo;
                        stream.Close();
                        users.Add(oldSave);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            
        }

        /// <summary>
        /// Gets all the addition highscores among users and returns a list of the highest scores with the users name
        /// </summary>
        /// <returns></returns>
        public static List<KeyValuePair<string, int>> getAdditionHighScores()
        {
            try
            {
                loadUsers();
            }
            catch (Exception e)
            {
                throw e;
            }
            additionHighScores.Clear();

            foreach (UserInfo user in users)
            {
                foreach (int score in user.getHighScoresAddition())
                {
                    additionHighScores.Add(new KeyValuePair<string, int>(user.getUserName(), score));
                }
            }

            // Sorts list by the Score
            additionHighScores.Sort((x, y) => x.Value.CompareTo(y.Value));
            additionHighScores.Reverse();

            if (additionHighScores.Count > 11)
            {
                additionHighScores.RemoveRange(10, additionHighScores.Count() - 1 - 10);
            }

            return additionHighScores;
        }

        /// <summary>
        /// Gets all the subtraction highscores among users and returns a list of the highest scores with the users name
        /// </summary>
        /// <returns></returns>
        public static List<KeyValuePair<string, int>> getSubtractionHighScores()
        {
            try
            {
                loadUsers();
            }
            catch (Exception e)
            {
                throw e;
            }
            subtractionHighScores.Clear();

            foreach (UserInfo user in users)
            {
                foreach (int score in user.getHighScoresSubtraction())
                {
                    subtractionHighScores.Add(new KeyValuePair<string, int>(user.getUserName(), score));
                }
            }

            // Sorts list by the Score
            subtractionHighScores.Sort((x, y) => x.Value.CompareTo(y.Value));
            subtractionHighScores.Reverse();

            if (subtractionHighScores.Count > 11)
            {
                subtractionHighScores.RemoveRange(10, additionHighScores.Count() - 1 - 10);
            }

            return subtractionHighScores;
        }

        /// <summary>
        /// Gets all the multiplication highscores among users and returns a list of the highest scores with the users name
        /// </summary>
        /// <returns></returns>
        public static List<KeyValuePair<string, int>> getMultiplicationHighScores()
        {
            try
            {
                loadUsers();
            }
            catch (Exception e)
            {
                throw e;
            }
            multiplicationHighScores.Clear();

            foreach (UserInfo user in users)
            {
                foreach (int score in user.getHighScoresMultiplication())
                {
                    multiplicationHighScores.Add(new KeyValuePair<string, int>(user.getUserName(), score));
                }
            }

            // Sorts list by the Score
            multiplicationHighScores.Sort((x, y) => x.Value.CompareTo(y.Value));
            multiplicationHighScores.Reverse();

            if (multiplicationHighScores.Count > 11)
            {
                multiplicationHighScores.RemoveRange(10, multiplicationHighScores.Count() - 1 - 10);
            }

            return multiplicationHighScores;
        }

        /// <summary>
        /// Gets all the division highscores among users and returns a list of the highest scores with the users name
        /// </summary>
        /// <returns></returns>
        public static List<KeyValuePair<string, int>> getDivisionHighScores()
        {
            try
            {
                loadUsers();
            }
            catch (Exception e)
            {
                throw e;
            }
            divisionHighScores.Clear();

            foreach (UserInfo user in users)
            {
                foreach (int score in user.getHighScoresDivision())
                {
                    divisionHighScores.Add(new KeyValuePair<string, int>(user.getUserName(), score));
                }
            }

            // Sorts list by the Score
            divisionHighScores.Sort((x, y) => x.Value.CompareTo(y.Value));
            divisionHighScores.Reverse();

            if (divisionHighScores.Count > 11)
            {
                divisionHighScores.RemoveRange(10, divisionHighScores.Count() - 1 - 10);
            }

            return divisionHighScores;
        }
    }
}
