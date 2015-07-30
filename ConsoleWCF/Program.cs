using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new System.ServiceModel.ServiceHost(typeof(ConsoleWCF.Service1));
            host.Open();

            Console.WriteLine("Service is running");
            Console.ReadLine();
        }
    }
}
