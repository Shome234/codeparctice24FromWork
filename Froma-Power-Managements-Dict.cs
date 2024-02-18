using System;
using System.Collections.Generic;
using System.Linq;
public class Program{
    public static Dictionary<string,int> PowerBankDetails=new Dictionary<string,int>();
    public void AddPowerBankDetails(string[] powerBank){
        foreach(var item in powerBank){
            string[] parts=item.Split(':');
            PowerBankDetails.Add(parts[0],int.Parse(parts[1]));
        }
    }
    public int FindBatteryPower(string powerBankName){
        // if(PowerBankDetails.ContainsKey(powerBankName)){
        //     return PowerBankDetails[powerBankName];
        // }
        // return -1;
        return PowerBankDetails.ContainsKey(powerBankName)?PowerBankDetails[powerBankName]:-1;
    }
    public List<string> FindTheHighestPowerBattery(){
        var highest=PowerBankDetails.Values.Max();
        var highestList=PowerBankDetails.Where(i=>i.Value==highest).Select(i=>i.Key).ToList();
        return highestList;
    }
    public static void Main(){
        Program p=new Program();
        var s=new string[]{"Hero Cell:30000","Bull Cell:40000","Ivp Cell:70000","Tvp Cell:20000","Netron Cell:70000"};
        p.AddPowerBankDetails(s);
        Console.WriteLine(p.FindBatteryPower("Cell"));
        var t=p.FindTheHighestPowerBattery();
        foreach(var i in t){
            Console.WriteLine(i);
        }
    }
}
