using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Square : Shape
    {
        public double Height { get; set; }

        public override double Area()
        {
            return Height * Height;
        }
    }
}
