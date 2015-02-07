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
        "Flight","Fire Generation","Weather Control", "Super Senses", "Super Intelligence"};
        //create random numbers
        Random rnd = new Random();
        private int randomElement;


        
        //******************** PRIVATE METHOD **************************
        private void generateRandomPowers()
        {
            // **********temporary Array for storing values ***************
            string[] temPowers = new string[powerList.Length];
            // Copy each element of the PowerList to temPowers
            for (int i = 0; i < powerList.Length; i++)
            {
                temPowers[i] = powerList[i];
            }
            //pick up three random powers
            int index = 0;
            while (index < superPowers.Length)
            {
           
                this.randomElement = generateRandomElement(rnd, powerList.Length);
                //assign the results to superPowers array
                if (temPowers[randomElement] != "Unavailable")
                {
                    this.superPowers[index] = temPowers[this.randomElement];
                    temPowers[this.randomElement] = "Unavailable";
                    index++;
                }
            }
        }

        //********************* PUBLIC METHOD ************************
        public void showPowers()
        {
            //display a list of powers
            Console.WriteLine("\t************** LIST OF POWERS ****************");
            for (int i = 0; i < this.powerList.Length; i++)
            {
                Console.WriteLine("\t {0}'s power : {1} ", this.name, this.powerList[i]);
            }
            Console.WriteLine("\t**********************************************");
            Console.WriteLine();
            //display superPowers
            Console.WriteLine("\t********** 3 random great Powers ***************");
            for (int i = 0; i < superPowers.Length; i++)
            {
                Console.WriteLine(" \t{0}'s super Natural Power #{1} : {2} ", this.name,i+1 ,this.superPowers[i]);
            }
            Console.WriteLine("\t************************************************");
        }


        // *************** Extracted Method **************
        public static int generateRandomElement(Random rnd, int max)
        {
            int randomNumber = rnd.Next(max);
            //Console.WriteLine("My random number is {0}", randomNumber); For testing purpose
            return randomNumber;
        }

    }
}
