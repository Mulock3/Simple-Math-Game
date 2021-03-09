
namespace Assignment5
{
    partial class GameWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.submitAnswer = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.TextBox();
            this.enterAnswerLabel = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.answerErrorLabel = new System.Windows.Forms.Label();
            this.correctLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timeSpentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitAnswer
            // 
            this.submitAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitAnswer.Location = new System.Drawing.Point(359, 391);
            this.submitAnswer.Name = "submitAnswer";
            this.submitAnswer.Size = new System.Drawing.Size(75, 27);
            this.submitAnswer.TabIndex = 0;
            this.submitAnswer.Text = "Start";
            this.submitAnswer.UseVisualStyleBackColor = true;
            this.submitAnswer.Click += new System.EventHandler(this.submitAnswer_Click);
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(348, 352);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(100, 20);
            this.answer.TabIndex = 1;
            this.answer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.answer_KeyPress);
            // 
            // enterAnswerLabel
            // 
            this.enterAnswerLabel.AutoSize = true;
            this.enterAnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterAnswerLabel.Location = new System.Drawing.Point(292, 325);
            this.enterAnswerLabel.Name = "enterAnswerLabel";
            this.enterAnswerLabel.Size = new System.Drawing.Size(220, 24);
            this.enterAnswerLabel.TabIndex = 2;
            this.enterAnswerLabel.Text = "Provide Answer Below";
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(292, 150);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(94, 24);
            this.questionLabel.TabIndex = 3;
            this.questionLabel.Text = "Question";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // answerErrorLabel
            // 
            this.answerErrorLabel.AutoSize = true;
            this.answerErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.answerErrorLabel.Location = new System.Drawing.Point(332, 375);
            this.answerErrorLabel.Name = "answerErrorLabel";
            this.answerErrorLabel.Size = new System.Drawing.Size(131, 13);
            this.answerErrorLabel.TabIndex = 6;
            this.answerErrorLabel.Text = "Please enter only numbers";
            // 
            // correctLabel
            // 
            this.correctLabel.AutoSize = true;
            this.correctLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.correctLabel.Location = new System.Drawing.Point(374, 421);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(44, 13);
            this.correctLabel.TabIndex = 7;
            this.correctLabel.Text = "Correct!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Time Spent";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timeSpentLabel
            // 
            this.timeSpentLabel.AutoSize = true;
            this.timeSpentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSpentLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.timeSpentLabel.Location = new System.Drawing.Point(389, 33);
            this.timeSpentLabel.Name = "timeSpentLabel";
            this.timeSpentLabel.Size = new System.Drawing.Size(20, 22);
            this.timeSpentLabel.TabIndex = 9;
            this.timeSpentLabel.Text = "0";
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timeSpentLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.correctLabel);
            this.Controls.Add(this.answerErrorLabel);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.enterAnswerLabel);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.submitAnswer);
            this.Name = "GameWindow";
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitAnswer;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Label enterAnswerLabel;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label answerErrorLabel;
        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeSpentLabel;
    }
}