using System;
using Cpp2IlInjected;

// Token: 0x020001A4 RID: 420
[Token(Token = "0x20001A4")]
public class Bullet_smallIceSpark2 : Bullet_iceSpark
{
	// Token: 0x06000744 RID: 1860 RVA: 0x00024D2C File Offset: 0x00022F2C
	[Token(Token = "0x6000744")]
	[Address(RVA = "0x80DE30", Offset = "0x80C430", VA = "0x18080DE30", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		base.HitZombie(zombie);
		throw new NullReferenceException();
	}

	// Token: 0x06000745 RID: 1861 RVA: 0x00024D48 File Offset: 0x00022F48
	[Token(Token = "0x6000745")]
	[Address(RVA = "0x80DE70", Offset = "0x80C470", VA = "0x18080DE70")]
	public Bullet_smallIceSpark2()
	{
	}
}
