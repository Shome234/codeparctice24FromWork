using System;
namespace WaterWonders{
    public class WaterBill{
        public string UsageType{get;set;}
        public double Volume{get;set;}
        public double PricePerGallon{get;set;}
    }
    public class BillUtility:WaterBill{
        public bool ValidateUsageType(){
            if(UsageType=="Residential"||UsageType=="Commercial"||UsageType=="Industrial"){
                return true;
            }
            return false;
        }
        public double WaterPriceCalculation(){
            double price=0;
            double taxless=0;
            if(UsageType=="Residential"){
                taxless=(PricePerGallon*Volume);
                price=taxless+(taxless*0.1);
            }
            if(UsageType=="Commercial"){
                taxless=(PricePerGallon*Volume);
                price=taxless+(taxless*0.2);
            }
            if(UsageType=="Industrial"){
                taxless=(PricePerGallon*Volume);
                price=taxless+(taxless*0.3);
            }
            return price;
        }
        public class Program{
            
            public static void Main(){
                BillUtility bu=new BillUtility();
                Console.WriteLine("Enter the usage type");
                bu.UsageType=Console.ReadLine();
                if(bu.ValidateUsageType()){
                    Console.WriteLine("Enter the volume of water");
                    bu.Volume=Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the price per gallon");
                    bu.PricePerGallon=Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"The total price is {bu.WaterPriceCalculation()}");
                }
                else{
                    Console.WriteLine("Invalid Usage Type");
                }
            }
            
            
        } 
    } 
}