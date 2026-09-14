using System;
using Cpp2IlInjected;

// Token: 0x020004E8 RID: 1256
[Token(Token = "0x20004E8")]
public class DoubleCherry : Shooter
{
	// Token: 0x0600179D RID: 6045 RVA: 0x000811E8 File Offset: 0x0007F3E8
	[Token(Token = "0x600179D")]
	[Address(RVA = "0x459090", Offset = "0x457690", VA = "0x180459090", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 15f;
	}

	// Token: 0x0600179E RID: 6046 RVA: 0x00081208 File Offset: 0x0007F408
	[Token(Token = "0x600179E")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cherry;
	}

	// Token: 0x0600179F RID: 6047 RVA: 0x00081218 File Offset: 0x0007F418
	[Token(Token = "0x600179F")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public DoubleCherry()
	{
	}
}
