using Abstractions.MessageBroker.Models;

namespace Abstractions.MessageBroker
{
    public interface IPublisher
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        void Publish(IMessage message);
    }
}