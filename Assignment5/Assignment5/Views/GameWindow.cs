using Assignment5.Models.Static_Resources;
using Assignment5.Properties;
using Assignment5.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class GameWindow : Form
    {
        /// <summary>
        /// How many correct answers the user got
        /// </summary>
        private int totalGoodAnswers = 0;
        /// <summary>
        /// Total time it took to complete
        /// </summary>
        private int totalTime = 0;
        /// <summary>
        /// Current count of how many questions provided
        /// </summary>
        private int count = 0;
        /// <summary>
        /// Amount of elpased seconds
        /// </summary>
        private int secondsPassed = 0;
        /// <summary>
        /// Timer for timing event
        /// </summary>
        private System.Timers.Timer newTimer;

        /// <summary>
        /// Sets up the initialized values for the form
        /// </summary>
        public GameWindow()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            try
            {
                Game.newQuestion();
                questionLabel.Text = "Press start when ready";


                answerErrorLabel.Visible = false;

                newTimer = new System.Timers.Timer();
                //newTimer.Start();
                newTimer.Elapsed += updateClock;
                newTimer.Interval = 1000;

                correctLabel.Visible = false;
                this.ActiveControl = answer;

                this.BackgroundImage = Resources.agnieszka_kowalczyk_c0VRNWVEjOA_unsplash;
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }
}

        /// <summary>
        /// Updates the timer clock every second
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateClock(object sender, ElapsedEventArgs e)
        {
            try
            {
                secondsPassed++;
                this.BeginInvoke(new MethodInvoker(delegate
                {
                    this.timeSpentLabel.Text = secondsPassed.ToString();
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }
        }

        /// <summary>
        /// Checks the answer then passes along the new question and answer
        /// 
        /// After 10 ends the Window and submits scores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitAnswer_Click(object sender, EventArgs e)
        {
            try
            {
                if (submitAnswer.Text == "Start")
                {
                    newTimer.Start();
                    questionLabel.Text = Game.currentQuestion;
                    submitAnswer.Text = "Submit";
                    return;
                }

                answerErrorLabel.Visible = false;
                int answerIN = 0;
                try
                {
                    answerIN = Convert.ToInt32(answer.Text);
                }
                catch
                {
                    answerErrorLabel.Visible = true;
                    return;
                }
                if (answerIN == Game.currentAnswer)
                {
                    totalGoodAnswers++;
                    correctLabel.Text = "Correct!";
                    correctLabel.ForeColor = Color.Blue;
                    correctLabel.Visible = true;
                    SoundPlayer simpleSound = new SoundPlayer(Resources.Abrupt_Burst);

                    simpleSound.Play();
                }
                else
                {
                    correctLabel.Text = "Incorrect";
                    correctLabel.ForeColor = Color.Red;
                    correctLabel.Visible = true;
                    SoundPlayer simpleSound = new SoundPlayer(Resources.Alarmed_Trill);

                    simpleSound.Play();
                }

                // Last Question
                if (count == 9)
                {
                    newTimer.Stop();
                    HighScores newHighScores;

                    try
                    {
                        newHighScores = new HighScores(Game.getScore(totalGoodAnswers, secondsPassed), totalGoodAnswers);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                        return;
                    }

                    newHighScores.ShowDialog();
                    this.Close();
                    return;
                }

                // Next question
                count++;
                Game.newQuestion();
                questionLabel.Text = Game.currentQuestion;

                answer.Text = "";

                this.ActiveControl = answer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }

        }

        /// <summary>
        /// This tells if we pressed the enter key, and calls our other function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void answer_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                // If enter is pressed
                if (e.KeyChar == (char)13)
                {
                    submitAnswer_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }
        }
    }
}
