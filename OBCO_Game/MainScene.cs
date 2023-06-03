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

        #region Методы сцен
        private async Task MorningScene1()
        {
            SceneProps props = new SceneProps
            {
                CharacterFileName = "nagitoWoke.png",
                BackgroundFileName = "morningBox.jpg",
                CharacterSpeech = "Ох, уже 10 часов утра"
            };
            await SceneBuilder(props);
        }
        private async Task MorningScene2()
        {
            SceneProps props = new SceneProps
            {
                CharacterFileName = "nagitoThinking.png",
                BackgroundFileName = "morningBox.jpg",
                CharacterSpeech = "Видимо я опоздаю на встречу с Микан в лаборатории."
            };
            await SceneBuilder(props);
        }
        private async Task MorningScene3()
        {
            SceneProps props = new SceneProps
            {
                CharacterFileName = "nagitoHmm.png",
                BackgroundFileName = "morningBox.jpg",
                CharacterSpeech = "Нужно поторопиться, я должен проверить ее знания по цифровой грамотности..."
            };
            await SceneBuilder(props);
        }
        private async Task MorningScene4()
        {
            SceneProps props = new SceneProps
            {
                CharacterFileName = "nagitoWhat.png",
                BackgroundFileName = "morningBox.jpg",
                CharacterSpeech = "Иначе она не сможет сдать сессию в университете."
            };
            await SceneBuilder(props);
        }

        private async Task MorningRoadScene1()
        {
            SceneProps props = new SceneProps
            {
                CharacterFileName = "nagitoHmm.png",
                BackgroundFileName = "morningRoadBox.jpg",
                CharacterSpeech = "Отличная погода, наконец наступило лето."
            };
            await SceneBuilder(props);
        }
        private async Task MorningRoadScene2()
        {
            SceneProps props = new SceneProps
            {
                CharacterFileName = "nagitoThinking.png",
                BackgroundFileName = "morningRoadBox.jpg",
                CharacterSpeech = "Жаль, что я не смогу как следует прогуляться, меня ждет Микан."
            };
            await SceneBuilder(props);
        }
        private async Task MorningRoadScene3()
        {
            SceneProps props = new SceneProps
            {
                CharacterFileName = "nagitoThinking.png",
                BackgroundFileName = "morningRoadBox.jpg",
                CharacterSpeech = "Лаборатория в 5 минутах ходьбы отсюда. Осталось совсем немного."
            };
            await SceneBuilder(props);
        }
        private async Task MorningRoadScene4()
        {
            SceneProps props = new SceneProps
            {
                CharacterFileName = "nagitoThinking.png",
                BackgroundFileName = "morningRoadBox.jpg",
                CharacterSpeech = "Ладно, ускорюсь пожалуй. А иначе будет не очень хорошо по отношению к ней если я" +
                "\nбуду стоять здесь как истукан."
            };
            await SceneBuilder(props);
        }

        private async Task LabScene1()
        {
            SceneProps props = new SceneProps
            {
                CharacterFileName = "nagitoHmm.png",
                BackgroundFileName = "labBox.jpg",
                CharacterSpeech = "Так, теперь осталось найти Микан. Куда же она решила пойти?"
            };
            await SceneBuilder(props);
        }
        #endregion

        #region Методы управления интерфейсом
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
        private async Task ShowDotsUI()
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
        #endregion

        #region Методы для работы со спрайтами и речью
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
        private void SetBackgroundImage(string fileName)
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
        private async Task TypeSpeech(string speech)
        {
            speechTextLabel.Text = string.Empty;
            foreach (char c in speech)
            {
                speechTextLabel.Text += c;
                await Task.Delay(10);
            }
        }
        #endregion

        #region Методы работы со сценами
        private async void SwitchScene(string backgroundFileName, string characterFileName)
        {
            HideUI();
            SetBackgroundImage("loadingScreen.jpg");
            await Task.Delay(3000);
            SetBackgroundImage(backgroundFileName);
            SetNagitoSprite(characterFileName);
            isProcessing = false;
        }
        private void SwitchSubScene()
        {
            speechTextLabel.Text = string.Empty;
            dotsLabel.Text = string.Empty;
            isWaitingForResponse = !isWaitingForResponse;
            sceneIndex++;
        }
        private async Task SceneBuilder(SceneProps props)
        {
            SetNagitoSprite(props.CharacterFileName);
            SetBackgroundImage(props.BackgroundFileName);
            await TypeSpeech(props.CharacterSpeech);

            isProcessing = false;
            isWaitingForResponse = true;
            await ShowDotsUI();
        }
        #endregion

        #region Обработчики событий
        private async void gameBackground_Click(object sender, EventArgs e)
        {
            if (isProcessing) return;

            isProcessing = true;

            SwitchSubScene();

            switch (sceneIndex)
            {
                // Утренняя сцена, пробуждение
                case 0:
                    await ShowUI();
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
                    SwitchScene("morningRoadBackground.jpg", "nagitoHmm.png");
                    break;
                case 5:
                    await ShowUI();
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
                    SwitchScene("labBackground.jpg", "nagitoHmm.png");
                    break;
                case 10:
                    await ShowUI();
                    await LabScene1();
                    break;

                // Первый выбор. Местонахождение Микан.
                default:
                    DialogResult dialogResult = MessageBox.Show("Дальнейший сюжет игры в разработке. Хотите вернуться в главное меню?", "Attention!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MainMenu mainMenu = new MainMenu();
                        mainMenu.Show();
                        Dispose();
                        Close();
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                    break;
            }
        }
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
            SetBackgroundImage("morningBackground.jpg");
            exitButton.Show();
        }
        #endregion
    }
    public class SceneProps
    {
        public string CharacterFileName { get; set; }
        public string BackgroundFileName { get; set; }
        public string CharacterSpeech { get; set; }
    }
}