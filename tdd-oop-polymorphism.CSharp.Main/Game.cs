﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Game : IProduct
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Game(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

        public int getPrice()
        {
            return this.Price;
        }

        public string getName()
        {
            return Name;
        }
    }
}
