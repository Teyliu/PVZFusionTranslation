using System;
using Cpp2IlInjected;

// Token: 0x020003D5 RID: 981
[Token(Token = "0x20003D5")]
public class JackboxPumpkin : MagnetPumpkin
{
	// Token: 0x060011EC RID: 4588 RVA: 0x00064DB0 File Offset: 0x00062FB0
	[Token(Token = "0x60011EC")]
	[Address(RVA = "0x497340", Offset = "0x495940", VA = "0x180497340", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		if (damageType != DamageType.JackboxExplode)
		{
			return;
		}
	}

	// Token: 0x060011ED RID: 4589 RVA: 0x00064DC4 File Offset: 0x00062FC4
	[Token(Token = "0x60011ED")]
	[Address(RVA = "0x497370", Offset = "0x495970", VA = "0x180497370")]
	public JackboxPumpkin()
	{
	}
}
