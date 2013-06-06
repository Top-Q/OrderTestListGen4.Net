using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Reflection.Assembly o = System.Reflection.Assembly.LoadFile(  @"C:\workspaces\ClickSoftware\TestProject2\TestProject2\bin\Debug\TestProject2.dll");


            
            var project=o.GetModules()[0];
            var xxx = project.GetTypes();

            foreach(var className in xxx)
            {
                var methods= className.GetMethods();
                foreach (var method in methods)
                {
                    var att= method.Attributes;
                    var x = method.GetCustomAttributes(false);
                    foreach (var o1 in x)
                    {
                        Console.WriteLine(o1.ToString());
                    }
                }
            }


        }
    }
}
