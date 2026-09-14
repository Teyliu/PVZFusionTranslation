using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006FB RID: 1787
[Token(Token = "0x20006FB")]
public class SnowBucketZombie : SnowNormalZombie
{
	// Token: 0x06002321 RID: 8993 RVA: 0x000B7A58 File Offset: 0x000B5C58
	[Token(Token = "0x6002321")]
	[Address(RVA = "0x5D1250", Offset = "0x5CF850", VA = "0x1805D1250", Slot = "63")]
	protected override void FirstArmorBroken()
	{
		GameObject gameObject = this.outterIce;
		int num = 0;
		gameObject.SetActive(num != 0);
		int theFirstArmorMaxHealth = this.theFirstArmorMaxHealth;
		int theFirstArmorHealth = this.theFirstArmorHealth;
	}

	// Token: 0x06002322 RID: 8994 RVA: 0x000B7A8C File Offset: 0x000B5C8C
	[Token(Token = "0x6002322")]
	[Address(RVA = "0x58B130", Offset = "0x589730", VA = "0x18058B130")]
	public SnowBucketZombie()
	{
	}

	// Token: 0x040011F7 RID: 4599
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x40011F7")]
	public GameObject outterIce;

	// Token: 0x040011F8 RID: 4600
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x40011F8")]
	public GameObject innerIce;
}
