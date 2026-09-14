using System;
using Cpp2IlInjected;

// Token: 0x020004FC RID: 1276
[Token(Token = "0x20004FC")]
public class CherryThreePeater : ThreePeater
{
	// Token: 0x060017FE RID: 6142 RVA: 0x0008313C File Offset: 0x0008133C
	[Token(Token = "0x60017FE")]
	[Address(RVA = "0x51EF10", Offset = "0x51D510", VA = "0x18051EF10", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_pea_threeCherry;
	}

	// Token: 0x060017FF RID: 6143 RVA: 0x00083150 File Offset: 0x00081350
	[Token(Token = "0x60017FF")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public CherryThreePeater()
	{
	}
}
