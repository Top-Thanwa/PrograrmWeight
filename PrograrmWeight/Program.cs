using System.Numerics;

namespace PrograrmWeight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string gender = "";
            int height = 0;
            int weight = 0;
            Console.WriteLine("Hello, World!");
            Console.WriteLine();
            Console.Write("Please input your gender M or F: ");
            gender = Console.ReadLine();

            Console.Write("Please fill you height(cm) : ");
            height = Convert.ToInt16(Console.ReadLine());
            if (gender == "M")
            {
                weight = height - 100;
            }
            else if (gender == "F")
            {
                weight = height - 110;
            }
            else Console.Write("Please input M or F: ");

            Console.WriteLine("You ideal weight is " + weight.ToString());

            Console.WriteLine();
            Console.WriteLine("Press any key to end program");
            Console.ReadKey();
        }
    }
}
