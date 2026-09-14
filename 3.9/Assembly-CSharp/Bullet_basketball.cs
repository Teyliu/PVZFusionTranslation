using System;
using Cpp2IlInjected;

// Token: 0x0200010F RID: 271
[Token(Token = "0x200010F")]
public class Bullet_basketball : Bullet_cabbage
{
	// Token: 0x0600054B RID: 1355 RVA: 0x0001C348 File Offset: 0x0001A548
	[Token(Token = "0x600054B")]
	[Address(RVA = "0x6E1D10", Offset = "0x6E0310", VA = "0x1806E1D10", Slot = "21")]
	protected override void HitPlant(Plant plant)
	{
		plant.FlashOnce();
		base.Die();
	}

	// Token: 0x0600054C RID: 1356 RVA: 0x0001C368 File Offset: 0x0001A568
	[Token(Token = "0x600054C")]
	[Address(RVA = "0x6E1D80", Offset = "0x6E0380", VA = "0x1806E1D80", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		int num = 0;
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)num, fromType, num2 != 0UL);
		base.Die();
	}

	// Token: 0x0600054D RID: 1357 RVA: 0x0001C39C File Offset: 0x0001A59C
	[Token(Token = "0x600054D")]
	[Address(RVA = "0x6E1D00", Offset = "0x6E0300", VA = "0x1806E1D00", Slot = "17")]
	public override void HitLand()
	{
		base.Die();
	}

	// Token: 0x0600054E RID: 1358 RVA: 0x0001C3B0 File Offset: 0x0001A5B0
	[Token(Token = "0x600054E")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_basketball()
	{
	}
}
