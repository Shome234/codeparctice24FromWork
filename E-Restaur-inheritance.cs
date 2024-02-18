using System;
using System.Collections.Generic;
using System.Linq;
public class FoodDetails{
    public string FoodType{get;set;}
    public int Quantity{get;set;}
    public int PricePerPiece{get;set;}
    public double TotalPrice{get;set;}
    public double Discount{get;set;}
}
public class Billing:FoodDetails{
    public bool ValidateFoodType(){
        return FoodType=="Samosa"||FoodType=="Spring Roll"||FoodType=="Empanada"?true:false;
    }
    public FoodDetails GenerateBill(){
        TotalPrice=Quantity*PricePerPiece;
        Discount=TotalPrice>=100&&TotalPrice<=500?TotalPrice*0.1:TotalPrice>500&&TotalPrice<=1000?TotalPrice*0.15:TotalPrice>1000?TotalPrice*0.2:TotalPrice<100?0:0;
        // TotalPrice=TotalPrice-Discount;
        return this;
    }
}
//change it accordingly
public class Program{
    public static void Main(){
        Billing b=new Billing{FoodType="Samosa",Quantity=20,PricePerPiece=40};
        Console.WriteLine(b.ValidateFoodType());
        var c=b.GenerateBill();
        Console.WriteLine($"{c.TotalPrice}\t{c.Discount}");
    }
}
