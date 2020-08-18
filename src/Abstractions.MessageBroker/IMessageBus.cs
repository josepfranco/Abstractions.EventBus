using System;

namespace Abstractions.EventBus
{
    /// <summary>
    /// 
    /// </summary>
    public interface IMessageBus : ISubscriber, IPublisher, IDisposable
    {
        
    }
}