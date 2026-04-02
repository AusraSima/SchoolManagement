namespace SchoolManagement
{
	internal class Teacher : Staff
	{
		public string SubjectArea { get; set; }
		public List<string> CoursesTaught { get; set; }
		public double TeachingRating { get; set; }
		public override string GetRole()
		{
			return "Teacher";
		}
		public override string GetProfile()
		{
			return $"{base.GetProfile()}\t Subject Area: {SubjectArea}\t Courses Taught: {string.Join(", ", CoursesTaught)}\t Teaching Rating: {TeachingRating}";
		}
		public override decimal CalculateAnnualBonus()
		{
			if (TeachingRating >= 4.5)
			{
				return Salary * 1.10m;
			}
			else
			{
				return Salary;
			}
		}
	}
}
