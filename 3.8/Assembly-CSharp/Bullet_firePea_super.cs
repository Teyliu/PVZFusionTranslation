using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000140 RID: 320
[Token(Token = "0x2000140")]
public class Bullet_firePea_super : Bullet_pierce
{
	// Token: 0x060005FC RID: 1532 RVA: 0x00020144 File Offset: 0x0001E344
	[Token(Token = "0x60005FC")]
	[Address(RVA = "0x6C3360", Offset = "0x6C1960", VA = "0x1806C3360", Slot = "18")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(59, 61), 0.5f, 1f);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060005FD RID: 1533 RVA: 0x00020184 File Offset: 0x0001E384
	[Token(Token = "0x60005FD")]
	[Address(RVA = "0x6C3440", Offset = "0x6C1A40", VA = "0x1806C3440", Slot = "25")]
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

	// Token: 0x060005FE RID: 1534 RVA: 0x000201FC File Offset: 0x0001E3FC
	[Token(Token = "0x60005FE")]
	[Address(RVA = "0x6C35A0", Offset = "0x6C1BA0", VA = "0x1806C35A0", Slot = "27")]
	protected override void SetPenetrationTime()
	{
		if (!Lawnf.TravelAdvanced((AdvBuff)((uint)8)) && !Lawnf.TravelAdvanced((AdvBuff)((uint)12008)))
		{
			this.penetrationTimes = (int)((ulong)3L);
			return;
		}
		this.penetrationTimes = (int)((ulong)1000000L);
	}

	// Token: 0x060005FF RID: 1535 RVA: 0x00020238 File Offset: 0x0001E438
	[Token(Token = "0x60005FF")]
	[Address(RVA = "0x6B71A0", Offset = "0x6B57A0", VA = "0x1806B71A0")]
	public Bullet_firePea_super()
	{
	}
}
