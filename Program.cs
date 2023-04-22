using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Сохранение_в_файл
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string writePath = @"C:\Users\user\Desktop\Колледж\Системное программирование\Dyba.txt";
                string readPath = @"C:\Users\user\Desktop\Колледж\Системное программирование\Dyba.txt";

                using (StreamWriter sw = new StreamWriter(writePath, true, Encoding.Default))
                {
                    sw.WriteLine("Добро пожаловать в бесные ночи");
                }

                using (StreamReader sr = new StreamReader(readPath, Encoding.Default))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            } 
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
