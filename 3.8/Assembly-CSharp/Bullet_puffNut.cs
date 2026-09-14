using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000189 RID: 393
[Token(Token = "0x2000189")]
public class Bullet_puffNut : Bullet_pierce
{
	// Token: 0x060006EA RID: 1770 RVA: 0x00024010 File Offset: 0x00022210
	[Token(Token = "0x60006EA")]
	[Address(RVA = "0x6BEEE0", Offset = "0x6BD4E0", VA = "0x1806BEEE0", Slot = "27")]
	protected override void SetPenetrationTime()
	{
		this.penetrationTimes = (int)((ulong)1000000L);
	}

	// Token: 0x060006EB RID: 1771 RVA: 0x0002402C File Offset: 0x0002222C
	[Token(Token = "0x60006EB")]
	[Address(RVA = "0x7DCDA0", Offset = "0x7DB3A0", VA = "0x1807DCDA0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int currentFirstHealth = zombie.CurrentFirstHealth;
		PlantType fromType = this.fromType;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.PlaySound(zombie);
		int num = this._damage;
		num -= currentFirstHealth;
		this._damage = num;
		base.Die();
	}

	// Token: 0x060006EC RID: 1772 RVA: 0x00024084 File Offset: 0x00022284
	[Token(Token = "0x60006EC")]
	[Address(RVA = "0x7DCCC0", Offset = "0x7DB2C0", VA = "0x1807DCCC0", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060006ED RID: 1773 RVA: 0x000240B0 File Offset: 0x000222B0
	[Token(Token = "0x60006ED")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_puffNut()
	{
	}
}
