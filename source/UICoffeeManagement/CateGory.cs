﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UICoffeeManagement
{
    class CateGory
    {
        public List<Product> pr = new List<Product>();
        public string name { get; set; }


        public void addProduct(Product temp)
        {
            pr.Add(temp);
        }
        public override string ToString()
        {
            return name;
        }



    }
}