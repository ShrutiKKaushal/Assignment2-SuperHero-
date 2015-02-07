/*
 * Student Name   : Shruti Kirti Kaushal
 * Student Number :  300804023
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {


            SuperHero newSuperHero = new SuperHero("Super Man");
            newSuperHero.showPowers();
            Hero h1 = new Hero("King");
            h1.fight();


            /*Hero myHero = new Hero("Tarzan");
            myHero.fight();
            myHero.show();*/
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
