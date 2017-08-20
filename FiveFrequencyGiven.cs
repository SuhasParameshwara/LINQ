using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveFrequencyGiven
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the string : \n\n");
                string str = Console.ReadLine();
                var query = from ch in str
                           group ch by ch into temp
                           select temp;
                Console.Write("\nThe frequency of the characters are :\n");
                foreach (var temp in query)
                {
                    if (temp.Count() > 1)
                    {
                        Console.WriteLine("\nCharacter " + temp.Key + ": " + temp.Count() + " times");
                    }
                    else
                    {
                        Console.WriteLine("\nCharacter " + temp.Key + ": " + temp.Count() + " time");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
