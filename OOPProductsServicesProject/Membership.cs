using System;
using System.Collections.Generic;
using System.Text;

namespace OOPProductsServicesProject {
    class Membership: baseclass {

        public int Fee;
        public int Units;


        public override decimal CalcGetTotal() {
            return Fee * Units;
        }
        public Membership (int Id, string Name, int Fee, int Units): base (Id, Name) {
            this.Fee = Fee;
            this.Units = Units;
        }
    }



}
