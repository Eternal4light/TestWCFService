using System;
using System.ServiceModel;
using static System.Console;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Title = "Client";

            Uri address = new Uri("http://localhost:4000/IService");
            BasicHttpBinding binding = new BasicHttpBinding();
            EndpointAddress endpointAddress = new EndpointAddress(address);

            ChannelFactory<IService> factory = new ChannelFactory<IService>(binding, endpointAddress);
            IService channel = factory.CreateChannel();

            StartInteraction(channel);

        }

        private static void StartInteraction(IService channel)
        {
            while (true)
            {
                WriteLine("Введите сообщение для передачи на сервер:");
                string input = ReadLine();
                channel.Say(input);
                WriteLine("Done");
            }
        }
    }
}
