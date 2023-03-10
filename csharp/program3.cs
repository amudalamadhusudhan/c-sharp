using System;

namespace myprogram
{
 class Car 
{
 public string color = "red";
  static void m()
   {
    Console.WriteLine("this is Method");
        Console.WriteLine(color);

   }

  static void Main(string[] args)
  {
    Tractor obj = new Tractor();
    Console.WriteLine(obj.colors);
    Console.WriteLine("hello");
    obj.c(10);//passing value
    int b =Convert.ToInt32 (Console.ReadLine());
    
    Console.WriteLine("valu of"+b);
    double d =Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("value of double "+d);
    string s =Console.ReadLine();
    Console.WriteLine("string\n"+s);
    m();
  }
}
class Tractor
{
  public Tractor()
 {
    Console.WriteLine("this is constructor");
 }
 public string colors="y";
 public void c (int a)
 {
    Car objs = new Car();
Console.WriteLine("a value"+a);
 Console.WriteLine(objs.color);

 }
}
 
}

                           