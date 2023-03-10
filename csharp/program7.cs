using System;
namespace inheritprogram
{
    public class upperbase 
    {
public void up()
{
    Console.WriteLine("upper base class");
}
    }
class class1: upperbase
{
    public void s()
    {
        Console.WriteLine("base class");
    }
}
class program :class1
{
    public void d()
    {
        Console.WriteLine("child class or drived class");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("helloworld");
        program ob =new program();
        ob.s();
        ob.d();
        ob.up();
    }
}
}