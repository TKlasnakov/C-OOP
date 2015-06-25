using System;

namespace Excercisses04
{
	public class Mage : Character
	{
		public Mage (int health, int mana, int damage)
			: base(health, mana, damage)
		{
		}

		public override void IAttack (Character target)
		{
			this.Mana -= 100;
			target.Health -= 2 * this.Damage;
		}

	}
}

