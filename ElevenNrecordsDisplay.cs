using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNrecordsDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the number of elements: \n");
                int size = int.Parse(Console.ReadLine());
                if (size == 0)
                {
                    Console.WriteLine("\nArray Size cannot be zero!");
                }
                else
                {
                    Console.WriteLine("\nEnter the elements: \n");
                    List<int> templist = new List<int>();
                    for (int i = 0; i < size; i++)
                    {
                        templist.Add(int.Parse(Console.ReadLine()));
                    }
                    Console.WriteLine("\nThe members of the list are : ");
                    foreach (var temp in templist)
                    {
                        Console.WriteLine(temp + " ");
                    }
                    Console.Write("\nHow many records you want to display ? : ");
                    int num = int.Parse(Console.ReadLine());
                    templist.Sort();
                    templist.Reverse();
                    Console.Write("\nThe top {0} records from the list are : \n", num);
                    foreach (int top in templist.Take(num))
                    {
                        Console.WriteLine("\n"+top);
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
