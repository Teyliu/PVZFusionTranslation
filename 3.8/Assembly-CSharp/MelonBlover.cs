using System;
using Cpp2IlInjected;

// Token: 0x02000537 RID: 1335
[Token(Token = "0x2000537")]
public class MelonBlover : CabbageBlover
{
	// Token: 0x060018D4 RID: 6356 RVA: 0x00086D28 File Offset: 0x00084F28
	[Token(Token = "0x60018D4")]
	[Address(RVA = "0x453480", Offset = "0x451A80", VA = "0x180453480", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_melon;
	}

	// Token: 0x060018D5 RID: 6357 RVA: 0x00086D38 File Offset: 0x00084F38
	[Token(Token = "0x60018D5")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public MelonBlover()
	{
	}
}
