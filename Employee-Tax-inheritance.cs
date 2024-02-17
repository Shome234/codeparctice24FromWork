using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
public class Employee{
    public string EmployeeId{get;set;}
    public double Salary{get;set;}
}
public class EmployeeUtility:Employee{
    public bool ValidateEmployeeId(){
        return Regex.IsMatch(EmployeeId,@"^[A-Z]{1}\d{3}$");
    }
    public double CalculateTaxAmount(){
        double tax=0;
        if(Salary<=20000){
            tax=0;
        }
        if(Salary>=20001&&Salary<=50000){
            tax=(Salary-20000)*0.1;
        }
        if(Salary>=50001&&Salary<=100000){
            tax=(20000*0)+(30000*0.1)+((Salary-50000)*2);
        }
        if(Salary>=100001){
            tax=(20000*0)+(30000*0.1)+(50000*0.2)+((Salary-100000)*0.3);
        }
        return tax;
    }
}
//change this accordingly
public class Program{
    public static void Main(){
        EmployeeUtility e=new EmployeeUtility{EmployeeId="A234",Salary=200000};
        Console.WriteLine(e.ValidateEmployeeId());
        Console.WriteLine(e.CalculateTaxAmount());
    }
}
