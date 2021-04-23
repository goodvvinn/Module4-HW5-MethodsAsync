﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Entities
{
    public class Title
    {
        public int TitleId { get; set; }
        public string Name { get; set; }
        public List<Employee> Employee { get; set; } = new List<Employee>();
    }
}
