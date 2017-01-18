using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOdemot
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaRadio();
            
        }
        //Tehtävän 5 radio-Luokan testaus
        static void TestaaRadio()
        {
            //Luodaan radio-olio
            Radio radio = new JAMK.IT.Radio();

            //Pistetään radio päälle        
            Console.WriteLine("Pistä radio päälle (k/e) : ");
            string kytkin = Console.ReadLine();

            switch (kytkin)
            {
                case "e":
            //Pistetään radio päälle        
            Console.WriteLine("No mee kattoon sitten televiissoria! ");           
                    break;
                case "k":
            //näytetään konsollilla ja otetaan tietoa talteen kanavaa varten
            Console.WriteLine("Anna kanava:");
            radio.Kanava = float.Parse(Console.ReadLine());

            //näytetään konsollilla ja otetaan tietoa talteen volymia varten
            Console.WriteLine("Anna volyymi:");
            radio.Vola = int.Parse(Console.ReadLine());

            //tulostetaan radion arvot
            Console.WriteLine("radion kanava on: {0} ", radio.Kanava);
            Console.WriteLine("radion äänen voimakkuus on: {0} ", radio.Vola);
                    break;
            }
        }
    }
}     

