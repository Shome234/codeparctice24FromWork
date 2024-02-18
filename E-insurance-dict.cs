using System;
using System.Collections.Generic;
using System.Linq;
public class Program{
    public static Dictionary<string,double> SchemeDetails=new Dictionary<string,double>();
    public void AddSchemeDetails(string[] scheme){
        foreach(var item in scheme){
            string[] parts=item.Split(':');
            SchemeDetails.Add(parts[0],int.Parse(parts[1]));
        }
    }
    public double FindSchemeMonthlyAmount(string schemeName){
        return SchemeDetails.ContainsKey(schemeName)?SchemeDetails[schemeName]:-1;
    }
   public List<string> FindLowestMonthlyAmountScheme(){
       return SchemeDetails.Where(i=>i.Value==SchemeDetails.Values.Min()).Select(i=>i.Key).ToList();
   }
  //change this accordingly
    public static void Main(){
        Program p=new Program();
        var s=new string[]{"The Ayushman Bharat:5200",
                            "National Pension System:6000",
                            "The Employees' State Insurance Scheme:8000",
                            "The Central Government Health Scheme:4800",
                            "The Pradhan Mantri Suraksha Bima Yojana:4800"};
        p.AddSchemeDetails(s);
        Console.WriteLine(p.FindSchemeMonthlyAmount("Cell"));
        var t=p.FindLowestMonthlyAmountScheme();
        foreach(var i in t){
            Console.WriteLine(i);
        }
    }
}
