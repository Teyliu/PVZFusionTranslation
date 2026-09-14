using System;
using Cpp2IlInjected;

// Token: 0x0200057D RID: 1405
[Token(Token = "0x200057D")]
public class SuperHypnoGatling : SuperSnowGatling
{
	// Token: 0x060019F2 RID: 6642 RVA: 0x0008BB04 File Offset: 0x00089D04
	[Token(Token = "0x60019F2")]
	[Address(RVA = "0x4CBD00", Offset = "0x4CA300", VA = "0x1804CBD00", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_hypnoPea;
	}

	// Token: 0x060019F3 RID: 6643 RVA: 0x0008BB18 File Offset: 0x00089D18
	[Token(Token = "0x60019F3")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public SuperHypnoGatling()
	{
	}
}
