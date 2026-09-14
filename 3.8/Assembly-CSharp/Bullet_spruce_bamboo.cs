using System;
using Cpp2IlInjected;

// Token: 0x020001A9 RID: 425
[Token(Token = "0x20001A9")]
public class Bullet_spruce_bamboo : Bullet_spruce
{
	// Token: 0x06000764 RID: 1892 RVA: 0x000261D0 File Offset: 0x000243D0
	[Token(Token = "0x6000764")]
	[Address(RVA = "0x7E3440", Offset = "0x7E1A40", VA = "0x1807E3440", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		base.PlaySound(zombie);
		Plant from = this.from;
		int num2 = 0;
		if (from != num2)
		{
			Plant from2 = this.from;
		}
	}

	// Token: 0x06000765 RID: 1893 RVA: 0x00026224 File Offset: 0x00024424
	[Token(Token = "0x6000765")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_spruce_bamboo()
	{
	}
}
