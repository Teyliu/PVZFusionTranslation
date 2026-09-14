using System;
using Cpp2IlInjected;

// Token: 0x020004EF RID: 1263
[Token(Token = "0x20004EF")]
public class FireMelon : Melonpult
{
	// Token: 0x060017B1 RID: 6065 RVA: 0x00081608 File Offset: 0x0007F808
	[Token(Token = "0x60017B1")]
	[Address(RVA = "0x4C83B0", Offset = "0x4C69B0", VA = "0x1804C83B0", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_fireMelon;
	}

	// Token: 0x060017B2 RID: 6066 RVA: 0x00081618 File Offset: 0x0007F818
	[Token(Token = "0x60017B2")]
	[Address(RVA = "0x41DAA0", Offset = "0x41C0A0", VA = "0x18041DAA0")]
	public FireMelon()
	{
	}
}
