using System;
using Cpp2IlInjected;

// Token: 0x02000765 RID: 1893
[Token(Token = "0x2000765")]
public class ZombieDuck : Zombie
{
	// Token: 0x0600267D RID: 9853 RVA: 0x000C9B60 File Offset: 0x000C7D60
	[Token(Token = "0x600267D")]
	[Address(RVA = "0x634460", Offset = "0x632A60", VA = "0x180634460", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("swim");
		this.anim.SetBool("inWater", true);
		this.inWater = true;
		base.SetMaskLayer();
	}

	// Token: 0x0600267E RID: 9854 RVA: 0x000C9BA8 File Offset: 0x000C7DA8
	[Token(Token = "0x600267E")]
	[Address(RVA = "0x634550", Offset = "0x632B50", VA = "0x180634550")]
	public ZombieDuck()
	{
	}
}
