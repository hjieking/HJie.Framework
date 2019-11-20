using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HJie.Lib.Server
{
    public class Server
    {
        public IWebHost Host { get; private set; }
        private string[] _urls = new string[] { };
        public Task Run()
        {
            string url = String.Format("http://localhost:5000");
            var urls = new List<string>();
            if (!_urls.Any())
            {
                urls.Add(url);
            }
            else
            {
                urls = _urls.ToList();
            }

            Host =
                 new WebHostBuilder()
                    .UseUrls(urls.ToArray())
                    .UseKestrel()
                    .Configure(app =>
                    {
                        app.Run(http =>
                        {
                            return Task.Run(() =>
                            {
                                var req = http.Request;
                                var resp = http.Response;
                                var method = http.Request.Method;
                                var path = req.Path;

                                var cacheKey = $"Request:{method}-{path}";
                                resp.StatusCode = (int)HttpStatusCode.NotFound;
                                Console.WriteLine($"Response:{resp.StatusCode} {HttpStatusCode.NotFound}");

                                return resp.WriteAsync("NotFound");
                            });
                        });
                    })
                    .Build();
            var task = Host.StartAsync();

            urls.ForEach(u =>
            {
                Console.WriteLine($"AServer listen on {u} .");
            });

            return task;
        }
    }
}
