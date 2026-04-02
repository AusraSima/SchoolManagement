using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
	internal class HeadOfDepartment : Teacher
	{
		public int TeamSize { get; set; }
		public string DepartmentVision { get; set; }
		public override string GetRole()
		{
			return "Head of Department";
		}
		public override string GetProfile()
		{
			return base.GetProfile() + $"\nTeam Size: {TeamSize}\nDepartment Vision: {DepartmentVision}";
		}
		public override string GetContactInfo()
		{
			return base.GetContactInfo();
		}
		public override decimal CalculateAnnualBonus()
		{
			if (TeamSize >= 10)
			{
				return (Salary * 0.15m) + Salary;
			}
			else
			{
				return base.CalculateAnnualBonus();
			}
		}
	}
}
