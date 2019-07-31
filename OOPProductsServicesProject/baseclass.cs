using System;
using System.Collections.Generic;
using System.Text;

namespace OOPProductsServicesProject {
    public class baseclass {

        public int Id { get; set; }
        public string Name;


        public virtual decimal CalcGetTotal() {
            return Id;

        }


        public baseclass(int Id, string Name) {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
