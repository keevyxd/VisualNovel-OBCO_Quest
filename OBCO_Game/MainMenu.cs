using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCO_Game
{
    public partial class MainMenu : Form
    {
        // 955; 536 - Размер окна приложения
        public MainMenu()
        {
            InitializeComponent();
            SetBackground("menu1.jpg");
        }
        private void SetBackground(string fileName)
        {
            string path = Path.Combine(Application.StartupPath, "Sprites", fileName);

            if (File.Exists(path))
            {
                Image background = Image.FromFile(path);
                menuBackground.Image = background;
            }
            else
            {
                MessageBox.Show("Ошибка в коде. Неправильное расположение/название спрайта.");
            }
        }
        private void HideUI()
        {
            menuBackground.Hide();
            startGameButton.Hide();
            exitButton.Hide();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите выйти из игры?", ":(", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private async void startGameButton_Click(object sender, EventArgs e)
        {
            HideUI();
            SetBackground("loadingScreen.jpg");
            await Task.Delay(3000);

            MainScene mainScene = new MainScene();
            mainScene.Show();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Close();
        }
    }
}
