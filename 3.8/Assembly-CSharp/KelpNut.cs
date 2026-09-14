using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003C7 RID: 967
[Token(Token = "0x20003C7")]
public class KelpNut : Plant
{
	// Token: 0x060011A7 RID: 4519 RVA: 0x00063BC8 File Offset: 0x00061DC8
	[Token(Token = "0x60011A7")]
	[Address(RVA = "0x41A120", Offset = "0x418720", VA = "0x18041A120", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x060011A8 RID: 4520 RVA: 0x00063BD8 File Offset: 0x00061DD8
	[Token(Token = "0x60011A8")]
	[Address(RVA = "0x446160", Offset = "0x444760", VA = "0x180446160", Slot = "29")]
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

	// Token: 0x060011A9 RID: 4521 RVA: 0x00063C40 File Offset: 0x00061E40
	[Token(Token = "0x60011A9")]
	[Address(RVA = "0x4460E0", Offset = "0x4446E0", VA = "0x1804460E0", Slot = "35")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		if (zombie.inWater)
		{
			int num = 0;
			zombie.SetKelped(1f, num != 0);
		}
	}

	// Token: 0x060011AA RID: 4522 RVA: 0x00063C6C File Offset: 0x00061E6C
	[Token(Token = "0x60011AA")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public KelpNut()
	{
	}

	// Token: 0x04000BC8 RID: 3016
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000BC8")]
	public GameObject crack;

	// Token: 0x04000BC9 RID: 3017
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000BC9")]
	public GameObject arm1;

	// Token: 0x04000BCA RID: 3018
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000BCA")]
	public GameObject arm2;
}
