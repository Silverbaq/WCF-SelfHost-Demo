using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace SelfHostServiceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ServiceHost studentServiceHost = null;
            try
            {
                ////Base Address for Service
                //Uri httpBaseAddress = new Uri("http://localhost:54321/Hello");

                ////Instantiate ServiceHost
                //studentServiceHost = new System.ServiceModel.ServiceHost(typeof(SelfHostServiceDemo.Service1),httpBaseAddress);

                ////Add Endpoint to Host
                //studentServiceHost.AddServiceEndpoint(typeof(IService1), new WSHttpBinding(), "");

                ////Metadata Exchange
                //ServiceMetadataBehavior serviceBehavior = new ServiceMetadataBehavior();
                //serviceBehavior.HttpGetEnabled = true;
                //studentServiceHost.Description.Behaviors.Add(serviceBehavior);

                //Open
                studentServiceHost.Open();
                Console.WriteLine("Service is live now at: { 0}", "");
                Console.ReadKey();
            }

            catch (Exception ex)
            {
                studentServiceHost = null;
                Console.WriteLine("There is an issue with StudentService" +ex.Message);
            }

        }
    }
}
