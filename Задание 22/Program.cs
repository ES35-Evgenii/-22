using System;

namespace Задание_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввод строки: ");
            string str = Console.ReadLine();
            string fifteenLetters = ShortString(str);
            if (str.Length > 15)
            {
                Console.WriteLine($"{fifteenLetters}...");
            }
            else
            {
                Console.WriteLine(fifteenLetters);
            }
            Console.WriteLine("Длина строки: " + fifteenLetters.Length); //для наглядности
        }

        private static string ShortString(string str)
        {
            string[] array = str.Split(); //разбил по словам
            string result = "";           //будущий результат
            if(str.Length > 15)           //длина введенной строки более 15 символов
            {
                for(int i = 0; i < array.Length; i++)
                {
                    //длина результата + длина следующего слова меньше 15 символов
                    if ((result.Length + array[i].Length) < 15) 
                    {
                        result += array[i] + " ";
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                result = str;
            }
            return result;
        }
    }
}