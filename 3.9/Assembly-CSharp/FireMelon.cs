using System;
using Cpp2IlInjected;

// Token: 0x02000517 RID: 1303
[Token(Token = "0x2000517")]
public class FireMelon : Melonpult
{
	// Token: 0x06001868 RID: 6248 RVA: 0x00084850 File Offset: 0x00082A50
	[Token(Token = "0x6001868")]
	[Address(RVA = "0x5236F0", Offset = "0x521CF0", VA = "0x1805236F0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_fireMelon;
	}

	// Token: 0x06001869 RID: 6249 RVA: 0x00084860 File Offset: 0x00082A60
	[Token(Token = "0x6001869")]
	[Address(RVA = "0x4D6B50", Offset = "0x4D5150", VA = "0x1804D6B50")]
	public FireMelon()
	{
	}
}
