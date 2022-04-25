using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace totest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write(("please entre your hegt =   "));
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write(("please entre your Sex :   "));
            char b = Convert.ToChar(Console.ReadLine());

            Wight toe = new Wight
            {
                heght = a,
                sex = b
            };
            double resalt = toe.getSutibleWegith();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"your weght = {toe.getSutibleWegith()}");

           
            Console.ReadKey();



        }

    }
}
