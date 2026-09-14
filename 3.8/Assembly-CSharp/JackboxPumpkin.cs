using System;
using Cpp2IlInjected;

// Token: 0x020003C1 RID: 961
[Token(Token = "0x20003C1")]
public class JackboxPumpkin : MagnetPumpkin
{
	// Token: 0x06001190 RID: 4496 RVA: 0x00063790 File Offset: 0x00061990
	[Token(Token = "0x6001190")]
	[Address(RVA = "0x4453F0", Offset = "0x4439F0", VA = "0x1804453F0", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		if (damageType != DamageType.JackboxExplode)
		{
			return;
		}
	}

	// Token: 0x06001191 RID: 4497 RVA: 0x000637A4 File Offset: 0x000619A4
	[Token(Token = "0x6001191")]
	[Address(RVA = "0x41C050", Offset = "0x41A650", VA = "0x18041C050")]
	public JackboxPumpkin()
	{
	}
}
