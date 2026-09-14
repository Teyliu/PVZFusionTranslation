using System;
using Cpp2IlInjected;

// Token: 0x02000694 RID: 1684
[Token(Token = "0x2000694")]
public class ElephantZombie_b : ElephantZombie_a
{
	// Token: 0x0600200A RID: 8202 RVA: 0x000A9D5C File Offset: 0x000A7F5C
	[Token(Token = "0x600200A")]
	[Address(RVA = "0x5A5CA0", Offset = "0x5A42A0", VA = "0x1805A5CA0", Slot = "39")]
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

	// Token: 0x0600200B RID: 8203 RVA: 0x000A9DA8 File Offset: 0x000A7FA8
	[Token(Token = "0x600200B")]
	[Address(RVA = "0x5A5A70", Offset = "0x5A4070", VA = "0x1805A5A70")]
	public ElephantZombie_b()
	{
	}
}
