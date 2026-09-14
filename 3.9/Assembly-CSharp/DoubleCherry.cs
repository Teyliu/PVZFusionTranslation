using System;
using Cpp2IlInjected;

// Token: 0x02000510 RID: 1296
[Token(Token = "0x2000510")]
public class DoubleCherry : Shooter
{
	// Token: 0x06001854 RID: 6228 RVA: 0x00084430 File Offset: 0x00082630
	[Token(Token = "0x6001854")]
	[Address(RVA = "0x4AD470", Offset = "0x4ABA70", VA = "0x1804AD470", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 15f;
	}

	// Token: 0x06001855 RID: 6229 RVA: 0x00084450 File Offset: 0x00082650
	[Token(Token = "0x6001855")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cherry;
	}

	// Token: 0x06001856 RID: 6230 RVA: 0x00084460 File Offset: 0x00082660
	[Token(Token = "0x6001856")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public DoubleCherry()
	{
	}
}
