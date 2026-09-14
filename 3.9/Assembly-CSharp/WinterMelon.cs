using System;
using Cpp2IlInjected;

// Token: 0x020005FF RID: 1535
[Token(Token = "0x20005FF")]
public class WinterMelon : Melonpult
{
	// Token: 0x06001CA9 RID: 7337 RVA: 0x00098CC8 File Offset: 0x00096EC8
	[Token(Token = "0x6001CA9")]
	[Address(RVA = "0x56F770", Offset = "0x56DD70", VA = "0x18056F770", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_winterMelon;
	}

	// Token: 0x06001CAA RID: 7338 RVA: 0x00098CD8 File Offset: 0x00096ED8
	[Token(Token = "0x6001CAA")]
	[Address(RVA = "0x4D6B50", Offset = "0x4D5150", VA = "0x1804D6B50")]
	public WinterMelon()
	{
	}
}
