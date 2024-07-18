using EntityFrameworkCoreExample;

using StudentContext dbContext = new StudentContext();

Student s = new Student()
{
	FullName = "Joe Ortiz",
	EmailAddress = "Joe.Ortiz@cptc.edu",
	DateOfBirth = new DateTime(2000, 1, 1)
};

Student s2 = new Student()
{
	FullName = "Jim Halpert",
	EmailAddress = "Jim.Halpert@cptc.edu",
	DateOfBirth = new DateTime(2000, 1, 1)
};

//Prepares the student insert statement
dbContext.Students.Add(s);
//Executes pending inserts.(In actuality, executes any pending insert/update/delete)
dbContext.SaveChanges();

dbContext.Students.Add(s2);
dbContext.SaveChanges();

//Retrieve Student from DB
List<Student> allStudents = dbContext.Students.ToList(); //Method syntax

//allStudents = (from stu in dbContext.Students
//			  select stu).ToList(); //Query syntax

foreach (Student stu in allStudents)
{
	Console.WriteLine($"{stu.FullName} has an email of {stu.EmailAddress}");
}









