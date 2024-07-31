namespace DesignPatterns.App.BuilderDesignPattern;

public class CarDirector(ICarBuilder carBuilder)
{
    public Car CreateCar(string model, string color)
    {
        carBuilder.SetModel(model);
        carBuilder.SetColor(color);
        carBuilder.SetSeat();
        carBuilder.SetGear();
        carBuilder.SetWindShield();
        return carBuilder.Build();
    }
}

public interface ICarBuilder
{
    void SetModel(string model);
    void SetColor(string color);
    void SetSeat();
    void SetGear();
    void SetWindShield();
    Car Build();
}

public class HatchbackCarBuilder : ICarBuilder
{
    private string _model;
    private string _color;
    private Seat _seat;
    private Gear _gear;
    private WindShield _windShield;


    public void SetModel(string model) => _model = model;


    public void SetColor(string color) => _color = color;

    public void SetSeat() => _seat = Seat.Four;


    public void SetGear() => _gear = Gear.Manuel;

    public void SetWindShield() => _windShield = new WindShield() { Model = "abc", Type = "123" };

    public Car Build()
    {
        return new Car()
        {
            Color = _color,
            Gear = _gear,
            Model = _model,
            Seat = _seat,
            WindShield = _windShield
        };
    }
}

public class CoupeCarBuilder : ICarBuilder
{
    private Car Car { get; } = new();

    public void SetModel(string model)
    {
        Car.Model = model;
    }

    public void SetColor(string color)
    {
        Car.Color = color;
    }

    public void SetSeat()
    {
        Car.Seat = Seat.Two;
    }


    public void SetGear()
    {
        Car.Gear = Gear.Automatic;
    }

    public void SetWindShield()
    {
        Car.WindShield = new WindShield() { Model = "def", Type = "456" };
    }

    public Car Build()
    {
        return Car;
    }
}

public record Car
{
    public string Model { get; init; } = null!;
    public string Color { get; init; } = null!;
    public Seat Seat { get; init; }

    public Gear Gear { get; init; }

    public WindShield WindShield { get; init; } = null!;
}

public enum Seat
{
    Two,
    Four,
    Six
}

public enum Gear
{
    Automatic,
    Manuel
}

public class WindShield
{
    public string Model { get; set; } = null!;
    public string Type { get; set; } = null!;
}