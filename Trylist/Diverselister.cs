using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trylist;

namespace Trylist
{
    internal class Diverselister
    {

        List<string> diverselist = new List<string>() { "bent", "john", "fuck" };

        public void VisIndholdAfListe()
        {
            foreach (string item in diverselist)
            {

                Console.WriteLine(item);
            }

        }


        

       


       


        public void AddSuperhelte()
        {

            List<String> userList = new List<String>();
            

            bool moreSuperhelte = true;
            while (moreSuperhelte)
            {
                Console.WriteLine("skriv navn på din Superhero ");
                String ?input = Console.ReadLine();
                Console.WriteLine("Tilføj flere spillere? skriv '1' for ja, '2' for nej.");
                userList.Add(input);

                string ?userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    moreSuperhelte = true;
                }
                else break;
                
                    //foreach (var user in userList)
                    //{
                    //    Console.WriteLine(user);


                    //}

            }


            Console.WriteLine(" Liste af tilføjet Superheros");

            foreach (var user in userList)
            {
                Console.WriteLine(user);


            }

           










            //public void AddSuperhelte()
            //{
            //    bool moreSuperhelte = true;
            //    while (moreSuperhelte)
            //    {
            //        Console.WriteLine("skriv navn på din Superhero ");

            //        string ?user = Console.ReadLine();
            //        MineEgneSuperhelte.Add(new user(Console.ReadLine())); )


            //        MineEgneSuperhelte.Add(new Superhero(Console.ReadLine()));
            //        Console.WriteLine("Tilføj flere Superhero? skriv '1' for ja, '2' for nej.");
            //        string userInput = Console.ReadLine();

            //        if (userInput == "1")
            //        {
            //            moreSuperhelte = true;
            //        }
            //        else break;




            //    }
            //}

            //public void Indtastsuperhelte()
            //{

            //    MineEgneSuperhelte.Add(Console.ReadLine());

            //    //MineEgneSuperhelte  = Console.ReadLine();

            //}


            //public void VisSuperhelte()
            //{
            //    foreach (string item in diverselist)
            //    {

            //        Console.WriteLine(item);
            //    }

            //}






        }




        








    }   

            
}



