using System;
using System.Collections.Generic;
using System.Linq;

namespace WinCinemas{
    public class Movie{
        public string MovieName{get;set;}
        public string ScreenedDate{get;set;}
        public string RemovedDate{get;set;}
        public double Price{get;set;}
    }
    public class Program{
        public static Dictionary<int,Movie> screeningDetails=new Dictionary<int,Movie>();
        public Dictionary<string,double> MovieScreenedMoreNumberOfDays(){
            var moviesPrice=new Dictionary<string,double>();
            double maxScreenDays=0;
            foreach(var item in screeningDetails.Values){
                double screenDays=(DateTime.Parse(item.RemovedDate)-DateTime.Parse(item.ScreenedDate)).TotalDays;
                if(screenDays>maxScreenDays){
                    maxScreenDays=screenDays;
                    moviesPrice.Clear();
                    moviesPrice.Add(item.MovieName,item.Price);
                }
                if(screenDays==maxScreenDays){
                    moviesPrice.Add(item.MovieName,item.Price);
                }
            }
            return moviesPrice;
            // double maxDays=moviesDays.Values.Max();
            // var movieScreenedMaxDays=moviesDays.Where(item=>item.Value==maxDays).ToDictionary(item=>item.Key,item=>item.Value);
            // return movieScreenedMaxDays;
        }
        public Dictionary<string,double> MovieWithScreenedDays(){
            var movieDays=new Dictionary<string,double>();
            foreach(var item in screeningDetails.Values){
                double screenDays=(DateTime.Parse(item.RemovedDate)-DateTime.Parse(item.ScreenedDate)).TotalDays;
                if(movieDays.ContainsKey(item.MovieName)){
                    movieDays[item.MovieName]+=screenDays;
                }
                else{
                    movieDays.Add(item.MovieName,screenDays);
                }
            }
            return movieDays;
        }
        public static void Main(){
            Program p=new Program();
            int choice;
            do{
                Console.WriteLine("1.Movie screening more number of days");
                Console.WriteLine("2.Movie with their screening days");
                Console.WriteLine("3.Exit");
                Console.WriteLine("Enter your choice");
                if(int.TryParse(Console.ReadLine(),out choice)){
                    switch(choice){
                        case 1:
                            var movie1=p.MovieScreenedMoreNumberOfDays();
                            foreach(var item in movie1){
                                Console.WriteLine($"{item.Key} {item.Value}");
                            }
                            break;
                        case 2:
                            var movie2=p.MovieWithScreenedDays();
                            foreach(var item in movie2){
                                Console.WriteLine($"{item.Key} {item.Value}");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Thank You");
                            return;
                        default:
                            Console.WriteLine("wrong choice");
                            break;
                    }
                    
                }
                else{
                        Console.WriteLine("Invalid");
                    }
            }while(choice!=3);
            
        }
    }
}
