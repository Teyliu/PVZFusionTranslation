using System;
using Cpp2IlInjected;

// Token: 0x020003F3 RID: 1011
[Token(Token = "0x20003F3")]
public class ObsidianSpike : SpikeRock
{
	// Token: 0x060012A4 RID: 4772 RVA: 0x00069078 File Offset: 0x00067278
	[Token(Token = "0x60012A4")]
	[Address(RVA = "0x459090", Offset = "0x457690", VA = "0x180459090", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 15f;
	}

	// Token: 0x060012A5 RID: 4773 RVA: 0x00069098 File Offset: 0x00067298
	[Token(Token = "0x60012A5")]
	[Address(RVA = "0x459040", Offset = "0x457640", VA = "0x180459040", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.AttributeCountdown = 15f;
		int num = 0;
		ulong num2;
		base.Recover(500f, (DamageType)num, true, num2 != 0UL);
	}

	// Token: 0x060012A6 RID: 4774 RVA: 0x000690C0 File Offset: 0x000672C0
	[Token(Token = "0x60012A6")]
	[Address(RVA = "0x459150", Offset = "0x457750", VA = "0x180459150", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)7)))
		{
		}
	}

	// Token: 0x060012A7 RID: 4775 RVA: 0x000690D8 File Offset: 0x000672D8
	[Token(Token = "0x60012A7")]
	[Address(RVA = "0x4590C0", Offset = "0x4576C0", VA = "0x1804590C0", Slot = "73")]
	protected override void OnAttack(Zombie zombie)
	{
		int num = 0;
		if (!Lawnf.TravelAdvanced((AdvBuff)((uint)6)))
		{
			base.OnAttack(zombie);
			return;
		}
		PlantType thePlantType = this.thePlantType;
		ulong num2;
		zombie.TakeDamage(num, this, (DamageType)((uint)4), thePlantType, num2 != 0UL);
	}

	// Token: 0x060012A8 RID: 4776 RVA: 0x00069114 File Offset: 0x00067314
	[Token(Token = "0x60012A8")]
	[Address(RVA = "0x400D00", Offset = "0x3FF300", VA = "0x180400D00")]
	public ObsidianSpike()
	{
	}
}
