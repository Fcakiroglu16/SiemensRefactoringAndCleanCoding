using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensRefactoringAndCleanCoding.ObjectOrientedRefactoring
{
    public class BaseVehicleForwardBackwardBehavior
    {
        public void Forward()
        {
            Console.WriteLine("Forward");
        }

        public void Backward()
        {
            Console.WriteLine("Forward");
        }
    }

    public class BaseVehicleRightOrLeftBehavior
    {
        public virtual void Right()
        {
            Console.WriteLine("Right");
        }

        public virtual void Left()
        {
            Console.WriteLine("Left");
        }
    }

    public class BaseVehicle
    {
        public void Forward()
        {
            Console.WriteLine("Forward");
        }

        public void Backward()
        {
            Console.WriteLine("Forward");
        }

        public virtual void Right()
        {
            Console.WriteLine("Right");
        }

        public virtual void Left()
        {
            Console.WriteLine("Left");
        }
    }


    public class Car : BaseVehicle
    {
    }

    public class SuperCar : BaseVehicle
    {
        public override void Left()
        {
            Console.WriteLine("Super Left");
        }
    }

    public class SuperCar2 : BaseVehicle
    {
        public override void Left()
        {
            Console.WriteLine("Super Left");
        }
    }

    public class NormalCar : BaseVehicle
    {
        public override void Right()
        {
            Console.WriteLine("Normal  Right");
        }
    }


    public class XCar : BaseVehicle
    {
        public override void Right()
        {
            Console.WriteLine("X Right");
        }
    }

    public class Train : BaseVehicleForwardBackwardBehavior
    {
    }
}