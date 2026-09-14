using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000151 RID: 337
[Token(Token = "0x2000151")]
public class Bullet_iceDoom : Bullet_pierce
{
	// Token: 0x0600062D RID: 1581 RVA: 0x00020F80 File Offset: 0x0001F180
	[Token(Token = "0x600062D")]
	[Address(RVA = "0x6C6070", Offset = "0x6C4670", VA = "0x1806C6070", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int num = 0;
		uint num2;
		zombie.AddfreezeLevel((int)num2, num);
		int num3 = this._damage;
		Transform transform = base.transform;
		PlantType fromType = this.fromType;
		Vector3 vector;
		float z = vector.z;
		num3 -= transform;
		if (transform == 0)
		{
		}
		PlantType fromType2 = this.fromType;
		Transform transform2 = base.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		uint num4;
		GameAPP.PlaySound((int)num4, 0.5f, 1f);
	}

	// Token: 0x0600062E RID: 1582 RVA: 0x00020FF0 File Offset: 0x0001F1F0
	[Token(Token = "0x600062E")]
	[Address(RVA = "0x6C5F40", Offset = "0x6C4540", VA = "0x1806C5F40", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		Transform transform2 = base.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		PlantType fromType = this.fromType;
		GameAPP.PlaySound(70, 0.5f, 1f);
		base.Die();
	}

	// Token: 0x0600062F RID: 1583 RVA: 0x00021044 File Offset: 0x0001F244
	[Token(Token = "0x600062F")]
	[Address(RVA = "0x6B71A0", Offset = "0x6B57A0", VA = "0x1806B71A0")]
	public Bullet_iceDoom()
	{
	}
}
