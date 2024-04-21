using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal abstract class Animal
    {
        private byte _avgLifeTime;
        private string _breed;
        private int _hp = 100;
        public enum Gender
        {
            Male,
            Female
        }
        public Gender AnimalGender { get; set; }
        public byte AvgLifeTime
        {
            get => _avgLifeTime;
            set
            {
                if (value > 0 || value < 500)
                {
                    _avgLifeTime = value;
                }
            }
        }

        public string Breed
        {
            get => _breed;
            set
            {
                if (value.Length > 1 && value.Length < 128)
                {
                    _breed = value;
                }
            }

        }
        public int Hp
        {
            get => _hp;
            set
            {
                if (value > -1 || value < 100)
                {
                    _hp = value;
                }
            }
        }

        public Animal(byte avgLifeTime, string breed, int hp, Gender animalGender)
        {
            Hp = hp;
            AvgLifeTime = avgLifeTime;
            Breed = breed;
            AnimalGender = animalGender;
        }
        public abstract void Hunt<T>(T prey) where T : Animal;

    }
    internal class ZooCage<T, U> where T : Animal where U : Food
    {
        private T _animal;
        private U _food;

        public ZooCage(T animal, U food)
        {
            _animal = animal;
            _food = food;
        }

    }
}
