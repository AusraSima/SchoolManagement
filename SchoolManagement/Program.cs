namespace SchoolManagement
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var undergradutate = new UndergraduateStudent
			{
				FirstName = "John",
				LastName = "Doe",
				Birthday = new DateOnly(2006, 6, 15),
				Email = "johndoe@test.test",
				StudentId = "123456",
				Program = "Bachelor of Science",
				GPA = 3.5,
				EnrollmentYear = new DateOnly(2024, 9, 1),
				Major = "Computer Science",
				Minor = "Mathematics",
				TotalCredits = 90,
			};

			var graduate = new GraduateStudent
			{
				FirstName = "Jane",
				LastName = "Smith",
				Birthday = new DateOnly(1998, 3, 22),
				Email = "janesmith@test.test",
				StudentId = "654321",
				Program = "Master of Science",
				GPA = 7.8,
				EnrollmentYear = new DateOnly(2021, 9, 1),
				ThesisTitle = "Advanced Algorithms in Machine Learning",
				Supervisor = "E.Brown",
				ThesisSubmitted = new DateOnly(2025, 5, 1),
			};

			var teacher = new Teacher
			{
				FirstName = "Emily",
				LastName = "Brown",
				Birthday = new DateOnly(1985, 11, 30),
				Email = "emilybrown@test.test",
				EmployeeId = "T12345",
				Department = "Computer Science",
				Salary = 75000m,
				HireDate = new DateOnly(2010, 8, 15),
				SubjectArea = "Artificial Intelligence",
				CoursesTaught = new List<string> { "Intro to AI", "Machine Learning" },
				TeachingRating = 4.5,
			};

			var head = new HeadOfDepartment
			{
				FirstName = "Michael",
				LastName = "Johnson",
				Birthday = new DateOnly(1975, 2, 10),
				Email = "michaeljohnson@test.test",
				EmployeeId = "H12345",
				Department = "Computer Science",
				Salary = 90000m,
				HireDate = new DateOnly(2005, 6, 1),
				SubjectArea = "Software Engineering",
				CoursesTaught = new List<string> { "Software Design", "Project Management" },
				TeachingRating = 4.8,
				TeamSize = 10,
				DepartmentVision = "To foster innovation and excellence in computer science education and research.",
			};

			var admin = new Administrator
			{
				FirstName = "Sarah",
				LastName = "Williams",
				Birthday = new DateOnly(1990, 7, 20),
				Email = "sarahwilliams@test.test",
				EmployeeId = "A12345",
				Department = "Administration",
				Salary = 60000m,
				HireDate = new DateOnly(2015, 3, 10),
				Office = "Main Building, Room 101",
				Responsibilities = new List<string> { "Student Records Management", "Event Coordination", "Budget Oversight" },
			};

			var people = new List<Person> { undergradutate, graduate, teacher, head, admin };
			Console.WriteLine("Lis of all persons:");
			foreach (var person in people)
			{
				Console.WriteLine($"Profile: {person.GetProfile()}");
				Console.WriteLine("------");

			}

			var staff = new List<Staff> { teacher, head, admin };
			Console.WriteLine("List of staff:");
			foreach (var member in staff)
			{
				Console.WriteLine($"Annual Bonus for {member.FirstName} {member.LastName}, {member.GetRole()}, {member.CalculateAnnualBonus()} EUR");
				Console.WriteLine("------");

			}

			var students = new List<Student> { undergradutate, graduate };
			Console.WriteLine("List of students");
			foreach (var student in students)
			{
				Console.WriteLine($"Academic Standing for {student.FirstName} {student.LastName}, {student.GPA}, {student.GetAcademicStanding()}");
				Console.WriteLine("------");
			}
		}
	}
}
