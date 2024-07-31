using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensRefactoringAndCleanCoding.Refactoring
{
    public class Product
    {
        public string Name { get; set; }
    }

    internal class NullExample
    {
        public string Name { get; set; } = default!;

        public string GetName()
        {
            return string.Empty;
        }

        public List<string> GetNames()
        {
            //try
            //{

            //}
            //catch (Exception e)
            //{
            //    //SendEmail(e
            //}

            return new List<string>();
        }

        public void Method(Product p)
        {
            var x = p?.Name;
        }
    }
}