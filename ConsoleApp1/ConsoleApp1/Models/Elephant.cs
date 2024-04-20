using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Elephant : Animal
    {
        private double _weight;
        public bool IsTrained;

        public double Weight
        {
            get => _weight;
            set
            {
                if (value > 0 && value <3000)
                {
                    _weight = value;
                }
            }

        }
        public Elephant(byte avgLifeTime, string breed, int hp, double weight, bool isTrained, Gender animalGender) : base(avgLifeTime, breed, hp, animalGender)
        {
            Weight = weight;
            IsTrained = isTrained;
        }

        public override void Hunt<T>(T prey)
        {
        }
    }
}
