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
			return $"{base.GetProfile()}\t Team Size: {TeamSize}\t Department Vision: {DepartmentVision}";
		}
		public override string GetContactInfo()
		{
			return base.GetContactInfo();
		}
		public override decimal CalculateAnnualBonus()
		{
			if (TeamSize >= 10)
			{
				return Salary * 1.15m;
			}
			else
			{
				return base.CalculateAnnualBonus();
			}
		}
	}
}
