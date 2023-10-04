using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaintApp
{
    public partial class Form1 : Form
    {

        List<Shape> shapes = new List<Shape>();
        Shape curShape = null;

        public enum TOOL
        {
            SELECT,
            LINE,
            RECT,
            CIRCLE
        }

     

        public TOOL curTool = TOOL.SELECT;
        public int XPos = 0;
        public int YPos = 0;

        bool isDrawing = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if(curShape != null && isDrawing == true)
                curShape.Draw(e.Graphics);

            foreach(Shape s in shapes)
                s.Draw(e.Graphics);         
           
        }



        private void Form1_Click(object sender, EventArgs e)
        {
          
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            curTool = TOOL.RECT;

        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            curTool = TOOL.CIRCLE;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            XPos = e.X;
            YPos = e.Y;

            if (curTool == TOOL.RECT)
            {

                curShape = new Rectangle(XPos, YPos, e.X - XPos, e.Y - YPos);

            }
            else if (curTool == TOOL.CIRCLE)
            {
                curShape = new Circle();
                curShape.X = XPos;
                curShape.Y = YPos;

            }

            isDrawing = true;

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (curShape != null)
            {
                shapes.Add(curShape);
                curShape = null;
                Invalidate();
            }
            isDrawing= false;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (curShape != null && isDrawing == true)
            {
                if (curTool == TOOL.RECT)
                {

                    ((Rectangle)curShape).Width = e.X - XPos;
                    ((Rectangle)curShape).Height = e.Y - YPos;
                    toolStripStatusLabel1.Text = "Pos: " + e.X + "," + e.Y;

                }
                else if (curTool == TOOL.CIRCLE)
                {
                    ((Circle)curShape).Radius = e.X - XPos;

                }
            Invalidate();
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

		private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}
	}
}
