using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace EmployeeManagement.Mediator
{
  public class Notifier1 : INotificationHandler<NotificationMessage>
  {
    public Task Handle(NotificationMessage notification, CancellationToken cancellationToken)
    {
      Console.WriteLine($"Debugging from Notifier 1. Message  : {notification.NotifyText} ");
      return Task.CompletedTask;
    }
  }

  public class Notifier2 : INotificationHandler<NotificationMessage>
  {
    public Task Handle(NotificationMessage notification, CancellationToken cancellationToken)
    {
      Console.WriteLine($"Debugging from Notifier 2. Message  : {notification.NotifyText} ");
      return Task.CompletedTask;
    }
  }

  public class Notifier3 : INotificationHandler<NotificationMessage>
  {
    public Task Handle(NotificationMessage notification, CancellationToken cancellationToken)
    {
      Console.WriteLine($"Debugging from Notifier 3. Message  : {notification.NotifyText} ");
      return Task.CompletedTask;
    }
  }
}