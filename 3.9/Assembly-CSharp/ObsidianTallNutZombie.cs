using System;
using Cpp2IlInjected;

// Token: 0x020006DE RID: 1758
[Token(Token = "0x20006DE")]
public class ObsidianTallNutZombie : WallNutZombie
{
	// Token: 0x0600223F RID: 8767 RVA: 0x000B4040 File Offset: 0x000B2240
	[Token(Token = "0x600223F")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "51")]
	public override void SetJalaed()
	{
	}

	// Token: 0x06002240 RID: 8768 RVA: 0x000B4050 File Offset: 0x000B2250
	[Token(Token = "0x6002240")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "56")]
	public override void SetCold(float time, int coldLevel = 0, bool fromFreeze = false)
	{
	}

	// Token: 0x06002241 RID: 8769 RVA: 0x000B4060 File Offset: 0x000B2260
	[Token(Token = "0x6002241")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x06002242 RID: 8770 RVA: 0x000B4070 File Offset: 0x000B2270
	[Token(Token = "0x6002242")]
	[Address(RVA = "0x5C4FE0", Offset = "0x5C35E0", VA = "0x1805C4FE0", Slot = "26")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
		base.TakeDamage(damage, this, (DamageType)((uint)12), reportType, fix);
	}

	// Token: 0x06002243 RID: 8771 RVA: 0x000B408C File Offset: 0x000B228C
	[Token(Token = "0x6002243")]
	[Address(RVA = "0x58B130", Offset = "0x589730", VA = "0x18058B130")]
	public ObsidianTallNutZombie()
	{
	}
}
