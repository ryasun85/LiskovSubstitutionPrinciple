﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPLibrary
{
    public class Employee : BaseEmployee, IManaged
    {
        public IEmployee Manager { get; set; } = null;
  
        public virtual void AssignManager(IEmployee manager)
        {
            //method (not) prop due to symulation
            Manager = manager;
        }

    }
}
