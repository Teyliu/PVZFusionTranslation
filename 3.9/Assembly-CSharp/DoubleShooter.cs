using System;
using Cpp2IlInjected;

// Token: 0x02000511 RID: 1297
[Token(Token = "0x2000511")]
public class DoubleShooter : Shooter
{
	// Token: 0x06001857 RID: 6231 RVA: 0x00084474 File Offset: 0x00082674
	[Token(Token = "0x6001857")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "71")]
	protected override BulletMoveWay GetBulletMoveWay()
	{
		return BulletMoveWay.MoveRight;
	}

	// Token: 0x06001858 RID: 6232 RVA: 0x0008448C File Offset: 0x0008268C
	[Token(Token = "0x6001858")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_pea;
	}

	// Token: 0x06001859 RID: 6233 RVA: 0x000844A4 File Offset: 0x000826A4
	[Token(Token = "0x6001859")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public DoubleShooter()
	{
	}
}
