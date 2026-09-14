using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000129 RID: 297
[Token(Token = "0x2000129")]
public class Bullet_cactusStar : Bullet_star
{
	// Token: 0x060005A4 RID: 1444 RVA: 0x0001DC34 File Offset: 0x0001BE34
	[Token(Token = "0x60005A4")]
	[Address(RVA = "0x6E7050", Offset = "0x6E5650", VA = "0x1806E7050", Slot = "12")]
	protected override void Update()
	{
		base.Update();
		if (this.theExistTime > 0.3f)
		{
			base.MoveWay = (BulletMoveWay)((uint)3);
			bool flag = this.hitFilters.Remove((uint)3);
			return;
		}
	}

	// Token: 0x060005A5 RID: 1445 RVA: 0x0001DC74 File Offset: 0x0001BE74
	[Token(Token = "0x60005A5")]
	[Address(RVA = "0x5E0510", Offset = "0x5DEB10", VA = "0x1805E0510", Slot = "22")]
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

	// Token: 0x060005A6 RID: 1446 RVA: 0x0001DCB0 File Offset: 0x0001BEB0
	[Token(Token = "0x60005A6")]
	[Address(RVA = "0x6E6FD0", Offset = "0x6E55D0", VA = "0x1806E6FD0", Slot = "17")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x060005A7 RID: 1447 RVA: 0x0001DCDC File Offset: 0x0001BEDC
	[Token(Token = "0x60005A7")]
	[Address(RVA = "0x6E70E0", Offset = "0x6E56E0", VA = "0x1806E70E0")]
	public Bullet_cactusStar()
	{
	}
}
