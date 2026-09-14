using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000124 RID: 292
[Token(Token = "0x2000124")]
public class Bullet_cabbage_small : Bullet_sunCabbage
{
	// Token: 0x06000593 RID: 1427 RVA: 0x0001D790 File Offset: 0x0001B990
	[Token(Token = "0x6000593")]
	[Address(RVA = "0x6E65B0", Offset = "0x6E4BB0", VA = "0x1806E65B0", Slot = "9")]
	public override void InitData()
	{
		base.InitData();
		this.smallEffect = false;
	}

	// Token: 0x06000594 RID: 1428 RVA: 0x0001D7AC File Offset: 0x0001B9AC
	[Token(Token = "0x6000594")]
	[Address(RVA = "0x6E65D0", Offset = "0x6E4BD0", VA = "0x1806E65D0", Slot = "25")]
	protected override void SetPenetrationTime()
	{
		this.maxHitCount = (int)((ulong)3L);
	}

	// Token: 0x06000595 RID: 1429 RVA: 0x0001D7C4 File Offset: 0x0001B9C4
	[Token(Token = "0x6000595")]
	[Address(RVA = "0x6E6440", Offset = "0x6E4A40", VA = "0x1806E6440", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		if (!zombie.isSmall)
		{
			if (!this.smallEffect)
			{
				goto IL_0024;
			}
			zombie.BeSmall(0.7f);
		}
		this.smallEffect = true;
		IL_0024:
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		base.PlaySound(zombie);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		float num2 = this.velocity.y * -1f;
		this.velocity.y = num2;
	}

	// Token: 0x06000596 RID: 1430 RVA: 0x0001D854 File Offset: 0x0001BA54
	[Token(Token = "0x6000596")]
	[Address(RVA = "0x6E6360", Offset = "0x6E4960", VA = "0x1806E6360", Slot = "17")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x06000597 RID: 1431 RVA: 0x0001D898 File Offset: 0x0001BA98
	[Token(Token = "0x6000597")]
	[Address(RVA = "0x6E2090", Offset = "0x6E0690", VA = "0x1806E2090")]
	public Bullet_cabbage_small()
	{
	}

	// Token: 0x04000368 RID: 872
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000368")]
	protected bool smallEffect;
}
