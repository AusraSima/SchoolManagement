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
			return $"Name: {FirstName} {LastName}\t Birthday: {Birthday}\t Email: {Email}\t Student ID: {StudentId}\t Program: {Program}\t GPA: {GPA}\t Enrollment Year: {EnrollmentYear}";
		}
		public virtual string GetAcademicStanding(double GPA)
		{
			switch (GPA)
			{
				case >= 9.5:
					return "Dean's List";
					break;
				case >= 7.0:
					return "Good Standing";
					break;
				case >= 4.0:
					return "Satisfactory";
					break;
				case < 4.0:
					return "Academic Probation";
					break;
				default:
					return "Unknown";
					break;
			}
		}
	}
}
