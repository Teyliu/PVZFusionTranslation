using System;
using Cpp2IlInjected;

// Token: 0x02000534 RID: 1332
[Token(Token = "0x2000534")]
public class HypnoPeashooter : Shooter
{
	// Token: 0x060018DE RID: 6366 RVA: 0x0008692C File Offset: 0x00084B2C
	[Token(Token = "0x60018DE")]
	[Address(RVA = "0x4AD470", Offset = "0x4ABA70", VA = "0x1804AD470", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 15f;
	}

	// Token: 0x060018DF RID: 6367 RVA: 0x0008694C File Offset: 0x00084B4C
	[Token(Token = "0x60018DF")]
	[Address(RVA = "0x528020", Offset = "0x526620", VA = "0x180528020", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_hypnoPea;
	}

	// Token: 0x060018E0 RID: 6368 RVA: 0x00086960 File Offset: 0x00084B60
	[Token(Token = "0x60018E0")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public HypnoPeashooter()
	{
	}
}
