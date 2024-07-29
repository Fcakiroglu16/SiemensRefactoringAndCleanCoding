using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensRefactoringAndCleanCoding.MethodLevels
{
    public class AccessModifiers
    {
        private List<string> Names { get; set; }


        public void Add(string name)
        {
            if (name.Length < 3)
            {
                Names.Add(name);
            }

            throw new Exception("");
        }

        public ImmutableList<string> GetAll()
        {
            return Names.ToImmutableList();
        }
    }

    public class AccessModifiersService
    {
        public void Method()
        {
            AccessModifiers accessModifiers = new AccessModifiers();


            accessModifiers.Add("mehmet");

            var namesList = accessModifiers.GetAll();

            namesList.ToList().Add("aaa");
        }
    }
}