using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MezentsevSE.Sprint5.Task1.V7.Lib
{
    public class DataService : ISprint5Task1V7
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            string str;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Sin(x) / (x + 1.2) - (Math.Sin(x) * 2) - 2 * x;
                y = Math.Round(y, 2);
                if (x == -1.2)
                {
                    y = 0;
                }
                str = Convert.ToString(y);
                
                if (x != stopValue)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }
            }
            return path;
        }
    }
}
