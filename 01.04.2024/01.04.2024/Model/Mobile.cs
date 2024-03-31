using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._04._2024.Model
{
    internal class Mobile : Device
    {
        public string[] SimCard = new string[0];


        public Mobile(int simcount)
        {
            if (simcount == 1 || simcount == 2)
            {
                SimCard = new string[simcount];
            }
            else { Console.WriteLine("No more than 2 numbers can be entered!"); }
        }

        public void AddNumber()
        {

            if (SimCard.Length == 1)
            {
                Console.WriteLine("Enter the number!");
                string nomre1 = Console.ReadLine();
            }

        }
    }
}