using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the number of elements: \n");
                int size = int.Parse(Console.ReadLine());
                int[] arr = new int[size];
                Console.WriteLine("Enter the elements: \n");
                for (int i = 0; i < size; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                var query = from num in arr
                            group num by num into temp
                            select temp;
                Console.WriteLine("The number and the frequency are: \n");
                foreach (var temp in query)
                {
                    if (temp.Count() > 1)
                    {
                        Console.WriteLine("Number {0} appears {1} times.", temp.Key, temp.Count());
                    }
                    else
                    {
                        Console.WriteLine("Number {0} appears only {1} time.", temp.Key, temp.Count());
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
