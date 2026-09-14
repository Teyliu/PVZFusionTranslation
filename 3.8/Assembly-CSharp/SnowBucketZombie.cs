using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006C3 RID: 1731
[Token(Token = "0x20006C3")]
public class SnowBucketZombie : SnowNormalZombie
{
	// Token: 0x06002206 RID: 8710 RVA: 0x000B2C64 File Offset: 0x000B0E64
	[Token(Token = "0x6002206")]
	[Address(RVA = "0x56D590", Offset = "0x56BB90", VA = "0x18056D590", Slot = "61")]
	protected override void FirstArmorBroken()
	{
		GameObject gameObject = this.outterIce;
		int num = 0;
		gameObject.SetActive(num != 0);
		int theFirstArmorMaxHealth = this.theFirstArmorMaxHealth;
		int theFirstArmorHealth = this.theFirstArmorHealth;
	}

	// Token: 0x06002207 RID: 8711 RVA: 0x000B2C98 File Offset: 0x000B0E98
	[Token(Token = "0x6002207")]
	[Address(RVA = "0x534450", Offset = "0x532A50", VA = "0x180534450")]
	public SnowBucketZombie()
	{
	}

	// Token: 0x04001129 RID: 4393
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4001129")]
	public GameObject outterIce;

	// Token: 0x0400112A RID: 4394
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x400112A")]
	public GameObject innerIce;
}
