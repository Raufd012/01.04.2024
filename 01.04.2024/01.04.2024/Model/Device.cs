using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._04._2024.Model
{
    internal class Device
    {
        public decimal Height;
        public string Weight;
        public bool first = true;


        public void OpenDevice()
        {
            if (first)
            {
                Console.WriteLine("Device Opening");

            }
            else { Console.WriteLine("Device Alredy Opening"); }



        }
    }
}
