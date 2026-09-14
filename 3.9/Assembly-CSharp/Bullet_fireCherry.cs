using System;
using Cpp2IlInjected;

// Token: 0x0200013F RID: 319
[Token(Token = "0x200013F")]
public class Bullet_fireCherry : Bullet_firePea
{
	// Token: 0x060005EF RID: 1519 RVA: 0x0001F434 File Offset: 0x0001D634
	[Token(Token = "0x60005EF")]
	[Address(RVA = "0x6ED090", Offset = "0x6EB690", VA = "0x1806ED090", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		base.FireZombie(zombie, true);
		TimeBomb timeBomb = zombie.timeBomb;
		int num = 0;
		if (timeBomb != num)
		{
			TimeBomb timeBomb2 = zombie.timeBomb;
			int damage = this._damage;
			timeBomb2.Charge(damage);
		}
	}

	// Token: 0x060005F0 RID: 1520 RVA: 0x0001F478 File Offset: 0x0001D678
	[Token(Token = "0x60005F0")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_fireCherry()
	{
	}
}
