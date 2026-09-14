using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000110 RID: 272
[Token(Token = "0x2000110")]
public class Bullet_bigButter : Bullet_sunCabbage
{
	// Token: 0x0600054F RID: 1359 RVA: 0x0001C3C4 File Offset: 0x0001A5C4
	[Token(Token = "0x600054F")]
	[Address(RVA = "0x6E2000", Offset = "0x6E0600", VA = "0x1806E2000", Slot = "25")]
	protected override void SetPenetrationTime()
	{
		this.maxHitCount = (int)((ulong)3L);
		AdvantureData data = AdvantureConfig.data;
		bool flag;
		if (flag)
		{
		}
	}

	// Token: 0x06000550 RID: 1360 RVA: 0x0001C3EC File Offset: 0x0001A5EC
	[Token(Token = "0x6000550")]
	[Address(RVA = "0x6E1ED0", Offset = "0x6E04D0", VA = "0x1806E1ED0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		base.PlaySound(zombie);
		zombie.Buttered(4f, true);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		float num2 = this.velocity.y * -0.5f;
		this.velocity.y = num2;
		float num3 = this.velocity * 0.5f;
		this.velocity = num3;
	}

	// Token: 0x06000551 RID: 1361 RVA: 0x0001C478 File Offset: 0x0001A678
	[Token(Token = "0x6000551")]
	[Address(RVA = "0x6E1DF0", Offset = "0x6E03F0", VA = "0x1806E1DF0", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x06000552 RID: 1362 RVA: 0x0001C4A4 File Offset: 0x0001A6A4
	[Token(Token = "0x6000552")]
	[Address(RVA = "0x6E2090", Offset = "0x6E0690", VA = "0x1806E2090")]
	public Bullet_bigButter()
	{
	}
}
