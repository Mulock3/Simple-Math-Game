using Assignment5.Models;
using Assignment5.Models.Static_Resources;
using Assignment5.Properties;
using Assignment5.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes our set up
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            ageErrorLabel.Visible = false;
            nameErrorLabel.Visible = false;
            string currentDir = Environment.CurrentDirectory;

            this.BackgroundImage = Resources.Yoda;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        /// <summary>
        /// Does user validation first, if the user currently exists it'll save info
        /// If the user does not exist it'll create a new user info
        /// 
        /// Also selects the gamemode
        /// 
        /// New users won't be saved till they play their first game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startGame_Click(object sender, EventArgs e)
        {
            try
            {
                // User Validation
                ageErrorLabel.Visible = false;
                nameErrorLabel.Visible = false;
                bool validation = false;

                CurrentUser.currentName = userName.Text;
                try
                {
                    CurrentUser.currentAge = Convert.ToInt32(age.Text);
                }
                catch
                {
                    ageErrorLabel.Text = "Please only enter numbers";
                    ageErrorLabel.Visible = true;
                }

                try
                {
                    validation = CurrentUser.loadUser();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                    return;
                }

                if (validation == true)
                {
                    // Game Selection
                    int gameSelected = 0;

                    if (gameModeOne.Checked == true)
                    {
                        gameSelected = 0;
                    }
                    else if (gameModeTwo.Checked == true)
                    {
                        gameSelected = 1;
                    }
                    else if (gameModeThree.Checked == true)
                    {
                        gameSelected = 2;
                    }
                    else if (gameModeFour.Checked == true)
                    {
                        gameSelected = 3;
                    }

                    Game.changeGame(gameSelected);

                    GameWindow newWindow = new GameWindow();
                    newWindow.ShowDialog();
                }
                else
                {
                    if (CurrentUser.currentUser.getNameValid() == false)
                    {
                        nameErrorLabel.Visible = true;
                    }
                    if (CurrentUser.currentUser.getAgeValid() == false)
                    {
                        ageErrorLabel.Text = "Please enter valid age (3-10)";
                        ageErrorLabel.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }
        }

        /// <summary>
        /// Pulls up highscores page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void highScoresButton_Click(object sender, EventArgs e)
        {
            try
            {
                HighScores newHighScores = new HighScores();
                newHighScores.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }
        }
    }
}
