using System;

namespace Excercisses04
{
	public class Priest : Character, IHeal
	{
		public Priest (int health, int mana, int damage)
			: base(health, mana, damage)
		{
		}

		public override void IAttack (Character target)
		{
			this.Mana -= 100;
			this.Health += 10;
			target.Health -= this.Damage;
		}

		public void IHeal(Character target)
		{
			this.Mana -= 100;
			this.Health += 150;
		}
	}
}

