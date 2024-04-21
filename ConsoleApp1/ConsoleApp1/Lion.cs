using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Lion : Animal
    {
        public Lion(byte avgLifeTime, string breed, int hp, Gender animalGender) : base(avgLifeTime, breed, hp, animalGender)
        {
        }

        
        public override void Hunt<T>(T prey)
        {
            /*Console.WriteLine($"Telebe parcalandi !");*/

        }
        /*public void Attack(Student prey)
        {
            if ((IsPlagiated || IsHelpedToPlagiate))
            {
                Console.WriteLine("Telebe parcalandi");
            }
            else
            {
                Console.WriteLine("Telebe agillidi");
            }
        }*/
    }
}

