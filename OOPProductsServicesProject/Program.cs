using System;

namespace OOPProductsServicesProject {
    class Program {
        static void Main(string[] args) {

            var p = new Products();
            p.Name = "Basic";
            p.Id = 1001;
            p.Price = 10;
            p.Units = 2500;
            Console.WriteLine($"Name:{p.Name} units sold: {p.Units} total profit: ****");
            Console.WriteLine($"Name:{p.Name} units sold: {p.Units} total profit: ****");
            Console.WriteLine($"Name:{p.Name} units sold: {p.Units} total profit: ****");


            var bs = new Services();
            bs.Name = "Basic Support";
            bs.Id = 1101;
            bs.Rate = 25;
            bs.Hours = 1000;

            var ps = new Services();
            ps.Name = "Priority Support";
            ps.Id = 1102;
            ps.Rate = 50;
            ps.Hours = 550;

            var fs = new Services();
            fs.Name = "24/7 Full Support";
            fs.Id = 1103;
            fs.Rate = 100;
            fs.Hours=


            Console.WriteLine($"Name: {bs.Name} Rate: {bs.Rate}, Hours Sold: {bs.Hours} Total Profit: *****");
            Console.WriteLine($"Name: {ps.Name} Rate: {ps.Rate}, Hours Sold: {ps.Hours} Total Profit: *****");
            Console.WriteLine($"Name: {s.Name} Rate: {s.Rate}, Hours Sold: {s.Hours} Total Profit: *****");


















            //basic, elite, supreme widget
            //price int
            //services : basic, advanced, premiere (with different rates)
            //at least 3 recods in each category
            //price*unit    rate*hour added together to get the sales of the company




        }
    }
}
