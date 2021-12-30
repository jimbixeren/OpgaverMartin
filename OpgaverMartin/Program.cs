// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System;
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
        


        class Player
        {
            public string username;

            public Player(string username)
            {
                this.username = username;
            }
            public override string ToString()
            {
                return username;
            }
            
        }




        // her bliver metoden kaldt
        static void Main(string[] args)
        {

            List<Player> Players = new List<Player>();


            Players.Add(new Player("Batman"));
            Players.Add(new Player("Superman"));
            Players.Add(new Player("Robin"));



            //Player player1 = new Player("Chat");
            //Player player2 = new Player("Kurt");
            //Player player3 = new Player("Fin");

            //Players.Add(player1);
            //Players.Add(player2);
            //Players.Add(player3);

            foreach (Player player in Players)
            {

                Console.WriteLine(player);
            }




            velkommen();

            Hej hej = new Hej();


            Sinput();


            // når metoden ikke er statisk
            Lommeregner lommeregner = new Lommeregner(1, 5, 7, "");


            


           
            // nå metoden  er statisk
            Calculater_static.SayHi("mike");




       
           






            //List<DiverseList> LstdiverseLists = new List<DiverseList>();
            //LstdiverseLists.Add(new DiverseList());
            //LstdiverseLists[0].Batman();
            //LstdiverseLists[0].GPA = 2.1;
            //LstdiverseLists.Add(new DiverseList());
            //LstdiverseLists[1].Name = " Bent";
            //LstdiverseLists.Add(new DiverseList());
            //LstdiverseLists[1].GPA = 20;

            //foreach (DiverseList oDiverseList in LstdiverseLists)
            //{
            //    Console.WriteLine(oDiverseList.getData());

            //}

            //List<string> food = new List<string>();
            //food.Add("fries");
            //food.Add("pizza");
            //food.Add("hamburger");
            //food.Add("hotdog");
            //food.Add("fries");

            //food.Insert(0, "Sushi");

            //food.Remove("pizza");

            //Console.WriteLine(food[0]);

            //Console.WriteLine(food.Count);
            //Console.WriteLine(food.IndexOf("fries"));
            //Console.WriteLine(food.LastIndexOf("fries"));
            //Console.WriteLine(food.Contains("pizza"));
            //food.Sort();
            //food.Reverse(); 
            //food.Clear();

            //foreach (string item in food)
            //{

            //    Console.WriteLine(item);
            //}
                



            Console.ReadLine();



        }


       

        

       
       

       
        


       
    }



}