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
		public override string GetAcademicStanding()
		{
			if (GPA >= 9.5)
			{
				return "Distinction";
			}
			else if (GPA >= 7.0)
			{
				return "Merit";
			}
			else if (GPA >= 4.0)
			{
				return "Pass";
			}
			else
			{
				return "At Risk";
			}
		}
	}
}
