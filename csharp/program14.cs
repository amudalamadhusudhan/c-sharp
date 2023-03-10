using System;  
using System.Collections.Generic;  
namespace Listprogram
{
  
public class ListExample  
{  
    public static void Main(string[] args)  
    {  
        // Create a list of strings  
        List<int> names = new List<int>();  
        names.Add(1);  
        names.Add(2);  
        names.Add(3);  
        names.Add(3);  
  
        // Iterate list element using foreach loop  
        foreach (int n in names)  
        {  
            Console.WriteLine(n);  
        }  
    }  
}  
}