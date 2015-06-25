using System;

namespace Excercisses04
{
	public abstract class Character : IAttack
	{
		private int mana;
		private int health;
		private int damage;

		protected Character (int health, int mana, int damage)
		{
			this.Health = health;
			this.Mana = mana;
			this.Damage = damage;
		}

		public int Health
		{
			get
			{
				return this.health;
			}
			set
			{
				if (value < 100 || value > 300)
				{
					throw new ArgumentOutOfRangeException("Wrong character healt input !!!");
				}
				this.health = value;
			}
		}

		public int Mana
		{
			get
			{
				return this.mana;
			}
			set
			{
				if (value < 0 || value > 300)
				{
					throw new ArgumentOutOfRangeException("Wrong character mana input !!!");
				}
				this.mana = value;
			}
		}

		public int Damage
		{
			get
			{
				return this.damage;
			}
			set
			{
				if (value < 75 || value > 120)
				{
					throw new ArgumentOutOfRangeException("Wrong character damage input !!!");
				}
				this.damage = value;
			}
		}

		public abstract void IAttack(Character target);
	}
}

