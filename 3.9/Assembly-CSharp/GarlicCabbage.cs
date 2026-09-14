using System;
using Cpp2IlInjected;

// Token: 0x0200051F RID: 1311
[Token(Token = "0x200051F")]
public class GarlicCabbage : Cabbage
{
	// Token: 0x0600188A RID: 6282 RVA: 0x00085294 File Offset: 0x00083494
	[Token(Token = "0x600188A")]
	[Address(RVA = "0x524F40", Offset = "0x523540", VA = "0x180524F40", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_garlicCabbage;
	}

	// Token: 0x0600188B RID: 6283 RVA: 0x000852A4 File Offset: 0x000834A4
	[Token(Token = "0x600188B")]
	[Address(RVA = "0x4D6B50", Offset = "0x4D5150", VA = "0x1804D6B50")]
	public GarlicCabbage()
	{
	}
}
