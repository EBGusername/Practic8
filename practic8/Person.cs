using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic8
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age}\nHeight: {Height}\nWeight: {Weight}";

        }
    }
}
