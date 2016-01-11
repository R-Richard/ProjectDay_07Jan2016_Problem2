using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDay_07Jan2016_Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We Are Going to Add Five Numbers");
            Console.WriteLine("Enter Your First Number");
            String nbrOneAsString = Console.ReadLine();
            double nbrOneAsDouble = Convert.ToDouble(nbrOneAsString);

            Console.WriteLine("Enter Your Second Number");
            String nbrTwoAsString = Console.ReadLine();
            double nbrTwoAsDouble = Convert.ToDouble(nbrTwoAsString);

            Console.WriteLine("Enter Your Third Number");
            String nbrThreeAsString = Console.ReadLine();
            double nbrThreeAsDouble = Convert.ToDouble(nbrThreeAsString);

            Console.WriteLine("Enter Your Fourth Number");
            String nbrFourAsString = Console.ReadLine();
            double nbrFourAsDouble = Convert.ToDouble(nbrFourAsString);

            Console.WriteLine("Enter Your Fifth Number");
            String nbrFiveAsString = Console.ReadLine();
            double nbrFiveAsDouble = Convert.ToDouble(nbrFiveAsString);

            Console.WriteLine(" ");

            Console.WriteLine(nbrOneAsString + " + " + nbrTwoAsString + " + " + nbrThreeAsString + " + " + nbrFourAsString + " + " + nbrFiveAsString + " = ");

            double sumOfFive = (nbrOneAsDouble + nbrTwoAsDouble + nbrThreeAsDouble + nbrFourAsDouble + nbrFiveAsDouble);
            Console.WriteLine("Sum = " + sumOfFive);

        }
    }
}
