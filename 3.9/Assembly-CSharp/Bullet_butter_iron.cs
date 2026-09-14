using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000117 RID: 279
[Token(Token = "0x2000117")]
public class Bullet_butter_iron : Bullet_butter
{
	// Token: 0x06000566 RID: 1382 RVA: 0x0001C9A8 File Offset: 0x0001ABA8
	[Token(Token = "0x6000566")]
	[Address(RVA = "0x6E2F70", Offset = "0x6E1570", VA = "0x1806E2F70", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		PlantType fromType = this.fromType;
		if (zombie.theFirstArmorHealth == 0)
		{
		}
		ulong num;
		zombie.Buttered(4f, num != 0UL);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
		base.Die();
	}

	// Token: 0x06000567 RID: 1383 RVA: 0x0001CA00 File Offset: 0x0001AC00
	[Token(Token = "0x6000567")]
	[Address(RVA = "0x6E2EA0", Offset = "0x6E14A0", VA = "0x1806E2EA0", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		GameAPP.PlaySound(100, 0.5f, 1f);
		base.Die();
	}

	// Token: 0x06000568 RID: 1384 RVA: 0x0001CA3C File Offset: 0x0001AC3C
	[Token(Token = "0x6000568")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_butter_iron()
	{
	}
}
