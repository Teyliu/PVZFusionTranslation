using System;
using Cpp2IlInjected;

// Token: 0x02000513 RID: 1299
[Token(Token = "0x2000513")]
public class FireCabbage : Cabbage
{
	// Token: 0x0600185D RID: 6237 RVA: 0x00084548 File Offset: 0x00082748
	[Token(Token = "0x600185D")]
	[Address(RVA = "0x522D00", Offset = "0x521300", VA = "0x180522D00", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cabbage_fire;
	}

	// Token: 0x0600185E RID: 6238 RVA: 0x0008455C File Offset: 0x0008275C
	[Token(Token = "0x600185E")]
	[Address(RVA = "0x4D6B50", Offset = "0x4D5150", VA = "0x1804D6B50")]
	public FireCabbage()
	{
	}
}
