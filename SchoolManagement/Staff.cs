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
			return $"Name: {FirstName} {LastName}\t Birthday: {Birthday}\t Email: {Email}\t Employee ID: {EmployeeId}\t Department: {Department}\t Salary: {Salary:C}\t Hire Date: {HireDate}";
		}
		public override string GetContactInfo()
		{
			return $"Email: {Email}\t Department: {Department}";
		}
		public virtual decimal CalculateAnnualBonus()
		{
			if ((HireDate.Year % DateTime.Now.Year) % 5 == 0)
			{
				return Salary * 1.05m;
			}
			else
			{
				return Salary;
			}
		}
	}
}
