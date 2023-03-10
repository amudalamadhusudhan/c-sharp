using System;
namespace methodoverloading
{
    class csharp
    {
        public int add(int a, int b)
        {
            int sum =a+b;
            return sum;
        }
        public double add (double a,double b,double c)
        {
            double sum = a+b+c;
            return sum;
        }
        public static void Main(string[] args)
        {
            csharp ob =new csharp();
            int sum1 =ob.add(1,2);
            Console.WriteLine("sum of the two"+"integer value:"+sum1);
            double sum2 =ob.add(1.5,2.6,3.8);
            Console.WriteLine("sum of the three"+"integer value:"+sum2);
        }
    }
}