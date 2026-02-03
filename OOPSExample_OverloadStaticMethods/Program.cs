using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExample_OverloadStaticMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //==========overloading static methods==================
            //static methods we are calling with(classname.methodname());
            myclass.print();//0 parameter combination method calling
            myclass.print(10);//single parameter combination method calling
            myclass.print(10, 20);//Two parameter combination method calling
            myclass.print(10, 20,30);//Three parameter combination method calling
            myclass.print(10, 20,30,40);//Four parameter combination method calling
            myclass.print(10, 20, 30, 40,50);//Five parameter combination method calling

            //===========overload normal methods======================
            //non static methods we are calling with (objectname.methodname());
            myclass obj = new myclass();
            obj.print("10");
            obj.print("10", "20");
            obj.print("10", "20", "30");
            obj.print("10", "20", "30", "40");
        }
    }
}
/*output:
zero parameter is calling
one parameter print :10
Two parameter print :30
Three parameter print :60
Four parameter print :100
Five parameter print :1020304050

*/