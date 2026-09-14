using System;
using Cpp2IlInjected;

// Token: 0x0200044F RID: 1103
[Token(Token = "0x200044F")]
public class TallIceNut : TallNutFootball
{
	// Token: 0x0600145E RID: 5214 RVA: 0x00071B98 File Offset: 0x0006FD98
	[Token(Token = "0x600145E")]
	[Address(RVA = "0x476720", Offset = "0x474D20", VA = "0x180476720", Slot = "59")]
	public override void InfluenceByIceShroom()
	{
		int num = 0;
		ulong num2;
		base.Recover(1000f, (DamageType)num, true, num2 != 0UL);
	}

	// Token: 0x0600145F RID: 5215 RVA: 0x00071BB8 File Offset: 0x0006FDB8
	[Token(Token = "0x600145F")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public TallIceNut()
	{
	}
}
