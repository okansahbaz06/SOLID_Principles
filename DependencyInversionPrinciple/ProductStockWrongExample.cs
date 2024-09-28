using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{

    //As seen in this example, the upper-level class ProductStockOperations is dependent on lower-level classes. Every time a new operation is added, the upper-level class needs to be modified again, which makes this example violate the Dependency Inversion Principle.
    public class ProductStockWrongExample
    {
        public void CheckBedStock()
        {
            new BedStock().HasStock();
        }

        public void CheckChairStock()
        {
            new ChairStock().HasStock();
        }
    }
    public class BedStockWrong
    {
        public void HasStockWrong()
        {
            Console.WriteLine("Stokta Var");
        }
    }
    public class ChairStockWrong
    {
        public void HasStockWrong()
        {
            Console.WriteLine("Stokta Yok");
        }
    }
}
