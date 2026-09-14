using System;
using Cpp2IlInjected;

// Token: 0x020004FC RID: 1276
[Token(Token = "0x20004FC")]
public class GarlicThreePeater : ThreePeater
{
	// Token: 0x060017D6 RID: 6102 RVA: 0x00081D00 File Offset: 0x0007FF00
	[Token(Token = "0x60017D6")]
	[Address(RVA = "0x4C8F80", Offset = "0x4C7580", VA = "0x1804C8F80", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_pea_garlic;
	}

	// Token: 0x060017D7 RID: 6103 RVA: 0x00081D14 File Offset: 0x0007FF14
	[Token(Token = "0x60017D7")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public GarlicThreePeater()
	{
	}
}
