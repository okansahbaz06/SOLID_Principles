﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    internal interface IWrite
    {
        public void Add();
        public void Update();
        public void Delete();
    }
}
