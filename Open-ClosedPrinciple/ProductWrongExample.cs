using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_ClosedPrinciple
{
    public class ProductWrongExample
    {

        //Bu örnekte değişime açık geliştirmeye kapalı yanlış bir örnek var, her yeni bir ürün eklediğimiz var olan kodu değiştirmek durumunda kaldığımız için bu yap Open-Closed prensibine uymayacaktır.
        public void HasStock(string productName)
        {
            if (productName == "AcerComputer")
            {
                Console.WriteLine("Stokta Yok");
            }
            else if (productName == "IPhone16")
            {
                Console.WriteLine("Stokta Var");
            }
            else
            {
                Console.WriteLine("Bilinmeyen ürün");
            }
        }
    }
}
