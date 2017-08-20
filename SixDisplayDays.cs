using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixDisplayDays
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
                Console.WriteLine("Displaying the name of the days of the week..........\n");
                var query = from name in days
                           select name;
                foreach (var temp in days)
                {
                    Console.WriteLine(temp+"\n");
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
