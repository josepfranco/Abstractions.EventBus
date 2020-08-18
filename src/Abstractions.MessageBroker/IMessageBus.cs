using System;

namespace Abstractions.MessageBroker
{
    /// <summary>
    /// 
    /// </summary>
    public interface IMessageBus : ISubscriber, IPublisher, IDisposable
    {
        
    }
}