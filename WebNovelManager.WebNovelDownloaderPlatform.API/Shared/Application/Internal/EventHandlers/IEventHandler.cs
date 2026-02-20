using WebNovelManager.WebNovelDownloaderPlatform.API.Shared.Domain.Model.Events;

using Cortex.Mediator.Notifications;

namespace WebNovelManager.WebNovelDownloaderPlatform.API.Shared.Application.Internal.EventHandlers;

public interface IEventHandler<in TEvent> : INotificationHandler<TEvent> where TEvent : IEvent
{
    
}