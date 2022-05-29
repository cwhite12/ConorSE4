using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConorSE4.Shapes
{
    abstract class Shape
    {

        protected Color colour; 
        protected int x, y; 
        public Shape(Color colour, int x, int y)
        {

            this.colour = colour; //shape's colour
            this.x = x; //its x pos
            this.y = y; //its y pos
            
        }

        public abstract void draw(Graphics g); //any derrived class must implement this method

        public override string ToString()
        {
            return base.ToString() + "    " + this.x + "," + this.y + " : ";
        }

    }
}

