using System.Security.Cryptography.X509Certificates;

namespace LiskovSubstituonPrinciple
{

    //The goal of the Liskov Substitution Principle is that subclasses should be able to replace their base classes. In this example, the AcerComputer and IPhone16Series classes are using the HasStock function of the base class Product and can substitute for this class.
    public class ProductLSP
    {
        public abstract class Product
        {
            public abstract void HasStock();
        }
        public class AcerComputer : Product
        {
            public override void HasStock()
            {
                Console.WriteLine("Stokta Yok");
            }
        }
        public class IPhone16Series : Product
        {
            public override void HasStock()
            {
                Console.WriteLine("Stokta Var");
            }

        }

        public void CheckStock()
        {
            //Subclasses replace the superclass.
            Product product = new AcerComputer();
            product.HasStock();

            product = new IPhone16Series();
            product.HasStock();
        }
    }
}
