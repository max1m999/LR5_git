using lr5.Creatures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr5
{
    public class Plant : Creature
    {
        public Plant(int X, int Y) 
            : base(X,Y) 
        {
            
        }
        public override Pen GetCreaturePen()
        {
            return new Pen(Color.Green);
        }
        public override void Move()
        {
            return;
        }
        public override void Eat(List<Creature> creatures)
        {
            return;
        }

    }
}
