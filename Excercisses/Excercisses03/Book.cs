using System;

namespace Excercisses03
{
	public class Book
	{
		private string title, author;
		private decimal price;

		public Book (string title, string author, decimal price)
		{
			this.Title = title;
			this.Author = author;
			this.Price = price;
		}
			
		public string Title
		{
			get{ return this.title; }
			set
			{
				if (string.IsNullOrEmpty (value))
				{
					throw new ArgumentNullException ("Wrong title input");
				}
				this.title = value;
			}
		}

		public string Author
		{
			get{ return this.author; }
			set
			{
				if (string.IsNullOrEmpty (value))
				{
					throw new ArgumentNullException ("Wrong author input");
				}
				this.author = value;
			}
		}

		public virtual decimal Price
		{
			get{ return this.price; }
			set
			{
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException ("Wrong price input");
				}
				this.price = value;
			}
		}

		public override string ToString ()
		{
			return string.Format ("[Book: Title={0}, Author={1}, Price={2}], Type={3}", Title, Author, Price, GetType().Name);
		}






	}
}

