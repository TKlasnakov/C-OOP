using System;

namespace Excercisses03
{
	public class GoldEditionBook : Book
	{

		public GoldEditionBook (string title, string author, decimal price)
			:base(title,author,price)
		{
		}

		public override decimal Price {
			get 
			{
				return base.Price+(base.Price * 30/100);
			}
		
		}
	
		public override string ToString ()
		{
			return string.Format ("[Book: Title={0}, Author={1}, Price={2}], Type={3}", Title, Author, Price, GetType().Name);
		}
	}
}

