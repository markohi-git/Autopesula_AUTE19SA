using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Autopesula_AUTE19SA
{
    
    public class Henkiloauto:Auto,IPesu
    {
        public Henkiloauto(int pyorienmaara) : base(pyorienmaara) { }
        public void Pesu()
        {
            Console.WriteLine(this.GetType() + " Pesu käynnissä");
        }
    }
}