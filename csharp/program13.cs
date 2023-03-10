using System;  
namespace program
{

public class ExExample  
{  
    public static void Main(string[] args)  
    {  
        try
{
  int[] myNumbers = {1, 2, 3};
  Console.WriteLine(myNumbers[10]);
}
catch (Exception e)
{
  Console.WriteLine(e);
}
        finally 
        {
             Console.WriteLine("Finally block is executed");
              }  
        Console.WriteLine("Rest of the code");  
    }  
}  
}