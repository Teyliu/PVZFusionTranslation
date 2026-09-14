using System;
using Cpp2IlInjected;

// Token: 0x020004F9 RID: 1273
[Token(Token = "0x20004F9")]
public class GarlicPea : PeaShooter
{
	// Token: 0x060017CE RID: 6094 RVA: 0x00081BF4 File Offset: 0x0007FDF4
	[Token(Token = "0x60017CE")]
	[Address(RVA = "0x459090", Offset = "0x457690", VA = "0x180459090", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 15f;
	}

	// Token: 0x060017CF RID: 6095 RVA: 0x00081C14 File Offset: 0x0007FE14
	[Token(Token = "0x60017CF")]
	[Address(RVA = "0x4C8F80", Offset = "0x4C7580", VA = "0x1804C8F80", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_pea_garlic;
	}

	// Token: 0x060017D0 RID: 6096 RVA: 0x00081C28 File Offset: 0x0007FE28
	[Token(Token = "0x60017D0")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public GarlicPea()
	{
	}
}
