using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensRefactoringAndCleanCoding.ObjectOrientedRefactoring;

public interface IAudit
{
    DateTime Create { get; set; }
}

public abstract class BaseEntity<T>
{
    public T Id { get; set; }

    public abstract void Write();
}

public class User : BaseEntity<int>, IAudit
{
    public DateTime Create { get; set; }

    public override void Write()
    {
        throw new NotImplementedException();
    }
}

public class Product : BaseEntity<int>
{
    public override void Write()
    {
        throw new NotImplementedException();
    }
}