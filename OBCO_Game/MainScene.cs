﻿using System;
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
using System.Web;
using System.Media;
using System.Runtime.InteropServices;
using static OBCO_Game.TestScene;

namespace OBCO_Game
{
    public partial class MainScene : Form
    {
        public MainScene()
        {
            InitializeComponent();

            exitButton.Hide();
            gameBackground.Hide();
            charSprite.Hide();
            charNameLabel.Hide();

            firstChoiceButton.Hide();
            secondChoiceButton.Hide();
            thirdChoiceButton.Hide();
            skipButton.Hide();

            charNameLabel.Text = "Нагито";
            speechTextLabel.Text = string.Empty;
            dotsLabel.Text = string.Empty;
        }

        private int sceneIndex = 0, sceneIndexNew = 44;
        private static bool isWaitingForResponse = false, isProcessing = false;
        private static string dialogueChoice = string.Empty;

        int resultCorrectAnswers = ResultData.CorrectAnswers;

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
                                  "\nкомнату светом. Он потянулся и вздохнул, осознавая, что перед ним новый день полный" +
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
                CharacterSpeech = "Я опаздываю на встречу с Микан в лаборатории. Лучше поторопиться."
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
                CharacterSpeech = "Это очень важно, потому что так ей будет проще сдать сессию в лучшем университете" +
                "\nвсего мира, в МГТУ имени Г.И.Носова."
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
                CharacterSpeech = "Нагито внимательно наблюдал за ними, задумываясь о том, что каждый из них скрывает за" +
                                "\nсвоей внешностью."
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
                CharacterSpeech = "Жаль, что я не могу насладиться прогулкой. Но обещание есть обещание, и я должен" +
                                "\nвстретиться с Микан."
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
                CharacterSpeech = "Нагито уверенно вошел в лабораторию, в которой он был уже далеко не раз."
            };
            await SceneBuilder(props);
        }
        private async Task LabScene2()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "nagitoHmm.png",
                BackgroundFileName = "labBox.jpg",
                CharacterSpeech = "Он поступил в МГТУ имени Г.И. Носова на направление \"Информационная безопасность\"" +
                                "\nпосле успешной сдачи вступительных экзаменов. Уже на втором курсе, проявляя огромный" +
                                "\nинтерес к научным исследованиям, он решил подрабатывать в местной лаборатории," +
                                "\nспециализирующейся на изучении различных микроорганизмов."
            };
            await SceneBuilder(props);
        }
        private async Task LabScene3()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "nagitoHmm.png",
                BackgroundFileName = "labBox.jpg",
                CharacterSpeech = "Его аналитический склад ума и тонкое чутье позволили ему отыскать интересные" +
                                "\nзакономерности и связи в этих исследованиях. Он проводил дни и ночи, углубляясь" +
                                "\nв свои исследования и стремясь раскрыть тайны, прячущиеся за этими исследованиями."
            };
            await SceneBuilder(props);
        }
        private async Task LabScene4()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "nagitoHmm.png",
                BackgroundFileName = "labBox.jpg",
                CharacterSpeech = "В процессе работы в лаборатории, Нагито познакомился с Микан, молодым и талантливым" +
                                "\nисследователем, увлеченным астрофизикой и информатикой. Их общая страсть к науке и" +
                                "\nлюбовь к загадкам привели их к сотрудничеству. Нагито и Микан проводили много времени" +
                                "\nвместе, обсуждая идеи, проводя эксперименты и делая различные открытия."
            };
            await SceneBuilder(props);
        }
        private async Task LabScene5()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "nagitoHmm.png",
                BackgroundFileName = "labBox.jpg",
                CharacterSpeech = "Навевают приятные воспоминания, нужно отыскать Микан."
            };
            await SceneBuilder(props);
        }
        private async Task LabScene6()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "nagitoHmm.png",
                BackgroundFileName = "labBox.jpg",
                CharacterSpeech = "Куда же она могла направиться?"
            };
            await SceneBuilder(props);
        }

        private async Task LabTransitionScene1()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "nagitoHmm.png",
                BackgroundFileName = "labBox2.jpg",
                CharacterSpeech = "Нагито торопливо шел по коридорам научной лаборатории, направляясь к кабинету Микан."
            };
            await SceneBuilder(props);
        }
        private async Task LabTransitionScene2()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "nagitoHmm.png",
                BackgroundFileName = "labBox2.jpg",
                CharacterSpeech = "Вокруг него царила оживленная атмосфера научной работы: исследователи в белых халатах" +
                                "\nпроходили мимо, обсуждая последние результаты экспериментов, приборы жужжали и" +
                                "\nиздавали тихие звуки, создавая фоновую акустику исследовательской деятельности."
            };
            await SceneBuilder(props);
        }
        private async Task LabTransitionScene3()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "nagitoHmm.png",
                BackgroundFileName = "labBox2.jpg",
                CharacterSpeech = "По пути Нагито замечал знакомые лица, с кем он ранее работал вместе над научными" +
                                "\nпроектами. Все они были поглощены своими исследованиями, стремясь найти ответы на" +
                                "\nинтересующие их вопросы и сделать новые открытия. Нагито не мог не восхищаться их" +
                                "\nнастойчивостью и стремлением к знаниям."
            };
            await SceneBuilder(props);
        }
        private async Task LabTransitionScene4()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "nagitoHmm.png",
                BackgroundFileName = "labBox2.jpg",
                CharacterSpeech = "Нагито неторопливо подошел к двери кабинета, стараясь не производить лишнего шума." +
                                "\nОн осторожно повернул ручку и медленно открыл дверь, чтобы не пугать Микан."
            };
            await SceneBuilder(props);
        }

        private async Task LabCabSceneTransition()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "nagitoHmm.png",
                BackgroundFileName = "blackScreen.png",
                CharacterSpeech = "..."
            };
            await SceneBuilder(props);
        }
        private async Task LabCabScene1()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "nagitoHmm.png",
                BackgroundFileName = "mikanWonderBox.jpg",
                CharacterSpeech = "Однако, когда он вошел, он увидел, что Микан была сильно удивлена его появлением.."
            };
            await SceneBuilder(props);
        }
        private async Task LabCabScene2()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "nagitoHmm.png",
                BackgroundFileName = "mikanWonderBox.jpg",
                CharacterSpeech = "Микан, стоявшая перед дверью, вздрогнула и едва не уронила свою тетрадь по подготовке" +
                                "\nк предстоящим экзаменам."
            };
            await SceneBuilder(props);
        }
        private async Task LabCabScene3()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "nagitoHmm.png",
                BackgroundFileName = "mikanWonderBox.jpg",
                CharacterSpeech = "Ее глаза широко раскрылись, и она не могла скрыть свое удивление. В ее взгляде смешались" +
                                "\nизумление и легкая неуверенность, словно она не знала, как правильно отреагировать на" +
                                "\nтакое неожиданное появление Нагито."
            };
            await SceneBuilder(props);
        }
        private async Task LabCabScene4()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "mikanShy.png",
                BackgroundFileName = "labCabinetBox.jpg",
                CharacterSpeech = "Привет Нагито. Не ожидала тебя увидеть прямо сейчас. Думала ты проспал..."
            };
            await SceneBuilder(props);
        }
        private async Task LabCabScene5()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "mikanPoint.png",
                BackgroundFileName = "labCabinetBox.jpg",
                CharacterSpeech = "Пока тебя не было я готовилась к предстоящей сессии."
            };
            await SceneBuilder(props);
        }
        private async Task LabCabScene6()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "mikanPoint.png",
                BackgroundFileName = "labCabinetBox.jpg",
                CharacterSpeech = "Привет, Микан. Да, поздновато я встал сегодня. Извини, если тебя это смутило. А ты " +
                                "\nготовишься к сессии? Как идут подготовки?"
            };
            await SceneBuilder(props);
        }
        private async Task LabCabScene7()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "mikanHuh.png",
                BackgroundFileName = "labCabinetBox.jpg",
                CharacterSpeech = "Да, конечно, готовлюсь... пытаюсь быть готовой к экзаменам. Но, если честно, я... не" +
                                "\nсовсем уверена в своих знаниях."
            };
            await SceneBuilder(props);
        }
        private async Task LabCabScene8()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "mikanHuh.png",
                BackgroundFileName = "labCabinetBox.jpg",
                CharacterSpeech = "Все это время я пыталась изучать... эм... микроорганизмы особого типа. Но чего-то мне" +
                                "\nкажется, что это отвлекло меня от основного предмета."
            };
            await SceneBuilder(props);
        }
        private async Task LabCabScene9()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "mikanHuh.png",
                BackgroundFileName = "labCabinetBox.jpg",
                CharacterSpeech = "Понимаю. Иногда бывает трудно сосредоточиться на нужных вещах, особенно когда есть" +
                                "\nдругие интересы. Но ты должна понимать, что сессия - очень ответственная период учебы." +
                                "\nЕсли плохо подготовишься, то тебя могут исключить."
            };
            await SceneBuilder(props);
        }
        private async Task LabCabScene10()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "mikanShy.png",
                BackgroundFileName = "labCabinetBox.jpg",
                CharacterSpeech = "Да, конечно... Я понимаю это и не хочу быть обузой для тебя. Я чувствую, что все должно" +
                                "\nбыть готово, иначе... Мне будет немного стыдно."
            };
            await SceneBuilder(props);
        }
        private async Task LabCabScene11()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "mikanShy.png",
                BackgroundFileName = "labCabinetBox.jpg",
                CharacterSpeech = "Микан, не говори так. Ты никогда не будешь обузой для меня. Мы друзья, и я хочу помочь" +
                                "\nтебе. Ты справишься с экзаменом, я уверен в тебе."
            };
            await SceneBuilder(props);
        }
        private async Task LabCabScene12()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "mikanShy.png",
                BackgroundFileName = "labCabinetBox.jpg",
                CharacterSpeech = "Спасибо, Нагито. Я ценю твою поддержку. Но... если не затруднит, может быть, ты мог бы" +
                                "\nпроверить мои знания, чтобы я узнала, насколько я подготовлена?"
            };
            await SceneBuilder(props);
        }
        private async Task LabCabScene13()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "mikanShy.png",
                BackgroundFileName = "labCabinetBox.jpg",
                CharacterSpeech = "Конечно, я с удовольствием помогу тебе проверить свои знания. Это будет полезно для тебя."
            };
            await SceneBuilder(props);
        }
        private async Task LabCabScene14()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "mikanPoint.png",
                BackgroundFileName = "labCabinetBox.jpg",
                CharacterSpeech = "Хорошо, спасибо большое. Тогда приступим."
            };
            await SceneBuilder(props);
        }

        private async Task TestScene1()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "mikanHuh.png",
                BackgroundFileName = "labCabinetBox.jpg",
                CharacterSpeech = "Ну, надеюсь, что я не провалилась."
            };
            await SceneBuilder(props);
        }
        private async Task TestScene2()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "mikanHuh.png",
                BackgroundFileName = "labCabinetBox.jpg",
                CharacterSpeech = "Да, конечно. Дай немного времени на проверку."
            };
            await SceneBuilder(props);
        }
        private async Task TestScene3()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "mikanPoint.png",
                BackgroundFileName = "labCabinetBox.jpg",
                CharacterSpeech = "Хорошо, жду твоего вердикта!"
            };
            await SceneBuilder(props);
        }

        private async Task ResultsScene1()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "mikanHuh.png",
                BackgroundFileName = "labCabinetBox.jpg",
                CharacterSpeech = "Ну, какие результаты?"
            };
            await SceneBuilder(props);
        }

        private async Task ExcellentResultsScene1()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "mikanHuh.png",
                BackgroundFileName = "labCabinetBox.jpg",
                CharacterSpeech = $"У тебя {resultCorrectAnswers} правильных ответов из 30." +
                                $"\nИдеально! Бог ты мой)))))))"
            };
            await SceneBuilder(props);
        }
        private async Task ExcellenResultsScene2()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "mikanHuh.png",
                BackgroundFileName = "labCabinetBox.jpg",
                CharacterSpeech = "ААААА"
            };
            await SceneBuilder(props);
        }
        private async Task GoodResultsScene1()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "mikanHuh.png",
                BackgroundFileName = "labCabinetBox.jpg",
                CharacterSpeech = $"У тебя {resultCorrectAnswers} правильных ответов из 30." +
                                $"\nМолодец! Вполне неплохо подготовилась."
            };
            await SceneBuilder(props);
        }
        private async Task GoodResultsScene2()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "mikanHuh.png",
                BackgroundFileName = "labCabinetBox.jpg",
                CharacterSpeech = "Да, конечно. Дай немного времени на проверку."
            };
            await SceneBuilder(props);
        }
        private async Task SatisfactoryResultsScene1()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "mikanPoint.png",
                BackgroundFileName = "labCabinetBox.jpg",
                CharacterSpeech = $"У тебя {resultCorrectAnswers} правильных ответов из 30. Удовлетворительный" +
                                $"\nрезультат, надо бы подготовиться получше."
            };
            await SceneBuilder(props);
        }
        private async Task SatisfactoryResultsScene2()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "mikanPoint.png",
                BackgroundFileName = "labCabinetBox.jpg",
                CharacterSpeech = "Хорошо, жду твоего вердикта!"
            };
            await SceneBuilder(props);
        }
        private async Task BadResultsScene1()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "mikanPoint.png",
                BackgroundFileName = "labCabinetBox.jpg",
                CharacterSpeech = "...\nНе хочу тебя расстраивать, но у тебя очень плохой результат." +
                                    $"\nВсего {resultCorrectAnswers} правильных ответов из 30."
            };
            await SceneBuilder(props);
        }
        private async Task BadResultsScene2()
        {
            SceneData props = new SceneData
            {
                CharacterFileName = "mikanPoint.png",
                BackgroundFileName = "labCabinetBox.jpg",
                CharacterSpeech = $"..."
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
                    HideCharacter();
                    ShowUI();
                    PlaySound("thinPurple.wav");
                    await MorningScene1();
                    break;
                case 2:
                    await MorningScene2();
                    break;
                case 3:
                    ShowCharacter("Нагито");
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
                    HideCharacter();
                    StopSound();
                    SwitchScene("loadingScreen.jpg", "morningRoadBackground.jpg", "nagitoHmm.png");
                    break;
                case 8:
                    ShowUI();
                    PlaySound("investigation.wav");
                    await MorningRoadScene1();
                    break;
                case 9:
                    await MorningRoadScene2();
                    break;
                case 10:
                    ShowCharacter("Нагито");
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
                    StopSound();
                    SwitchScene("loadingScreen.jpg", "labBackground.jpg", "nagitoHmm.png");
                    break;
                //  * Первый выбор, не влияет на концовку.
                case 15:
                    PlaySound("investigation.wav");
                    HideCharacter();
                    ShowUI();
                    await LabScene1();
                    break;
                case 16:
                    await LabScene2();
                    break;
                case 17:
                    await LabScene3();
                    break;
                case 18:
                    await LabScene4();
                    break;
                case 19:
                    ShowCharacter("Нагито");
                    await LabScene5();
                    break;
                case 20:
                    ShowCharacter("Нагито");
                    await LabScene6();
                    break;
                case 21:
                    ChoiceText("Кабинет Микан", "Химическая лаборатория", "Комната отдыха");
                    ShowButtons();
                    break;
                case 22:
                    HideButtons();
                    await Task.Delay(500);
                    if (dialogueChoice == "A")
                    {
                        isProcessing = false;
                        firstChoiceButton.Enabled = false;
                        SceneData props = new SceneData
                        {
                            CharacterFileName = "nagitoHmm.png",
                            BackgroundFileName = "labBox.jpg",
                            CharacterSpeech = "Попробую сходить в ее кабинет. Наверняка она повторяет учебный материал."
                        };
                        await SceneBuilder(props);
                        gameBackground.Enabled = true;
                    }
                    else if (dialogueChoice == "B")
                    {
                        isProcessing = false;
                        secondChoiceButton.Enabled = false;
                        SceneData props = new SceneData
                        {
                            CharacterFileName = "nagitoHmm.png",
                            BackgroundFileName = "labBox.jpg",
                            CharacterSpeech = "Вряд ли она пойдет в лабораторию, у нее нет к ней доступа. Может она находится" +
                                              "\nв другом месте?"
                        };
                        sceneIndex -= 2;

                        await SceneBuilder(props);
                        gameBackground.Enabled = true;
                    }
                    else if (dialogueChoice == "C")
                    {
                        isProcessing = false;
                        thirdChoiceButton.Enabled = false;
                        SceneData props = new SceneData
                        {
                            CharacterFileName = "nagitoHmm.png",
                            BackgroundFileName = "labBox.jpg",
                            CharacterSpeech = "Точно, она же написала мне в Телеграме, что она сейчас находится в своем кабинете" +
                                              "\nвряд ли она пошла в комнату отдыха."
                        };
                        sceneIndex -= 2;

                        await SceneBuilder(props);
                        gameBackground.Enabled = true;
                    }
                    break;

                // Промежуточная сцена. Дорога в кабинет Микан.
                case 23:
                    StopSound();
                    SwitchScene("loadingScreen.jpg", "labBackground2.jpg", "nagitoHmm.png");
                    break;
                case 24:
                    PlaySound("thinPurple.wav");
                    HideCharacter();
                    ShowUI();
                    await LabTransitionScene1();
                    break;
                case 25:
                    await LabTransitionScene2();
                    break;
                case 26:
                    await LabTransitionScene3();
                    break;
                case 27:
                    await LabTransitionScene4();
                    break;

                // Главная сцена. Кабинет Микан.
                case 28:
                    StopSound();
                    PlaySound("doorOpening.wav");
                    await Task.Delay(1200);
                    ShowCharacter("Микан");
                    charSprite.Hide();

                    PlaySound("huh.wav");
                    await LabCabSceneTransition();
                    break;
                case 29:
                    PlaySound("girlOfTheShell.wav");
                    HideCharacter();
                    await LabCabScene1();
                    break;
                case 30:
                    await LabCabScene2();
                    break;
                case 31:
                    await LabCabScene3();
                    break;
                case 32:
                    ShowCharacter("Микан");
                    await LabCabScene4();
                    break;
                case 33:
                    await LabCabScene5();
                    break;
                case 34:
                    ShowCharacter("Нагито");
                    await LabCabScene6();
                    break;
                case 35:
                    ShowCharacter("Микан");
                    await LabCabScene7();
                    break;
                case 36:
                    await LabCabScene8();
                    break;
                case 37:
                    ShowCharacter("Нагито");
                    await LabCabScene9();
                    break;
                case 38:
                    ShowCharacter("Микан");
                    await LabCabScene10();
                    break;
                case 39:
                    ShowCharacter("Нагито");
                    await LabCabScene11();
                    break;
                case 40:
                    ShowCharacter("Микан");
                    await LabCabScene12();
                    break;
                case 41:
                    ShowCharacter("Нагито");
                    await LabCabScene13();
                    break;
                case 42:
                    ShowCharacter("Микан");
                    await LabCabScene14();
                    break;
                case 43:
                    TestScene testScene = new TestScene();
                    testScene.TestFinished += TestScene_TestFinished;
                    testScene.Show();
                    break;
                case 44:
                    ShowCharacter("Нагито");
                    await TestScene2();
                    break;
                case 45:
                    ShowCharacter("Микан");
                    await TestScene3();
                    break;
                case 46:
                    StopSound();
                    SwitchScene("loadingScreen.jpg", "labCabinetBox.jpg", "nagitoShy.png");
                    break;
                // Результаты теста. Концовки.
                case 47:
                    ShowUI();
                    ShowCharacter("Нагито");
                    if (resultCorrectAnswers <= 10)
                    {
                        PlaySound("girlOfTheShell.wav");
                        await BadResultsScene1();
                    }
                    else if (resultCorrectAnswers <= 20)
                    {
                        PlaySound("thinPurple.wav");
                        await SatisfactoryResultsScene1();
                    }
                    else if (resultCorrectAnswers < 30)
                    {
                        PlaySound("investigation.wav");
                        await GoodResultsScene1();
                    }
                    else if (resultCorrectAnswers <= 30)
                    { 
                        PlaySound("huh.wav");
                        await ExcellentResultsScene1();
                    }
                    HideCharacter();
                    ShowUI();
                    await LabScene1();
                    break;
                default:
                    DialogResult dialogResult = MessageBox.Show("Дальнейший сюжет игры в разработке. Хотите вернуться в главное меню?", "Attention!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MainMenu mainMenu = new MainMenu();
                        mainMenu.Show();
                        StopSound();
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
        private async void TestScene_TestFinished(object sender, EventArgs e)
        {
            SwitchSubScene();
            switch (sceneIndexNew)
            {
                case 44:
                    ShowUI();
                    ShowCharacter("Микан");
                    PlaySound("thinPurple.wav");
                    await TestScene1();
                    break;
                
            }
        }

        #region Методы управления интерфейсом
        private void ShowCharacter(string charName)
        {
            charSprite.Show();
            charNameLabel.Show();
            charNameLabel.Text = charName;
        }
        private void HideCharacter()
        {
            charSprite.Hide();
            charNameLabel.Hide();
            charNameLabel.Text = string.Empty;
        }
        private void ShowUI()
        {
            charNameLabel.Show();
            speechTextLabel.Show();
            exitButton.Show();
            dotsLabel.Show();
            skipButton.Show();
        }
        private void HideUI()
        {
            exitButton.Hide();
            charSprite.Hide();
            charNameLabel.Hide();
            dotsLabel.Hide();
            skipButton.Hide();
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
            // Текст кнопок выбора
            firstChoiceButton.Text = firstChoiceText;
            secondChoiceButton.Text = secondChoiceText;
            thirdChoiceButton.Text = thirdChoiceText;
        }
        #endregion

        #region Методы для работы со мультимедиа и речью
        private void SetCharacterSprite(string fileName)
        {
            string path = Path.Combine(Application.StartupPath, "Sprites", fileName);

            if (File.Exists(path))
            {
                Image character = Image.FromFile(path);
                charSprite.Image = character;
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
        private void PlaySound(string fileName)
        {
            string path = Path.Combine(Application.StartupPath, "Sounds", fileName);

            if (File.Exists(path))
            {
                using (SoundPlayer soundPlayer = new SoundPlayer(path))
                {
                    soundPlayer.Play();
                }
            }
            else
            {
                MessageBox.Show("Ошибка в коде. Неправильное расположение/название звукового файла.");
            }
        }
        private void StopSound()
        {
            SoundPlayer soundPlayer = new SoundPlayer();
            if (soundPlayer != null)
            {
                soundPlayer.Stop();
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
        private async void SwitchScene(string loadingFileName, string backgroundFileName, string characterFileName)
        {
            HideUI();
            SetBackgroundImage(loadingFileName);
            await Task.Delay(3000);
            SetBackgroundImage(backgroundFileName);
            SetCharacterSprite(characterFileName);
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
            SetCharacterSprite(props.CharacterFileName);
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

            isProcessing = false;
            gameBackground_Click(sender, e);
        }
        private void secondChoiceButton_Click(object sender, EventArgs e)
        {
            dialogueChoice = "B";

            secondChoiceButton.Enabled = false;

            isProcessing = false;
            gameBackground_Click(sender, e);
        }
        private void thirdChoiceButton_Click(object sender, EventArgs e)
        {
            dialogueChoice = "C";

            thirdChoiceButton.Enabled = false;

            isProcessing = false;
            gameBackground_Click(sender, e);
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            if (isProcessing) return;

            isProcessing = true;

            if (sceneIndex < 21)
            {
                isProcessing = false;
                sceneIndex = 40; //19 27
                gameBackground_Click(sender, e);
                skipButton.Enabled = false;
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите выйти в главное меню?", ":(", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                StopSound();
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
    #region Классы обработки сцен
    public class SceneData
    {
        public string CharacterFileName { get; set; }
        public string BackgroundFileName { get; set; }
        public string CharacterSpeech { get; set; }
    }
    #endregion
}