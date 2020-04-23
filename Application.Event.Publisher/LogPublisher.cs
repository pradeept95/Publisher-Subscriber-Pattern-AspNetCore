

using Application.EventType.Data;
using HotBag.AspNetCore.EventBus;

namespace Application.Event.Publisher
{
    public class LogPublisher
    {
        EventBus bus;
        public LogPublisher()
        {
            bus = EventBus.Instance; 
        }

        public void PublishLog(FileLoggerMessage fileLoggerMessage)
        {
            //EventAggregator.Publish<string>("this is log message");
            //EventAggregator.Publish(10);

            bus.Publish<FileLoggerMessage>(fileLoggerMessage);
        }
    }
}
