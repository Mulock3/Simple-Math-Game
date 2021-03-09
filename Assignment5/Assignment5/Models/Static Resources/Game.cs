using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.Models.Static_Resources
{
    static class Game
    {
        /// <summary>
        /// Current gamemode
        /// 0 = Add
        /// 1 = Sub
        /// 2 = Mult
        /// 3 = Div
        /// </summary>
        private static int gameMode = 0;
        /// <summary>
        /// The current question
        /// 
        /// This is a C# property
        /// </summary>
        public static string currentQuestion { get; set; }
        /// <summary>
        /// The current answer to the current problem
        /// </summary>
        public static int currentAnswer { get; set; }

        /// <summary>
        /// Changes the gamemode
        /// 0 = Add
        /// 1 = Sub
        /// 2 = Mult
        /// 3 = Div
        /// 
        /// Invalid response results in Add being selected
        /// </summary>
        /// <param name="gameModeIN"></param>
        public static void changeGame(int gameModeIN)
        {
            gameMode = gameModeIN;

            // Basic catch if you roll outside the bounds
            if (gameMode > 3 || gameMode < 0)
            {
                gameMode = 0;
            }
        }

        /// <summary>
        /// Gets the next answer and question for the player
        /// </summary>
        public static void newQuestion()
        {
            try
            {
                Random newRando = new Random();
                int firstInt;
                int secondINt;

                // Add
                if (gameMode == 0)
                {
                    firstInt = newRando.Next(1, 10);
                    secondINt = newRando.Next(1, 10);
                    currentQuestion = firstInt + " + " + secondINt + " = ?";
                    currentAnswer = firstInt + secondINt;
                }
                // Sub
                else if (gameMode == 1)
                {
                    // Logic makes it so you can only have positive numbers
                    firstInt = newRando.Next(2, 10);
                    secondINt = newRando.Next(1, firstInt);
                    currentQuestion = firstInt + " - " + secondINt + " = ?";
                    currentAnswer = firstInt - secondINt;
                }
                // Mult
                else if (gameMode == 2)
                {
                    firstInt = newRando.Next(0, 10);
                    secondINt = newRando.Next(0, 10);
                    currentQuestion = firstInt + " * " + secondINt + " = ?";
                    currentAnswer = firstInt * secondINt;
                }
                // Divide
                else if (gameMode == 3)
                {
                    // This way you only have answers below 25 (I hope that's okay) and they have to be whole numbers
                    secondINt = newRando.Next(1, 5);
                    firstInt = newRando.Next(1, 5) * secondINt;
                    currentQuestion = firstInt + " / " + secondINt + " = ?";
                    currentAnswer = firstInt / secondINt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Checks the answer and returns true or false pending on the result
        /// </summary>
        /// <param name="answerIN"></param>
        /// <returns></returns>
        public static bool checkAnswer(int answerIN)
        {
            if (answerIN == currentAnswer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gets the new highscore for the users and saves it
        /// Also returns the score from the game
        /// 
        /// Takes correct answers and time into consideration
        /// </summary>
        /// <param name="correctAnswersTotal"></param>
        /// <param name="timeTotal"></param>
        /// <returns></returns>
        public static int getScore(int correctAnswersTotal, int timeTotal)
        {
            double newScore = correctAnswersTotal * 1000;
            newScore /= (Convert.ToDouble(timeTotal) / 10);

            try
            {
                if (gameMode == 0)
                {
                    CurrentUser.currentUser.addHighScoreAdd(Convert.ToInt32(newScore));
                }
                else if (gameMode == 1)
                {
                    CurrentUser.currentUser.addHighScoreSub(Convert.ToInt32(newScore));
                }
                else if (gameMode == 2)
                {
                    CurrentUser.currentUser.addHighScoreMult(Convert.ToInt32(newScore));
                }
                else if (gameMode == 3)
                {
                    CurrentUser.currentUser.addHighScoreDiv(Convert.ToInt32(newScore));
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return Convert.ToInt32(newScore);
        }

        /// <summary>
        /// Returns current gamemode
        /// </summary>
        /// <returns></returns>
        public static int getGameMode()
        {
            return gameMode;
        }
    }
}
