namespace DesignPatterns.App.AbstractFactoryDesignPattern
{
    public class Ram
    {
        public int Capacity { get; set; }
    }

    public class Cpu
    {
        public int Capacity { get; set; }
    }

    public class Gpu
    {
        public int Capacity { get; set; }
    }

    public interface IComputer
    {
        public Ram Ram { get; set; }
        public Cpu Cpu { get; set; }
        public Gpu Gpu { get; set; }
    }

    public class LowLevelComputer : IComputer
    {
        public Ram Ram { get; set; }
        public Cpu Cpu { get; set; }
        public Gpu Gpu { get; set; }
    }

    public class MiddleLevelComputer : IComputer
    {
        public Ram Ram { get; set; }
        public Cpu Cpu { get; set; }
        public Gpu Gpu { get; set; }
    }

    public class HighLevelComputer : IComputer
    {
        public Ram Ram { get; set; }
        public Cpu Cpu { get; set; }
        public Gpu Gpu { get; set; }
    }

    public interface IComputerComponentFactory
    {
        Ram CreateRam();

        IComputer CreateComputer();
    }

    public class LowLevelComputerComponentFactory : IComputerComponentFactory
    {
        public Ram CreateRam()
        {
            return new Ram() { Capacity = 8 };
        }

        public Cpu CreateCpu()
        {
            return new Cpu() { Capacity = 8 };
        }

        public Gpu CreateGpu()
        {
            return new Gpu() { Capacity = 8 };
        }

        public IComputer CreateComputer()
        {
            return new LowLevelComputer()
            {
                Cpu = CreateCpu(),
                Gpu = CreateGpu(),
                Ram = CreateRam()
            };
        }
    }

    public class MiddleLevelComputerComponentFactory : IComputerComponentFactory
    {
        public Ram CreateRam()
        {
            return new Ram() { Capacity = 16 };
        }

        public IComputer CreateComputer()
        {
            return new MiddleLevelComputer();
        }
    }

    public class HighLevelComputerComponentFactory : IComputerComponentFactory
    {
        public Ram CreateRam()
        {
            return new Ram() { Capacity = 32 };
        }

        public IComputer CreateComputer()
        {
            return new HighLevelComputer();
        }
    }
}