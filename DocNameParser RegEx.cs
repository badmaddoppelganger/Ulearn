using System;
using System.Text;
using System.Text.RegularExpressions;

namespace CreateAgreementNameConstr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите наименование шаблона");
            string name = Console.ReadLine();
            var newName = CreateAgreementName(name); 
            Console.WriteLine($"Наименование договора будет {newName}");
        }

        public static string CreateAgreementName(string agrName)
        {
            //{12}--{21:0000}-abc-{02}РВИ
            Regex regex = new Regex(@"({)\d+(:*)\d*(})");
            StringBuilder newName = new StringBuilder(agrName);
            MatchCollection matches = regex.Matches(agrName);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Value);
                    newName = newName.Replace(match.Value, GetTemplateValue(match.Value.Substring(1, match.Length - 2).Split(':')[0]));
                }
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
            return newName.ToString();
        }

        public static string GetTemplateValue(string tempValue)
        {
            // change to new value  
            return tempValue;
        }
    }
}
