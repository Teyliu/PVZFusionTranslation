using System;
using Cpp2IlInjected;

// Token: 0x0200054D RID: 1357
[Token(Token = "0x200054D")]
public class JalaPeashooter : Shooter
{
	// Token: 0x06001936 RID: 6454 RVA: 0x000887F8 File Offset: 0x000869F8
	[Token(Token = "0x6001936")]
	[Address(RVA = "0x4AD470", Offset = "0x4ABA70", VA = "0x1804AD470", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 15f;
	}

	// Token: 0x06001937 RID: 6455 RVA: 0x00088818 File Offset: 0x00086A18
	[Token(Token = "0x6001937")]
	[Address(RVA = "0x52C7E0", Offset = "0x52ADE0", VA = "0x18052C7E0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_pea_jala;
	}

	// Token: 0x06001938 RID: 6456 RVA: 0x0008882C File Offset: 0x00086A2C
	[Token(Token = "0x6001938")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public JalaPeashooter()
	{
	}
}
