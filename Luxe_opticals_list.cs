/*Luxe Opticals is a renowned eyewear store in the city, has appointed you as a software consultant to design a C# application that will optimize their business operations. Your role involves helping them develop the application with various features to simplify their daily tasks and improve efficiency.

 

Functionalities:

1.  class Opticals 

Implement the below-given properties

Data Type

Property Name

   string

   FrameMaterial

   string

   LensCoating

   double

   Price


 

2.  class Program

Implement the below-given static property

Data Type

Property Name

SortedDictionary<int, Opticals> 

   OpticalDetails

Start the value for int from 1 while adding

 

3.  class OpticalsUtility

Implement the below-given methods

Method

Rules

public void AddOpticalDetails(string frameMaterial,string lensCoating,double price)

This method is used to add the optical details to the OpticalDetails property.

public List<Opticals> GetOpticalDetails(string frameMaterial,string lensCoating)

This method is used to retrieve the optical details from the  OpticalDetails based on the Frame Material and Lens Coating.

If the frame material and lens coating is present in the OpticalDetails, store it in a list and return it.

If the frame material and lens coating is not present in the OpticalDetails, then return an empty List.

public List<Opticals> SortByPrice()

This method is used to sort the opticals by the price, from highest to lowest. 

Then add the sorted values as list and return that.

 

 

In Program class, Main method, 

1.    Get the values from the user.

2.    Call the methods accordingly and display the result.

      -- If the AddOpticalDetails method adds correctly, then display Added  successfully 

      -- If the GetOpticalDetails method returns an empty List, then display Product not found

3.    In the Sample Input / Output provided, the highlighted text in bold corresponds to the input given by the user and the remaining text represents the output.

 

Note:

-  Keep the properties, methods and classes as public.

-  Please read the method rules clearly.

-  Do not use Environment.Exit() to terminate the program.

-  Do not change the given code template.

 

Sample Input / Output:

1. Add optical details

2. Get optical details

3. Sort by price

4. Exit

Enter your choice

1

Enter the frame material

Plastic

Enter the lens coating

Anti-scratch

Enter the lens price

2500

 

Added  successfully 

 

1. Add optical details

2. Get optical details

3. Sort by price

4. Exit

Enter your choice

1

Enter the frame material

Metal

Enter the lens coating

UV protection

Enter the lens price

3000

 

Added  successfully 

 

1. Add optical details

2. Get optical details

3. Sort by price

4. Exit

Enter your choice

1

Enter the frame material

Acetate

Enter the lens coating

Anti-reflective

Enter the lens price

1700

 

Added  successfully 

 

1. Add optical details

2. Get optical details

3. Sort by price

4. Exit

Enter your choice

2

Enter the frame material

Metal

Enter the lens coating

UV protection

 

Frame Material               Lens Coating               Price

Metal                                UV protection              3000

 

1. Add optical details

2. Get optical details

3. Sort by price

4. Exit

Enter your choice

3 

 

Frame Material              Lens Coating              Price

Metal                               UV protection             3000

 Plastic                            Anti-scratch                2500

Acetate                           Anti-reflective             1700

 

 

1. Add optical details

2. Get optical details

3. Sort by price

4. Exit

Enter your choice

4
*/

using System;
using System.Collections.Generic;
using System.Linq;
class Opticals{
    public string FrameMaterial{get;set;}
    public string LensCoating{get;set;}
    public double Price{get;set;}
}
class Program{
    public static SortedDictionary<int,Opticals> OpticalDetails{get;set;}=new SortedDictionary<int,Opticals>();
}
class OpticalUtility{
    private int k=1;
    public void AddOpticalDetails(string frameMaterial,string lensCoating,double price){
        
        Program.OpticalDetails.Add(k++,new Opticals{FrameMaterial=frameMaterial,LensCoating=lensCoating,Price=price});
    }
    public List<Opticals> GetOpticalDetails(string frameMaterial,string lensCoating){
       return Program.OpticalDetails.Values.Where(i=>i.FrameMaterial==frameMaterial && i.LensCoating==lensCoating).ToList();
    }
    public List<Opticals> SortByPrice(){
        return Program.OpticalDetails.Values.OrderByDescending(i=>i.Price).ToList();
    }
}
/*using System;
using System.Collections.Generic;
using System.Linq;
class Opticals{
    public string FrameMaterial{get;set;}
    public string LensCoating{get;set;}
    public double Price{get;set;}
}
class Program{
    public static SortedDictionary<int,Opticals> OpticalDetails{get;set;}=new SortedDictionary<int,Opticals>();
    public static void Main(){
        OpticalUtility o=new OpticalUtility();
        o.AddOpticalDetails("surd","teel",123.98);
        o.AddOpticalDetails("surdty","teelty",123.976);
        o.AddOpticalDetails("surd","teelna",123.986);
        var l1=o.GetOpticalDetails("surdty","teeltiy");
        if(l1.Count>0){
            foreach(var item in l1){
                Console.WriteLine($"{item.FrameMaterial}_{item.LensCoating}_{item.Price}");
            }
        }
        var l2=o.SortByPrice();
        if(l2.Count>0){
            foreach(var item in l2){
                Console.WriteLine($"{item.FrameMaterial}_{item.LensCoating}_{item.Price}");
            }
        }
        
        
    }
}
class OpticalUtility{
    private int k=1;
    public void AddOpticalDetails(string frameMaterial,string lensCoating,double price){
        
        Program.OpticalDetails.Add(k++,new Opticals{FrameMaterial=frameMaterial,LensCoating=lensCoating,Price=price});
    }
    public List<Opticals> GetOpticalDetails(string frameMaterial,string lensCoating){
       return Program.OpticalDetails.Values.Where(i=>i.FrameMaterial==frameMaterial && i.LensCoating==lensCoating).ToList();
    }
    public List<Opticals> SortByPrice(){
        return Program.OpticalDetails.Values.OrderByDescending(i=>i.Price).ToList();
    }
}*/
