using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class ProductOperations
    {
        //The Single Responsibility Principle states that a class should have only one responsibility.
        //Therefore, in this example, the Product Operations class should contain only methods related to product operations.
        //For example, while the first two methods manage operations related to products, the presence of the AddCustomer method in this class violates the Single Responsibility Principle. This method should not be in the Product class.

        public void UpdateProductStock()
        { 
            //Update Product Stock Example

            List<object> productList = new List<object>();
            if (productList.Count == 0)
            {
                for (int i = 0; i < 100; i++)
                {
                    productList.Add(i);
                }
            }
        }

        public void RemoveProduct()
        {
            //Remove Operation
        }

        public void AddCustomer()
        {
            //Add Customer Operation 
        }
    }
}
