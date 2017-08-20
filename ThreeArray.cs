using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the number of elements: \n");
                int size = int.Parse(Console.ReadLine());
                int[] arr = new int[size];
                Console.WriteLine("\nEnter the elements: \n");
                for (int i = 0; i < size; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                var num = from int Number in arr
                           let sqr = Number * Number
                           select new { Number, sqr };
                Console.WriteLine("\n");
                foreach (var a in num)
                {
                    Console.WriteLine(a);
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
