using System;
using Cpp2IlInjected;

// Token: 0x02000344 RID: 836
[Token(Token = "0x2000344")]
public class BigPumpkin : JackboxPumpkin
{
	// Token: 0x06000F59 RID: 3929 RVA: 0x0005957C File Offset: 0x0005777C
	[Token(Token = "0x6000F59")]
	[Address(RVA = "0x41A940", Offset = "0x418F40", VA = "0x18041A940", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		if (damageType != DamageType.JackboxExplode)
		{
			return;
		}
	}

	// Token: 0x06000F5A RID: 3930 RVA: 0x00059590 File Offset: 0x00057790
	[Token(Token = "0x6000F5A")]
	[Address(RVA = "0x41A9A0", Offset = "0x418FA0", VA = "0x18041A9A0")]
	public BigPumpkin()
	{
	}
}
