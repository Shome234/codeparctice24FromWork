using System;
using System.Collections.Generic;
using System.Linq;

class Program{
    public static Dictionary<string,int> ProductDetails=new Dictionary<string,int>();
    public void AddProductDetails(string itemName,int quantity){
        if(ProductDetails.ContainsKey(itemName)){
            ProductDetails[itemName]+=quantity;
        }
        ProductDetails.Add(itemName,quantity);
    }
    public List<string> CheckReorderLevel(int reorderLevel){
        return ProductDetails.Where(i=>i.Value<reorderLevel).Select(i=>i.Key).ToList();
    }
    public static void Main(string[] args)
    {
        Program storeProgram = new Program();
 
        Console.WriteLine("Enter the number of products");
        int numProducts = Convert.ToInt32(Console.ReadLine());
 
        // Get product details from the user
        for (int i = 0; i < numProducts; i++)
        {
            Console.WriteLine("Enter the item name");
            string itemName = Console.ReadLine();
 
            Console.WriteLine("Enter the stock quantity");
            int quantity = Convert.ToInt32(Console.ReadLine());
 
            // Call AddProductDetails method
            storeProgram.AddProductDetails(itemName, quantity);
        }
 
        Console.WriteLine("Enter re-order level");
        int reorderLevel = Convert.ToInt32(Console.ReadLine());
 
        // Call CheckReorderLevel method and display the result
        List<string> itemsToReorder = storeProgram.CheckReorderLevel(reorderLevel);
        if (itemsToReorder.Count > 0)
        {
            Console.WriteLine("List of Products - reorder level below " + reorderLevel);
            foreach (string item in itemsToReorder)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("No need for reorder");
        }
    }
}
