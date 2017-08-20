using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneThreeParts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Processing Data.............");
            int[] arr = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("\nProcessing Query............");
            var query =
                from VarNum in arr
                where (VarNum % 2) == 0
                select VarNum;

            Console.WriteLine("\nExecuting Query..............");
            Console.Write("\nThe numbers which produce the remainder 0 after divided by 2 are : \n\n");
            foreach (int VarNum in query)
            {
                Console.Write("{0} ", VarNum);
            }
            Console.ReadLine();
        }
    }
}
