using System;

namespace myprogram
{
    class Car
    {
        public string color = "red";
        static void m(int a, int b)
        {
            Console.WriteLine("this is named parameters" + (a + b));
        }
        static void r(ref int v)
        {
            Console.WriteLine("this is ref  parameters" + (++v));

        }
        static void h(out int v1, out int v2)
        {
            v1 = 11;
            v2 = 13;
            Console.WriteLine("this is out  parameters" + (++v1));
            Console.WriteLine("this is out  parameters" + (++v2));
        }
        static void d(int a, int b)
        {
            Console.WriteLine("this is default parameters" + (a + b));
        }
        static void dy(dynamic d)
        {
            int a = d * d;
            Console.WriteLine("this is dynamic parameters" + a);

        }
        static void va(int a, int b)
        {

            Console.WriteLine("this is value type parameters" + (a + b));

        }
        static void pa(params int[] n)
        {
            int s = 0;
            foreach (int k in n)
            {
                s = s + k;
            }
            Console.WriteLine("this is value param type parameters" + s);

        }


        static void Main(string[] args)
        {
            Tractor obj = new Tractor();
            Console.WriteLine(obj.colors);
            Console.WriteLine("hello");
            obj.c(10);//passing value
            // int b = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("valu of" + b);
            // double d = Convert.ToDouble(Console.ReadLine());

            // Console.WriteLine("value of double " + d);
            // string s = Console.ReadLine();
            // Console.WriteLine("string\n" + s);

            m(a: 1, b: 2);
            int v = 2, v1, v2;
            r(ref v);
            h(out v1, out v2);
            d(1, 3);
            dy(7);
            int q = 2, w = 3;
            va(q, w);
            pa(1, 2, 3, 4, 5);
        }
    }
    class Tractor
    {
        public Tractor()
        {
            Console.WriteLine("this is constructor");
        }
        public string colors = "y";
        public void c(int a)
        {
            Car objs = new Car();
            Console.WriteLine("a value" + a);
            Console.WriteLine(objs.color);

        }
    }

}


