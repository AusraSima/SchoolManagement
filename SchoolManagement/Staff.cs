namespace SchoolManagement
{
	public class Staff : Person
	{
		public string EmployeeId { get; set; }
		public string Department { get; set; }
		public decimal Salary { get; set; }
		public DateOnly HireDate { get; set; }

		public override string GetRole()
		{
			return "Employee";
		}
		public override string GetProfile()
		{
			return $"Name: {FirstName} {LastName}\n" +
				   $"Birthday: {Birthday}\n" +
				   $"Email: {Email}\n" +
				   $"Employee ID: {EmployeeId}\n" +
				   $"Department: {Department}\n" +
				   $"Salary: {Salary:C}\n" +
				   $"Hire Date: {HireDate}";
		}
		public override string GetContactInfo()
		{
			return $"Email: {Email}\n" +
				   $"Department: {Department}";
		}
		public virtual decimal CalculateAnnualBonus()
		{
			if ((HireDate.Year % DateTime.Now.Year) % 5 == 0)
			{
				return (Salary * 0.05m) + Salary;
			}
			else
			{
				return Salary;
			}
		}
	}
}
