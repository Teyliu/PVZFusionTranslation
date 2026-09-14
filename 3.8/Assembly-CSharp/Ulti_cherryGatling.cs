using System;
using Cpp2IlInjected;

// Token: 0x02000290 RID: 656
[Token(Token = "0x2000290")]
public class Ulti_cherryGatling : Shooter
{
	// Token: 0x06000BD2 RID: 3026 RVA: 0x0004428C File Offset: 0x0004248C
	[Token(Token = "0x6000BD2")]
	[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_superCherry;
	}

	// Token: 0x06000BD3 RID: 3027 RVA: 0x0004429C File Offset: 0x0004249C
	[Token(Token = "0x6000BD3")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public Ulti_cherryGatling()
	{
	}
}
