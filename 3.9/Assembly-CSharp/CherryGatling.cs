using System;
using Cpp2IlInjected;

// Token: 0x020004F5 RID: 1269
[Token(Token = "0x20004F5")]
public class CherryGatling : Shooter
{
	// Token: 0x060017EC RID: 6124 RVA: 0x00082CF4 File Offset: 0x00080EF4
	[Token(Token = "0x60017EC")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cherry;
	}

	// Token: 0x060017ED RID: 6125 RVA: 0x00082D04 File Offset: 0x00080F04
	[Token(Token = "0x60017ED")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public CherryGatling()
	{
	}
}
