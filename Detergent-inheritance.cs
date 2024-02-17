using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
public class Detergent{
    public string BillId{get;set;}
    public string Name{get;set;}
    public int GramsInPack{get;set;}
    public double CostPerPack{get;set;}
}
public class Service:Detergent{
    public bool ValidateBillId(){
        return Regex.IsMatch(BillId,@"^\d{2}:[A-Z]{2}$");
    }
    public double CalculateTotalCost(float quantity){
        return (CostPerPack*(quantity*1000)/GramsInPack);
    }
}
//change it accordingly
public class Program{
    public static void Main(){
        Service ser=new Service{BillId="12:AB",Name="james",GramsInPack=250,CostPerPack=80};
        Console.WriteLine(ser.ValidateBillId());
        Console.WriteLine(ser.CalculateTotalCost(1));
    }
}
