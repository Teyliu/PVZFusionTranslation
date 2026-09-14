using System;
using Cpp2IlInjected;

// Token: 0x0200072C RID: 1836
[Token(Token = "0x200072C")]
public class ZombieDuck : Zombie
{
	// Token: 0x06002558 RID: 9560 RVA: 0x000C4C38 File Offset: 0x000C2E38
	[Token(Token = "0x6002558")]
	[Address(RVA = "0x5D3040", Offset = "0x5D1640", VA = "0x1805D3040", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("swim");
		this.anim.SetBool("inWater", true);
		this.inWater = true;
		base.SetMaskLayer();
	}

	// Token: 0x06002559 RID: 9561 RVA: 0x000C4C80 File Offset: 0x000C2E80
	[Token(Token = "0x6002559")]
	[Address(RVA = "0x5D3130", Offset = "0x5D1730", VA = "0x1805D3130")]
	public ZombieDuck()
	{
	}
}
