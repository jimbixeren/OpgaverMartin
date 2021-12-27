using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaverMartin
{
    internal class Lommeregner
    {
        public double firstnumber;
        public double secondnumber;
        public double resutat;
        public string? ops;// +-*/%

       

        public Lommeregner(double aFirstnumber, double aSecondnumber, double aResutat, string aOps)
        {
            firstnumber = aFirstnumber;
            secondnumber = aSecondnumber;   
            resutat = aResutat;
            ops = aOps;

            Console.WriteLine("\t\t\tOpgave 3: Calculator \r");
            Console.WriteLine("\t\t\t---------------------\r");


            Console.WriteLine("\t\t\tEnter first number\n");
            firstnumber = Convert.ToDouble(Console.ReadLine());
                

            Console.WriteLine("\t\t\tSelect and Operator: (+, -, *, /, %, )\n");
            ops = Console.ReadLine();


            Console.WriteLine("\t\t\tEnter Secondnumber number\n");
            secondnumber = Convert.ToDouble(Console.ReadLine());

            if (ops == "+")
            {
                resutat = firstnumber + secondnumber;
                Console.Write("=" + resutat);

            }
            else if (ops == "-")
            {
                secondnumber = firstnumber - secondnumber;
                Console.Write(resutat);

            }
            else if (ops == "*")
            {
                resutat = firstnumber * secondnumber;
                Console.Write("=" + resutat);
            }
            else if (ops == "/")
            {
                resutat = firstnumber / secondnumber;
                Console.Write("=" + resutat);
            }
            else if (ops == "%")
            {
                resutat = firstnumber % secondnumber;
                Console.Write("=" + resutat);
            }

            Console.Write("\n\n\t\t\t" + "\nPress any key to exit");



            //Console.WriteLine("Input first number");
            //aInput1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Input seckund number");
            //aInput2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(aInput1 + aInput2);

        }


    }
}
