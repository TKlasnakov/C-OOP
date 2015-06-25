using System;

namespace Excercisses04
{
	public class Warrior : Character
	{
		public Warrior(int health, int mana, int damage)
			: base(health, mana, damage)
		{
		}

		public override void IAttack (Character target)
		{
			target.Health -= Damage;
		}
	}
}

