using System;
public class Student
{
	public string stuName;
	public int stuId;
	public string stuEmail;
	public string university;

	public Student(string stuName, int stuId, string stuEmail, string university)
	{
		this.stuId = stuId;
		this.stuName = stuName;
		this.stuEmail = stuEmail;
		this.university = university;
	}
}
public class StudentBuilder
{
	public static void Main()
	{
		Console.WriteLine("\t---------- Student's Card --------------");
		Student student = new Student("Samirah Alhusayni", 14, "Samirah.Alhusayni", " Taif University");

		string c = buildStudent(student);

		Console.WriteLine(c);
		Console.WriteLine("-----------------------------------------------------------");
	}

	public static string buildStudent(Student student)
	{
		CardBuilder stu = new CardBuilder();
		string card = stu

				.start()
				.add("\n\t\"Student\": " + student.stuName + ",\n\t")
				.add("\"ID\": " + student.stuId + ",\n\t")
				.add("\"email\": \"" + student.stuEmail + ",\n\t")
				.add("\"unuversity\":\"" + student.university + ",\n\t")
			.end()
			.getCard();

		return card;
	}



	class CardBuilder
	{
		private string card;
		public CardBuilder()
		{
			this.card = "";
		}

		public CardBuilder start()
		{
			this.card += "\tDisclaimer: This ID Card is intended only for official use of the addressee. ";
			return this;
		}

		public CardBuilder add(string value)
		{
			this.card += value;
			return this;
		}

		public CardBuilder end()
		{
			Console.WriteLine("-----------------------------------------------------------");
			this.card += "Student Affairs Administration ";

			return this;
		}

		public string getCard()
		{
			return this.card;

		}
	}
}
