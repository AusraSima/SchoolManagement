namespace SchoolManagement
{
	internal class GraduateStudent : Student
	{
		public string ThesisTitle { get; set; }
		public string Supervisor { get; set; }
		public DateOnly ThesisSubmitted { get; set; }
		public override string GetRole()
		{
			return base.GetRole();
		}
		public override string GetAcademicStanding(double GPA)
		{
			switch (GPA)
			{
				case >= 9.5:
					return "Distinction";
					break;
				case >= 7.0:
					return "Merit";
					break;
				case >= 4.0:
					return "Pass";
					break;
				case < 4.0:
					return "At Risk";
					break;
				default:
					return "Unknown";
					break;
			}
		}
	}
}
