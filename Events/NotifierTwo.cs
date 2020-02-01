using System;

namespace EmployeeManagement.Events
{
	public class NotifierTwo : INotifier
	{
		public void Notify()
		{
			Console.WriteLine("Hello from Two");
		}
	}
}
