using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Data.SqlTypes;
using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /* Find vowels number in given string*/
            List <string> list = new List<string>();

            for(int i=0;i<5;i++)
            {
                list.Add(Console.ReadLine());
            }
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
        }

    }
}
