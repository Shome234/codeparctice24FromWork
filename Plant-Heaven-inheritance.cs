using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
public class Plant{
    public string PlantName{get;set;}
    public int NoOfSapling{get;set;}
    public string Category{get;set;}
    public int PricePerSapling{get;set;}
    public Plant(){}
}
public class PlantUtility:Plant{
    public Plant ExtractDetails(string PlantDetails){
        string[] p=PlantDetails.Split(':');
        this.PlantName=p[0];
        this.NoOfSapling=int.Parse(p[1]);
        this.Category=p[2];
        this.PricePerSapling=int.Parse(p[3]);
        return this;
    }
    public double CalculateCost(){
        double TotalAmount=NoOfSapling*PricePerSapling;
        double discount=(TotalAmount>500 &TotalAmount<=1000)?TotalAmount*0.1:(TotalAmount>1000)?TotalAmount*0.2:(TotalAmount<=500)?0:0;
        return TotalAmount-discount;
        // TotalAmount-=(TotalAmount>500 &TotalAmount<=1000)?TotalAmount*0.1:(TotalAmount>1000)?TotalAmount*0.2:(TotalAmount<=500)?0:0;
        // return TotalAmount;
    }
}
public class Program{
    public static void Main(){
        PlantUtility p=new PlantUtility();
        var p1=p.ExtractDetails("sunflower:10:flowering:70");
        Console.WriteLine($"{p1.PlantName}_{p1.NoOfSapling}_{p1.Category}_{p1.PricePerSapling}");
        Console.WriteLine(p.CalculateCost());
    }
}
