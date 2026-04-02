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
		public override string GetAcademicStanding(double GPA)
		{
			switch (GPA)
			{
				case >= 9.5:
					return "Senior";
					break;
				case >= 7.0:
					return "Junior";
					break;
				case >= 4.0:
					return "Sophomore";
					break;
				case < 4.0:
					return "Freshman";
					break;
			}
			return "Unknown";
		}
	}
}

