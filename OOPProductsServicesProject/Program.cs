using System;

namespace OOPProductsServicesProject {
    class Program {
        static void Main(string[] args) {

            var bw = new Product(1001, "Basic Widget", 10, 2500);
            var aw = new Product(1002, "Advanced Widget", 25, 1500);
            var sw = new Product(1003, "Supreme Widget", 50, 1000);
            Console.WriteLine($"Name: {bw.Name} units sold: {bw.Units}.");
            Console.WriteLine($"Name: {aw.Name} units sold: {aw.Units}.");
            Console.WriteLine($"Name: {sw.Name} units sold: {sw.Units}.");


            var bs = new Service(1101, "Basic Support", 25, 1000);
            var ps = new Service(1102, "Priority Support", 50, 550);
            var fs = new Service(1103, "24/7 Support", 100, 750);


            Console.WriteLine($"Name: {bs.Name} Rate: {bs.Rate}, Hours Sold: {bs.Hours}.");
            Console.WriteLine($"Name: {ps.Name} Rate: {ps.Rate}, Hours Sold: {ps.Hours}.");
            Console.WriteLine($"Name: {fs.Name} Rate: {fs.Rate}, Hours Sold: {fs.Hours}.");





            var sales = new baseclass[] {
                bw,aw, sw, bs, ps, fs,

            new Membership(21, "Basic Membership", 100, 1500),
            new Membership(21, "Advanced Membership", 200, 700),
            new Membership(21, "Premiere Membership", 400, 300)
        }; 

            var total = 0M;

            foreach(var sale in sales) {
                total += sale.CalcGetTotal();
            }




            Console.WriteLine($"Total sales is ${total}.");








            //basic, elite, supreme widget
            //price int
            //services : basic, advanced, premiere (with different rates)
            //at least 3 recods in each category
            //price*unit    rate*hour added together to get the sales of the company




        }
    }
}
