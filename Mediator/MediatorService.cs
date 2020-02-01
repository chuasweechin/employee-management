using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeManagement.Events;
using MediatR;

namespace EmployeeManagement.Mediator
{
  public class MediatorService : IMediatorService
	{
		private readonly IMediator _mediator;

		public MediatorService(IMediator mediator)
		{
			_mediator = mediator;
		}

		public void Notify(string notifyText)
		{
			_mediator.Publish(new NotificationMessage { NotifyText = notifyText });
		}

		public void Query(string queryText)
		{
			_mediator.Publish(new QueryMessage { QueryText = queryText });
		}
	}
}
