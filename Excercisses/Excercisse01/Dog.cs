using System;

namespace Excercisse01
{
	public class Dog
	{
		public Dog ()
		{
		}
			
		public Dog(string breed, string name)
		{
			this.Name = name;
			this.Breed = breed;
		}

		public Dog(string name)
		{
			this.Name = name;
		}

		public string Breed{ get; set; }

		public string Name {get; set; }

		public override string ToString ()
		{
			return string.Format ("{0} ({1}) said BAU", this.Name ?? "[unnamed dog]", this.Breed ?? "[unnamed breed]" );
		}
	}
}

