using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExample_OverloadStaticMethods
{
    internal class myclass
    {
        /*
Method Overloading It doesn't depend on method return type and static method or non-static method it will always follow method name should be same and Parameters should be different. 
Same method combination should not repeat.
If you repeat same combination it will throw compile time error.
        */

        internal static void print()//0 parameter static method
        {
            Console.WriteLine("zero parameter is calling");
        }
        internal static void print(int a)//single parameter static method
        {
            Console.WriteLine("one parameter print :" + a);
        }
        internal static void print(int a,int b)//Two parameter static method
        {
            int result = a + b;
            Console.WriteLine("Two parameter print :" + result);
        }
        internal static void print(int a, int b,int c)//Three parameter static method
        {
            int result = a + b+c;
            Console.WriteLine("Three parameter print :" + result);
        }
        internal static void print(int a, int b, int c,int d)//Four parameter static method
        {
            int result = a + b + c+d;
            Console.WriteLine("Four parameter print :" + result);
        }
        internal static void print(int a, int b, int c, int d,int e)//Five parameter static method
        {
            Console.WriteLine("Five parameter print :" + a + b + c+d+e);
        }
        /*   don't repeat same combination in normal methods (or)static methods in overloading concept
        internal static void print(int a)//if same combination is repeat it will throw compiletime error
        {
            Console.WriteLine("one parameter print :" + a);
        }
        */
        //overloading doesn't depend method return type  and static or non static method.it will always depeds on methodname same and parameter should be diffrent
       /*
        internal string print(int a)//single parameter  non static method(here it is throwing compile time error)same combination repeated.
        {
            Console.WriteLine("one parameter print :" + a);
            return "abc";
        }
        internal void print(int a)//single parameter  non static method(here it is throwing compile time error)same combination repeated.
        {
            Console.WriteLine("one parameter print :" + a);
            
        }
       */

    }
}
