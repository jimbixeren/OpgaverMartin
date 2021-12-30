using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMedObjekter
{
    internal class Superhelte
    {

        public string? Name { get; set; }
        public string? Øjenfave { get; set; }
        public int Age { get; set; }
        public bool Kanflyve { get; set; }


        List<Superhelte> SuperhelteList = new List<Superhelte>();

        public void Addsuperhelte()
        {
            

            SuperhelteList.Add(new Superhelte
            {
                Name ="Batman",
                Øjenfave = "Sort",
                Age = 20,
                Kanflyve = false
                

            });

            SuperhelteList.Add(new Superhelte
            {
                Name = "Superman",
                Øjenfave = "Rød",
                Age = 30,
                Kanflyve = true


            });
            SuperhelteList.Add(new Superhelte
            {
                Name = "Robin",
                Øjenfave = "Blå",
                Age = 40,
                Kanflyve = false


            });

            foreach(var Superhelte in SuperhelteList)
            {
                Console.WriteLine("Name:" + " " + Superhelte.Name);
                Console.WriteLine("Øjenfarve:" + " " + Superhelte.Øjenfave);
                Console.WriteLine("Age:" + " " + Superhelte.Age);
                Console.WriteLine("Kan Flyve:" + " " + Superhelte.Kanflyve);
                Console.WriteLine("********************");


            }


        }


    }
}
