using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
public class Cab{
    public string BookingId{get;set;}
    public string CabType{get;set;}
    public double Distance{get;set;}
    public double Fare{get;set;}
}
public class CabDetails:Cab{
    public bool ValidateBookingId(){
        return Regex.IsMatch(BookingId,@"^AC@\d{3}$");
    }
    public Cab CalculateFareAmount(){
        
        Fare=CabType=="Hatchback"?Distance*10:CabType=="Sedan"?Distance*20:CabType=="SUV"?Distance*30:0;
        return this;
        
    }
}
//change this accordingly
public class Program{
    public static void Main(){
        CabDetails ser=new CabDetails{BookingId="AC@235",CabType="SUV",Distance=10};
        Console.WriteLine(ser.ValidateBookingId());
        var a=ser.CalculateFareAmount();
        Console.WriteLine($"{a.BookingId}-{a.CabType}-{a.Distance}-{a.Fare}");
    }
}
