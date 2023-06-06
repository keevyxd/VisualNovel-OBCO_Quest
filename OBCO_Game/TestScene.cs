using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection.Emit;

namespace OBCO_Game
{
    public partial class TestScene : Form
    {
        public event EventHandler TestFinished;
        public TestScene()
        {
            InitializeComponent();

            LoadQuestionsFromFile("questions.txt");  // Загрузка вопросов из файла при запуске формы
            DisplayCurrentQuestion();

            lblQuestion.AutoSize = true;

            lblAnsw1.AutoSize = lblAnsw2.AutoSize = lblAnsw3.AutoSize = true;
        }
        private void SetBackground(string fileName)
        {
            string path = Path.Combine(Application.StartupPath, "Resources", fileName);

            if (File.Exists(path))
            {
                Image background = Image.FromFile(path);
                testScreen.Image = background;
            }
            else
            {
                MessageBox.Show("Ошибка в коде. Неправильное расположение/название спрайта.");
            }
        }

        public static class ResultData
        {
            public static int CorrectAnswers { get; set; }
            public static int SceneIndex { get; set; }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CheckAnswer())
            {
                correctAnswers++;
            }
            currentQuestionIndex++;

            if (currentQuestionIndex < 10)
            {
                SetBackground("testBackground1.jpg");
            }
            else if (currentQuestionIndex < 20)
            {
                SetBackground("testBackground2.jpg");
            }
            else if (currentQuestionIndex < 30)
            {
                SetBackground("testBackground3.jpg");
            }

            ResultData.CorrectAnswers = correctAnswers;
            ResultData.SceneIndex = 44;
            DisplayCurrentQuestion();
        }

        private string[] questions;
        private int currentQuestionIndex = 0;
        private int correctAnswers = 0;

        private void LoadQuestionsFromFile(string filePath)
        {
            questions = File.ReadAllLines(filePath);
        }

        private async void DisplayCurrentQuestion()
        {
            if (currentQuestionIndex < questions.Length)
            {
                string[] questionData = questions[currentQuestionIndex].Split(';');
                lblQuestion.Text = questionData[0];  // Первый элемент - вопрос

                // Проверяем, достаточно ли элементов для трех вариантов ответов
                if (questionData.Length >= 4)
                {
                    // Варианты ответов
                    lblAnsw1.Text = questionData[1];
                    lblAnsw2.Text = questionData[2];
                    lblAnsw3.Text = questionData[3];
                }

                // Сброс выбранного ответа
                radioButton1.Checked = radioButton2.Checked = radioButton3.Checked = false;
            }
            else
            {
                // Вопросы закончились
                lblQuestion.Text = "Тест завершен.";
                radioButton1.Enabled = radioButton2.Enabled = radioButton3.Enabled = false;
                btnNext.Enabled = false;

                await Task.Delay(3000);
                TestFinished?.Invoke(this, EventArgs.Empty);
                Hide();
            }
        }

        private bool CheckAnswer()
        {
            // Правильный ответ
            string[] questionData = questions[currentQuestionIndex].Split(';');
            int correctAnswerIndex = int.Parse(questionData[4]);

            // Проверка правильного варианта ответа
            if (radioButton1.Checked && correctAnswerIndex == 1)
            {
                return true;
            }
            else if (radioButton2.Checked && correctAnswerIndex == 2)
            {
                return true;
            }
            else if (radioButton3.Checked && correctAnswerIndex == 3)
            {
                return true;
            }
            return false;
        }
    }
}
