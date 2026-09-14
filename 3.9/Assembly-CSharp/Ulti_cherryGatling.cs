using System;
using Cpp2IlInjected;

// Token: 0x02000296 RID: 662
[Token(Token = "0x2000296")]
public class Ulti_cherryGatling : Shooter
{
	// Token: 0x06000BEE RID: 3054 RVA: 0x000440F8 File Offset: 0x000422F8
	[Token(Token = "0x6000BEE")]
	[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_superCherry;
	}

	// Token: 0x06000BEF RID: 3055 RVA: 0x00044108 File Offset: 0x00042308
	[Token(Token = "0x6000BEF")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public Ulti_cherryGatling()
	{
	}
}
