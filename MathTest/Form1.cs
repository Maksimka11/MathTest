using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Test test = new Test();
        int Answer = 0;

        //Загрузка вопроса из массива
        private void LoadNewQuestion()
        {
            tbQuest.Text = test.testQuestion[test.QuestNumber, 0];
            rbAnswer1.Text = test.testQuestion[test.QuestNumber, 1];
            rbAnswer2.Text = test.testQuestion[test.QuestNumber, 2];
            rbAnswer3.Text = test.testQuestion[test.QuestNumber, 3];
            rbAnswer4.Text = test.testQuestion[test.QuestNumber, 4];
            //Отображение номера вопроса на форме
            lblQuestionNumber.Text = (test.QuestNumber + 1).ToString() + @"\" + "15";
        }
        //Обработка загрузки формы
        private void Form_Load(object sender, EventArgs e)
        {
            //Загружаем вопросы из файла
            test.LoadTest();
            //Загружаем на форму первый вопрос
            LoadNewQuestion();
        }
        //Обработка нажатия на кнопку btnAnswer
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            //Проверяем выбор ответа
            if (Answer == 0)
            {
                MessageBox.Show("Выберите вариант ответа!");
                return;
            }
            else
            {
                //Передаем номер ответа в метод проверки ответа
                test.CheckAnswer(Answer);
                //Проверка на номер вопроса. Если номер ответа равен 15, то тест заканчивается и выводится количество правильных ответов
                if (test.QuestNumber == 15) MessageBox.Show("Тест окончен. Правильных ответов: " + test.AnswerRight.ToString());
                else
                {
                    //Очищаем прошлый выбор ответа
                    rbClear();
                    //Загружаем новый вопрос
                    LoadNewQuestion();
                    //Очищаем поле с ответом для дальнейшего использования
                    Answer = 0;
                }
            }
            
        }
        //Обработка выбора ответа
        private void rbAnswer1_CheckedChanged(object sender, EventArgs e)
        {
            //В поле Answer записываем номер ответа
            Answer = 1;
        }

        private void rbAnswer2_CheckedChanged(object sender, EventArgs e)
        {
            Answer = 2;
        }

        private void rbAnswer3_CheckedChanged(object sender, EventArgs e)
        {
            Answer = 3;
        }

        private void rbAnswer4_CheckedChanged(object sender, EventArgs e)
        {
            Answer = 4;
        }
        //Метод очистки выбора ответов
        private void rbClear()
        {
            rbAnswer1.Checked = false;
            rbAnswer2.Checked = false;
            rbAnswer3.Checked = false;
            rbAnswer4.Checked = false;
        }
    }
}
