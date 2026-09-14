using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200010B RID: 267
[Token(Token = "0x200010B")]
public class Bullet_bigKernal : Bullet_sunCabbage
{
	// Token: 0x06000542 RID: 1346 RVA: 0x0001CB38 File Offset: 0x0001AD38
	[Token(Token = "0x6000542")]
	[Address(RVA = "0x6B73A0", Offset = "0x6B59A0", VA = "0x1806B73A0", Slot = "27")]
	protected override void SetPenetrationTime()
	{
		this.penetrationTimes = (int)((ulong)3L);
		AdvantureData data = AdvantureConfig.data;
		bool flag;
		if (flag)
		{
		}
	}

	// Token: 0x06000543 RID: 1347 RVA: 0x0001CB60 File Offset: 0x0001AD60
	[Token(Token = "0x6000543")]
	[Address(RVA = "0x6B7290", Offset = "0x6B5890", VA = "0x1806B7290", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		base.PlaySound(zombie);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		float vy = this.Vy;
		float vx = this.Vx;
		float num2 = vy * -0.5f;
		float num3 = vx * 0.5f;
		this.Vy = num2;
		this.Vx = num3;
	}

	// Token: 0x06000544 RID: 1348 RVA: 0x0001CBDC File Offset: 0x0001ADDC
	[Token(Token = "0x6000544")]
	[Address(RVA = "0x6B71B0", Offset = "0x6B57B0", VA = "0x1806B71B0", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x06000545 RID: 1349 RVA: 0x0001CC08 File Offset: 0x0001AE08
	[Token(Token = "0x6000545")]
	[Address(RVA = "0x6B71A0", Offset = "0x6B57A0", VA = "0x1806B71A0")]
	public Bullet_bigKernal()
	{
	}
}
