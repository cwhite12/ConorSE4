using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ConorSE4.Shapes
{
    class Draw
    {
        private Graphics g;
        private Pen p;
        private int x;
        private int numbers;
        private MouseEventArgs e;

        public Draw(Graphics g,Pen p,Point firstPoint,Point drawTo)
        {
            g.DrawLine(p,firstPoint,drawTo);
            p.Dispose();

        }

        public Draw(Graphics g, Pen p, int x, int numbers)
        {
            this.g = g;
            this.p = p;
            this.x = x;
            this.numbers = numbers;
          
        }
    }
}
