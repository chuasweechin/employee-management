using MediatR;

namespace EmployeeManagement.Mediator
{
  public class NotificationMessage : INotification
  {
    public string NotifyText { get; set; }
  }
}