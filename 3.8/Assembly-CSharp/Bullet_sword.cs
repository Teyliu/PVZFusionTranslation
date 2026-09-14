using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001C0 RID: 448
[Token(Token = "0x20001C0")]
public class Bullet_sword : Bullet_pierce
{
	// Token: 0x060007B6 RID: 1974 RVA: 0x00027AE4 File Offset: 0x00025CE4
	[Token(Token = "0x60007B6")]
	[Address(RVA = "0x7D98C0", Offset = "0x7D7EC0", VA = "0x1807D98C0", Slot = "27")]
	protected override void SetPenetrationTime()
	{
		this.penetrationTimes = (int)((ulong)2147483647L);
	}

	// Token: 0x060007B7 RID: 1975 RVA: 0x00027B04 File Offset: 0x00025D04
	[Token(Token = "0x60007B7")]
	[Address(RVA = "0x7E33D0", Offset = "0x7E19D0", VA = "0x1807E33D0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		base.PlaySound(zombie);
	}

	// Token: 0x060007B8 RID: 1976 RVA: 0x00027B38 File Offset: 0x00025D38
	[Token(Token = "0x60007B8")]
	[Address(RVA = "0x7E7A70", Offset = "0x7E6070", VA = "0x1807E7A70", Slot = "18")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x060007B9 RID: 1977 RVA: 0x00027B64 File Offset: 0x00025D64
	[Token(Token = "0x60007B9")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_sword()
	{
	}
}
