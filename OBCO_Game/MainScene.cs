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

namespace OBCO_Game
{
    public partial class MainScene : Form
    {
        public MainScene()
        {
            InitializeComponent();
            exitButton.Hide();
            gameBackground.Hide();
            nagitoChar.Hide();
            charNameLabel.Hide();
            charNameLabel.Text = "Нагито";
            speechTextLabel.Text = string.Empty;
            dotsLabel.Text = string.Empty;
        }

        private int sceneIndex = -1;
        private static bool isWaitingForResponse = false, isProcessing = false;

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите выйти в главное меню?", ":(", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                Close();
            }
        }

        private void welcomeScreen_Click(object sender, EventArgs e)
        {
            welcomeScreen.Hide();
            gameBackground.Show();
            SetBackground("morningBackground.jpg");
            exitButton.Show();
        }

        private async Task ShowUI()
        {
            nagitoChar.Show();
            await Task.Delay(300);

            charNameLabel.Show();
            speechTextLabel.Show();
            exitButton.Show();
            dotsLabel.Show();
        }
        private void HideUI()
        {
            exitButton.Hide();
            nagitoChar.Hide();
            charNameLabel.Hide();
            dotsLabel.Hide();
            speechTextLabel.Hide();
            speechTextLabel.Text = string.Empty;
            dotsLabel.Text = string.Empty;
        }
        private async Task ShowDots()
        {
            while (isWaitingForResponse)
            {
                dotsLabel.Text = string.Empty;
                dotsLabel.Text += ".";
                await Task.Delay(300);
                dotsLabel.Text += ".";
                await Task.Delay(300);
                dotsLabel.Text += ".";
                await Task.Delay(300);
            }
        }

        private async Task TypeSpeech(string speech)
        {
            speechTextLabel.Text = string.Empty;
            foreach (char c in speech)
            {
                speechTextLabel.Text += c;
                await Task.Delay(10);
            }
        }

        private void SetNagitoSprite(string fileName)
        {
            string path = Path.Combine(Application.StartupPath, "Sprites", fileName);

            if (File.Exists(path))
            {
                Image character = Image.FromFile(path);
                nagitoChar.Image = character;
            }
            else
            {
                MessageBox.Show("Ошибка в коде. Неправильное расположение/название спрайта персонажа.");
            }
        }

        private void SetBackground(string fileName)
        {
            string path = Path.Combine(Application.StartupPath, "Sprites", fileName);

            if (File.Exists(path))
            {
                Image background = Image.FromFile(path);
                gameBackground.Image = background;
            }
            else
            {
                MessageBox.Show("Ошибка в коде. Неправильное расположение/название спрайта.");
            }
        }

        private async void SwitchScene(string sceneName)
        {
            HideUI();
            SetBackground("loadingScreen.jpg");
            await Task.Delay(3000);
            SetBackground(sceneName);
            isProcessing = false;
        }

        private async Task MorningScene1()
        {
            SetBackground("morningBox.jpg");

            SetNagitoSprite("nagitoWoke.png");
            await Task.Delay(300);

            nagitoChar.Show();
            await Task.Delay(300);

            charNameLabel.Show();
            speechTextLabel.Show();
            await TypeSpeech("Ох, уже 10 часов утра.");

            isProcessing = false;
            isWaitingForResponse = true;
            await ShowDots();
        }
        private async Task MorningScene2()
        {
            SetNagitoSprite("nagitoThinking.png");

            await TypeSpeech("Видимо я опоздаю на встречу с Микан в лаборатории.");

            isProcessing = false;
            isWaitingForResponse = true;
            await ShowDots();
        }
        private async Task MorningScene3()
        {
            SetNagitoSprite("nagitoHmm.png");

            await TypeSpeech("Нужно поторопиться, я должен проверить ее знания по цифровой грамотности...");

            isProcessing = false;
            isWaitingForResponse = true;
            await ShowDots();
        }
        private async Task MorningScene4()
        {
            SetNagitoSprite("nagitoWhat.png");

            await TypeSpeech("Иначе она не сможет сдать сессию в университете.");

            isProcessing = false;
            isWaitingForResponse = true;
            await ShowDots();
        }
        private async Task MorningRoadScene1()
        {
            SetBackground("morningRoadBox.jpg");

            SetNagitoSprite("nagitoHmm.png");
            await Task.Delay(300);
            await ShowUI();
            await TypeSpeech("Отличная погода, наконец наступило лето.");

            isProcessing = false;
            isWaitingForResponse = true;
            await ShowDots();
        }
        private async Task MorningRoadScene2()
        {
            SetNagitoSprite("nagitoThinking.png");

            await TypeSpeech("Жаль, что я не смогу как следует прогуляться, меня ждет Микан.");

            isProcessing = false;
            isWaitingForResponse = true;
            await ShowDots();
        }
        private async Task MorningRoadScene3()
        {
            SetNagitoSprite("nagitoThinking.png");
            await TypeSpeech("Лаборатория в 5 минутах ходьбы отсюда. Осталось совсем немного.");

            isProcessing = false;
            isWaitingForResponse = true;
            await ShowDots();
        }
        private async Task MorningRoadScene4()
        {
            await TypeSpeech("Ладно, пожалуй, ускорюсь немного.");

            isProcessing = false;
            isWaitingForResponse = true;
            await ShowDots();
        }
        private async Task LabScene1()
        {
            SetBackground("labBox.jpg");

            SetNagitoSprite("nagitoWoke.png");
            await Task.Delay(300);

            await ShowUI();

            await TypeSpeech("Так, теперь осталось найти Микан. Куда же она решила пойти?");

            isProcessing = false;
            isWaitingForResponse = true;
            await ShowDots();
        }

        private async void morningBackground1_Click(object sender, EventArgs e)
        {
            if (isProcessing)
                return;

            isProcessing = true;
            speechTextLabel.Text = string.Empty;
            dotsLabel.Text = string.Empty;
            isWaitingForResponse = !isWaitingForResponse;
            sceneIndex++;
            string speech = string.Empty;
            switch (sceneIndex)
            {
                // Утренняя сцена, пробуждение
                case 0:
                    await MorningScene1();
                    break;
                case 1:
                    await MorningScene2();
                    break;
                case 2:
                    await MorningScene3();
                    break;   
                case 3:
                    await MorningScene4();
                    break;

                // Утренняя сцена, дорога в лабораторию
                case 4:
                    SwitchScene("morningRoadBackground.jpg");
                    break;
                case 5:
                    await MorningRoadScene1();
                    break;
                case 6:
                    await MorningRoadScene2();
                    break;
                case 7:
                    await MorningRoadScene3();
                    break;
                case 8:
                    await MorningRoadScene4();
                    break;
                // Главная сцена. Лаборатория.
                case 9:
                    SwitchScene("labBackground.jpg");
                    break;

                case 10:
                    await LabScene1();
                    break;
                // Первый выбор. Местонахождение Микан.
                default:
                    DialogResult dialogResult = MessageBox.Show("Дальнейший сюжет игры в разработке. Хотите вернуться в главное меню?", "Attention!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MainMenu mainMenu = new MainMenu();
                        mainMenu.Show();
                        MainScene mainScene = new MainScene();
                        mainScene.Close();
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                    break;
            }
        }
    }
}
