using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000145 RID: 325
[Token(Token = "0x2000145")]
public class Bullet_firePea_super : Bullet_pierce
{
	// Token: 0x06000603 RID: 1539 RVA: 0x0001F92C File Offset: 0x0001DB2C
	[Token(Token = "0x6000603")]
	[Address(RVA = "0x6EE140", Offset = "0x6EC740", VA = "0x1806EE140", Slot = "17")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(59, 61), 0.5f, 1f);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x06000604 RID: 1540 RVA: 0x0001F96C File Offset: 0x0001DB6C
	[Token(Token = "0x6000604")]
	[Address(RVA = "0x6EE220", Offset = "0x6EC820", VA = "0x1806EE220", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		zombie.SetJalaed();
		bool flag = Lawnf.TravelAdvanced((AdvBuff)((uint)8));
		if (flag)
		{
			int damage2 = this._damage;
			int num2 = 0;
			zombie.JalaedExplode(true, damage2, num2 != 0);
		}
		GameAPP.PlaySound(flag ? 1 : 0, 0.5f, 1f);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06000605 RID: 1541 RVA: 0x0001F9E4 File Offset: 0x0001DBE4
	[Token(Token = "0x6000605")]
	[Address(RVA = "0x6EE380", Offset = "0x6EC980", VA = "0x1806EE380", Slot = "25")]
	protected override void SetPenetrationTime()
	{
		if (!Lawnf.TravelAdvanced((AdvBuff)((uint)8)) && !Lawnf.TravelAdvanced((AdvBuff)((uint)12008)))
		{
			this.maxHitCount = (int)((ulong)3L);
			return;
		}
		this.maxHitCount = (int)((ulong)1000000L);
	}

	// Token: 0x06000606 RID: 1542 RVA: 0x0001FA20 File Offset: 0x0001DC20
	[Token(Token = "0x6000606")]
	[Address(RVA = "0x6E2090", Offset = "0x6E0690", VA = "0x1806E2090")]
	public Bullet_firePea_super()
	{
	}
}
