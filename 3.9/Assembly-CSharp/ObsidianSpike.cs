using System;
using Cpp2IlInjected;

// Token: 0x0200040D RID: 1037
[Token(Token = "0x200040D")]
public class ObsidianSpike : SpikeRock
{
	// Token: 0x06001317 RID: 4887 RVA: 0x0006ADFC File Offset: 0x00068FFC
	[Token(Token = "0x6001317")]
	[Address(RVA = "0x4AD470", Offset = "0x4ABA70", VA = "0x1804AD470", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 15f;
	}

	// Token: 0x06001318 RID: 4888 RVA: 0x0006AE1C File Offset: 0x0006901C
	[Token(Token = "0x6001318")]
	[Address(RVA = "0x4AD420", Offset = "0x4ABA20", VA = "0x1804AD420", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.AttributeCountdown = 15f;
		int num = 0;
		ulong num2;
		base.Recover(500f, (DamageType)num, true, num2 != 0UL);
	}

	// Token: 0x06001319 RID: 4889 RVA: 0x0006AE44 File Offset: 0x00069044
	[Token(Token = "0x6001319")]
	[Address(RVA = "0x4AD530", Offset = "0x4ABB30", VA = "0x1804AD530", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)7)))
		{
		}
	}

	// Token: 0x0600131A RID: 4890 RVA: 0x0006AE5C File Offset: 0x0006905C
	[Token(Token = "0x600131A")]
	[Address(RVA = "0x4AD4A0", Offset = "0x4ABAA0", VA = "0x1804AD4A0", Slot = "72")]
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

	// Token: 0x0600131B RID: 4891 RVA: 0x0006AE98 File Offset: 0x00069098
	[Token(Token = "0x600131B")]
	[Address(RVA = "0x488C90", Offset = "0x487290", VA = "0x180488C90")]
	public ObsidianSpike()
	{
	}
}
