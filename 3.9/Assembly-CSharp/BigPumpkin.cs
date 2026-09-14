using System;
using Cpp2IlInjected;

// Token: 0x02000354 RID: 852
[Token(Token = "0x2000354")]
public class BigPumpkin : JackboxPumpkin
{
	// Token: 0x06000FA5 RID: 4005 RVA: 0x0005A4DC File Offset: 0x000586DC
	[Token(Token = "0x6000FA5")]
	[Address(RVA = "0x4717E0", Offset = "0x46FDE0", VA = "0x1804717E0", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		if (damageType != DamageType.JackboxExplode)
		{
			return;
		}
	}

	// Token: 0x06000FA6 RID: 4006 RVA: 0x0005A4F0 File Offset: 0x000586F0
	[Token(Token = "0x6000FA6")]
	[Address(RVA = "0x471840", Offset = "0x46FE40", VA = "0x180471840")]
	public BigPumpkin()
	{
	}
}
