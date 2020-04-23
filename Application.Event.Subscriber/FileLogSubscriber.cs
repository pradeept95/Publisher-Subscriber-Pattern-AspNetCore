using Application.EventType.Data;
using HotBag.AspNetCore.EventBus;
using System;

namespace Application.Event.Subscriber
{
    public class FileLogSubscriber
    {
        Subscription<FileLoggerMessage> fileLoggerToken;
        EventBus eventBus;

        public FileLogSubscriber()
        {
            eventBus = EventBus.Instance;
           
        }

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
