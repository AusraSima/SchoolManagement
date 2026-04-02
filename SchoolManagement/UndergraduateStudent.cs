namespace SchoolManagement
{
	internal class UndergraduateStudent : Student
	{
		public string Minor { get; set; }
		public string Major { get; set; }
		public double TotalCredits { get; set; }
		public override string GetRole()
		{
			return base.GetRole();
		}
		public override string GetProfile()
		{
			return base.GetProfile() + $"\nMinor: {Minor}\nNajor: {Major}\nTotal Credits: {TotalCredits}";
		}
		public override string GetAcademicStanding()
		{
			if (GPA >= 9.5)
			{
				return "Senior";
			}
			else if (GPA >= 7.0)
			{
				return "Junior";
			}
			else if (GPA >= 4.0)
			{
				return "Sophomore";
			}
			else
			{
				return "Freshman";
			}
		}
	}
}
