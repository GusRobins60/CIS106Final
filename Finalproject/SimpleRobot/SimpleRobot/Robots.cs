using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRobot
{
    public class Robots
    {
        public Robots() 
        {
        }

        public Robots(int positionx, int positiony, string direction) => (this.Positionx, this.Positiony, this.Direction) = (positionx, positiony, direction);

        public int Positionx { get; set; }
        public int Positiony { get; set; }

        public string Direction { get; set; }
        

    }
}
