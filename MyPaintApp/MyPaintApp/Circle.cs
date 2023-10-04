using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaintApp
{
    internal class Circle : Shape
    {
		private float radius;

		public float Radius
		{
			get { return radius; }
			set {
			    if(value >= 0) radius = value;
			}
		}

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Blue);
            g.DrawEllipse(pen, X, Y, radius, radius);


        }

        public override double getArea()
        {
            return Math.PI* radius * radius;
        }

    }
}
