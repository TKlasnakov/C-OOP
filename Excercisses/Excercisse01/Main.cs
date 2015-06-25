using System;

namespace Excercisse01
{
	class MainClass
	{
		public static void Main ()
		{
			Dog sharo = new Dog ("Sharo", "Melez");
			Dog unnamed = new Dog ();
			unnamed.Breed = "German Shepard";

			Console.WriteLine (sharo);
			Console.WriteLine (unnamed);
		}
	}
}
