using System.Numerics;
using System.Reflection;

namespace PrograrmWeight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string gender = "";
            int height = 0;
            int weight = 0;
            Console.WriteLine("Hello, World!");
            Console.WriteLine();

            do
               {
                   Console.Write("input your name : ");
                   name = Console.ReadLine();
                   if (string.IsNullOrWhiteSpace(name))
                   {
                       Console.WriteLine("Error");
                   }
                   else if (name.Length < 3)
                   {
                    Console.WriteLine("Error");
                }

            } while (string.IsNullOrWhiteSpace(name) || name.Length < 3);

            do
            {
                Console.Write("Please fill you height(cm) : ");
                height = Convert.ToInt16(Console.ReadLine());
                if (height <= 30 || height >= 220)
                {
                    Console.WriteLine("Error height(cm)");
                }

            } while (height <= 30 || height >= 220);

            do
            {
                Console.Write("\nPlease input your gender M or F: ");
                gender = Console.ReadLine();
                if (gender != "M" || gender != "F")
                {
                    Console.WriteLine("Please input M or F: ");
                }

            } while (gender != "M" && gender != "F" && gender != "m" && gender != "f");

            if (gender == "M")
            {
                weight = height - 100;
            }
            else if (gender == "F")
            {
                weight = height - 110;
            }
            Console.WriteLine("\nYour name is " + name);
            Console.WriteLine("You ideal weight is " + weight.ToString());

            Console.WriteLine();
            Console.WriteLine("Press any key to end program");
            Console.ReadKey();
        }
    }
}
