using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Human
    {
        public int age;
        public int height;
        public virtual void favorite() //public void favorite()
        {
            Console.WriteLine("FOOD");
        }
    }

    class Man : Human
    {
        public int added1;
        public override void favorite() //public new void favorite()
        {
            Console.WriteLine("Drone");
        }
    }

    class Woman : Human
    {
        public int added2;
        public override void favorite() //public new void favorite()
        {
            Console.WriteLine("Robot Arm");
        }
    }
}
