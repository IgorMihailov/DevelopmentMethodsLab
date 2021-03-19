﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    class BalanceChange
    {
        public string Product { get; set; }
        public string Supplier { get; set; }
        public int Amount { get; set; }
        public int Type { get; set; }

        public BalanceChange(string product, string supplier, int amount, int type)
        {
            this.Product = product;
            this.Supplier = supplier;
            this.Amount = amount;
            this.Type = type;
        }
    }
}
