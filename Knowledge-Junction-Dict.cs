/*Scenario:

Knowledge Junction is a popular local library located in a bustling neighborhood. They have decided to modernize their operations and have 
enlisted your help as a software consultant to develop a comprehensive library management application using C#. The application will help streamline 
their daily tasks and improve the overall library experience for both staff and patrons. 



Functionalities:

1.  class Book

Implement the below-given properties

Data Type

Property Name

string

Title

string

Author

  int

ISBN

  string

Genre

 

2.  class Program

Implement the below-given static property

Data Type

         Property Name

Dictionary<int, Book> 

          Catalog

 

3.  class BookUtility

Implement the below-given methods

Method

Rules

public bool AddBookDetails(int isbn, string title, string author, string genre)

This method is used to add the book details to the Catalog property.

Check whether the ISBN already exists or not.

If not, then add the book details to the Catalog and return true. else, return false.

Note: In the Catalog, add the ISBN as the key and the Book object as the value.

public List<Book> UpdateCatalog(int isbn,string author)

This method is used to find the isbn in the Catalog.

If the isbn is present in the Catalog, then update the author and return the entire updated catalog details.

If the isbn is not present in the Catalog, then return an empty List.

public List<Book> RemoveBookDetails(int isbn)

This method is used to remove the book details by isbn.

If the isbn is present in the  Catalog,  then remove that details and return the remaining Catalog details as a List. else, return an empty List.

 

 

In Program class, Main method, 

1.    Get the values from the user.

2.    Call the methods accordingly and display the result.

      -- If the AddBookDetails method returns true, then display Added  successfully, else display Not Added.

      -- If the UpdateCatalog method returns an empty List, then display Not updated.

     -- If the RemoveBookDetails method returns an empty List, then display ISBN not found

3.    In the Sample Input / Output provided, the highlighted text in bold corresponds to the input given by the user and the remaining text represents the output.

 

Note:

-  Keep the properties, methods and classes as public.

-  Please read the method rules clearly.

-  Do not use Environment.Exit() to terminate the program.

-  Do not change the given code template.

 

 

Sample Input / Output:

1. Add book details

2. update catalog details 

3. Remove book details

4. Exit

Enter your choice

1

Enter the ISBN

123456

Enter the Title

The Midnight Garden

Enter the Author

Emily Rivers

Enter the Genre

Fantasy

 

Added successfully

 

1. Add book details

2. update catalog details 

3. Remove book details

4. Exit

Enter your choice

1

Enter the ISBN

138456

Enter the Title

Whispers in the Wind

Enter the Author

Sarah Mitchell

Enter the Genre

Mystery

 

Added successfully

 

1. Add book details

2. update catalog details 

3. Remove book details

4. Exit

Enter your choice

1

Enter the ISBN

138450

Enter the Title

Serenity's Song

Enter the Author

Isabella Williams

Enter the Genre

Romance

 

Added successfully

  

1. Add book details

2. update catalog details 

3. Remove book details

4. Exit

Enter your choice

2

Enter the ISBN

123456

Enter the Author

Jonathan Harper 

 

ISBN                            Title                                         Author                                 Genre

123456                       The Midnight Garden            Jonathan Harper               Fantasy

138456                        Whispers in the Wind           Sarah Mitchell                    Mystery

138450                        Serenity's Song                     Isabella Williams                Romance

 

1. Add book details

2. update catalog details 

3. Remove book details

4. Exit

Enter your choice

3

Enter the ISBN

138456

 

ISBN                            Title                                         Author                               Genre

123456                       The Midnight Garden           Jonathan Harper              Fantasy

138450                        Serenity's Song                     Isabella Williams             Romance

 

1. Add book details

2. update catalog details 

3. Remove book details

4. Exit

Enter your choice

4

----------------------------------------------------------------------------------
Answer:*/
using System;
using System.Collections.Generic;
using System.Linq;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int ISBN { get; set; }
    public string Genre { get; set; }
}

public class Program
{
    public static Dictionary<int, Book> Catalog{get;set;} = new Dictionary<int, Book>();
}

public class BookUtility
{
    public bool AddBookDetails(int isbn, string title, string author, string genre)
    {
        if (!Program.Catalog.ContainsKey(isbn))
        {
            Program.Catalog.Add(isbn, new Book { Title = title, Author = author, Genre = genre, ISBN = isbn });
            return true;
        }
        else
        {
            return false;
        }
    }

    public List<Book> UpdateCatalog(int isbn, string author)
    {
        if (Program.Catalog.ContainsKey(isbn))
        {
            Program.Catalog[isbn].Author = author;
            return Program.Catalog.Values.ToList();
        }
        else
        {
            return new List<Book>();
        }
    }

    public List<Book> RemoveBookDetails(int isbn)
    {
        if (Program.Catalog.ContainsKey(isbn))
        {
            Program.Catalog.Remove(isbn);
            return Program.Catalog.Values.ToList();
        }
        else
        {
            return new List<Book>();
        }
    }
}
