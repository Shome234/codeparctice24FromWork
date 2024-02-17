using System;
using System.Collections.Generic;
using System.Linq;

public class Installation{
    public string ExpectedDate{get;set;}
    public string InstalledDate{get;set;}
    public double Rating{get;set;}
    public string FeedBack{get;set;}
}
public class InstallationDetails:Installation{
    public void GetCustomerFeedBack(){
        DateTime expectedDate=DateTime.Parse(ExpectedDate);
        DateTime installedDate=DateTime.Parse(InstalledDate);
        if(installedDate<expectedDate){
            FeedBack="VeryGood";
        }
        if(installedDate==expectedDate){
            FeedBack="Good";
        }
        if((installedDate-expectedDate).TotalDays==3){
            FeedBack="Average";
        }
        if((installedDate-expectedDate).TotalDays>3){
            FeedBack="Poor";
        }
    }
    public double CalculateRating(){
        if(FeedBack=="VeryGood"){
            Rating+=Rating*0.5;
        }
        if(FeedBack=="Good"){
            Rating+=Rating*0.2;
        }
        if(FeedBack=="Average"){
            Rating-=Rating*0.2;
        }
        if(FeedBack=="Poor"){
            Rating-=Rating*0.5;
        }
        return Rating;
    }
}
//change it accordingly
public class Program{
    public static void Main(){
        InstallationDetails idetails=new InstallationDetails{
            ExpectedDate="05/25/2023",
            InstalledDate="05/20/2023",
            Rating=9
        };
        idetails.GetCustomerFeedBack();
        var rating=idetails.CalculateRating();
        Console.WriteLine($"your new rating is {rating}");
    }
}
