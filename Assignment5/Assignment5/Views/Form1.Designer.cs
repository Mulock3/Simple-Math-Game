
namespace Assignment5
{
    partial class Form1
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
            this.userName = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameErrorLabel = new System.Windows.Forms.Label();
            this.ageErrorLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.TextBox();
            this.gameModeOne = new System.Windows.Forms.RadioButton();
            this.gameTypeLabel = new System.Windows.Forms.Label();
            this.gameModeTwo = new System.Windows.Forms.RadioButton();
            this.gameModeThree = new System.Windows.Forms.RadioButton();
            this.gameModeFour = new System.Windows.Forms.RadioButton();
            this.startGame = new System.Windows.Forms.Button();
            this.highScoresButton = new System.Windows.Forms.Button();
            this.gameBox = new System.Windows.Forms.GroupBox();
            this.gameBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(7, 43);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(100, 20);
            this.userName.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(6, 16);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(65, 24);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // nameErrorLabel
            // 
            this.nameErrorLabel.AutoSize = true;
            this.nameErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.nameErrorLabel.Location = new System.Drawing.Point(7, 66);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(104, 13);
            this.nameErrorLabel.TabIndex = 2;
            this.nameErrorLabel.Text = "Please enter a name";
            // 
            // ageErrorLabel
            // 
            this.ageErrorLabel.AutoSize = true;
            this.ageErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.ageErrorLabel.Location = new System.Drawing.Point(117, 66);
            this.ageErrorLabel.Name = "ageErrorLabel";
            this.ageErrorLabel.Size = new System.Drawing.Size(142, 13);
            this.ageErrorLabel.TabIndex = 5;
            this.ageErrorLabel.Text = "Please enter valid age (3-10)";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.BackColor = System.Drawing.Color.Transparent;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.Location = new System.Drawing.Point(116, 16);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(48, 24);
            this.ageLabel.TabIndex = 4;
            this.ageLabel.Text = "Age";
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(120, 43);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(100, 20);
            this.age.TabIndex = 3;
            // 
            // gameModeOne
            // 
            this.gameModeOne.AutoSize = true;
            this.gameModeOne.BackColor = System.Drawing.Color.Transparent;
            this.gameModeOne.Checked = true;
            this.gameModeOne.Location = new System.Drawing.Point(32, 115);
            this.gameModeOne.Name = "gameModeOne";
            this.gameModeOne.Size = new System.Drawing.Size(63, 17);
            this.gameModeOne.TabIndex = 6;
            this.gameModeOne.TabStop = true;
            this.gameModeOne.Text = "Addition";
            this.gameModeOne.UseVisualStyleBackColor = false;
            // 
            // gameTypeLabel
            // 
            this.gameTypeLabel.AutoSize = true;
            this.gameTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTypeLabel.Location = new System.Drawing.Point(3, 88);
            this.gameTypeLabel.Name = "gameTypeLabel";
            this.gameTypeLabel.Size = new System.Drawing.Size(124, 24);
            this.gameTypeLabel.TabIndex = 7;
            this.gameTypeLabel.Text = "Game Mode";
            // 
            // gameModeTwo
            // 
            this.gameModeTwo.AutoSize = true;
            this.gameModeTwo.BackColor = System.Drawing.Color.Transparent;
            this.gameModeTwo.Location = new System.Drawing.Point(32, 138);
            this.gameModeTwo.Name = "gameModeTwo";
            this.gameModeTwo.Size = new System.Drawing.Size(79, 17);
            this.gameModeTwo.TabIndex = 8;
            this.gameModeTwo.Text = "Subtraction";
            this.gameModeTwo.UseVisualStyleBackColor = false;
            // 
            // gameModeThree
            // 
            this.gameModeThree.AutoSize = true;
            this.gameModeThree.BackColor = System.Drawing.Color.Transparent;
            this.gameModeThree.Location = new System.Drawing.Point(32, 161);
            this.gameModeThree.Name = "gameModeThree";
            this.gameModeThree.Size = new System.Drawing.Size(86, 17);
            this.gameModeThree.TabIndex = 9;
            this.gameModeThree.Text = "Multiplication";
            this.gameModeThree.UseVisualStyleBackColor = false;
            // 
            // gameModeFour
            // 
            this.gameModeFour.AutoSize = true;
            this.gameModeFour.BackColor = System.Drawing.Color.Transparent;
            this.gameModeFour.Location = new System.Drawing.Point(32, 184);
            this.gameModeFour.Name = "gameModeFour";
            this.gameModeFour.Size = new System.Drawing.Size(62, 17);
            this.gameModeFour.TabIndex = 10;
            this.gameModeFour.Text = "Division";
            this.gameModeFour.UseVisualStyleBackColor = false;
            // 
            // startGame
            // 
            this.startGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGame.Location = new System.Drawing.Point(12, 374);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(130, 29);
            this.startGame.TabIndex = 11;
            this.startGame.Text = "Start Game";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // highScoresButton
            // 
            this.highScoresButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.highScoresButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoresButton.Location = new System.Drawing.Point(12, 409);
            this.highScoresButton.Name = "highScoresButton";
            this.highScoresButton.Size = new System.Drawing.Size(130, 29);
            this.highScoresButton.TabIndex = 12;
            this.highScoresButton.Text = "High Scores";
            this.highScoresButton.UseVisualStyleBackColor = true;
            this.highScoresButton.Click += new System.EventHandler(this.highScoresButton_Click);
            // 
            // gameBox
            // 
            this.gameBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gameBox.Controls.Add(this.nameLabel);
            this.gameBox.Controls.Add(this.userName);
            this.gameBox.Controls.Add(this.nameErrorLabel);
            this.gameBox.Controls.Add(this.ageErrorLabel);
            this.gameBox.Controls.Add(this.gameModeFour);
            this.gameBox.Controls.Add(this.ageLabel);
            this.gameBox.Controls.Add(this.gameModeThree);
            this.gameBox.Controls.Add(this.age);
            this.gameBox.Controls.Add(this.gameModeTwo);
            this.gameBox.Controls.Add(this.gameTypeLabel);
            this.gameBox.Controls.Add(this.gameModeOne);
            this.gameBox.Location = new System.Drawing.Point(12, 162);
            this.gameBox.Name = "gameBox";
            this.gameBox.Size = new System.Drawing.Size(386, 206);
            this.gameBox.TabIndex = 13;
            this.gameBox.TabStop = false;
            this.gameBox.Text = "Game Info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 450);
            this.Controls.Add(this.highScoresButton);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.gameBox);
            this.MaximumSize = new System.Drawing.Size(426, 489);
            this.MinimumSize = new System.Drawing.Size(426, 489);
            this.Name = "Form1";
            this.Text = "Math Game";
            this.gameBox.ResumeLayout(false);
            this.gameBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label nameErrorLabel;
        private System.Windows.Forms.Label ageErrorLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.RadioButton gameModeOne;
        private System.Windows.Forms.Label gameTypeLabel;
        private System.Windows.Forms.RadioButton gameModeTwo;
        private System.Windows.Forms.RadioButton gameModeThree;
        private System.Windows.Forms.RadioButton gameModeFour;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.Button highScoresButton;
        private System.Windows.Forms.GroupBox gameBox;
    }
}

