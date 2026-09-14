using System;
using Cpp2IlInjected;

// Token: 0x020004E3 RID: 1251
[Token(Token = "0x20004E3")]
public class DoomMelon : Melonpult
{
	// Token: 0x0600178A RID: 6026 RVA: 0x00080B98 File Offset: 0x0007ED98
	[Token(Token = "0x600178A")]
	[Address(RVA = "0x4A1C80", Offset = "0x4A0280", VA = "0x1804A1C80", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_doomMelon;
	}

	// Token: 0x0600178B RID: 6027 RVA: 0x00080BAC File Offset: 0x0007EDAC
	[Token(Token = "0x600178B")]
	[Address(RVA = "0x47E9D0", Offset = "0x47CFD0", VA = "0x18047E9D0")]
	public DoomMelon()
	{
	}
}
