using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaintApp
{
    internal abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Shape() 
        {
            
        }

       public abstract  double getArea();
       public abstract void Draw(Graphics g);

    }
}
