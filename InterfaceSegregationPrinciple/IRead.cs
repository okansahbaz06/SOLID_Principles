using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public interface IRead
    {
        public void GetAll();
        public void GetById(int id);
        public void GetByName(string name);
    }
}
