using System.Collections.Generic;
using System;
using System.Linq;
class program
{
public static SortedDictionary<string,long>mobileDetails=new SortedDictionary<string,long>();
public SortedDictionary<string,long> FindMobileDetails(long soldCount)
{
    SortedDictionary<string,long> sd=new SortedDictionary<string,long>();
    foreach(var item in mobileDetails.Keys)
    {
        if(item.Equals(soldCount))
        {
            sd.Add(item,mobileDetails[item]);
        }
    }
    return sd;
}
public List<string>FindMinandMaxSoldMobiles()
{
    List<string>li=new List<string>();
    long res=0;
    long res1=0;
    foreach(var item in mobileDetails.Keys)
    {
        res=Math.Min(mobileDetails[item],res);
        res1=Math.Max(mobileDetails[item],res1);
    }
    foreach(var item in mobileDetails.Keys)
    {
        if(res==mobileDetails[item])
        {
            li.Add(item);
        }
    }
     foreach(var item in mobileDetails.Keys)
    {
        if(res1==mobileDetails[item])
        {
            li.Add(item);
        }
    }
    return li;
}
public Dictionary<string,long>SortbyCount()
{
    var sorted=mobileDetails.OrderBy(i=>i.Value).ToDictionary(i=>i.Key,i=>i.Value);
    return sorted;
}
    
} 
