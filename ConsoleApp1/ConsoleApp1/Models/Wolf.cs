using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Wolf : Animal
    {
        public bool IsPrideLeader;
        private int _attackDamage;
        public int AttackDamage
        {
            get => _attackDamage;
            set
            {
                if (value < 101 && value > -1)
                {
                    _attackDamage = value;
                }
                else
                {
                    Console.WriteLine("Damage cant bigger than 100 ");
                }
            }
        }

        public override void Hunt<T>(T prey)
        {
            ((Animal)prey).Hp -= AttackDamage;
            if (((Animal)prey).Hp <= 0)
            {
                Console.WriteLine($"The {prey.GetType().Name} has been defeated.");
                ((Animal)prey).Hp = 0;
            }
        }
        /*public int Attack(Animal prey)
        {
            if (prey.Hp > 0)
            {
                prey.Hp -= AttackDamage;

            }

            return prey.Hp;
        }*/
        public Wolf(byte avgLifeTime, string breed, int hp, bool isPride, int attackDamage, Gender animalGender) : base(avgLifeTime, breed, hp,animalGender)
        {
            IsPrideLeader = isPride;
            AttackDamage = attackDamage;
        }

        
    }
}
