using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SiemensRefactoringAndCleanCoding.MethodLevels.FunctionalProgramming;

public class CalculateService
{
    public decimal Calculate10(decimal price, int amount)
    {
        //Immutable object
        //pure function( no side effect)
        //function as Parameters
        return price + amount + 80;
    }

    public CalculateService()
    {
        int i = 10;


        var calculate = (decimal price, decimal mount) => price * mount;

        //action
        Action<decimal, decimal> calculate2 = (price, mount) => { Console.WriteLine(price * mount); };
        // Predicate
        Predicate<decimal> calculate3 = (price) => price > 10;
        // Func
        Func<decimal, decimal, decimal> calculate4 = (price, mount) => price * mount;


        var price = 1000;
        var amount = 20;

        var calculatePrice = price * amount + 20;

        CalculateWithDelegate(100, 10, (price, amount) => price * amount + 20);

        CalculateWithDelegate(100, 10, Calculate10);
    }


    public decimal CalculateWithDelegate(decimal price, int amount, Func<decimal, int, decimal> funcCalculate)
    {
        var result = funcCalculate(price, amount);
        Console.WriteLine($"Send To API : {result}");

        return result;
    }

    public decimal CalculateTax(decimal price, decimal amount)
    {
        Console.WriteLine($"Send To API :");
        return price * amount;
    }

    public decimal CalculateTax2(decimal price, decimal amount)
    {
        Console.WriteLine($"Send To API :");
        return price * amount * 20;
    }


    public decimal CalculateTax3(decimal price, decimal amount)
    {
        Console.WriteLine($"Send To API :");
        return price * amount * 20 * 1.20m;
    }
}