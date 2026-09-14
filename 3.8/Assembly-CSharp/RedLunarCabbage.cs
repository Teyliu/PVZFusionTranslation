using System;
using Cpp2IlInjected;

// Token: 0x0200054D RID: 1357
[Token(Token = "0x200054D")]
public class RedLunarCabbage : LunarCabbage
{
	// Token: 0x06001934 RID: 6452 RVA: 0x00088250 File Offset: 0x00086450
	[Token(Token = "0x6001934")]
	[Address(RVA = "0x4DCE90", Offset = "0x4DB490", VA = "0x1804DCE90", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_redLunarCabbage;
	}

	// Token: 0x06001935 RID: 6453 RVA: 0x00088264 File Offset: 0x00086464
	[Token(Token = "0x6001935")]
	[Address(RVA = "0x4DCEA0", Offset = "0x4DB4A0", VA = "0x1804DCEA0")]
	public RedLunarCabbage()
	{
	}
}
