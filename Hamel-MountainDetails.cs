using System;
using System.Collections.Generic;
using System.Linq;

namespace Hamel{
    public class Program{
        public static Dictionary<string,int> MountainDetails=new Dictionary<string,int>();
        public void AddMountainDetails(string[] mountain){
            foreach(var item in mountain){
                var singleItem=item.Split(':');
                MountainDetails.Add(singleItem[0],int.Parse(singleItem[1]));
            }
        }
        public int FindMountainHeight(string mountainName){
            if(MountainDetails.ContainsKey(mountainName)){
                return MountainDetails[mountainName];
            }
            else{
                return -1;
            }
        }
        public List<string> FindTheHighestMountains(){
            int max=MountainDetails.Values.Max();
            return MountainDetails.Where(key=>key.Value==max).Select(key=>key.Key).ToList();
        }
        public static void Main(){
            
            Console.WriteLine("Enter the number of entries");
            int entries=Convert.ToInt32(Console.ReadLine());
            var listMountain=new string[entries];
            // if(int.TryParse(Console.ReadLine(),out entries)){
            //     listMountain=new string[entries];
                for(int i=0;i<entries;i++){
                    listMountain[i]=Console.ReadLine();
                }
            // }
            Program p=new Program();
            int choice;
            do{
                Console.WriteLine("1.Add Mountain Details");
                Console.WriteLine("2.View Mountain Height");
                Console.WriteLine("3.View Mountains With Highest Height");
                Console.WriteLine("4.Exit");
                if(int.TryParse(Console.ReadLine(),out choice)){
                    switch(choice){
                        case 1:
                            p.AddMountainDetails(listMountain);
                            break;
                        case 2:
                            Console.WriteLine("Enter the mountain name needs to be searched");
                            string name=Console.ReadLine();
                            if(p.FindMountainHeight(name)!=-1){
                                Console.WriteLine($"Height is : {p.FindMountainHeight(name)}");
                            }
                            else{
                                Console.WriteLine("No mountains are available");
                            }
                            break;
                        case 3:
                            var mountainHighest=p.FindTheHighestMountains();
                            Console.WriteLine("Mountain names with heighest height are:");
                            foreach(var item in mountainHighest){
                                Console.WriteLine(item);
                            }
                            break;
                        case 4:
                            Console.WriteLine("Thank You");
                            return;
                        default:
                            Console.WriteLine("invalid choice");
                            break;
                    }
                }
                else{
                    Console.WriteLine("invalid");
                }
            }while(choice!=4);
        }
    }
}
