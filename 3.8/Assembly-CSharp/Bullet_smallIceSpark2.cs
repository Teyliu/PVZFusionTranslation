using System;
using Cpp2IlInjected;

// Token: 0x0200019D RID: 413
[Token(Token = "0x200019D")]
public class Bullet_smallIceSpark2 : Bullet_iceSpark
{
	// Token: 0x06000737 RID: 1847 RVA: 0x000253F4 File Offset: 0x000235F4
	[Token(Token = "0x6000737")]
	[Address(RVA = "0x7E06F0", Offset = "0x7DECF0", VA = "0x1807E06F0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		base.HitZombie(zombie);
		throw new NullReferenceException();
	}

	// Token: 0x06000738 RID: 1848 RVA: 0x00025410 File Offset: 0x00023610
	[Token(Token = "0x6000738")]
	[Address(RVA = "0x7E0730", Offset = "0x7DED30", VA = "0x1807E0730")]
	public Bullet_smallIceSpark2()
	{
	}
}
