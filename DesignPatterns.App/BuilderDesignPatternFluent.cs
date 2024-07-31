namespace DesignPatterns.App.BuilderDesignPatternFluent;

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
    ICarBuilder SetModel(string model);
    ICarBuilder SetColor(string color);
    ICarBuilder SetSeat();
    ICarBuilder SetGear();
    ICarBuilder SetWindShield();
    Car Build();
}

public class HatchbackCarBuilder : ICarBuilder
{
    private string _model;
    private string _color;
    private Seat _seat;
    private Gear _gear;
    private WindShield _windShield;


    public ICarBuilder SetModel(string model)
    {
        _model = model;
        return this;
    }


    public ICarBuilder SetColor(string color)
    {
        _color = color;
        return this;
    }

    public ICarBuilder SetSeat()
    {
        _seat = Seat.Four;
        return this;
    }


    public ICarBuilder SetGear()
    {
        _gear = Gear.Manuel;
        return this;
    }

    public ICarBuilder SetWindShield()
    {
        _windShield = new WindShield() { Model = "abc", Type = "123" };
        return this;
    }

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