using System;
using System.Collections.Generic;
using System.Linq;
class Program{
    public static Dictionary<string,int> BirdDetails=new Dictionary<string,int>();
    public void AddBirdDetails(string[] bird){
        foreach(var item in bird){
            string[] parts=item.Split(":");
            BirdDetails.Add(parts[0],int.Parse(parts[1]));
        }
    }
    public int FindTheBirdCount(string birdName){
        return BirdDetails.ContainsKey(birdName)?BirdDetails[birdName]:-1;
    }
    public List<string> FindTheHighestCountOfBird(){
        var highestCount=BirdDetails.Values.Max();
        var countList=BirdDetails.Where(i=>i.Value==highestCount).Select(i=>i.Key).ToList();
        return countList;
    }
    public static void Main(){
        Program p=new Program();
        while(true){
            Console.WriteLine("1.Add bird details");
            Console.WriteLine("2.find bird count");
            Console.WriteLine("3.find highest bird count");
            Console.WriteLine("4.exit");
            int choice;
            if(int.TryParse(Console.ReadLine(),out choice)){
                switch(choice){
                    case 1:
                        Console.WriteLine("enter the numebr of entries");
                        int e=Convert.ToInt32(Console.ReadLine());
                        string[] li=new string[e];
                        for(int i=0;i<e;i++){
                            li[i]=Console.ReadLine();
                        }
                        p.AddBirdDetails(li);
                        break;
                    case 2:
                        Console.WriteLine("enter the bird name");
                        string bird=Console.ReadLine();
                        if(p.FindTheBirdCount(bird)!=-1){
                            Console.WriteLine($"numbers {p.FindTheBirdCount(bird)}");
                        }
                        else{
                            Console.WriteLine("invalid name");
                        }
                        break;
                    case 3:
                        var li2=p.FindTheHighestCountOfBird();
                        if(li2.Count>0){
                            foreach(var item in li2){
                                Console.WriteLine(item);
                            }
                        }
                        else{
                            Console.WriteLine("no returns");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Thank you");
                        return;
                    default:
                        Console.WriteLine("nooooooooooo");
                        break;
                }
            }
            else{
                Console.WriteLine("invalid choice input");
            }
        }
    }
}
