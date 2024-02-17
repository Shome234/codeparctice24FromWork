using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
public class Club{
    public string MemberId{get;set;}
    public string MemberName{get;set;}
    public string MemberType{get;set;}
}
public class Service:Club{
    public bool ValidateMemberId(){
        return Regex.IsMatch(MemberId,@"^(Gold|Premium)\d{4}$");
    }
    public double CalculateMembershipPrice(){
        return MemberType=="Gold"?50000:MemberType=="Premium"?75000:0;
    }
}
//change this accordingly
class Program{
    public static void Main(){
        Service ser=new Service{MemberId="Gold7892",MemberName="James",MemberType="Premiu"};
        Console.WriteLine(ser.ValidateMemberId());
        Console.WriteLine(ser.CalculateMembershipPrice());
    }
}
