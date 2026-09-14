using System;
using Cpp2IlInjected;

// Token: 0x02000509 RID: 1289
[Token(Token = "0x2000509")]
public class HypnoPeashooter : Shooter
{
	// Token: 0x06001815 RID: 6165 RVA: 0x000830EC File Offset: 0x000812EC
	[Token(Token = "0x6001815")]
	[Address(RVA = "0x459090", Offset = "0x457690", VA = "0x180459090", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 15f;
	}

	// Token: 0x06001816 RID: 6166 RVA: 0x0008310C File Offset: 0x0008130C
	[Token(Token = "0x6001816")]
	[Address(RVA = "0x4CBD00", Offset = "0x4CA300", VA = "0x1804CBD00", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_hypnoPea;
	}

	// Token: 0x06001817 RID: 6167 RVA: 0x00083120 File Offset: 0x00081320
	[Token(Token = "0x6001817")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public HypnoPeashooter()
	{
	}
}
