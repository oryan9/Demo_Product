﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }

        public Job? job { get; set; }

        public int JobID { get; set; }
    }
}
