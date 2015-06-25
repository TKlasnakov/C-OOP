using System;

namespace Excercisses03
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Book normal = new Book ("Pod Igoto", "Ivan Vazov", 15.90m);
			GoldEditionBook golden = new GoldEditionBook ("Dimitar Dimov", "Ivan Vazov", 22.9m);

			Console.WriteLine (normal);
			Console.WriteLine ();
			Console.WriteLine (golden);
		}
	}
}
