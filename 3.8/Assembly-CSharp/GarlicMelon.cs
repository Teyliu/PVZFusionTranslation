using System;
using Cpp2IlInjected;

// Token: 0x020004F8 RID: 1272
[Token(Token = "0x20004F8")]
public class GarlicMelon : Melonpult
{
	// Token: 0x060017CC RID: 6092 RVA: 0x00081BD0 File Offset: 0x0007FDD0
	[Token(Token = "0x60017CC")]
	[Address(RVA = "0x4C8F70", Offset = "0x4C7570", VA = "0x1804C8F70", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_garlicMelon;
	}

	// Token: 0x060017CD RID: 6093 RVA: 0x00081BE0 File Offset: 0x0007FDE0
	[Token(Token = "0x60017CD")]
	[Address(RVA = "0x41DAA0", Offset = "0x41C0A0", VA = "0x18041DAA0")]
	public GarlicMelon()
	{
	}
}
