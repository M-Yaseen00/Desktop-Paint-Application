namespace MyPaintApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.btnRectangle = new System.Windows.Forms.Button();
			this.btnCircle = new System.Windows.Forms.Button();
			this.mnuMain = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
			this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.coloursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel14 = new System.Windows.Forms.Panel();
			this.panel15 = new System.Windows.Forms.Panel();
			this.panel10 = new System.Windows.Forms.Panel();
			this.panel11 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel9 = new System.Windows.Forms.Panel();
			this.panel12 = new System.Windows.Forms.Panel();
			this.panel13 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuStrip2 = new System.Windows.Forms.MenuStrip();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.mnuMain.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnRectangle
			// 
			this.btnRectangle.Location = new System.Drawing.Point(33, 495);
			this.btnRectangle.Margin = new System.Windows.Forms.Padding(4);
			this.btnRectangle.Name = "btnRectangle";
			this.btnRectangle.Size = new System.Drawing.Size(100, 28);
			this.btnRectangle.TabIndex = 2;
			this.btnRectangle.Text = "Rectangle";
			this.btnRectangle.UseVisualStyleBackColor = true;
			this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
			// 
			// btnCircle
			// 
			this.btnCircle.Location = new System.Drawing.Point(161, 495);
			this.btnCircle.Margin = new System.Windows.Forms.Padding(4);
			this.btnCircle.Name = "btnCircle";
			this.btnCircle.Size = new System.Drawing.Size(100, 28);
			this.btnCircle.TabIndex = 3;
			this.btnCircle.Text = "Circle";
			this.btnCircle.UseVisualStyleBackColor = true;
			this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
			// 
			// mnuMain
			// 
			this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.coloursToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.mnuMain.Location = new System.Drawing.Point(0, 48);
			this.mnuMain.Name = "mnuMain";
			this.mnuMain.Size = new System.Drawing.Size(939, 28);
			this.mnuMain.TabIndex = 4;
			this.mnuMain.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
			this.newToolStripMenuItem.Text = "New";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
			this.saveToolStripMenuItem.Text = "Save";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectangleToolStripMenuItem,
            this.circleToolStripMenuItem,
            this.toolStripTextBox1,
            this.lineToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
			this.toolsToolStripMenuItem.Text = "Tools";
			this.toolsToolStripMenuItem.Click += new System.EventHandler(this.toolsToolStripMenuItem_Click);
			// 
			// rectangleToolStripMenuItem
			// 
			this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
			this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
			this.rectangleToolStripMenuItem.Text = "Rectangle";
			this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.btnRectangle_Click);
			// 
			// circleToolStripMenuItem
			// 
			this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
			this.circleToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
			this.circleToolStripMenuItem.Text = "Circle";
			this.circleToolStripMenuItem.Click += new System.EventHandler(this.btnCircle_Click);
			// 
			// toolStripTextBox1
			// 
			this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.toolStripTextBox1.Name = "toolStripTextBox1";
			this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
			// 
			// lineToolStripMenuItem
			// 
			this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
			this.lineToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
			this.lineToolStripMenuItem.Text = "Line";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// imageToolStripMenuItem
			// 
			this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
			this.imageToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
			this.imageToolStripMenuItem.Text = "Image";
			// 
			// coloursToolStripMenuItem
			// 
			this.coloursToolStripMenuItem.Name = "coloursToolStripMenuItem";
			this.coloursToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
			this.coloursToolStripMenuItem.Text = "Colours";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
			this.statusStrip1.Location = new System.Drawing.Point(0, 584);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
			this.statusStrip1.Size = new System.Drawing.Size(939, 26);
			this.statusStrip1.TabIndex = 5;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
			this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel14);
			this.panel1.Controls.Add(this.panel15);
			this.panel1.Controls.Add(this.panel10);
			this.panel1.Controls.Add(this.panel11);
			this.panel1.Controls.Add(this.panel8);
			this.panel1.Controls.Add(this.panel9);
			this.panel1.Controls.Add(this.panel12);
			this.panel1.Controls.Add(this.panel13);
			this.panel1.Controls.Add(this.panel6);
			this.panel1.Controls.Add(this.panel7);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(740, 76);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(199, 508);
			this.panel1.TabIndex = 6;
			// 
			// panel14
			// 
			this.panel14.BackColor = System.Drawing.Color.Magenta;
			this.panel14.Location = new System.Drawing.Point(104, 473);
			this.panel14.Margin = new System.Windows.Forms.Padding(4);
			this.panel14.Name = "panel14";
			this.panel14.Size = new System.Drawing.Size(93, 78);
			this.panel14.TabIndex = 4;
			// 
			// panel15
			// 
			this.panel15.BackColor = System.Drawing.Color.Silver;
			this.panel15.Location = new System.Drawing.Point(0, 473);
			this.panel15.Margin = new System.Windows.Forms.Padding(4);
			this.panel15.Name = "panel15";
			this.panel15.Size = new System.Drawing.Size(96, 78);
			this.panel15.TabIndex = 3;
			// 
			// panel10
			// 
			this.panel10.BackColor = System.Drawing.Color.Aqua;
			this.panel10.Location = new System.Drawing.Point(104, 383);
			this.panel10.Margin = new System.Windows.Forms.Padding(4);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(93, 82);
			this.panel10.TabIndex = 4;
			// 
			// panel11
			// 
			this.panel11.BackColor = System.Drawing.Color.Orange;
			this.panel11.Location = new System.Drawing.Point(0, 383);
			this.panel11.Margin = new System.Windows.Forms.Padding(4);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(96, 82);
			this.panel11.TabIndex = 3;
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.Gray;
			this.panel8.Location = new System.Drawing.Point(104, 290);
			this.panel8.Margin = new System.Windows.Forms.Padding(4);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(93, 85);
			this.panel8.TabIndex = 4;
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.Color.Purple;
			this.panel9.Location = new System.Drawing.Point(0, 290);
			this.panel9.Margin = new System.Windows.Forms.Padding(4);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(96, 85);
			this.panel9.TabIndex = 3;
			// 
			// panel12
			// 
			this.panel12.BackColor = System.Drawing.Color.Pink;
			this.panel12.Location = new System.Drawing.Point(104, 218);
			this.panel12.Margin = new System.Windows.Forms.Padding(4);
			this.panel12.Name = "panel12";
			this.panel12.Size = new System.Drawing.Size(93, 65);
			this.panel12.TabIndex = 4;
			// 
			// panel13
			// 
			this.panel13.BackColor = System.Drawing.Color.SkyBlue;
			this.panel13.Location = new System.Drawing.Point(0, 218);
			this.panel13.Margin = new System.Windows.Forms.Padding(4);
			this.panel13.Name = "panel13";
			this.panel13.Size = new System.Drawing.Size(96, 65);
			this.panel13.TabIndex = 3;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.Yellow;
			this.panel6.Location = new System.Drawing.Point(104, 145);
			this.panel6.Margin = new System.Windows.Forms.Padding(4);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(93, 65);
			this.panel6.TabIndex = 4;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.Green;
			this.panel7.Location = new System.Drawing.Point(0, 145);
			this.panel7.Margin = new System.Windows.Forms.Padding(4);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(96, 65);
			this.panel7.TabIndex = 3;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Blue;
			this.panel4.Location = new System.Drawing.Point(104, 73);
			this.panel4.Margin = new System.Windows.Forms.Padding(4);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(93, 65);
			this.panel4.TabIndex = 4;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Red;
			this.panel5.Location = new System.Drawing.Point(0, 73);
			this.panel5.Margin = new System.Windows.Forms.Padding(4);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(96, 65);
			this.panel5.TabIndex = 3;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Black;
			this.panel3.Location = new System.Drawing.Point(104, 0);
			this.panel3.Margin = new System.Windows.Forms.Padding(4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(93, 65);
			this.panel3.TabIndex = 2;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(96, 65);
			this.panel2.TabIndex = 1;
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Location = new System.Drawing.Point(0, 24);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(939, 24);
			this.menuStrip1.TabIndex = 7;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// menuStrip2
			// 
			this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip2.Location = new System.Drawing.Point(0, 0);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Size = new System.Drawing.Size(939, 24);
			this.menuStrip2.TabIndex = 9;
			this.menuStrip2.Text = "menuStrip2";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(286, 495);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 28);
			this.button1.TabIndex = 10;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(409, 495);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(96, 28);
			this.button2.TabIndex = 11;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(151, 20);
			this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(939, 610);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.btnCircle);
			this.Controls.Add(this.btnRectangle);
			this.Controls.Add(this.mnuMain);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.menuStrip2);
			this.MainMenuStrip = this.mnuMain;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Click += new System.EventHandler(this.Form1_Click);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
			this.mnuMain.ResumeLayout(false);
			this.mnuMain.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem coloursToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
	}
}

