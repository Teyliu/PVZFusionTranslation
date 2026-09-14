using System;
using Cpp2IlInjected;

// Token: 0x0200057C RID: 1404
[Token(Token = "0x200057C")]
public class RedLunarCabbage : LunarCabbage
{
	// Token: 0x06001A10 RID: 6672 RVA: 0x0008C1BC File Offset: 0x0008A3BC
	[Token(Token = "0x6001A10")]
	[Address(RVA = "0x53AFA0", Offset = "0x5395A0", VA = "0x18053AFA0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_redLunarCabbage;
	}

	// Token: 0x06001A11 RID: 6673 RVA: 0x0008C1D0 File Offset: 0x0008A3D0
	[Token(Token = "0x6001A11")]
	[Address(RVA = "0x474940", Offset = "0x472F40", VA = "0x180474940")]
	public RedLunarCabbage()
	{
	}
}
