namespace SiemensRefactoringAndCleanCoding.ObjectOrientedRefactoringGood;

public interface IBackWardBehavior
{
    void Backward();
}

public interface IRightOrLeftBehavior
{
    void Right();
    void Left();
}

public class SuperCarRightOrLeftBehavior : IRightOrLeftBehavior
{
    public void Right()
    {
        Console.WriteLine("Super Right");
    }

    public void Left()
    {
        Console.WriteLine("Super Left");
    }
}

public class SuperCarBackwardBehavior : IBackWardBehavior
{
    public void Backward()
    {
        Console.WriteLine("Super Backward Right");
    }
}

public class SuperCar1BackwardBehavior : IBackWardBehavior
{
    public void Backward()
    {
        Console.WriteLine("Super car 1 Backward Right");
    }
}

public abstract class BaseVehicle
{
    protected IBackWardBehavior _backWardBehavior;
    protected IRightOrLeftBehavior _rightOrLeftBehavior;

    protected BaseVehicle(IBackWardBehavior backWardBehavior, IRightOrLeftBehavior rightOrLeftBehavior)
    {
        _backWardBehavior = backWardBehavior;
        _rightOrLeftBehavior = rightOrLeftBehavior;
    }

    public void ChangeBackwardBehavior(IBackWardBehavior backWardBehavior)
    {
        _backWardBehavior = backWardBehavior;
    }

    public void ChangeRightOrLeftBehavior(IRightOrLeftBehavior rightOrLeftBehavior)
    {
        _rightOrLeftBehavior = rightOrLeftBehavior;
    }


    public void Forward()
    {
        Console.WriteLine("Vehicle Forward");
    }

    public virtual void Backward()
    {
        _backWardBehavior.Backward();
    }

    public virtual void Right()
    {
        _rightOrLeftBehavior.Right();
    }

    public virtual void Left()
    {
        _rightOrLeftBehavior.Left();
    }
}

public class Car(IBackWardBehavior backWardBehavior, IRightOrLeftBehavior rightOrLeftBehavior)
    : BaseVehicle(backWardBehavior,
        rightOrLeftBehavior);

public class SuperCar(IBackWardBehavior backWardBehavior, IRightOrLeftBehavior rightOrLeftBehavior)
    : BaseVehicle(backWardBehavior, rightOrLeftBehavior);

public class Super1Car(IBackWardBehavior backWardBehavior, IRightOrLeftBehavior rightOrLeftBehavior)
    : BaseVehicle(backWardBehavior, rightOrLeftBehavior);

public class Super2Car(IBackWardBehavior backWardBehavior, IRightOrLeftBehavior rightOrLeftBehavior)
    : BaseVehicle(backWardBehavior, rightOrLeftBehavior)
{
    public override void Backward()
    {
        Console.WriteLine("Super2Car");
    }
}

public class NormalCar(IBackWardBehavior backWardBehavior, IRightOrLeftBehavior rightOrLeftBehavior)
    : BaseVehicle(backWardBehavior, rightOrLeftBehavior);

public class Normal2Car(IBackWardBehavior backWardBehavior, IRightOrLeftBehavior rightOrLeftBehavior)
    : BaseVehicle(backWardBehavior, rightOrLeftBehavior);