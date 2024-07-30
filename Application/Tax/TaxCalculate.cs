namespace Application.Tax
{
    public enum UserType
    {
        Manager,
        Editor,
        Normal,
        Guest,
        Super
    }

    public class TaxService
    {
        public static readonly Dictionary<UserType, Func<decimal, decimal>> calculateDictionary = new();
        public static readonly Dictionary<UserType, ISalaryCalculate> calculateDictionary2 = new();
        public static readonly Dictionary<UserType, BaseSalaryCalculate> calculateDictionary3 = new();

        static TaxService()
        {
            calculateDictionary.Add(UserType.Manager, TaxCalculate.CalculateManagerSalary);
            calculateDictionary.Add(UserType.Editor, TaxCalculate.CalculateEditorSalary);
            calculateDictionary.Add(UserType.Normal, TaxCalculate.CalculateNormalSalary);
            calculateDictionary.Add(UserType.Guest, TaxCalculate.CalculateGuestSalary);
        }

        public TaxService()
        {
            var taxCalculate = new TaxCalculate();


            var userType = UserType.Editor;


            calculateDictionary[userType](1000);


            //var managerSalary = taxCalculate.CalculateSalaryDelegate(1000, TaxCalculate.CalculateManagerSalary);


            //var customSalary =
            //    taxCalculate.CalculateSalaryDelegate(1000, (baseSalary) => { return baseSalary * 1.2m; });
            //var managerSalary2 = taxCalculate.CalculateSalaryBad(1000, UserType.Manager);

            //var managerSalary3 = taxCalculate.CalculateSalaryInterface(2000, new EditorSalaryCalculate());

            //var managerSalary4 = taxCalculate.CalculateSalaryPoly(200, ManagerSalaryCalculate2.Create);
        }
    }


    #region Interface Example

    public interface ISalaryCalculate
    {
        decimal Calculate(decimal baseSalary);
    }


    public class ManagerSalaryCalculate : ISalaryCalculate
    {
        public decimal Calculate(decimal baseSalary)
        {
            return baseSalary * 1.2m;
        }
    }

    public class EditorSalaryCalculate : ISalaryCalculate
    {
        public decimal Calculate(decimal baseSalary)
        {
            return baseSalary * 1.1m;
        }
    }

    #endregion

    public abstract class BaseSalaryCalculate
    {
        public abstract decimal Calculate(decimal baseSalary);
    }


    public class ManagerSalaryCalculate2 : BaseSalaryCalculate
    {
        public override decimal Calculate(decimal baseSalary)
        {
            return baseSalary * 1.2m;
        }

        public static ManagerSalaryCalculate2 Create = new ManagerSalaryCalculate2();
    }

    public class EditorSalaryCalculate2 : BaseSalaryCalculate
    {
        public override decimal Calculate(decimal baseSalary)
        {
            return baseSalary * 1.1m;
        }
    }


    public class TaxCalculate
    {
        public static decimal CalculateManagerSalary(decimal basePrice)
        {
            return basePrice * 1.2m;
        }

        public static decimal CalculateEditorSalary(decimal basePrice)
        {
            return basePrice * 1.1m;
        }

        public static decimal CalculateNormalSalary(decimal basePrice)
        {
            return basePrice;
        }

        public static decimal CalculateGuestSalary(decimal basePrice)
        {
            return basePrice * 1.5m;
        }


        public decimal CalculateSalaryPoly(decimal baseSalary, BaseSalaryCalculate baseSalaryCalculate)
        {
            return baseSalaryCalculate.Calculate(baseSalary);
        }

        public decimal CalculateSalaryDelegate(decimal baseSalary, Func<decimal, decimal> calculate)
        {
            return calculate(baseSalary);
        }

        public decimal CalculateSalaryInterface(decimal baseSalary, ISalaryCalculate calculate)
        {
            return calculate.Calculate(baseSalary);
        }


        public decimal CalculateSalaryBad(decimal basePrice, UserType userType)
        {
            decimal totalPrice = 0;

            switch (userType)
            {
                case UserType.Manager:
                    totalPrice = basePrice * 1.2m;
                    break;
                case UserType.Editor:
                    totalPrice = basePrice * 1.1m;
                    break;
                case UserType.Normal:
                    totalPrice = basePrice;
                    break;
                case UserType.Guest:
                    totalPrice = basePrice * 1.5m;
                    break;
                default:
                    totalPrice = basePrice;
                    break;
            }

            return totalPrice;
        }
    }
}