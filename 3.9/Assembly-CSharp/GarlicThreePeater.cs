using System;
using Cpp2IlInjected;

// Token: 0x02000527 RID: 1319
[Token(Token = "0x2000527")]
public class GarlicThreePeater : ThreePeater
{
	// Token: 0x0600189F RID: 6303 RVA: 0x00085540 File Offset: 0x00083740
	[Token(Token = "0x600189F")]
	[Address(RVA = "0x525170", Offset = "0x523770", VA = "0x180525170", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_pea_garlic;
	}

	// Token: 0x060018A0 RID: 6304 RVA: 0x00085554 File Offset: 0x00083754
	[Token(Token = "0x60018A0")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public GarlicThreePeater()
	{
	}
}
