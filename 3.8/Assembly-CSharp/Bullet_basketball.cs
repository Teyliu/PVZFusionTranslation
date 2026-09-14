using System;
using Cpp2IlInjected;

// Token: 0x02000109 RID: 265
[Token(Token = "0x2000109")]
public class Bullet_basketball : Bullet_cabbage
{
	// Token: 0x0600053A RID: 1338 RVA: 0x0001C9CC File Offset: 0x0001ABCC
	[Token(Token = "0x600053A")]
	[Address(RVA = "0x6B6E30", Offset = "0x6B5430", VA = "0x1806B6E30", Slot = "24")]
	protected override void HitPlant(Plant plant)
	{
		plant.FlashOnce();
		base.Die();
	}

	// Token: 0x0600053B RID: 1339 RVA: 0x0001C9EC File Offset: 0x0001ABEC
	[Token(Token = "0x600053B")]
	[Address(RVA = "0x6B6EA0", Offset = "0x6B54A0", VA = "0x1806B6EA0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		int num = 0;
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)num, fromType, num2 != 0UL);
		base.Die();
	}

	// Token: 0x0600053C RID: 1340 RVA: 0x0001CA20 File Offset: 0x0001AC20
	[Token(Token = "0x600053C")]
	[Address(RVA = "0x6B6E20", Offset = "0x6B5420", VA = "0x1806B6E20", Slot = "18")]
	public override void HitLand()
	{
		base.Die();
	}

	// Token: 0x0600053D RID: 1341 RVA: 0x0001CA34 File Offset: 0x0001AC34
	[Token(Token = "0x600053D")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_basketball()
	{
	}
}
