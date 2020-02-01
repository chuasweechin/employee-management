using System;

namespace EmployeeManagement.Events
{
  public class NotifierOne : INotifier
  {
		public void Notify()
		{
			Console.WriteLine("Hello from One");
		}
  }
}
