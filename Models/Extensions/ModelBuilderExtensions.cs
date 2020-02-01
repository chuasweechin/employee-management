using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models.Extensions
{
  public static class ModelBuilderExtensions
  {
		public static void Seed(this ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Employee>().HasData(
					new Employee
					{
						Id = 90,
						Name = "Mark",
						Email = "Mark@gmail.com",
						Department = "Hive"
					}
			);
		}
  }
}
