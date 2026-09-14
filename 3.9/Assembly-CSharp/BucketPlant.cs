using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200035E RID: 862
[Token(Token = "0x200035E")]
public class BucketPlant : Plant
{
	// Token: 0x06000FCC RID: 4044 RVA: 0x0005AE50 File Offset: 0x00059050
	[Token(Token = "0x6000FCC")]
	[Address(RVA = "0x466C80", Offset = "0x465280", VA = "0x180466C80", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06000FCD RID: 4045 RVA: 0x0005AE60 File Offset: 0x00059060
	[Token(Token = "0x6000FCD")]
	[Address(RVA = "0x470EC0", Offset = "0x46F4C0", VA = "0x180470EC0", Slot = "28")]
	protected override void ReplaceSprite()
	{
		Transform transform = base.transform;
		int num = 0;
		GameObject gameObject = transform.GetChild(num).gameObject;
	}

	// Token: 0x06000FCE RID: 4046 RVA: 0x0005AE8C File Offset: 0x0005908C
	[Token(Token = "0x6000FCE")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public BucketPlant()
	{
	}
}
