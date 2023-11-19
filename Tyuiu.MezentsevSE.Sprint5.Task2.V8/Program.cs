using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Tyuiu.MezentsevSE.Sprint5.Task2.V8.Lib;
namespace Tyuiu.MezentsevSE.Sprint5.Task2.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Мезенцев С.Е. | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнила: Мезенцев С.Е. | ИИПб-23-2                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Заменить положительные элементы массива на 1, отрицательные на 0.       *");


            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[,] matrix = { { -9, 4, -6 }, { 3, 9, 9 }, { -6, 7, -4 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0, count = 0; j < 3; j++, count++)
                {
                    if (count != 2)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + "\n");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string path = ds.SaveToFileTextData(matrix);
            Console.WriteLine("Файл создан                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(File.ReadAllText(path));
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
