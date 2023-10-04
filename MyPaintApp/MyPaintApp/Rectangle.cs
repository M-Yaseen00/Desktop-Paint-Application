using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaintApp
{
    internal class Rectangle : Shape
    {
		private float width;

		public float Width
		{
			get { return width; }
			set { width = value; }
		}

		private float height;

		public float Height
		{
			get { return height; }
			set { height = value; }
		}

        public Rectangle()
        {
            height = 0;
            width = 0;
        }
        public Rectangle(int x, int y, float w, float h)
        {
            X = x;
            Y = y;
            height = h;
            width = w;
        }

        public override double getArea()
        {
            return width * height;
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            g.DrawRectangle(pen, X, Y, Width, Height);
        }
    }
}
