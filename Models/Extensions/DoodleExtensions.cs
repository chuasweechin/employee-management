using System;

namespace EmployeeManagement.Models.Extensions
{
  public static class DoodleExtensions
  {
    public static void Roaring(this Doodle doodle) {
      doodle.Said();
      Console.WriteLine("THEN IT ROAR FROM EXTENSIONS");
		}
  }
}
