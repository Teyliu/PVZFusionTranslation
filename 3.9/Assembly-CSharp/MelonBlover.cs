using System;
using Cpp2IlInjected;

// Token: 0x02000564 RID: 1380
[Token(Token = "0x2000564")]
public class MelonBlover : CabbageBlover
{
	// Token: 0x060019A4 RID: 6564 RVA: 0x0008A9E0 File Offset: 0x00088BE0
	[Token(Token = "0x60019A4")]
	[Address(RVA = "0x4A8140", Offset = "0x4A6740", VA = "0x1804A8140", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_melon;
	}

	// Token: 0x060019A5 RID: 6565 RVA: 0x0008A9F0 File Offset: 0x00088BF0
	[Token(Token = "0x60019A5")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public MelonBlover()
	{
	}
}
