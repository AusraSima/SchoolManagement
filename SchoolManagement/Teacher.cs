using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			return base.GetProfile() + $"\nSubject Area: {SubjectArea}\nCourses Taught: {string.Join(", ", CoursesTaught)}\nTeaching Rating: {TeachingRating}";
		}
		public override decimal CalculateAnnualBonus()
		{
			if (TeachingRating >= 4.5)
			{
				return (Salary * 0.10m) + Salary;
			}
			else
			{
				return Salary;
			}
		}
	}
}
