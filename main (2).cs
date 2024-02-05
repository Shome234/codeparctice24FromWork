using System;
namespace Lisa{
    public class Machine{
        public string Type{get;set;}
        public double CubicFootCapacity{get;set;}
        public double NoOfRevolution{get;set;}
        public double NoOfSeconds{get;set;}
        public double Price{get;set;}
    }
    public class MachineDetails:Machine{
        public double FindTheSpinSpeed(){
            return (60*NoOfRevolution)/NoOfSeconds;
        }
        public double CalculatePrice(){
            double discount=0;
            switch(Type){
                case "Front Load":
                    if(CubicFootCapacity>=2.0 && CubicFootCapacity<=5.5){
                       discount=Price*0.2;
                    }
                    if(CubicFootCapacity>=5.5){
                        discount=Price*0.4;
                    }
                    else{
                        discount=0;
                    }
                    break;
                case "Top Load":
                    if(CubicFootCapacity>=2.0 && CubicFootCapacity<=5.5){
                        discount=Price*0.3;
                    }
                    if(CubicFootCapacity>=5.5){
                        discount=Price*0.5;
                    }
                    else{
                        discount=0;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
            Price=Price-discount;
            return Price;
        }
    }
    public class Program{
        public static void Main(){
            MachineDetails md=new MachineDetails();
            Console.WriteLine("Enter Load Type");
            md.Type=Console.ReadLine();
            Console.WriteLine("Enter the cubic foot capacity");
            md.CubicFootCapacity=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number of revolutions");
            md.NoOfRevolution=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number of seconds");
            md.NoOfSeconds=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the price");
            md.Price=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Spin speed in {md.FindTheSpinSpeed()}");
            Console.WriteLine($"The price after discount {md.CalculatePrice()}");
        }
    }
}
    