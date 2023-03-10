using System;

namespace myprogram
{
    class construct
    {
        // public construct()
        // {
        //     Console.WriteLine("default constructor")
        // }
        // public construct(int a, int b)
        // {
        //     Console.WriteLine("parameter constructor\n" + (a + b));
        // }
        private construct()
        {
           Console.WriteLine("private construtor");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("constructor");
            //construct d = new construct();
        }
    }
    class a
    {
         
           static void e()
           {
             construct d = new construct();

           }
    }

}