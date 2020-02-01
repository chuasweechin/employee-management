using MediatR;

namespace EmployeeManagement.Mediator
{
  public class QueryMessage : INotification
  {
    public string QueryText { get; set; }
  }
}