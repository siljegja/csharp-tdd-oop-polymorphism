﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public interface IProduct
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public int getPrice();
        public string getName();

    }
}
