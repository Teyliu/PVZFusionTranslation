using System;
using Cpp2IlInjected;

// Token: 0x0200051C RID: 1308
[Token(Token = "0x200051C")]
public class IronMelon : Melonpult
{
	// Token: 0x0600185E RID: 6238 RVA: 0x00084B28 File Offset: 0x00082D28
	[Token(Token = "0x600185E")]
	[Address(RVA = "0x4CFBA0", Offset = "0x4CE1A0", VA = "0x1804CFBA0", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_melon_iron;
	}

	// Token: 0x0600185F RID: 6239 RVA: 0x00084B3C File Offset: 0x00082D3C
	[Token(Token = "0x600185F")]
	[Address(RVA = "0x41DAA0", Offset = "0x41C0A0", VA = "0x18041DAA0")]
	public IronMelon()
	{
	}
}
