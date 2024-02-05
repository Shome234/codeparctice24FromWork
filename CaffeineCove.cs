using System;
using System.Collections.Generic;
using System.Linq;

namespace CoffeineCove{
    public class Coffee{
        public string ItemName{get;set;}
        public double Price{get;set;}
    }
    public class Program{
        public static List<Coffee> CoffeeMenu{get;set;}=new List<Coffee>();
        
        public static void Main(){
            CoffeeUtility cu=new CoffeeUtility();
            int choice;
            do{
                Console.WriteLine("1.Add coffee details");
                Console.WriteLine("2.Update coffee price");
                Console.WriteLine("3.Sort by price");
                Console.WriteLine("4.Exit");
                if(int.TryParse(Console.ReadLine(),out choice)){
                    switch(choice){
                        case 1:
                            Coffee coffeeObj=new Coffee();
                            Console.WriteLine("Enter item name");
                            coffeeObj.ItemName=Console.ReadLine();
                            Console.WriteLine("Enter the price");
                            coffeeObj.Price=Convert.ToDouble(Console.ReadLine());
                            cu.AddCoffeePrice(coffeeObj);
                            break;
                        case 2:
                            Console.WriteLine("Enter item name");
                            string item=Console.ReadLine();
                            Console.WriteLine("Enter the price");
                            double price=Convert.ToDouble(Console.ReadLine());
                            var updated=cu.UpdateCoffeePrice(item,price);
                            if(updated.Count>0){
                                foreach(var i in updated){
                                    Console.WriteLine($"{i.ItemName}-{i.Price}");
                                }
                            }
                            else{
                                Console.WriteLine("No cahnges");
                            }
                            break;
                        case 3: 
                            var sorted=cu.SortByPrice();
                            foreach(var i in sorted){
                                Console.WriteLine($"{i.ItemName}-{i.Price}");
                            }
                            break;
                        case 4: 
                            Console.WriteLine("Thank You");
                            return;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                }
                else{
                    Console.WriteLine("Invalid input");
                }
            }while(choice!=4);
            
        }
    }
    public class CoffeeUtility{ 
        public void AddCoffeePrice(Coffee coffeeObj){
            Program.CoffeeMenu.Add(coffeeObj);
        }
        public List<Coffee> UpdateCoffeePrice(string itemName,double price){
            int count =0;
            var coffeeUpdate=Program.CoffeeMenu.FirstOrDefault(i=>i.ItemName==itemName);
            if(coffeeUpdate!=null){
                coffeeUpdate.Price=price;
                return Program.CoffeeMenu;
            }
            else{
                return new List<Coffee>();
            }
            
        }
        
        public List<Coffee> SortByPrice(){
            var coffeeSort=Program.CoffeeMenu.OrderByDescending(i=>i.Price).ToList();
            return coffeeSort;
        }
    }
}
