using System.Threading;
using System.Threading.Tasks;
using Abstractions.EventBus.Models;

namespace Abstractions.EventBus
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TMessage"></typeparam>
    public interface IMessageHandler<in TMessage> where TMessage : IMessage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="token">the cancellation token</param>
        /// <returns></returns>
        Task HandleAsync(TMessage message, CancellationToken token = default);
    }
}