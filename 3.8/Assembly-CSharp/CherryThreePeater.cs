using System;
using Cpp2IlInjected;

// Token: 0x020004D5 RID: 1237
[Token(Token = "0x20004D5")]
public class CherryThreePeater : ThreePeater
{
	// Token: 0x0600174B RID: 5963 RVA: 0x0007FFA4 File Offset: 0x0007E1A4
	[Token(Token = "0x600174B")]
	[Address(RVA = "0x49F740", Offset = "0x49DD40", VA = "0x18049F740", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_pea_threeCherry;
	}

	// Token: 0x0600174C RID: 5964 RVA: 0x0007FFB8 File Offset: 0x0007E1B8
	[Token(Token = "0x600174C")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public CherryThreePeater()
	{
	}
}
