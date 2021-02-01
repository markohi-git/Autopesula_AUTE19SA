using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Autopesula_AUTE19SA
{
    public class Autopesula
    {
        public void PeseAuto(Auto auto)
        {
            Console.WriteLine("\n Pesuun menevä auto on " + auto.GetType());
            if (auto is IPesu)
            {
                Console.WriteLine("Auto pesussa " + auto.GetType().Name);
            }
            else
            {
                Console.WriteLine("Ei voi pestä, koska auto ei toteuta IPesu luokkaa" + auto.GetType().FullName);
            }
        }
    }
}