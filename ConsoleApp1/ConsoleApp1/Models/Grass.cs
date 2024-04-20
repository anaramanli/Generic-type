using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Grass : Food
    {
        public string Name { get; set; }

        public Grass(int calorie) : base(calorie)
        {
        }
    }
}
