using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineGreatest
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the number of elements: \n");
                int size = int.Parse(Console.ReadLine());
                List<int> templist = new List<int>();
                Console.WriteLine("\nEnter the elements: \n");
                for (int i = 0; i < size; i++)
                {
                    templist.Add(int.Parse(Console.ReadLine()));
                }
                List<int> FilterList = templist.FindAll(x => x > 80 ? true : false);
                if (FilterList.Count() == 0)
                {
                    Console.WriteLine("\nThere are no elements greater than 80.");
                }
                else
                {
                    Console.WriteLine("\n\nThe numbers greater than 80 are : ");
                    foreach (var num in FilterList)
                    {
                        Console.WriteLine(num);
                    }
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
