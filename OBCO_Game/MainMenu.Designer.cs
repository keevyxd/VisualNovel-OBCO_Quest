namespace OBCO_Game
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.startGameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Label();
            this.menuBackground = new System.Windows.Forms.PictureBox();
            this.loadingScreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.menuBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // startGameButton
            // 
            this.startGameButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.startGameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.startGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startGameButton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startGameButton.Location = new System.Drawing.Point(549, 420);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(301, 65);
            this.startGameButton.TabIndex = 2;
            this.startGameButton.Text = "Начать игру";
            this.startGameButton.UseVisualStyleBackColor = false;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
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
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "X";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // menuBackground
            // 
            this.menuBackground.Image = global::OBCO_Game.Properties.Resources.menu1;
            this.menuBackground.Location = new System.Drawing.Point(-2, -2);
            this.menuBackground.Name = "menuBackground";
            this.menuBackground.Size = new System.Drawing.Size(958, 540);
            this.menuBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.menuBackground.TabIndex = 0;
            this.menuBackground.TabStop = false;
            // 
            // loadingScreen
            // 
            this.loadingScreen.Image = global::OBCO_Game.Properties.Resources.loadingScreen;
            this.loadingScreen.Location = new System.Drawing.Point(-2, -2);
            this.loadingScreen.Name = "loadingScreen";
            this.loadingScreen.Size = new System.Drawing.Size(958, 540);
            this.loadingScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.loadingScreen.TabIndex = 4;
            this.loadingScreen.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 536);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.menuBackground);
            this.Controls.Add(this.loadingScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.menuBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox menuBackground;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Label exitButton;
        private System.Windows.Forms.PictureBox loadingScreen;
    }
}

