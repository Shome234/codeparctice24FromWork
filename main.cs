using System;
using System.Collections.Generic;
using System.Linq;

public class Movie{
    public string MovieName{get;set;}
    public string ScreenedDate{get;set;}
    public string RemovedDate{get;set;}
    public double Price{get;set;}
}
public class Program{
    public static Dictionary<int,Movie> screeningDetails=new Dictionary<int,Movie>();
    public Dictionary<string,double> MovieScreenedMoreNumberOfDays(){
        return screeningDetails.Values.Select(item=>new{
            item.MovieName,
            ScreenDays=((DateTime.Parse(item.RemovedDate))-(DateTime.Parse(item.ScreenedDate))).TotalDays,
            item.Price
        }).GroupBy(x=>x.ScreenDays).OrderByDescending(g=>g.Key).First().ToDictionary(y=>y.MovieName,y=>y.Price);
        
    }
    public Dictionary<string,double> MovieWithScreenedDays(){
        return screeningDetails.Values.GroupBy(item=>item.MovieName).ToDictionary(g=>g.Key,g=>g.Sum(item=>((DateTime.Parse(item.RemovedDate))-(DateTime.Parse(item.ScreenedDate))).TotalDays));
        
    }
    public static void Main()
	{
    	Program pr = new Program();
    	screeningDetails.Add(1, new Movie { MovieName = "Eternals", ScreenedDate = "04/25/2020", RemovedDate = "05/30/2020", Price = 350 });
    	screeningDetails.Add(2, new Movie { MovieName = "Iron Man", ScreenedDate = "07/15/2008", RemovedDate = "08/15/2008", Price = 1350 });
    	screeningDetails.Add(3, new Movie { MovieName = "Avatar", ScreenedDate = "10/15/2003", RemovedDate = "02/05/2004", Price = 3500 });
    	screeningDetails.Add(4, new Movie { MovieName = "Light Year", ScreenedDate = "05/17/2020", RemovedDate = "07/03/2020", Price = 6350 });
    	while (true)
    	{
        	Console.WriteLine("1. Movie Screening More number of days");
        	Console.WriteLine("2. Movie with their Screening Days");
        	Console.WriteLine("3. Exit");
        	Console.WriteLine("Enter your choice");
        	int choice = int.Parse(Console.ReadLine());
        	switch (choice)
        	{
            	case 1:
                	Dictionary<string, double> mydict1 = pr.MovieScreenedMoreNumberOfDays();
                	foreach (var item1 in mydict1)
                	{
                    	Console.WriteLine($"{item1.Key} {item1.Value}");
                	}
                	break;
            	case 2:
                	Dictionary<string, double> mydict2 = pr.MovieWithScreenedDays();
                	foreach (var item2 in mydict2)
                	{
                    	Console.WriteLine($"{item2.Key} {item2.Value}");
                	}
                	break;
            	case 3:
                	Console.WriteLine("Thank you");
                	return;
        	}
    	}
	}
    
}