using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001A1 RID: 417
[Token(Token = "0x20001A1")]
public class Bullet_snowBall : Bullet_melon
{
	// Token: 0x06000745 RID: 1861 RVA: 0x00025798 File Offset: 0x00023998
	[Token(Token = "0x6000745")]
	[Address(RVA = "0x7E11C0", Offset = "0x7DF7C0", VA = "0x1807E11C0", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		int num = 0;
		base.AttackOtherZombie(num, (MelonSputterType)((uint)4));
		base.Die();
	}

	// Token: 0x06000746 RID: 1862 RVA: 0x000257D0 File Offset: 0x000239D0
	[Token(Token = "0x6000746")]
	[Address(RVA = "0x7E1790", Offset = "0x7DFD90", VA = "0x1807E1790", Slot = "25")]
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

	// Token: 0x06000747 RID: 1863 RVA: 0x0002584C File Offset: 0x00023A4C
	[Token(Token = "0x6000747")]
	[Address(RVA = "0x7E12C0", Offset = "0x7DF8C0", VA = "0x1807E12C0", Slot = "24")]
	protected override void HitPlant(Plant p)
	{
		int num;
		for (;;)
		{
			num = 0;
			PlantType fromType = this.fromType;
			if (p.thePlantType == fromType)
			{
				goto IL_00CA;
			}
			Plant from = this.from;
			int num2 = 0;
			if (from != num2)
			{
				Plant from2 = this.from;
				if (p == from2)
				{
					goto IL_00CA;
				}
			}
			PlantType thePlantType = p.thePlantType;
			if (thePlantType <= PlantType.BigSunNut)
			{
				goto IL_0072;
			}
			if (thePlantType == PlantType.BigWallNut || thePlantType == PlantType.CherryJalapeno)
			{
				goto IL_00BD;
			}
			if (thePlantType == PlantType.ThornsSpruce)
			{
				goto IL_0072;
			}
			IL_007C:
			int thePlantRow = p.thePlantRow;
			List<Plant> list = Lawnf.Get3x3Plants(p.thePlantColumn, thePlantRow);
			bool flag;
			if (flag)
			{
			}
			if (num == 0)
			{
				break;
			}
			continue;
			IL_0072:
			bool flag2;
			if (!flag2 && !flag2)
			{
				goto IL_007C;
			}
			goto IL_00BD;
		}
		Vector3 vector;
		float z = vector.z;
		Vector3 vector2;
		float z2 = vector2.z;
		Vector3 vector3;
		float z3 = vector3.z;
		IL_00BD:
		Vector3 vector4;
		float z4 = vector4.z;
		return;
		IL_00CA:
		this.hit = num != 0;
		throw new NullReferenceException();
	}

	// Token: 0x06000748 RID: 1864 RVA: 0x00025938 File Offset: 0x00023B38
	[Token(Token = "0x6000748")]
	[Address(RVA = "0x7E1900", Offset = "0x7DFF00", VA = "0x1807E1900")]
	public Bullet_snowBall()
	{
	}
}
