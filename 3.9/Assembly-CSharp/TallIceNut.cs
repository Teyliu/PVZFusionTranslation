using System;
using Cpp2IlInjected;

// Token: 0x0200046F RID: 1135
[Token(Token = "0x200046F")]
public class TallIceNut : TallNutFootball
{
	// Token: 0x060014EE RID: 5358 RVA: 0x00073EE8 File Offset: 0x000720E8
	[Token(Token = "0x60014EE")]
	[Address(RVA = "0x4CDFD0", Offset = "0x4CC5D0", VA = "0x1804CDFD0", Slot = "58")]
	public override void InfluenceByIceShroom()
	{
		int num = 0;
		ulong num2;
		base.Recover(1000f, (DamageType)num, true, num2 != 0UL);
	}

	// Token: 0x060014EF RID: 5359 RVA: 0x00073F08 File Offset: 0x00072108
	[Token(Token = "0x60014EF")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public TallIceNut()
	{
	}
}
