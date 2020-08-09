using System.Threading;
using System.Threading.Tasks;
using Abstractions.EventBus.Models;

namespace Abstractions.EventBus
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEvent"></typeparam>
    public interface IEventHandler<in TEvent> where TEvent : IEvent
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="event"></param>
        /// <param name="token">the cancellation token</param>
        /// <returns></returns>
        Task HandleAsync(TEvent @event, CancellationToken token = default);
    }
}