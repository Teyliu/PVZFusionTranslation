using System;
using Cpp2IlInjected;

// Token: 0x020001CE RID: 462
[Token(Token = "0x20001CE")]
public class Bullet_ultimateKernal : Bullet
{
	// Token: 0x060007DF RID: 2015 RVA: 0x00027A70 File Offset: 0x00025C70
	[Token(Token = "0x60007DF")]
	[Address(RVA = "0x815FF0", Offset = "0x8145F0", VA = "0x180815FF0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)2), fromType, num != 0UL);
		int num2 = 0;
		zombie.AddfreezeLevel(10, num2);
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x060007E0 RID: 2016 RVA: 0x00027AB8 File Offset: 0x00025CB8
	[Token(Token = "0x60007E0")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_ultimateKernal()
	{
	}
}
