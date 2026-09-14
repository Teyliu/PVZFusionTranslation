using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003DB RID: 987
[Token(Token = "0x20003DB")]
public class KelpNut : Plant
{
	// Token: 0x06001203 RID: 4611 RVA: 0x000651E8 File Offset: 0x000633E8
	[Token(Token = "0x6001203")]
	[Address(RVA = "0x466C80", Offset = "0x465280", VA = "0x180466C80", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06001204 RID: 4612 RVA: 0x000651F8 File Offset: 0x000633F8
	[Token(Token = "0x6001204")]
	[Address(RVA = "0x49A5F0", Offset = "0x498BF0", VA = "0x18049A5F0", Slot = "28")]
	protected override void ReplaceSprite()
	{
		CrackStatus crackStatus;
		if (crackStatus != CrackStatus.Good)
		{
			if (crackStatus != CrackStatus.Good)
			{
				if (crackStatus == CrackStatus.Normal)
				{
					GameObject gameObject = this.arm1;
					int num = 0;
					gameObject.SetActive(num != 0);
					GameObject gameObject2 = this.arm2;
					int num2 = 0;
					gameObject2.SetActive(num2 != 0);
					return;
				}
				return;
			}
			else
			{
				GameObject gameObject3 = this.arm1;
			}
		}
		ulong num3;
		this.arm1.SetActive(num3 != 0UL);
		ulong num4;
		this.arm2.SetActive(num4 != 0UL);
	}

	// Token: 0x06001205 RID: 4613 RVA: 0x00065260 File Offset: 0x00063460
	[Token(Token = "0x6001205")]
	[Address(RVA = "0x49A570", Offset = "0x498B70", VA = "0x18049A570", Slot = "34")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		if (zombie.inWater)
		{
			int num = 0;
			zombie.SetKelped(1f, num != 0);
		}
	}

	// Token: 0x06001206 RID: 4614 RVA: 0x0006528C File Offset: 0x0006348C
	[Token(Token = "0x6001206")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public KelpNut()
	{
	}

	// Token: 0x04000C2E RID: 3118
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C2E")]
	public GameObject crack;

	// Token: 0x04000C2F RID: 3119
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000C2F")]
	public GameObject arm1;

	// Token: 0x04000C30 RID: 3120
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000C30")]
	public GameObject arm2;
}
