using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001A8 RID: 424
[Token(Token = "0x20001A8")]
public class Bullet_snowBall : Bullet_melon
{
	// Token: 0x06000752 RID: 1874 RVA: 0x000250D0 File Offset: 0x000232D0
	[Token(Token = "0x6000752")]
	[Address(RVA = "0x80E900", Offset = "0x80CF00", VA = "0x18080E900", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		int num = 0;
		base.AttackOtherZombie(num, (MelonSputterType)((uint)4));
		base.Die();
	}

	// Token: 0x06000753 RID: 1875 RVA: 0x00025108 File Offset: 0x00023308
	[Token(Token = "0x6000753")]
	[Address(RVA = "0x80EEF0", Offset = "0x80D4F0", VA = "0x18080EEF0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)3), fromType, num != 0UL);
		zombie.AddfreezeLevel(20, 1);
		int num2 = 0;
		zombie.SetCold(10f, 1, num2 != 0);
		GameAPP.PlaySound(global::UnityEngine.Random.Range(104, 106), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x06000754 RID: 1876 RVA: 0x00025184 File Offset: 0x00023384
	[Token(Token = "0x6000754")]
	[Address(RVA = "0x80EA00", Offset = "0x80D000", VA = "0x18080EA00", Slot = "21")]
	protected override void HitPlant(Plant p)
	{
		int num;
		for (;;)
		{
			num = 0;
			PlantType fromType = this.fromType;
			if (p.thePlantType == fromType)
			{
				goto IL_00E0;
			}
			Plant from = this.from;
			int num2 = 0;
			if (from != num2)
			{
				Plant from2 = this.from;
				if (p == from2)
				{
					goto IL_00E0;
				}
			}
			PlantType thePlantType = p.thePlantType;
			if (thePlantType <= PlantType.BigWallNut)
			{
				break;
			}
			if (thePlantType == PlantType.CherryJalapeno)
			{
				goto IL_00A0;
			}
			if (thePlantType != PlantType.ThornsSpruce)
			{
				goto IL_0085;
			}
			int thePlantRow = p.thePlantRow;
			List<Plant> list = Lawnf.Get3x3Plants(p.thePlantColumn, thePlantRow);
			bool flag;
			if (flag)
			{
				goto IL_0085;
			}
			if (num == 0)
			{
				goto Block_5;
			}
		}
		IL_0090:
		string text;
		while (text > (ulong)33L)
		{
		}
		while (text >= (ulong)33L)
		{
		}
		goto IL_00A0;
		IL_0085:
		if (text != (ulong)1459L)
		{
			goto IL_0090;
		}
		IL_00A0:
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
		return;
		Block_5:
		Vector3 vector2;
		float z2 = vector2.z;
		Vector3 vector3;
		float z3 = vector3.z;
		Vector3 vector4;
		float z4 = vector4.z;
		IL_00E0:
		this.hitCount = num;
		throw new NullReferenceException();
	}

	// Token: 0x06000755 RID: 1877 RVA: 0x00025284 File Offset: 0x00023484
	[Token(Token = "0x6000755")]
	[Address(RVA = "0x80F060", Offset = "0x80D660", VA = "0x18080F060")]
	public Bullet_snowBall()
	{
	}
}
