using System;
using Cpp2IlInjected;

// Token: 0x02000660 RID: 1632
[Token(Token = "0x2000660")]
public class BlackFootballZombie_c : BlackFootballZombie_b
{
	// Token: 0x06001EDD RID: 7901 RVA: 0x000A4804 File Offset: 0x000A2A04
	[Token(Token = "0x6001EDD")]
	[Address(RVA = "0x588A20", Offset = "0x587020", VA = "0x180588A20", Slot = "70")]
	protected override void AttackEffect(Plant plant)
	{
		base.AttackEffect(plant);
		float[] timers = plant.Timers;
		float[] timers2 = plant.Timers;
	}

	// Token: 0x06001EDE RID: 7902 RVA: 0x000A4830 File Offset: 0x000A2A30
	[Token(Token = "0x6001EDE")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "56")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
	}

	// Token: 0x06001EDF RID: 7903 RVA: 0x000A4840 File Offset: 0x000A2A40
	[Token(Token = "0x6001EDF")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x06001EE0 RID: 7904 RVA: 0x000A4850 File Offset: 0x000A2A50
	[Token(Token = "0x6001EE0")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06001EE1 RID: 7905 RVA: 0x000A4860 File Offset: 0x000A2A60
	[Token(Token = "0x6001EE1")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x06001EE2 RID: 7906 RVA: 0x000A4870 File Offset: 0x000A2A70
	[Token(Token = "0x6001EE2")]
	[Address(RVA = "0x588630", Offset = "0x586C30", VA = "0x180588630")]
	public BlackFootballZombie_c()
	{
	}
}
