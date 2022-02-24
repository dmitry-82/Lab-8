using System;
using System.IO;

namespace Lab_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = File.CreateText("D:/Обучение/BIM - проектирование ИТМО/08 Занятие/Sum.txt"); //Здесь мы создали поток sw, 
                                                                                                           //а при помощи метода File.CreateText создали файл 
            {
                Random rnd = new Random();
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(rnd.Next(500)); //Записываем случайные числа в наш файл
                }
            }
            sw.Close(); //Закрываем поток

            string[] lines = File.ReadAllLines("D:/Обучение/BIM - проектирование ИТМО/08 Занятие/Sum.txt");

            //объявим переменную для хранения суммы
            int sum = 0;

            //проходим по строкам одна за другой...
            foreach (string line in lines)
            //преобразование строки в число, а затем добавление ее к сумме
            sum = sum + int.Parse(line);

            Console.WriteLine("sum " + sum);
            Console.ReadLine();
        }
    }
}

