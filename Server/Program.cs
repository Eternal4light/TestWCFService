using System;
using System.ServiceModel;
using static System.Console;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Title = "Server";

            Uri address = new Uri("http://localhost:4000/IService");
            BasicHttpBinding binding = new BasicHttpBinding();
            Type contract = typeof(IService);

            ServiceHost host = new ServiceHost(typeof(Service));
            host.AddServiceEndpoint(contract, binding, address);
            host.Open();

            WriteLine("Приложение готово к приему сообщений.");
            ReadLine();
        }
    }
}
