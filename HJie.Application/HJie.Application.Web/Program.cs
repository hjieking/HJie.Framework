using HJie.Lib.Util;
using System;

namespace HJie.Application.Web
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = new AssemblyHelper().GetAllType();
            Console.WriteLine(res);
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
