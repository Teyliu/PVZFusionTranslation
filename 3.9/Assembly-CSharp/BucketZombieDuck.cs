using System;
using Cpp2IlInjected;

// Token: 0x0200066D RID: 1645
[Token(Token = "0x200066D")]
public class BucketZombieDuck : BucketZombie
{
	// Token: 0x06001F2A RID: 7978 RVA: 0x000A592C File Offset: 0x000A3B2C
	[Token(Token = "0x6001F2A")]
	[Address(RVA = "0x58B440", Offset = "0x589A40", VA = "0x18058B440", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("swim");
		this.anim.SetBool("inWater", true);
		this.inWater = true;
		base.SetMaskLayer();
	}

	// Token: 0x06001F2B RID: 7979 RVA: 0x000A5974 File Offset: 0x000A3B74
	[Token(Token = "0x6001F2B")]
	[Address(RVA = "0x586E30", Offset = "0x585430", VA = "0x180586E30")]
	public BucketZombieDuck()
	{
	}
}
