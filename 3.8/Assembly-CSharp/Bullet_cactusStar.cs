using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000124 RID: 292
[Token(Token = "0x2000124")]
public class Bullet_cactusStar : Bullet_star
{
	// Token: 0x0600059C RID: 1436 RVA: 0x0001E464 File Offset: 0x0001C664
	[Token(Token = "0x600059C")]
	[Address(RVA = "0x6BC130", Offset = "0x6BA730", VA = "0x1806BC130", Slot = "14")]
	protected override Zombie GetNearestZombie()
	{
		return base.GetNearestFlyingZombie();
	}

	// Token: 0x0600059D RID: 1437 RVA: 0x0001E478 File Offset: 0x0001C678
	[Token(Token = "0x600059D")]
	[Address(RVA = "0x6BC1C0", Offset = "0x6BA7C0", VA = "0x1806BC1C0", Slot = "11")]
	protected override void Update()
	{
		base.Update();
		if (this.theExistTime > 0.3f)
		{
			base.MoveWay = (BulletMoveWay)((uint)6);
			return;
		}
	}

	// Token: 0x0600059E RID: 1438 RVA: 0x0001E4A4 File Offset: 0x0001C6A4
	[Token(Token = "0x600059E")]
	[Address(RVA = "0x5A9E70", Offset = "0x5A8470", VA = "0x1805A9E70", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		int num = 0;
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)num, fromType, num2 != 0UL);
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x0600059F RID: 1439 RVA: 0x0001E4E0 File Offset: 0x0001C6E0
	[Token(Token = "0x600059F")]
	[Address(RVA = "0x6BC140", Offset = "0x6BA740", VA = "0x1806BC140", Slot = "18")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x060005A0 RID: 1440 RVA: 0x0001E50C File Offset: 0x0001C70C
	[Token(Token = "0x60005A0")]
	[Address(RVA = "0x6BC210", Offset = "0x6BA810", VA = "0x1806BC210")]
	public Bullet_cactusStar()
	{
	}
}
