using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwelveUpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the string: \n");
                string str = Console.ReadLine();
                int flag = 0;
                var strwords = FilterWords(str);
                int count = 0;
                foreach (string temp in strwords)
                {
                    flag = 1;
                    Console.WriteLine("\nString {0} is {1}",++count,temp);
                }
                if(flag == 0)
                {
                    Console.WriteLine("\nSorry no string found!");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }

        static IEnumerable<string> FilterWords(string str)
        {
            var upper = str.Split(' ')
                        .Where(s => String.Equals(s, s.ToUpper(),
                                    StringComparison.Ordinal));

            return upper;

        }
    }
}
