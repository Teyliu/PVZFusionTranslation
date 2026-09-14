using System;
using Cpp2IlInjected;

// Token: 0x02000637 RID: 1591
[Token(Token = "0x2000637")]
public class BucketZombieDuck : BucketZombie
{
	// Token: 0x06001E28 RID: 7720 RVA: 0x000A11DC File Offset: 0x0009F3DC
	[Token(Token = "0x6001E28")]
	[Address(RVA = "0x534760", Offset = "0x532D60", VA = "0x180534760", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("swim");
		this.anim.SetBool("inWater", true);
		this.inWater = true;
		base.SetMaskLayer();
	}

	// Token: 0x06001E29 RID: 7721 RVA: 0x000A1224 File Offset: 0x0009F424
	[Token(Token = "0x6001E29")]
	[Address(RVA = "0x5302B0", Offset = "0x52E8B0", VA = "0x1805302B0")]
	public BucketZombieDuck()
	{
	}
}
