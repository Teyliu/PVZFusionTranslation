using System;
using Cpp2IlInjected;

// Token: 0x0200050B RID: 1291
[Token(Token = "0x200050B")]
public class DoomMelon : Melonpult
{
	// Token: 0x06001841 RID: 6209 RVA: 0x00083DE0 File Offset: 0x00081FE0
	[Token(Token = "0x6001841")]
	[Address(RVA = "0x5217B0", Offset = "0x51FDB0", VA = "0x1805217B0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_doomMelon;
	}

	// Token: 0x06001842 RID: 6210 RVA: 0x00083DF4 File Offset: 0x00081FF4
	[Token(Token = "0x6001842")]
	[Address(RVA = "0x4D6B50", Offset = "0x4D5150", VA = "0x1804D6B50")]
	public DoomMelon()
	{
	}
}
