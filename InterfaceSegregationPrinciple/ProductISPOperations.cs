using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    //The goal of the Interface Segregation Principle (ISP) is not to overload all operations onto a single interface. By creating multiple interfaces, we separate the operations, making the structure more understandable and aligned with this principle. In this example, we divided the Read and Write operations into two separate interfaces and used them accordingly.
    public class ProductISPOperations : IRead, IWrite
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
