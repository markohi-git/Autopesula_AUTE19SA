using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopesula_AUTE19SA
{
    class Program
    {
        static void Main(string[] args)
        {
            Avoauto aa = new Avoauto(4);
            Kuormaauto ka = new Kuormaauto(6);
            Henkiloauto ha = new Henkiloauto(4);

            Autopesula ap = new Autopesula();

            ap.PeseAuto(aa);
            ap.PeseAuto(ka); 
            ap.PeseAuto(ha);

            Console.ReadKey();
        }
    }
}
