using System;
using Cpp2IlInjected;

// Token: 0x0200013A RID: 314
[Token(Token = "0x200013A")]
public class Bullet_fireCherry : Bullet_firePea
{
	// Token: 0x060005E8 RID: 1512 RVA: 0x0001FC4C File Offset: 0x0001DE4C
	[Token(Token = "0x60005E8")]
	[Address(RVA = "0x6C22B0", Offset = "0x6C08B0", VA = "0x1806C22B0", Slot = "25")]
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

	// Token: 0x060005E9 RID: 1513 RVA: 0x0001FC90 File Offset: 0x0001DE90
	[Token(Token = "0x60005E9")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_fireCherry()
	{
	}
}
