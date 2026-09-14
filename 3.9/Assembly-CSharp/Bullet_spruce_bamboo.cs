using System;
using Cpp2IlInjected;

// Token: 0x020001B0 RID: 432
[Token(Token = "0x20001B0")]
public class Bullet_spruce_bamboo : Bullet_spruce
{
	// Token: 0x06000771 RID: 1905 RVA: 0x00025AC0 File Offset: 0x00023CC0
	[Token(Token = "0x6000771")]
	[Address(RVA = "0x810AC0", Offset = "0x80F0C0", VA = "0x180810AC0", Slot = "22")]
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

	// Token: 0x06000772 RID: 1906 RVA: 0x00025B14 File Offset: 0x00023D14
	[Token(Token = "0x6000772")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_spruce_bamboo()
	{
	}
}
