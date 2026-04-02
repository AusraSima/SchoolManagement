using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
	internal class Administrator : Staff
	{
		public string Office { get; set; }
		public List<string> Responsibilities { get; set; }
		public override string GetRole()
		{
			return "Administrator";
		}
		public override string GetProfile()
		{
			return base.GetProfile() + $"\nOffice: {Office}\nResponsibilities: {string.Join(", ", Responsibilities)}";
		}
		public override decimal CalculateAnnualBonus()
		{
			return Salary + 500;
		}
	}
}
