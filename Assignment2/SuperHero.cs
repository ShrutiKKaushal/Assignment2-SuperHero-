using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class SuperHero : Hero
    {

        //************* Private Properties ******************
        private string[] superPowers = new string[3];

        // ************* CONSTRUCTOR METHOD ********************
        public SuperHero(string name) : base(name)
        {
            generateRandomPowers();
        }

        // ************** Array with listing of Powers ******************
        private string[] powerList ={"Super Speed","Super Strength","Body Armour",
        "Flight","Fire Generation","Weather Control"};
        //create random numbers
        Random rnd = new Random();
        private int randomElement;


        
        //private Method++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void generateRandomPowers()
        {
            // **********temporary Array for storing values ***************
            string[] temPowers = new string[powerList.Length];
            // Copy each element of the listOf6Powers to temPowers
            for (int i = 0; i < powerList.Length; i++)
            {
                temPowers[i] = powerList[i];
            }
            //pick up three random powers
            int index = 0;
            while (index < superPowers.Length)
            {
                //generate random number
                this.randomElement = generateRandomElement(rnd, powerList.Length);
                //assign the results to superPowers array
                if (temPowers[randomElement] != "Unavailable")
                {
                    this.superPowers[index] = temPowers[this.randomElement];
                    temPowers[this.randomElement] = "Unavailable";
                    index++;
                }
            }
            /*
            //pick up three random powers
            for (int i = 0; i < superPowers.Length; i++)
            {
            //generate random number
            this.randomElement = generateRandomElement(rnd, listOf6Powers.Length);
            //assign the results to superPowers array
            if (temPowers[randomElement]!="Unavailable")
            {
            this.superPowers[i] = temPowers[this.randomElement];
            temPowers[this.randomElement] = "Unavailable";
            }
            }*/
        }
     
        public static int generateRandomElement(Random rnd, int max)
        {
            int randomNumber = rnd.Next(max);
            //Console.WriteLine("My random number is {0}", randomNumber); For testing purpose
            return randomNumber;
        }

    }
}
