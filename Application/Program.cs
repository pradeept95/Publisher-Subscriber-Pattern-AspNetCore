using Application.Event.Publisher;
using Application.Event.Subscriber;
using Application.EventType.Data;
using HotBag.AspNetCore.EventBus;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FileLogSubscriber sub = new FileLogSubscriber();
            sub.InitializeSubscription();

            //Task.Run(() => { 
            //    FileLogSubscriber sub = new FileLogSubscriber();
            //});


            //Task.Run(() => { 
            //    LogPublisher pub = new LogPublisher();
            //    pub.PublishLog(new EventType.Data.FileLoggerMessage { });
            //});

            var message = new FileLoggerMessage();
            LogPublisher pub = new LogPublisher();

            while (true)
            {
               
                Console.WriteLine("Enter Title:>>>");
                message.Title = Console.ReadLine();

                Console.WriteLine("Enter Description:>>>");
                message.Detail = Console.ReadLine();  
                pub.PublishLog(message);
                Console.WriteLine("\n-------------------------------------------------------\n");
            }


            Console.ReadLine();
        }
    }
}
