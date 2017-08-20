using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the number of elements: \n");
                int size = int.Parse(Console.ReadLine());
                int[] arr = new int[size];
                Console.WriteLine("\nEnter the elements of the array: \n");
                for (int i = 0; i < size; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                var query = from temp in arr
                            group temp by temp into ch
                            select ch;
                Console.Write("\nNumber" + "\t" + "Number*Frequency" + "\t" + "Frequency" + "\n");
                Console.Write("------------------------------------------------\n");

                foreach (var temp in query)
                {
                    Console.WriteLine(temp.Key + "\t" + temp.Sum() + "\t\t\t" + temp.Count());
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
