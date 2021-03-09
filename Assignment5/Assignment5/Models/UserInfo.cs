using Assignment5.Models.Static_Resources;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    [Serializable]
    class UserInfo
    {
        /// <summary>
        /// Username of the user
        /// </summary>
        private string userName;
        /// <summary>
        /// User's age
        /// </summary>
        private int userAge;
        /// <summary>
        /// Highscores for add (limit 10)
        /// </summary>
        private List<int> highscoresAdd = new List<int>();
        /// <summary>
        /// Highscores for sub (limit 10)
        /// </summary>
        private List<int> highscoresSub = new List<int>();
        /// <summary>
        /// Highscores for mult (limit 10)
        /// </summary>
        private List<int> highscoresMult = new List<int>();
        /// <summary>
        /// Highscores for div (limit 10)
        /// </summary>
        private List<int> highscoresDiv = new List<int>();
        /// <summary>
        /// Bool to see if name is good
        /// </summary>
        private bool nameGood = true;
        /// <summary>
        /// Bool to see if age is valid
        /// </summary>
        private bool ageGood = true;

        /// <summary>
        /// Basic constructor for the class, sets values to empty
        /// </summary>
        public UserInfo()
        {
            userName = "";
            userAge = 0;
        }

        /// <summary>
        /// Takes in the name and age of the user
        /// Only allows users to have a non blank name
        /// Only allows users to be from 3-10
        /// 
        /// Returns false if one of the situations above is not true
        /// </summary>
        /// <param name="nameIN"></param>
        /// <param name="ageIN"></param>
        /// <returns></returns>
        public bool setNameAndAge(string nameIN, int ageIN)
        {
            try
            {
                if (nameIN.Trim() == "")
                {
                    userName = "";
                    userAge = 0;
                    nameGood = false;
                }
                else
                {
                    userName = nameIN;
                    nameGood = true;
                }

                if (ageIN >= 3 && ageIN <= 10 && nameGood == true)
                {
                    userAge = ageIN;
                    ageGood = true;
                    return true;
                }
                else if (ageIN >= 3 && ageIN <= 10 && nameGood == false)
                {
                    userAge = ageIN;
                    ageGood = true;
                    return false;
                }
                else
                {
                    userName = "";
                    userAge = 0;
                    ageGood = false;
                    return false;
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        #region Getters
        /// <summary>
        /// Returns if the name was valid
        /// </summary>
        /// <returns></returns>
        public bool getNameValid()
        {
            return nameGood;
        }

        /// <summary>
        /// Returns if the age was valid
        /// </summary>
        /// <returns></returns>
        public bool getAgeValid()
        {
            return ageGood;
        }

        /// <summary>
        /// Returns users name
        /// </summary>
        /// <returns></returns>
        public string getUserName()
        {
            return userName;
        }

        /// <summary>
        /// Returns the highscores for addition
        /// </summary>
        /// <returns></returns>
        public List<int> getHighScoresAddition()
        {
            return highscoresAdd;
        }

        /// <summary>
        /// Returns the highscores for subtraction
        /// </summary>
        /// <returns></returns>
        public List<int> getHighScoresSubtraction()
        {
            return highscoresSub;
        }

        /// <summary>
        /// Returns the highscores for multiplication
        /// </summary>
        /// <returns></returns>
        public List<int> getHighScoresMultiplication()
        {
            return highscoresMult;
        }

        /// <summary>
        /// Returns the highscores for division
        /// </summary>
        /// <returns></returns>
        public List<int> getHighScoresDivision()
        {
            return highscoresDiv;
        }
        #endregion

        #region Highscores
        /// <summary>
        /// Takes in an integer to add to the high score board for addition
        /// 
        /// Sorts list, then it removes any entry above 10 (taking away the worst score)
        /// </summary>
        /// <param name="newScoreIN"></param>
        public void addHighScoreAdd(int newScoreIN)
        {
            try
            {
                // Whille there's a more effecient way to do this, for purposes of the scope I'll keep it simple
                highscoresAdd.Add(newScoreIN);
                highscoresAdd.Sort();

                if (highscoresAdd.Count > 11)
                {
                    highscoresAdd.RemoveRange(10, highscoresAdd.Count() - 1 - 10);
                }

                try
                {
                    saveInformation();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Takes in an integer to add to the high score board for subtraction
        /// 
        /// Sorts list, then it removes any entry above 10 (taking away the worst score)
        /// </summary>
        /// <param name="newScoreIN"></param>
        public void addHighScoreSub(int newScoreIN)
        {
            try
            {
                // Whille there's a more effecient way to do this, for purposes of the scope I'll keep it simple
                highscoresSub.Add(newScoreIN);
                highscoresSub.Sort();

                if (highscoresSub.Count > 11)
                {
                    highscoresSub.RemoveRange(10, highscoresSub.Count() - 1 - 10);
                }

                try
                {
                    saveInformation();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        /// <summary>
        /// Takes in an integer to add to the high score board for multiplication
        /// 
        /// Sorts list, then it removes any entry above 10 (taking away the worst score)
        /// </summary>
        /// <param name="newScoreIN"></param>
        public void addHighScoreMult(int newScoreIN)
        {
            try
            {
                // Whille there's a more effecient way to do this, for purposes of the scope I'll keep it simple
                highscoresMult.Add(newScoreIN);
                highscoresMult.Sort();

                if (highscoresMult.Count > 11)
                {
                    highscoresMult.RemoveRange(10, highscoresMult.Count() - 1 - 10);
                }

                try
                {
                    saveInformation();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Takes in an integer to add to the high score board for division
        /// 
        /// Sorts list, then it removes any entry above 10 (taking away the worst score)
        /// </summary>
        /// <param name="newScoreIN"></param>
        public void addHighScoreDiv(int newScoreIN)
        {
            try
            {
                // Whille there's a more effecient way to do this, for purposes of the scope I'll keep it simple
                highscoresDiv.Add(newScoreIN);
                highscoresDiv.Sort();

                if (highscoresDiv.Count > 11)
                {
                    highscoresDiv.RemoveRange(10, highscoresDiv.Count() - 1 - 10);
                }

                try
                {
                    saveInformation();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        /// <summary>
        /// Saves the users info (including highScores) to app data folder
        /// Keep in mind that with the age group currently selected you would never save the name and age
        /// </summary>
        public void saveInformation()
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                string playerDataPath = this.userName + this.userAge + ".gameInfo";
                string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string path = Path.Combine(appData, playerDataPath);

                try
                {
                    if (File.Exists(path))
                    {
                        // Deletes old save
                        File.Delete(path);
                        FileStream stream = new FileStream(path, FileMode.Create);

                        formatter.Serialize(stream, this);
                        stream.Close();
                    }
                    else
                    {
                        // Creates new save
                        FileStream stream = new FileStream(path, FileMode.Create);

                        formatter.Serialize(stream, this);
                        stream.Close();
                    }
                }
                catch
                {
                    throw new Exception("Unable to save file");
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
