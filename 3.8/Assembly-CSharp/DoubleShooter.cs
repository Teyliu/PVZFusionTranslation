using System;
using Cpp2IlInjected;

// Token: 0x020004E9 RID: 1257
[Token(Token = "0x20004E9")]
public class DoubleShooter : Shooter
{
	// Token: 0x060017A0 RID: 6048 RVA: 0x0008122C File Offset: 0x0007F42C
	[Token(Token = "0x60017A0")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "72")]
	protected override BulletMoveWay GetBulletMoveWay()
	{
		return BulletMoveWay.MoveRight;
	}

	// Token: 0x060017A1 RID: 6049 RVA: 0x00081244 File Offset: 0x0007F444
	[Token(Token = "0x60017A1")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_pea;
	}

	// Token: 0x060017A2 RID: 6050 RVA: 0x0008125C File Offset: 0x0007F45C
	[Token(Token = "0x60017A2")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public DoubleShooter()
	{
	}
}
