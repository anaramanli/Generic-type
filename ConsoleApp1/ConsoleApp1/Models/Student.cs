using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Student : Animal
    {
        private string _name;
        public bool IsPlagiated;
        public bool IsHelpedToPlagiate;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 2 || value.Length < 25)
                {
                    _name = value;
                }
            }
        }

        public Student(string name, bool isPlagiated, bool isHelpedToPlagiate) : base(default(byte), "Unknown", 0, Animal.Gender.Male)
        {
            Name = name;
            IsPlagiated = isPlagiated;
            IsHelpedToPlagiate = isHelpedToPlagiate;
        }

        public override void Hunt<T>(T prey)
        {
            if ((IsPlagiated || IsHelpedToPlagiate))
            {
                Console.WriteLine("Telebe parcalandi");
            }
            else
            {
                Console.WriteLine("Telebe agillidi");
            }
        }
    }
}
