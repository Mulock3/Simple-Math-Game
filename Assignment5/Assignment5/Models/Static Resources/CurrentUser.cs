using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.Models.Static_Resources
{
    static class CurrentUser
    {
        /// <summary>
        /// The current player of the game
        /// </summary>
        public static UserInfo currentUser { get; set; }
        /// <summary>
        /// Gets the current name for the user
        /// </summary>
        public static string currentName { get; set; }
        /// <summary>
        /// Gets the current age of the user
        /// </summary>
        public static int currentAge { get; set; }

        /// <summary>
        /// Attempts to load the new user or create a new user
        /// If the info is not valid to create the user then it will set currentUser to Null so that can be checked
        /// </summary>
        public static bool loadUser()
        {
            string oldSavePath = currentName + currentAge.ToString() + ".gameInfo";
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            bool goodUser = true;


            try
            {
                string path = Path.Combine(appData, oldSavePath);
                if (File.Exists(path))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    FileStream stream = new FileStream(path, FileMode.Open);

                    UserInfo oldSave = formatter.Deserialize(stream) as UserInfo;
                    stream.Close();
                    currentUser = oldSave;
                    return true;
                }
                else
                {
                    currentUser = new UserInfo();
                    goodUser = currentUser.setNameAndAge(currentName, currentAge);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            
            if (goodUser == false)
            {
                return false;
            }
            
            return true;

        }
    }
}
