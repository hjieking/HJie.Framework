using HJie.Lib.Server;
using HJie.Lib.Util;
using System;
using System.Threading.Tasks;

namespace HJie.Application.Web
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(async() =>
            {
                var res = new Server();
                await res.Run();
            });
            Console.ReadKey();
        }
    }
}
