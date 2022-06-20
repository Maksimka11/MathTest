using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTest
{
    public class Test
    {
        //Массив теста с вопросами и ответами
        public string[,] testQuestion = new string[15, 6];
        //Поля определяющие номер текущего вопроса и количество верных ответов
        public int QuestNumber = 0,AnswerRight = 0;


        //Загрузка теста из файла
        public void LoadTest()
        {
            //Путь к файлу
            string path = @"Test.txt";
            StreamReader sr = new StreamReader(path, System.Text.Encoding.Unicode);
            //Считывание строк из файла и занесение в массив
            for(int i = 0; i < 15; i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    testQuestion[i, j] = sr.ReadLine();
                }
            }
        }

        //Метод проверки ответа на корректность
        public void CheckAnswer(int Answer)
        {
            
            if (Answer == Convert.ToInt16(testQuestion[QuestNumber, 5]))
            {
                AnswerRight++;
            }
            //Увеличиваем номер вопроса
            QuestNumber++;
        }



    }
}
