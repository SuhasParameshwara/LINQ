using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenAcceptAndDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                int list, num, temp;
                List<int> templist = new List<int>();
                Console.Write("Input the number of members on the List : ");
                num = int.Parse(Console.ReadLine());

                for (int i = 0; i < num; i++)
                {
                    Console.Write("\nMember {0} : ", i);
                    list = Convert.ToInt32(Console.ReadLine());
                    templist.Add(list);
                }

                Console.Write("\nInput the value above you want to display the members of the List : ");
                temp = Convert.ToInt32(Console.ReadLine());

                List<int> FilterList = templist.FindAll(x => x > temp ? true : false);
                if (FilterList.Count() == 0)
                {
                    Console.WriteLine("\nSorry! Numbers Not found!");
                }
                else
                {
                    Console.WriteLine("\nThe numbers greater than {0} are : \n", temp);
                    foreach (var tempNum in FilterList)
                    {
                        Console.WriteLine(tempNum);
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
