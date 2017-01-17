using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Vechile
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public bool Tyres { get; set; }
    }
        public class Televisio
    {
        public bool OnkoPäällä { get; set; }
        public bool Hdmi { get; set; }
        public bool Antenni { get; set; }
        public int ÄänenVoimakkuus { get; set; }
        public bool Mykistys { get; set; }
    }
    public class Pesukone
    {
        public bool OnkoPäällä { get; set; }
        public bool VedenSaanti { get; set; }
        public float PyörimisNopeus { get; set; }
        public float KäyntiAika { get; set; }
        public float Lämpötila { get; set; }
    }
    public class Kiuas
    {
        public bool OnkoPäällä { get; set; } //"prop"+tab+tab
        public float Lämpötila { get; set; }
        //kosteus voi olla välilllä 0-100
        float kosteus;
        public float Kosteus
        {
            get
            {
                return kosteus;
            }
            set
            {
                kosteus = value;
                if (kosteus < 0 || kosteus > 100)
                {
                    kosteus = 0;
                }
            }

        }
    }
}
