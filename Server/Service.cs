using System;

namespace Server
{
    public class Service : IService
    {
        public void Say(string input)
        {
            Console.WriteLine($"Сообщение: {input}");
        }
    }
}
