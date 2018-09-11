using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.Sleep(5000);
            Console.WriteLine("ConsoleApp1");
           var connection = new HubConnectionBuilder()
           .WithUrl("http://localhost:8082/chatHub")
           .Build();
            connection.On<string, string>("ReceiveMessage", (user, message) =>
            {
                Console.WriteLine($"{user}: {message}");
            });
            connection.StartAsync().GetAwaiter().GetResult();
            connection.InvokeAsync("SendMessage", "ConsoleApp1", "Hello World!1");
            Console.ReadKey(false);
        }
    }
}
