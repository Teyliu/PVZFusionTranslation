using System;
using Cpp2IlInjected;

// Token: 0x020004FB RID: 1275
[Token(Token = "0x20004FB")]
public class GarlicSplit : SplitPea
{
	// Token: 0x060017D3 RID: 6099 RVA: 0x00081CB8 File Offset: 0x0007FEB8
	[Token(Token = "0x60017D3")]
	[Address(RVA = "0x459090", Offset = "0x457690", VA = "0x180459090", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 15f;
	}

	// Token: 0x060017D4 RID: 6100 RVA: 0x00081CD8 File Offset: 0x0007FED8
	[Token(Token = "0x60017D4")]
	[Address(RVA = "0x4C8F80", Offset = "0x4C7580", VA = "0x1804C8F80", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_pea_garlic;
	}

	// Token: 0x060017D5 RID: 6101 RVA: 0x00081CEC File Offset: 0x0007FEEC
	[Token(Token = "0x60017D5")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public GarlicSplit()
	{
	}
}
