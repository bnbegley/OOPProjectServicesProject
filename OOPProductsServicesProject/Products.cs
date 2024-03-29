﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOPProductsServicesProject {
    class Product : baseclass {


        public decimal Price;
        public int Units;

        public override decimal CalcGetTotal() {
            return Price * Units;
        }

        public Product (int Id, string Name, decimal Price, int Units) : base (Id, Name) {
            this.Price = Price;
            this.Units = Units;
        }
    }
}
