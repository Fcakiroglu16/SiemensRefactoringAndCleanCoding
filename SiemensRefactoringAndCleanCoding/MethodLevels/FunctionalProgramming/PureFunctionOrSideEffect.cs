using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensRefactoringAndCleanCoding.MethodLevels.FunctionalProgramming;

public class TaxCalculate
{
    public decimal CalculateTax(decimal price, int tax)
    {
        return price * tax / 100;
    }

    public decimal CalculateTax2(decimal price, int type, int tax)
    {
        return price * tax / 100 * type;
    }
}

public class TaxController
{
    public void Method1()
    {
        TaxCalculate taxCalculate = new TaxCalculate();
        taxCalculate.CalculateTax(100, 20);
    }
}

public class TaxController2
{
    public void Method1()
    {
        TaxCalculate taxCalculate = new TaxCalculate();
        taxCalculate.CalculateTax2(100, 2, 30);
    }
}