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
            bool notNum;

            Console.WriteLine("Hello, World!");
            Console.WriteLine();
            
            do //รับชื่อ
               {
                   Console.Write("input your name : ");
                   name = Console.ReadLine();
                   if (string.IsNullOrWhiteSpace(name))
                   {
                       Console.WriteLine("Try again");
                   }
                   else if (name.Length < 3)
                   {
                    Console.WriteLine("Try again");
                   }

            } while (string.IsNullOrWhiteSpace(name) || name.Length < 3);

            do //รับส่วนสูง
            {
                Console.Write("\nPlease fill you height(cm) : ");
                string input = Console.ReadLine();
                notNum = int.TryParse(input, out height);
                if (height <= 30 || height >= 220)
                {
                    Console.WriteLine("Error height(cm)");
                }
                else if (!notNum)
                {
                    Console.WriteLine("Error height(cm)");
                }

            } while (height <= 30 || height >= 220);

            do //รับเพศ
            {
                Console.Write("\nPlease input your gender M or F: ");
                gender = Console.ReadLine();
                if (gender != "M" && gender != "F" && gender != "m" && gender != "f")
                {
                    Console.WriteLine("Please input M or F: ");
                }

            } while (gender != "M" && gender != "F" && gender != "m" && gender != "f");

            if (gender == "M" || gender == "m")
            {
                weight = height - 100;
            }
            else if (gender == "F" || gender == "f")
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
