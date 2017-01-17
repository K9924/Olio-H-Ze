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
            TestaaKiuas();
            TestaaPesukone();
            TestaaTelevisio();
            testaaVechile();
        }
        //Tehtävän1 Kiuas-Luokan testaus
        static void TestaaKiuas()
        {
            //Luodaan Kiuas-olio
            Kiuas kiuas = new JAMK.IT.Kiuas();
            //pistetääs kiuas lämpenemään ja lämpötila ja kosteus
            kiuas.OnkoPäällä = true;
            kiuas.Lämpötila = 90;
            kiuas.Kosteus = 50;
            //näytetään konsollilla 
            Console.WriteLine("Kiuas on päällä {0}", kiuas.OnkoPäällä);
            Console.WriteLine("Kiukaan lämpötila {0}", kiuas.Lämpötila);
            Console.WriteLine("Kiukaan kosteus {0}", kiuas.Kosteus);
            //mitä tapahtuu jos kosteus ylittää rajan
            kiuas.Kosteus = 101;
            Console.WriteLine("Kiukaan kosteus {0}", kiuas.Kosteus);
            Console.WriteLine();
        }
        static void TestaaPesukone()
        {
            //luodaan pesukone-olio
            Pesukone pesukone = new JAMK.IT.Pesukone();
            pesukone.OnkoPäällä = true;
            pesukone.VedenSaanti = true;
            pesukone.PyörimisNopeus = 1400;
            pesukone.Lämpötila = 40;
            pesukone.KäyntiAika = 3;
            //näytetään konsolilla
            Console.WriteLine("Pesukone on päällä {0}", pesukone.OnkoPäällä);
            Console.WriteLine("Pesu kone saa vettä {0}", pesukone.VedenSaanti);
            Console.WriteLine("Pesukoneen pyörimisopeus {0}", pesukone.PyörimisNopeus);
            pesukone.PyörimisNopeus = 800;
            Console.WriteLine("pyörimis nopeus tippui {0} kierrokseen. Pesukoneesta löytyi märkä ja hyvin vatkattu kissa.", pesukone.PyörimisNopeus);
            pesukone.PyörimisNopeus = 1400;
            Console.WriteLine("pistetään kone uudelleen käyntiin ilma kissaa. nopeus on taas {0}", pesukone.PyörimisNopeus);
            Console.WriteLine("veden lämpötila on  {0}", pesukone.Lämpötila);
            Console.WriteLine("käyntiaika on {0} tuntia", pesukone.KäyntiAika);
            Console.WriteLine();
        }
        static void TestaaTelevisio()
        {   //luodaan televisio
            Televisio televisio = new JAMK.IT.Televisio();
            televisio.OnkoPäällä = true;
            televisio.Antenni = true;
            televisio.Hdmi = false;
            televisio.ÄänenVoimakkuus = 14;
            televisio.Mykistys = false;
            //faktaa konsolille
            Console.WriteLine("Televisio on päällä {0}", televisio.OnkoPäällä);
            Console.WriteLine("antennikin pelaa {0} ja Teija Sopanen keittää aromipesässä ketsuppikeittoa", televisio.Antenni);
            Console.WriteLine("Ääntäkin on kerrankin sopivasti {0} pykälää", televisio.ÄänenVoimakkuus);
            televisio.Hdmi = true;
            Console.WriteLine("Muija meni nukkumaan, jospa sitä kattois por...jonkun leffan. hdmi postti auki {0}", televisio.Hdmi);
            televisio.Mykistys = true;
            Console.WriteLine("...ja ilma ääniä {0}", televisio.Mykistys);
            Console.WriteLine();

        }
        static void testaaVechile()
        {   
            //Yx Mosse vetää jonoa
            Vechile vechile = new JAMK.IT.Vechile();
            vechile.Name = "Mosse";
            vechile.Speed = 60;
            vechile.Tyres = false;
            //Katotaan sielun sivuikkunasta miltä se näyttää
            Console.WriteLine("Auton nimi on: {0}." , vechile.Name);
            Console.WriteLine("Vauhtia sillä on {0}", vechile.Speed);
            Console.WriteLine("mikä on aika hyvin autolle jonka rengas tilanne on: {0}", vechile.Tyres);
            vechile.Name = "Boeing AH-64 Apache";
            vechile.Speed = 293;
            vechile.Tyres = true;
            Console.WriteLine("WÄPWÄPWÄPWÄPWÄPWÄP täyttyy ilma saatanallisella mekkalla!");
            Console.WriteLine("Mitä helvettiä ohi kiitää {0}.", vechile.Name);
            Console.WriteLine("Se on täydessä {0} km/t vauhdissaan menossa levittämään demokratia ilosanomaa", vechile.Speed);
            Console.WriteLine("rengas tilanne sillä on: {0}, mutta alas tulon merkkejä ei näy", vechile.Tyres);
        }
    }
}