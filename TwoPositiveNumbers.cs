using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPositiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the size of the array: \n");
                int size = int.Parse(Console.ReadLine());
                int[] arr = new int[size];
                Console.WriteLine("\nEnter the elements: \n");
                for(int i = 0; i < size; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                var query =
                    from VarNum in arr
                    where VarNum > 0
                    where VarNum < 12
                    select VarNum;
                Console.Write("\nThe numbers within the range of 1 to 11 are : \n\n");
                foreach (var VarNum in query)
                {
                    Console.Write("{0}  ", VarNum);
                }
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
