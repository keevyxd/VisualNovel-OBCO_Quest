namespace OBCO_Game
{
    partial class MainScene
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
            this.exitButton = new System.Windows.Forms.Label();
            this.charNameLabel = new System.Windows.Forms.Label();
            this.speechTextLabel = new System.Windows.Forms.Label();
            this.dotsLabel = new System.Windows.Forms.Label();
            this.firstChoiceButton = new System.Windows.Forms.Button();
            this.secondChoiceButton = new System.Windows.Forms.Button();
            this.thirdChoiceButton = new System.Windows.Forms.Button();
            this.skipButton = new System.Windows.Forms.Button();
            this.charSprite = new System.Windows.Forms.PictureBox();
            this.gameBackground = new System.Windows.Forms.PictureBox();
            this.welcomeScreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.charSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.welcomeScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.exitButton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.Color.Firebrick;
            this.exitButton.Location = new System.Drawing.Point(911, 21);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(21, 24);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "X";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // charNameLabel
            // 
            this.charNameLabel.AutoSize = true;
            this.charNameLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.charNameLabel.Location = new System.Drawing.Point(106, 392);
            this.charNameLabel.Name = "charNameLabel";
            this.charNameLabel.Size = new System.Drawing.Size(48, 24);
            this.charNameLabel.TabIndex = 9;
            this.charNameLabel.Text = "Имя";
            // 
            // speechTextLabel
            // 
            this.speechTextLabel.AutoSize = true;
            this.speechTextLabel.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speechTextLabel.Location = new System.Drawing.Point(106, 416);
            this.speechTextLabel.Name = "speechTextLabel";
            this.speechTextLabel.Size = new System.Drawing.Size(48, 20);
            this.speechTextLabel.TabIndex = 10;
            this.speechTextLabel.Text = "Текст";
            // 
            // dotsLabel
            // 
            this.dotsLabel.AutoSize = true;
            this.dotsLabel.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dotsLabel.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dotsLabel.Location = new System.Drawing.Point(791, 464);
            this.dotsLabel.Name = "dotsLabel";
            this.dotsLabel.Size = new System.Drawing.Size(0, 29);
            this.dotsLabel.TabIndex = 12;
            // 
            // firstChoiceButton
            // 
            this.firstChoiceButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.firstChoiceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.firstChoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstChoiceButton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstChoiceButton.Location = new System.Drawing.Point(167, 133);
            this.firstChoiceButton.Name = "firstChoiceButton";
            this.firstChoiceButton.Size = new System.Drawing.Size(617, 65);
            this.firstChoiceButton.TabIndex = 13;
            this.firstChoiceButton.Text = "firstChoice";
            this.firstChoiceButton.UseVisualStyleBackColor = false;
            this.firstChoiceButton.Click += new System.EventHandler(this.firstChoiceButton_Click);
            // 
            // secondChoiceButton
            // 
            this.secondChoiceButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.secondChoiceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.secondChoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secondChoiceButton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondChoiceButton.Location = new System.Drawing.Point(167, 204);
            this.secondChoiceButton.Name = "secondChoiceButton";
            this.secondChoiceButton.Size = new System.Drawing.Size(617, 65);
            this.secondChoiceButton.TabIndex = 14;
            this.secondChoiceButton.Text = "secondChoice";
            this.secondChoiceButton.UseVisualStyleBackColor = false;
            this.secondChoiceButton.Click += new System.EventHandler(this.secondChoiceButton_Click);
            // 
            // thirdChoiceButton
            // 
            this.thirdChoiceButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.thirdChoiceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.thirdChoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thirdChoiceButton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thirdChoiceButton.Location = new System.Drawing.Point(167, 275);
            this.thirdChoiceButton.Name = "thirdChoiceButton";
            this.thirdChoiceButton.Size = new System.Drawing.Size(617, 65);
            this.thirdChoiceButton.TabIndex = 15;
            this.thirdChoiceButton.Text = "thirdChoice";
            this.thirdChoiceButton.UseVisualStyleBackColor = false;
            this.thirdChoiceButton.Click += new System.EventHandler(this.thirdChoiceButton_Click);
            // 
            // skipButton
            // 
            this.skipButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.skipButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.skipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skipButton.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.skipButton.Location = new System.Drawing.Point(869, 479);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(74, 34);
            this.skipButton.TabIndex = 16;
            this.skipButton.Text = "Skip";
            this.skipButton.UseVisualStyleBackColor = false;
            this.skipButton.Click += new System.EventHandler(this.skipButton_Click);
            // 
            // charSprite
            // 
            this.charSprite.Image = global::OBCO_Game.Properties.Resources.nagitoWhat;
            this.charSprite.Location = new System.Drawing.Point(89, 54);
            this.charSprite.Name = "charSprite";
            this.charSprite.Size = new System.Drawing.Size(240, 326);
            this.charSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.charSprite.TabIndex = 11;
            this.charSprite.TabStop = false;
            // 
            // gameBackground
            // 
            this.gameBackground.Image = global::OBCO_Game.Properties.Resources.labBox;
            this.gameBackground.Location = new System.Drawing.Point(-1, -1);
            this.gameBackground.Name = "gameBackground";
            this.gameBackground.Size = new System.Drawing.Size(960, 540);
            this.gameBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gameBackground.TabIndex = 6;
            this.gameBackground.TabStop = false;
            this.gameBackground.Click += new System.EventHandler(this.gameBackground_Click);
            // 
            // welcomeScreen
            // 
            this.welcomeScreen.Image = global::OBCO_Game.Properties.Resources.tip;
            this.welcomeScreen.Location = new System.Drawing.Point(-1, -1);
            this.welcomeScreen.Name = "welcomeScreen";
            this.welcomeScreen.Size = new System.Drawing.Size(958, 540);
            this.welcomeScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.welcomeScreen.TabIndex = 5;
            this.welcomeScreen.TabStop = false;
            this.welcomeScreen.Click += new System.EventHandler(this.welcomeScreen_Click);
            // 
            // MainScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 536);
            this.Controls.Add(this.thirdChoiceButton);
            this.Controls.Add(this.secondChoiceButton);
            this.Controls.Add(this.firstChoiceButton);
            this.Controls.Add(this.skipButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.charNameLabel);
            this.Controls.Add(this.speechTextLabel);
            this.Controls.Add(this.charSprite);
            this.Controls.Add(this.dotsLabel);
            this.Controls.Add(this.gameBackground);
            this.Controls.Add(this.welcomeScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainScene";
            this.Text = "MorningScene";
            ((System.ComponentModel.ISupportInitialize)(this.charSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.welcomeScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exitButton;
        private System.Windows.Forms.PictureBox welcomeScreen;
        private System.Windows.Forms.PictureBox gameBackground;
        private System.Windows.Forms.PictureBox charSprite;
        private System.Windows.Forms.Label charNameLabel;
        private System.Windows.Forms.Label speechTextLabel;
        private System.Windows.Forms.Label dotsLabel;
        private System.Windows.Forms.Button firstChoiceButton;
        private System.Windows.Forms.Button secondChoiceButton;
        private System.Windows.Forms.Button thirdChoiceButton;
        private System.Windows.Forms.Button skipButton;
    }
}