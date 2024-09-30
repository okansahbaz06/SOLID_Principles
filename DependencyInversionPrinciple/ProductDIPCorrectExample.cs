using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class ProductDIPCorrectExample
    {

        //According to the Dependency Inversion Principle, higher-level modules should not depend directly on lower-level modules. Instead, the higher-level module should rely on an interface that provides the functionality of the lower-level modules. This way, the higher-level module depends on an abstraction (interface) rather than the specific implementation of the lower-level module, eliminating the need to change the higher-level module when the lower-level module is modified.

        private IStock _stock;

        public int ProductStockOperations(IStock stock)
        {
            _stock = stock;
            return 0;
            
        }

        public void CheckStock()
        {
            _stock.HasStock();
        }
    }
    public interface IStock
    {
        public void HasStock();
    }

    public class BedStock : IStock
    {
        public void HasStock()
        {
            Console.WriteLine("Stokta Var");
        }
    }

    public class ChairStock : IStock
    {
        public void HasStock()
        {
            Console.WriteLine("Stokta Yok");
        }
    }
}
