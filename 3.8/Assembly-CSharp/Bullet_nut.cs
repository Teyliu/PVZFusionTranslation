using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000178 RID: 376
[Token(Token = "0x2000178")]
public class Bullet_nut : Bullet_pierce
{
	// Token: 0x060006AB RID: 1707 RVA: 0x00022F64 File Offset: 0x00021164
	[Token(Token = "0x60006AB")]
	[Address(RVA = "0x7D9800", Offset = "0x7D7E00", VA = "0x1807D9800", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		int num = 0;
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)num, fromType, num2 != 0UL);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.PlaySound(zombie);
	}

	// Token: 0x060006AC RID: 1708 RVA: 0x00022FAC File Offset: 0x000211AC
	[Token(Token = "0x60006AC")]
	[Address(RVA = "0x7D98C0", Offset = "0x7D7EC0", VA = "0x1807D98C0", Slot = "27")]
	protected override void SetPenetrationTime()
	{
		this.penetrationTimes = (int)((ulong)2147483647L);
	}

	// Token: 0x060006AD RID: 1709 RVA: 0x00022FCC File Offset: 0x000211CC
	[Token(Token = "0x60006AD")]
	[Address(RVA = "0x7D9720", Offset = "0x7D7D20", VA = "0x1807D9720", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060006AE RID: 1710 RVA: 0x00022FF8 File Offset: 0x000211F8
	[Token(Token = "0x60006AE")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_nut()
	{
	}
}
