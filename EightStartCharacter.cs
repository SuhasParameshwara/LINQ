using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightStartCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                int flag = 0;
                string tempStart = null;
                string tempEnd = null;
                Console.WriteLine("Enter the number of cities to register: \n");
                int num = int.Parse(Console.ReadLine());
                string[] cities = new string[num];
                for(int i = 0; i < num; i++)
                {
                    cities[i] = Console.ReadLine();
                } 
                string chst, chen;
                char ch;
                Console.Write("\nInput starting character for the string : ");
                ch = char.Parse(Console.ReadLine());
                tempStart = ch.ToString();
                Console.Write("\nInput ending character for the string : ");
                ch = char.Parse(Console.ReadLine());
                tempEnd = ch.ToString();
                var query = from temp in cities
                              where temp.StartsWith(tempStart)
                              where temp.EndsWith(tempEnd)
                              select temp;
                Console.Write("\n\n");
                foreach (var city in query)
                {
                    flag = 1;
                    Console.Write("The city starting with {0} and ending with {1} is : {2} \n", tempStart, tempEnd, city);
                    
                }
                if(flag == 0)
                {
                    Console.WriteLine("Sorry! Not found!");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
