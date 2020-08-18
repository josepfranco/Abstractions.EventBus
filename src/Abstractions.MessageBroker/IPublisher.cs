using Abstractions.EventBus.Models;

namespace Abstractions.EventBus
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