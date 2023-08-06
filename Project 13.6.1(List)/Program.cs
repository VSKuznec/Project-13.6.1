using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Project_13._6._1_List_
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("C:\\Users\\sevac\\OneDrive\\Рабочий стол\\lms-cdn.skillfactory.ru_assets_courseware_v1_dc9cf029ae4d0ae3ab9e490ef767588f_asset-v1_SkillFactory+CDEV+2021+type@asset+block_Text1.pdf");

            char[] delimiters = new char[] { ' ', '\r', '\n' };

            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            
            Console.WriteLine(words.Length);

            var list = new List<int>();

            for (int i = 0; i < words.Length; i++)
            {
                list.Add(i);
            }

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            stopWatch.Stop();

            Console.WriteLine("Время вставки элементов в список: {0}", stopWatch.Elapsed);

            Console.ReadKey();
        }
    }

}
