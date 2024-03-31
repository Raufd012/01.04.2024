using _01._04._2024.Model;

namespace _01._04._2024
{
    internal class Program
    {
        static void Main()
        {
            {

                Mobile mobile = new Mobile(2);
                mobile.OpenDevice();

                mobile.AddNumber("9956667788");

                string[] numbers = mobile.GetNumbers();

                mobile.CloseDevice();


            }
        }
    }
}   
