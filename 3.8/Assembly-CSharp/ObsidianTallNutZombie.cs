using System;
using Cpp2IlInjected;

// Token: 0x020006A7 RID: 1703
[Token(Token = "0x20006A7")]
public class ObsidianTallNutZombie : WallNutZombie
{
	// Token: 0x06002128 RID: 8488 RVA: 0x000AF394 File Offset: 0x000AD594
	[Token(Token = "0x6002128")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "49")]
	public override void SetJalaed()
	{
	}

	// Token: 0x06002129 RID: 8489 RVA: 0x000AF3A4 File Offset: 0x000AD5A4
	[Token(Token = "0x6002129")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "54")]
	public override void SetCold(float time, int coldLevel = 0, bool fromFreeze = false)
	{
	}

	// Token: 0x0600212A RID: 8490 RVA: 0x000AF3B4 File Offset: 0x000AD5B4
	[Token(Token = "0x600212A")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x0600212B RID: 8491 RVA: 0x000AF3C4 File Offset: 0x000AD5C4
	[Token(Token = "0x600212B")]
	[Address(RVA = "0x5621F0", Offset = "0x5607F0", VA = "0x1805621F0", Slot = "25")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
		base.TakeDamage(damage, this, (DamageType)((uint)12), reportType, fix);
	}

	// Token: 0x0600212C RID: 8492 RVA: 0x000AF3E0 File Offset: 0x000AD5E0
	[Token(Token = "0x600212C")]
	[Address(RVA = "0x534450", Offset = "0x532A50", VA = "0x180534450")]
	public ObsidianTallNutZombie()
	{
	}
}
