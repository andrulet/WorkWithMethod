using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            A p = new A();
            p.i = 10;
            //Hello();
            //Lesson.Math(b:8,a:4);
            //int par = 9;           
            //Increment(par);
            Increment(ref p);
            Console.WriteLine(p.i);
            Console.ReadKey();
        }

        static void Increment(ref A a)
        {
            a = new A();
            a.i++;
        }

        //static void Hello()
        //{
        //    Console.WriteLine("Yes!!");
        //}

        //static void Increment(int x)
        //{
        //    //x++;
        //    x = 10;
        //}

    }

    //class Lesson
    //{
    //    public static void Math(int a,int b=5,params int[] r)
    //    {
    //        int s = a + b;
    //        Console.WriteLine($"Result: {s} ");
    //    }
    //}

    class A
    {
        public int i;
    }
}
