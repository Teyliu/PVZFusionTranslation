using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200034E RID: 846
[Token(Token = "0x200034E")]
public class BucketPlant : Plant
{
	// Token: 0x06000F80 RID: 3968 RVA: 0x00059EE0 File Offset: 0x000580E0
	[Token(Token = "0x6000F80")]
	[Address(RVA = "0x41A120", Offset = "0x418720", VA = "0x18041A120", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06000F81 RID: 3969 RVA: 0x00059EF0 File Offset: 0x000580F0
	[Token(Token = "0x6000F81")]
	[Address(RVA = "0x419FF0", Offset = "0x4185F0", VA = "0x180419FF0", Slot = "29")]
	protected override void ReplaceSprite()
	{
		Transform transform = base.transform;
		int num = 0;
		GameObject gameObject = transform.GetChild(num).gameObject;
	}

	// Token: 0x06000F82 RID: 3970 RVA: 0x00059F1C File Offset: 0x0005811C
	[Token(Token = "0x6000F82")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public BucketPlant()
	{
	}
}
