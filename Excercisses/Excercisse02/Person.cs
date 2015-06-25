using System;

namespace Excercisse02
{
	public class Person
	{
		string firstName;
		string lastName;
		int age;

		public Person (string firstName, string lastName, int age)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Age = age;
		}

		public string FirstName
		{
			get { return this.firstName; }
			set
			{
				if (string.IsNullOrEmpty (value)) 
				{
					throw new ArgumentNullException ("Firstname can't be empty !!!");
				}

				this.firstName = value;
			}
		}

		public string LastName
		{
			get { return this.lastName; }
			set
			{
				if (string.IsNullOrEmpty (value)) 
				{
					throw new ArgumentNullException ("Lastname can't be empty !!!");
				}
				this.lastName = value;
			}
		}

		public int Age
		{
			get { return this.age; }
			set
			{
				if (value < 0 || value > 120) 
				{
					throw new ArgumentOutOfRangeException("Age can't be less then 0 and more then 120 !!!");
				}

				this.age = value;
			}
		}

		public override string ToString ()
		{
			return string.Format ("[Person: FirstName={0}, LastName={1}, Age={2}]", FirstName, LastName, Age);
		}
	}
}

