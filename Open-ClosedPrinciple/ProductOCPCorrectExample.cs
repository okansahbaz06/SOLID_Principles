using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_ClosedPrinciple
{
    //In this example, there is a correct instance of being open to development but closed to modification. Instead of changing our structure for each product, if we continue by developing them separately with the help of abstraction, we will be adhering to the Open-Closed Principle.
    public abstract class ProductOCPCorrectExample
    {
        public abstract void HasStock();
    }
    public class AcerComputer : ProductOCPCorrectExample
    {
        public override void HasStock()
        {
            Console.WriteLine("Stokta Yok");
        }
    }
    public class IPhone16Series : ProductOCPCorrectExample
    {
        public override void HasStock()
        {
            Console.WriteLine("Stokta Var");
        }

    }
}