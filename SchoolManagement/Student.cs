namespace SchoolManagement
{
	internal class Student : Person
	{
		public string StudentId { get; set; }
		public string Program { get; set; }
		public double GPA { get; set; }
		public DateOnly EnrollmentYear { get; set; }
		public override string GetRole()
		{
			return "Student";
		}
		public override string GetProfile()
		{
			return $"Name: {FirstName} {LastName}\n" +
				   $"Birthday: {Birthday}\n" +
				   $"Email: {Email}\n" +
				   $"Student ID: {StudentId}\n" +
				   $"Program: {Program}\n" +
				   $"GPA: {GPA}\n" +
				   $"Enrollment Year: {EnrollmentYear}";
		}
		public virtual string GetAcademicStanding()
		{
			if (GPA >= 9.5)
			{
				return "Dean's List";
			}
			else if (GPA >= 7.0)
			{
				return "Good Standing";
			}
			else if (GPA >= 4.0)
			{
				return "Satisfactory";
			}
			else
			{
				return "Academic Probation";
			}

		}
	}
}
