using System;
using Cpp2IlInjected;

// Token: 0x020005A1 RID: 1441
[Token(Token = "0x20005A1")]
public class StarPea : Shooter
{
	// Token: 0x06001AAE RID: 6830 RVA: 0x0008F12C File Offset: 0x0008D32C
	[Token(Token = "0x6001AAE")]
	[Address(RVA = "0x545150", Offset = "0x543750", VA = "0x180545150", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_pea_star;
	}

	// Token: 0x06001AAF RID: 6831 RVA: 0x0008F140 File Offset: 0x0008D340
	[Token(Token = "0x6001AAF")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public StarPea()
	{
	}
}
