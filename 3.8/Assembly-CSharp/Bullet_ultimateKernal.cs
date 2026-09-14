using System;
using Cpp2IlInjected;

// Token: 0x020001C4 RID: 452
[Token(Token = "0x20001C4")]
public class Bullet_ultimateKernal : Bullet
{
	// Token: 0x060007C8 RID: 1992 RVA: 0x00027F28 File Offset: 0x00026128
	[Token(Token = "0x60007C8")]
	[Address(RVA = "0x7E8750", Offset = "0x7E6D50", VA = "0x1807E8750", Slot = "25")]
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

	// Token: 0x060007C9 RID: 1993 RVA: 0x00027F70 File Offset: 0x00026170
	[Token(Token = "0x60007C9")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_ultimateKernal()
	{
	}
}
