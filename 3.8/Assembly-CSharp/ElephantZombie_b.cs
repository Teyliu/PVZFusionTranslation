using System;
using Cpp2IlInjected;

// Token: 0x0200065E RID: 1630
[Token(Token = "0x200065E")]
public class ElephantZombie_b : ElephantZombie_a
{
	// Token: 0x06001F08 RID: 7944 RVA: 0x000A55E4 File Offset: 0x000A37E4
	[Token(Token = "0x6001F08")]
	[Address(RVA = "0x543680", Offset = "0x541C80", VA = "0x180543680", Slot = "37")]
	protected override void PlayEatSound2()
	{
		base.PlayEatSound2();
		int attributeCount = this.attributeCount;
		int num = attributeCount + 1;
		this.attributeCount = num;
		if (attributeCount == 10)
		{
			this.anim.SetTrigger("attack2");
			this.attributeCount = (int)((ulong)0L);
		}
	}

	// Token: 0x06001F09 RID: 7945 RVA: 0x000A5630 File Offset: 0x000A3830
	[Token(Token = "0x6001F09")]
	[Address(RVA = "0x543450", Offset = "0x541A50", VA = "0x180543450")]
	public ElephantZombie_b()
	{
	}
}
