using System;
using System.IO;
using System.Linq;
namespace pr16_1_Siver_zd1
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "text.txt";
            string text = File.ReadAllText(file);
            Console.WriteLine($"Текст: \n {text}");
            Console.WriteLine("Введите слово для поиска в тексте: ");
            string str = Console.ReadLine();
            string lowerText = text.ToLower();
            string lowerStr = str.ToLower();

            int count1 = 0;
            int index = 0;
            while ((index = lowerText.IndexOf(lowerStr,index)) != -1)
            {
                count1++;
                index += lowerStr.Length;
            }
            Console.WriteLine($"Были найдены {count1} вхождения (ий) поискового запроса {str}");

            // с помощью Linq
            var words = text.ToLower().Split(new[] { ' ', '\r', '\t', '\n', ',', '.', ';', '!', '?', ':', '"' }, StringSplitOptions.RemoveEmptyEntries);
            int count2 = words.Count(words => words == lowerStr);
            Console.WriteLine($"Были найдены {count2} вхождения (ий) поискового запроса {str}");

            Console.ReadLine();
        }
    }
}
