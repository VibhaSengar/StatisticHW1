using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gra= this.panel1.CreateGraphics();
            Pen blackPen = new Pen(Color.Blue, 6);

            PointF pnt1 = new PointF(100.0F, 100.0F);
            PointF pnt2 = new PointF(500.0F, 200.0F);
            e.Graphics.DrawLine(blackPen, pnt1, pnt2);

        }
    }
}
