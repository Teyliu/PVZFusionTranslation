using System;
using Cpp2IlInjected;

// Token: 0x020005CA RID: 1482
[Token(Token = "0x20005CA")]
public class WinterMelon : Melonpult
{
	// Token: 0x06001BAA RID: 7082 RVA: 0x000940D4 File Offset: 0x000922D4
	[Token(Token = "0x6001BAA")]
	[Address(RVA = "0x519E20", Offset = "0x518420", VA = "0x180519E20", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_winterMelon;
	}

	// Token: 0x06001BAB RID: 7083 RVA: 0x000940E4 File Offset: 0x000922E4
	[Token(Token = "0x6001BAB")]
	[Address(RVA = "0x47E9D0", Offset = "0x47CFD0", VA = "0x18047E9D0")]
	public WinterMelon()
	{
	}
}
