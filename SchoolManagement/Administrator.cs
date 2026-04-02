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
			return $"{base.GetProfile()}\t Office: {Office}\t Responsibilities: {string.Join(", ", Responsibilities)}";
		}
		public override decimal CalculateAnnualBonus()
		{
			return Salary + 500;
		}
	}
}
