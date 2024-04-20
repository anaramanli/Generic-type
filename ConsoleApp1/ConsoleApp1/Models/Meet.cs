using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Meet : Food
    {
        public enum Type
        {
            Baliq,
            Toyuq,
            Inek
        }
        public Type FoodType { get; set; }
        public Meet(int calorie, Type foodType ) : base(calorie)
        {
            FoodType = foodType;
        }
    }
}
