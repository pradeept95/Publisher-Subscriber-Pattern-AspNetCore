using Application.EventType.Data;
using HotBag.AspNetCore.EventBus;
using System;

namespace Application.Event.Subscriber
{
    public class FileLogSubscriber : SubscriberBase
    {
        Subscription<FileLoggerMessage> fileLoggerToken; 

        public void InitializeSubscription()
        {
            eventBus.Subscribe<FileLoggerMessage>(this.LogInFile);
        }

        private void LogInFile(FileLoggerMessage fileLoggerMessage)
        {
            Console.WriteLine($"===============================");
            Console.WriteLine($"=== { fileLoggerMessage.Title } ===");
            Console.WriteLine($"{fileLoggerMessage.Detail}");
            Console.WriteLine($"===============================");

            eventBus.UnSbscribe(fileLoggerToken);
        } 
    }
}
