using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Questao2.IRepository
{
    public interface IDatabaseRepository
    {
        bool CreateSalesOrder(Foo foo);

        bool UpdateSalesOrder(Foo foo);

        bool DeleteSalesOrder(int foo);
    }
}
