﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_And_Objects
{
    class Employee : Person
    {
        public Employee(int id)
        {
            id = id;
        }
        public int Id { get; set; }
    }
}
