﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intel.DonutMaster.Models
{
    public class Product : Base
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public bool IsGlutenFree { get; set; }

        public int Calories { get; set; }

        public Recipe Recipe { get; set; }


    }
}