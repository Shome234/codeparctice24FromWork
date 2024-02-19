using System;
using System.Collections.Generic;
using System.Linq;

public class Perfume{
    public string Type{get;set;}
    public int QuantitySold{get;set;}
}
public class Program{
    public static Dictionary<int,Perfume> PerfumeDetails{get;set;}=new Dictionary<int,Perfume>();

    public static void Main()
    {
        PerfumeUtility utility = new PerfumeUtility();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("1. Add perfume details");
            Console.WriteLine("2. Find maximum sold perfume");
            Console.WriteLine("3. Sort by quantity sold");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your choice");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the perfume type");
                    string type = Console.ReadLine();
                    Console.WriteLine("Enter the quantity sold");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    utility.AddPerfumeDetails(type, quantity);
                    break;
                case 2:
                    Console.WriteLine(utility.FindMaximumSoldPerfume());
                    break;
                case 3:
                    var sortedPerfumes = utility.SortByQuantitySold();
                    foreach (var perfume in sortedPerfumes)
                    {
                        Console.WriteLine($"{perfume.Key}\t{perfume.Value}");
                    }
                    break;
                case 4:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        Console.WriteLine("Thank you");
    }
}
public class PerfumeUtility{
    public void AddPerfumeDetails(string type,int quantity){
        Program.PerfumeDetails.Add(Program.PerfumeDetails.Count+1,new Perfume{Type=type,QuantitySold=quantity});
    }
    public string FindMaximumSoldPerfume(){
        var r= Program.PerfumeDetails.Values.Max(i=>i.QuantitySold);
        // string s="";
        foreach(var i in Program.PerfumeDetails.Values){
            if(i.QuantitySold==r){
                return i.Type;
            }
        }
        return null;
    }
    public Dictionary<string,int> SortByQuantitySold(){
        return Program.PerfumeDetails.Values.OrderByDescending(i=>i.QuantitySold).ToDictionary(g=>g.Type,g=>g.QuantitySold);
    }
}