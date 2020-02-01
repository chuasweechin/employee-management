using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace EmployeeManagement.Mediator
{
  public class Query : INotificationHandler<QueryMessage>
  {
    public Task Handle(QueryMessage query, CancellationToken cancellationToken)
    {
      Console.WriteLine($"Debugging from Query Message  : { query.QueryText } ");
      return Task.CompletedTask;
    }
  }
}