using Practical_7.Models;

namespace Practical_7.Extensions
{
	public static class EmployeeExtensions
	{
		public static decimal CalculateAnnualSalary(this Employee employee)
		{
			
			return employee.Salary * 12;
		}
	}
}
