using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Student
    {
        private string _name;
        private bool IsPlagiated;
        private bool IsHelpedToPlagiate;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length>2 || value.Length <25)
                {
                    _name = value;
                }
            }
        }

        public Student(string name, bool isPlagiated, bool isHelpedToPlagiate)
        {
            Name = name;
            IsPlagiated = isPlagiated;
            IsHelpedToPlagiate = isHelpedToPlagiate;
        }

        public abstract void Hunt<T>(T prey) where T : Student;
    }
}
