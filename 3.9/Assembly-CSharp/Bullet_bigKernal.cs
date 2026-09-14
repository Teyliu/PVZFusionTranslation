using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000111 RID: 273
[Token(Token = "0x2000111")]
public class Bullet_bigKernal : Bullet_sunCabbage
{
	// Token: 0x06000553 RID: 1363 RVA: 0x0001C4B8 File Offset: 0x0001A6B8
	[Token(Token = "0x6000553")]
	[Address(RVA = "0x6E2290", Offset = "0x6E0890", VA = "0x1806E2290", Slot = "25")]
	protected override void SetPenetrationTime()
	{
		this.maxHitCount = (int)((ulong)3L);
		AdvantureData data = AdvantureConfig.data;
		bool flag;
		if (flag)
		{
		}
	}

	// Token: 0x06000554 RID: 1364 RVA: 0x0001C4E0 File Offset: 0x0001A6E0
	[Token(Token = "0x6000554")]
	[Address(RVA = "0x6E2180", Offset = "0x6E0780", VA = "0x1806E2180", Slot = "22")]
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
		float num2 = this.velocity.y * -0.5f;
		this.velocity.y = num2;
		float num3 = this.velocity * 0.5f;
		this.velocity = num3;
	}

	// Token: 0x06000555 RID: 1365 RVA: 0x0001C560 File Offset: 0x0001A760
	[Token(Token = "0x6000555")]
	[Address(RVA = "0x6E20A0", Offset = "0x6E06A0", VA = "0x1806E20A0", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x06000556 RID: 1366 RVA: 0x0001C58C File Offset: 0x0001A78C
	[Token(Token = "0x6000556")]
	[Address(RVA = "0x6E2090", Offset = "0x6E0690", VA = "0x1806E2090")]
	public Bullet_bigKernal()
	{
	}
}
