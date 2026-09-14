using System;
using Cpp2IlInjected;

// Token: 0x02000520 RID: 1312
[Token(Token = "0x2000520")]
public class JalaPeashooter : Shooter
{
	// Token: 0x06001867 RID: 6247 RVA: 0x00084C64 File Offset: 0x00082E64
	[Token(Token = "0x6001867")]
	[Address(RVA = "0x459090", Offset = "0x457690", VA = "0x180459090", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 15f;
	}

	// Token: 0x06001868 RID: 6248 RVA: 0x00084C84 File Offset: 0x00082E84
	[Token(Token = "0x6001868")]
	[Address(RVA = "0x4CFEB0", Offset = "0x4CE4B0", VA = "0x1804CFEB0", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_pea_jala;
	}

	// Token: 0x06001869 RID: 6249 RVA: 0x00084C98 File Offset: 0x00082E98
	[Token(Token = "0x6001869")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public JalaPeashooter()
	{
	}
}
