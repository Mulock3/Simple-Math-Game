using Assignment5.Models.Static_Resources;
using Assignment5.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5.Views
{
    public partial class HighScores : Form
    {
        /// <summary>
        /// All high scores for selection
        /// </summary>
        private List<KeyValuePair<string, int>> currentHighScores;

        /// <summary>
        /// Call this initilization if you finished a game
        /// </summary>
        /// <param name="scoreIN"></param>
        public HighScores(int scoreIN, int totalWinsIn)
        {
            InitializeComponent();

            highScoreSelector.Visible = false;
            actualScoreLabel.Text = scoreIN.ToString();

            try
            {
                if (Game.getGameMode() == 0)
                {
                    currentHighScores = HighScoresClass.getAdditionHighScores();
                }
                else if (Game.getGameMode() == 1)
                {
                    currentHighScores = HighScoresClass.getSubtractionHighScores();
                }
                else if (Game.getGameMode() == 2)
                {
                    currentHighScores = HighScoresClass.getMultiplicationHighScores();
                }
                else if (Game.getGameMode() == 3)
                {
                    currentHighScores = HighScoresClass.getDivisionHighScores();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }

            try
            {
                if (totalWinsIn > 7)
                {
                    this.BackgroundImage = Resources.star_wars_award_ceremony;
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else if (totalWinsIn > 4)
                {
                    this.BackgroundImage = Resources.starwars_1615240704926_8871;
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else
                {
                    this.BackgroundImage = Resources.starwars_1615240660362_8207;
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }

    changeHighScores();
        }

        /// <summary>
        /// Call this if you open from main menu
        /// </summary>
        public HighScores()
        {
            InitializeComponent();

            yourScoreLabel.Visible = false;
            actualScoreLabel.Visible = false;

            try
            {
                currentHighScores = HighScoresClass.getAdditionHighScores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }
            changeHighScores();

            this.BackgroundImage = Resources.star_wars_attack;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        /// <summary>
        /// This is one area where it would be great to use data bindings
        /// </summary>
        private void changeHighScores()
        {
            try
            {
                if (currentHighScores.Count() >= 1)
                {
                    firstPlaceLabel.Text = "1) " + currentHighScores[0].Key + ": " + currentHighScores[0].Value;
                }
                else
                {
                    firstPlaceLabel.Text = "";
                }
                if (currentHighScores.Count() >= 2)
                {
                    secondPlaceLabel.Text = "2) " + currentHighScores[1].Key + ": " + currentHighScores[1].Value;
                }
                else
                {
                    secondPlaceLabel.Text = "";
                }
                if (currentHighScores.Count() >= 3)
                {
                    thirdPlaceLabel.Text = "3) " + currentHighScores[2].Key + ": " + currentHighScores[2].Value;
                }
                else
                {
                    thirdPlaceLabel.Text = "";
                }
                if (currentHighScores.Count() >= 4)
                {
                    fourthPlaceLabel.Text = "4) " + currentHighScores[3].Key + ": " + currentHighScores[3].Value;
                }
                else
                {
                    fourthPlaceLabel.Text = "";
                }
                if (currentHighScores.Count() >= 5)
                {
                    fifthPlaceLabel.Text = "5) " + currentHighScores[4].Key + ": " + currentHighScores[4].Value;
                }
                else
                {
                    fifthPlaceLabel.Text = "";
                }
                if (currentHighScores.Count() >= 6)
                {
                    sixthPlaceLabel.Text = "6) " + currentHighScores[5].Key + ": " + currentHighScores[5].Value;
                }
                else
                {
                    sixthPlaceLabel.Text = "";
                }
                if (currentHighScores.Count() >= 7)
                {
                    seventhPlaceLabel.Text = "7) " + currentHighScores[6].Key + ": " + currentHighScores[6].Value;
                }
                else
                {
                    seventhPlaceLabel.Text = "";
                }
                if (currentHighScores.Count() >= 8)
                {
                    eigthPlaceLabel.Text = "8) " + currentHighScores[7].Key + ": " + currentHighScores[7].Value;
                }
                else
                {
                    eigthPlaceLabel.Text = "";
                }
                if (currentHighScores.Count() >= 9)
                {
                    ninthPlaceLabel.Text = "9) " + currentHighScores[8].Key + ": " + currentHighScores[8].Value;
                }
                else
                {
                    ninthPlaceLabel.Text = "";
                }
                if (currentHighScores.Count() >= 10)
                {
                    tenthPlaceLabel.Text = "10) " + currentHighScores[9].Key + ": " + currentHighScores[9].Value;
                }
                else
                {
                    tenthPlaceLabel.Text = "";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
                return;
            }
        }

        /// <summary>
        /// Changes the high scores being displayed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void highScoreSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (highScoreSelector.SelectedIndex == 0)
                {
                    currentHighScores = HighScoresClass.getAdditionHighScores();
                }
                else if (highScoreSelector.SelectedIndex == 1)
                {
                    currentHighScores = HighScoresClass.getSubtractionHighScores();
                }
                else if (highScoreSelector.SelectedIndex == 2)
                {
                    currentHighScores = HighScoresClass.getMultiplicationHighScores();
                }
                else if (highScoreSelector.SelectedIndex == 3)
                {
                    currentHighScores = HighScoresClass.getDivisionHighScores();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }

            changeHighScores();
        }
    }
}
