// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace OpgaverMartin
{

    internal class Program
    {

        // Dette er en metode 
        static void velkommen()
        {
            Console.WriteLine("Opgave 1: Hej med dig");
        }


       
        static void Sinput()
        {

            Console.WriteLine("whats your name");
            string? name = Console.ReadLine();
            Console.WriteLine("Opgave 2" + " " + "Hello" + " " + name);

        }
        







        // her bliver metoden kaldt
        static void Main(string[] args)
        {
            velkommen();

            Hej hej = new Hej();


            Sinput();

            Lommeregner lommeregner = new Lommeregner(1,5,7, "");
           
            
           




            Console.ReadLine();



        }


       

        

       
       

       
        


       
    }



}