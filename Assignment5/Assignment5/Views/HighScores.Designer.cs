
namespace Assignment5.Views
{
    partial class HighScores
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
            this.highScoreLabel = new System.Windows.Forms.Label();
            this.yourScoreLabel = new System.Windows.Forms.Label();
            this.actualScoreLabel = new System.Windows.Forms.Label();
            this.highScoreSelector = new System.Windows.Forms.ComboBox();
            this.firstPlaceLabel = new System.Windows.Forms.Label();
            this.secondPlaceLabel = new System.Windows.Forms.Label();
            this.thirdPlaceLabel = new System.Windows.Forms.Label();
            this.fourthPlaceLabel = new System.Windows.Forms.Label();
            this.fifthPlaceLabel = new System.Windows.Forms.Label();
            this.sixthPlaceLabel = new System.Windows.Forms.Label();
            this.seventhPlaceLabel = new System.Windows.Forms.Label();
            this.eigthPlaceLabel = new System.Windows.Forms.Label();
            this.ninthPlaceLabel = new System.Windows.Forms.Label();
            this.tenthPlaceLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.AutoSize = true;
            this.highScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoreLabel.Location = new System.Drawing.Point(53, 102);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(125, 24);
            this.highScoreLabel.TabIndex = 3;
            this.highScoreLabel.Text = "High Scores";
            // 
            // yourScoreLabel
            // 
            this.yourScoreLabel.AutoSize = true;
            this.yourScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourScoreLabel.Location = new System.Drawing.Point(58, 36);
            this.yourScoreLabel.Name = "yourScoreLabel";
            this.yourScoreLabel.Size = new System.Drawing.Size(115, 24);
            this.yourScoreLabel.TabIndex = 4;
            this.yourScoreLabel.Text = "Your Score";
            // 
            // actualScoreLabel
            // 
            this.actualScoreLabel.AutoSize = true;
            this.actualScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualScoreLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.actualScoreLabel.Location = new System.Drawing.Point(95, 60);
            this.actualScoreLabel.Name = "actualScoreLabel";
            this.actualScoreLabel.Size = new System.Drawing.Size(30, 24);
            this.actualScoreLabel.TabIndex = 5;
            this.actualScoreLabel.Text = "10";
            this.actualScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // highScoreSelector
            // 
            this.highScoreSelector.FormattingEnabled = true;
            this.highScoreSelector.Items.AddRange(new object[] {
            "Addition",
            "Subtraction",
            "Multiplication",
            "Division"});
            this.highScoreSelector.Location = new System.Drawing.Point(52, 36);
            this.highScoreSelector.Name = "highScoreSelector";
            this.highScoreSelector.Size = new System.Drawing.Size(121, 21);
            this.highScoreSelector.TabIndex = 7;
            this.highScoreSelector.SelectedIndexChanged += new System.EventHandler(this.highScoreSelector_SelectedIndexChanged);
            // 
            // firstPlaceLabel
            // 
            this.firstPlaceLabel.AutoSize = true;
            this.firstPlaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstPlaceLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.firstPlaceLabel.Location = new System.Drawing.Point(53, 136);
            this.firstPlaceLabel.Name = "firstPlaceLabel";
            this.firstPlaceLabel.Size = new System.Drawing.Size(0, 24);
            this.firstPlaceLabel.TabIndex = 8;
            this.firstPlaceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // secondPlaceLabel
            // 
            this.secondPlaceLabel.AutoSize = true;
            this.secondPlaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondPlaceLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.secondPlaceLabel.Location = new System.Drawing.Point(53, 160);
            this.secondPlaceLabel.Name = "secondPlaceLabel";
            this.secondPlaceLabel.Size = new System.Drawing.Size(0, 24);
            this.secondPlaceLabel.TabIndex = 9;
            this.secondPlaceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // thirdPlaceLabel
            // 
            this.thirdPlaceLabel.AutoSize = true;
            this.thirdPlaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdPlaceLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.thirdPlaceLabel.Location = new System.Drawing.Point(53, 184);
            this.thirdPlaceLabel.Name = "thirdPlaceLabel";
            this.thirdPlaceLabel.Size = new System.Drawing.Size(0, 24);
            this.thirdPlaceLabel.TabIndex = 10;
            this.thirdPlaceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fourthPlaceLabel
            // 
            this.fourthPlaceLabel.AutoSize = true;
            this.fourthPlaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourthPlaceLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.fourthPlaceLabel.Location = new System.Drawing.Point(53, 208);
            this.fourthPlaceLabel.Name = "fourthPlaceLabel";
            this.fourthPlaceLabel.Size = new System.Drawing.Size(0, 24);
            this.fourthPlaceLabel.TabIndex = 11;
            this.fourthPlaceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fifthPlaceLabel
            // 
            this.fifthPlaceLabel.AutoSize = true;
            this.fifthPlaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fifthPlaceLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.fifthPlaceLabel.Location = new System.Drawing.Point(53, 232);
            this.fifthPlaceLabel.Name = "fifthPlaceLabel";
            this.fifthPlaceLabel.Size = new System.Drawing.Size(0, 24);
            this.fifthPlaceLabel.TabIndex = 12;
            this.fifthPlaceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sixthPlaceLabel
            // 
            this.sixthPlaceLabel.AutoSize = true;
            this.sixthPlaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixthPlaceLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.sixthPlaceLabel.Location = new System.Drawing.Point(53, 256);
            this.sixthPlaceLabel.Name = "sixthPlaceLabel";
            this.sixthPlaceLabel.Size = new System.Drawing.Size(0, 24);
            this.sixthPlaceLabel.TabIndex = 13;
            this.sixthPlaceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // seventhPlaceLabel
            // 
            this.seventhPlaceLabel.AutoSize = true;
            this.seventhPlaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seventhPlaceLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.seventhPlaceLabel.Location = new System.Drawing.Point(53, 280);
            this.seventhPlaceLabel.Name = "seventhPlaceLabel";
            this.seventhPlaceLabel.Size = new System.Drawing.Size(0, 24);
            this.seventhPlaceLabel.TabIndex = 14;
            this.seventhPlaceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // eigthPlaceLabel
            // 
            this.eigthPlaceLabel.AutoSize = true;
            this.eigthPlaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eigthPlaceLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.eigthPlaceLabel.Location = new System.Drawing.Point(53, 304);
            this.eigthPlaceLabel.Name = "eigthPlaceLabel";
            this.eigthPlaceLabel.Size = new System.Drawing.Size(0, 24);
            this.eigthPlaceLabel.TabIndex = 15;
            this.eigthPlaceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ninthPlaceLabel
            // 
            this.ninthPlaceLabel.AutoSize = true;
            this.ninthPlaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ninthPlaceLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ninthPlaceLabel.Location = new System.Drawing.Point(53, 328);
            this.ninthPlaceLabel.Name = "ninthPlaceLabel";
            this.ninthPlaceLabel.Size = new System.Drawing.Size(0, 24);
            this.ninthPlaceLabel.TabIndex = 16;
            this.ninthPlaceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tenthPlaceLabel
            // 
            this.tenthPlaceLabel.AutoSize = true;
            this.tenthPlaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenthPlaceLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tenthPlaceLabel.Location = new System.Drawing.Point(53, 352);
            this.tenthPlaceLabel.Name = "tenthPlaceLabel";
            this.tenthPlaceLabel.Size = new System.Drawing.Size(0, 24);
            this.tenthPlaceLabel.TabIndex = 17;
            this.tenthPlaceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(52, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 292);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // HighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tenthPlaceLabel);
            this.Controls.Add(this.ninthPlaceLabel);
            this.Controls.Add(this.eigthPlaceLabel);
            this.Controls.Add(this.seventhPlaceLabel);
            this.Controls.Add(this.sixthPlaceLabel);
            this.Controls.Add(this.fifthPlaceLabel);
            this.Controls.Add(this.fourthPlaceLabel);
            this.Controls.Add(this.thirdPlaceLabel);
            this.Controls.Add(this.secondPlaceLabel);
            this.Controls.Add(this.firstPlaceLabel);
            this.Controls.Add(this.highScoreSelector);
            this.Controls.Add(this.actualScoreLabel);
            this.Controls.Add(this.yourScoreLabel);
            this.Controls.Add(this.highScoreLabel);
            this.Controls.Add(this.groupBox1);
            this.Name = "HighScores";
            this.Text = "HighScores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label highScoreLabel;
        private System.Windows.Forms.Label yourScoreLabel;
        private System.Windows.Forms.Label actualScoreLabel;
        private System.Windows.Forms.ComboBox highScoreSelector;
        private System.Windows.Forms.Label firstPlaceLabel;
        private System.Windows.Forms.Label secondPlaceLabel;
        private System.Windows.Forms.Label thirdPlaceLabel;
        private System.Windows.Forms.Label fourthPlaceLabel;
        private System.Windows.Forms.Label fifthPlaceLabel;
        private System.Windows.Forms.Label sixthPlaceLabel;
        private System.Windows.Forms.Label seventhPlaceLabel;
        private System.Windows.Forms.Label eigthPlaceLabel;
        private System.Windows.Forms.Label ninthPlaceLabel;
        private System.Windows.Forms.Label tenthPlaceLabel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}