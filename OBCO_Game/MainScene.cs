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
using System.Text.Json;

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

            firstChoiceButton.Hide();
            secondChoiceButton.Hide();
            thirdChoiceButton.Hide();

            charNameLabel.Text = "Нагито";
            speechTextLabel.Text = string.Empty;
            dotsLabel.Text = string.Empty;
        }

        private int sceneIndex = 0;
        private static bool isWaitingForResponse = false, isProcessing = false;
        private static string dialogueChoice = string.Empty;

        #region Методы сцен
        private async Task MorningScene1()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "nagitoWoke.png",
                BackgroundFileName = "morningBox.jpg",
                CharacterSpeech = "Утро."
            };
            await SceneBuilder(props);
        }
        private async Task MorningScene2()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "nagitoWoke.png",
                BackgroundFileName = "morningBox.jpg",
                CharacterSpeech = "Когда Нагито проснулся, лучи утреннего солнца проникали сквозь занавески, наполняя" +
                                  "\nкомнату светом. Он потянулся и вздохнул, осознавая, что перед ним новый день полон" +
                                  "\nвозможностей."
            };
            await SceneBuilder(props);
        }
        private async Task MorningScene3()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "nagitoWoke.png",
                BackgroundFileName = "morningBox.jpg",
                CharacterSpeech = "Поздновато я проснулся. На часах уже 10 часов."
            };
            await SceneBuilder(props);
        }
        private async Task MorningScene4()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "nagitoWhat.png",
                BackgroundFileName = "morningBox.jpg",
                CharacterSpeech = "Я опаздываю на встречу с Микан в лаборатории. Лучше потороплюсь!"
            };
            await SceneBuilder(props);
        }
        private async Task MorningScene5()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "nagitoWhat.png",
                BackgroundFileName = "morningBox.jpg",
                CharacterSpeech = "Мне нужно проверить ее знания по цифровой грамотности сегодня."
            };
            await SceneBuilder(props);
        }
        private async Task MorningScene6()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "nagitoHmm.png",
                BackgroundFileName = "morningBox.jpg",
                CharacterSpeech = "Это очень важно, потому что так ей будет проще поступить в лучший университет" +
                "\nво всем мире, в МГТУ имени Г.И.Носова."
            };
            await SceneBuilder(props);
        }

        private async Task MorningRoadScene1()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "nagitoHmm.png",
                BackgroundFileName = "morningRoadBox.jpg",
                CharacterSpeech = "Перекресток был заполнен людьми, спешащими на работу или учебу."
            };
            await SceneBuilder(props);
        }
        private async Task MorningRoadScene2()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "nagitoHmm.png",
                BackgroundFileName = "morningRoadBox.jpg",
                CharacterSpeech = "Нагито внимательно наблюдал за ними, задумываясь о том, что каждый из них" +
                                  "\nскрывает за своей внешностью."
            };
            await SceneBuilder(props);
        }
        private async Task MorningRoadScene3()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "nagitoHmm.png",
                BackgroundFileName = "morningRoadBox.jpg",
                CharacterSpeech = "Все-таки отличная погода сегодня. Лето в самом разгаре!"
            };
            await SceneBuilder(props);
        }
        private async Task MorningRoadScene4()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "nagitoThinking.png",
                BackgroundFileName = "morningRoadBox.jpg",
                CharacterSpeech = "Жаль, что я не могу насладиться прогулкой. Но обещание есть обещание, и я" +
                                  "\nдолжен встретиться с Микан."
            }; 
            await SceneBuilder(props);
        }
        private async Task MorningRoadScene5()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "nagitoThinking.png",
                BackgroundFileName = "morningRoadBox.jpg",
                CharacterSpeech = "Лаборатория всего в пяти минутах ходьбы. Уже почти пришел."
            };
            await SceneBuilder(props);
        }
        private async Task MorningRoadScene6()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "nagitoHmm.png",
                BackgroundFileName = "morningRoadBox.jpg",
                CharacterSpeech = "Ладно, потороплюсь. Нехорошо затягивать время, особенно когда кто-то ждет."
            };
            await SceneBuilder(props);
        }
        private async Task LabScene1()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "nagitoHmm.png",
                BackgroundFileName = "labBox.jpg",
                CharacterSpeech = "Наконец-то я здесь. Теперь осталось найти Микан. Куда же она решила пойти?"
            };
            await SceneBuilder(props);
        }
        #endregion

        private async void gameBackground_Click(object sender, EventArgs e)
        {
            if (isProcessing) return;

            isProcessing = true;

            SwitchSubScene();

            switch (sceneIndex)
            {
                // Утренняя сцена, пробуждение
                case 1:
                    HideNagito();
                    ShowUI();
                    await MorningScene1();
                    break;
                case 2:
                    await MorningScene2();
                    break;
                case 3:
                    ShowNagito();
                    await MorningScene3();
                    break;
                case 4:
                    await MorningScene4();
                    break;
                case 5:
                    await MorningScene5();
                    break;
                case 6:
                    await MorningScene6();
                    break;

                // Утренняя сцена, дорога в лабораторию
                case 7:
                    HideNagito();
                    SwitchScene("morningRoadBackground.jpg", "nagitoHmm.png");
                    break;
                case 8:
                    ShowUI();
                    await MorningRoadScene1();
                    break;
                case 9:
                    await MorningRoadScene2();
                    break;
                case 10:
                    ShowNagito();
                    await MorningRoadScene3();
                    break;
                case 11:
                    await MorningRoadScene4();
                    break;
                case 12:
                    await MorningRoadScene5();
                    break;
                case 13:
                    await MorningRoadScene6();
                    break;
                // Главная сцена. Лаборатория.
                case 14:
                    SwitchScene("labBackground.jpg", "nagitoHmm.png");
                    break;
                //  Первый выбор, не влияет на концовку.
                case 15:
                    ShowNagito();
                    ShowUI();
                    await LabScene1();
                    break;           
                case 16:
                    ChoiceText("Кабинет Микан", "Химическая лаборатория", "Комната отдыха");

                    ShowButtons();
                    break;
                case 17:
                    await Task.Delay(1000);
                    HideButtons();

                    await Task.Delay(1000);
                    if (dialogueChoice == "A")
                    {
                        gameBackground.Enabled = true;
                        SceneData props = new SceneData
                        {
                            CharacterFileName = "nagitoHmm.png",
                            BackgroundFileName = "labBox.jpg",
                            CharacterSpeech = "Попробую сходить в ее кабинет. Наверняка она повторяет учебный материал."
                        };
                        await SceneBuilder(props);

                    }
                    else if (dialogueChoice == "B")
                    {
                        gameBackground.Enabled = true;
                        // Исполнить ветвь B диалога
                    }
                    else if (dialogueChoice == "C")
                    {
                        gameBackground.Enabled = true;
                        // Исполнить ветвь С диалога
                    }
                    break;
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

        #region Методы управления интерфейсом
        private void ShowNagito()
        {
            nagitoChar.Show();
            charNameLabel.Show();
            charNameLabel.Text = "Нагито";
        }
        private void HideNagito()
        {
            nagitoChar.Hide();
            charNameLabel.Hide();
            charNameLabel.Text = string.Empty;
        }
        private void ShowUI()
        {
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
        private void ShowButtons()
        {
            firstChoiceButton.Show();
            secondChoiceButton.Show();
            thirdChoiceButton.Show();
        }
        private void HideButtons()
        {
            firstChoiceButton.Hide();
            secondChoiceButton.Hide();
            thirdChoiceButton.Hide();
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
        private void ChoiceText(string firstChoiceText, string secondChoiceText, string thirdChoiceText)
        {
            firstChoiceButton.Text = firstChoiceText;
            secondChoiceButton.Text = secondChoiceText;
            thirdChoiceButton.Text = thirdChoiceText;
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
        private async Task SceneBuilder(SceneData props)
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
        private void firstChoiceButton_Click(object sender, EventArgs e)
        {
            dialogueChoice = "A";

            firstChoiceButton.Enabled = false;
            secondChoiceButton.Enabled = false;
            thirdChoiceButton.Enabled = false;

            sceneIndex++;
        }
        private void secondChoiceButton_Click(object sender, EventArgs e)
        {
            dialogueChoice = "B";

            firstChoiceButton.Enabled = false;
            secondChoiceButton.Enabled = false;
            thirdChoiceButton.Enabled = false;

            sceneIndex++;
        }
        private void thirdChoiceButton_Click(object sender, EventArgs e)
        {
            dialogueChoice = "C";

            firstChoiceButton.Enabled = false;
            secondChoiceButton.Enabled = false;
            thirdChoiceButton.Enabled = false;

            sceneIndex++;
        }

        private void welcomeScreen_Click(object sender, EventArgs e)
        {
            welcomeScreen.Hide();
            gameBackground.Show();
            SetBackgroundImage("morningBackground.jpg");
            exitButton.Show();
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
        #endregion
    }
    #region Классы обработки сцен
    public class SceneData
    {
        public string CharacterFileName { get; set; }
        public string BackgroundFileName { get; set; }
        public string CharacterSpeech { get; set; }
    }
    #endregion
}