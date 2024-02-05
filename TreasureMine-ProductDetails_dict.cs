using System;
using System.Collections.Generic;
using System.Linq;

namespace TreasureMine{
    public class Program{
        public static Dictionary<string,int> ProductDetails=new Dictionary<string,int>();
        public void AddProductDetails(string itemName,int quantity){
            ProductDetails.Add(itemName,quantity);
        }
        public List<string> CheckReorderLevel(int reorderLevel){
            var newList=new List<string>();
            foreach(var item in ProductDetails){
                if(item.Value<=reorderLevel){
                    newList.Add(item.Key);
                }
            }
            return newList;
        }
        public static void Main(){
            Program p=new Program();
            Console.WriteLine("Enter the number of products");
            int numOfProducts=Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<numOfProducts;i++){
                Console.WriteLine("Enter the item name");
                string itemName=Console.ReadLine();
                Console.WriteLine("Enter the stock quantity");
                int itemQuantity=Convert.ToInt32(Console.ReadLine());
                p.AddProductDetails(itemName,itemQuantity);
            }
            Console.WriteLine("Enter re-order level");
            int reorderValue=Convert.ToInt32(Console.ReadLine());
            var reorderList=p.CheckReorderLevel(reorderValue);
            if(reorderList.Count>0){
                Console.WriteLine($"List of Products-reorder level below {reorderValue}");
                foreach(var item in reorderList){
                    Console.WriteLine(item);
                }
            }
            else{
                Console.WriteLine("No need for reorder");
            }
        }
    }
}
