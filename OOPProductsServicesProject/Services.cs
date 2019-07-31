using System;
using System.Collections.Generic;
using System.Text;

namespace OOPProductsServicesProject {
    class Service: baseclass {


        public int Rate;
        public int Hours;

        public override decimal CalcGetTotal() {
            return Hours * Rate;
        }

        public Service (int Id, string Name, int Rate, int Hours) : base (Id, Name) {
            this.Id = Id;
            this.Name = Name;
            this.Rate = Rate;
            this.Hours = Hours;
        }

        //go look at the shape things and see how to not have to add info through the list! 




    }

}
