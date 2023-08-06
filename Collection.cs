/* Online C# Compiler and Editor */
// 
using System;
using System.Collections.Generic;
  namespace Collection{
      public class CollectionEx
      {
          public void ExampleofList(){
           Console.WriteLine("This is example of generic collection using List<T>");
          //  generic collection using List<T>
        // Creating a List of integers
        List<int> mylist = new List<int>();
  
        // adding items in mylist
        for (int j = 5; j < 10; j++) {
            mylist.Add(j * 3);
        }
  
        // Displaying items of mylist
        // by using foreach loop
        foreach(int items in mylist)
        {
            Console.WriteLine(items);
        }
          }
      }
      
public class Collection {
  
    // Main Method
    public static void Main(String[] args)
    {
  CollectionEx col =new CollectionEx();
  col.ExampleofList();
    }
}
}
