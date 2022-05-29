using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace ConorSE4.Shapes
{
    class Square : Rectangle
    {
        private int size;
        public Square(Color colour, int x, int y, int size) : base(colour, x, y, size, size)
        {
            this.size = size;
        }

        //no draw method here because it is provided by the parent class Rectangle
        public override void draw(Graphics g)
        {
            base.draw(g);
        }

    }
}
