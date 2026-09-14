using System;
using Cpp2IlInjected;

// Token: 0x0200062B RID: 1579
[Token(Token = "0x200062B")]
public class BlackFootballZombie_c : BlackFootballZombie_b
{
	// Token: 0x06001DDE RID: 7646 RVA: 0x000A01F0 File Offset: 0x0009E3F0
	[Token(Token = "0x6001DDE")]
	[Address(RVA = "0x531ED0", Offset = "0x5304D0", VA = "0x180531ED0", Slot = "68")]
	protected override void AttackEffect(Plant plant)
	{
		base.AttackEffect(plant);
		float[] timers = plant.Timers;
		float[] timers2 = plant.Timers;
	}

	// Token: 0x06001DDF RID: 7647 RVA: 0x000A021C File Offset: 0x0009E41C
	[Token(Token = "0x6001DDF")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "54")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
	}

	// Token: 0x06001DE0 RID: 7648 RVA: 0x000A022C File Offset: 0x0009E42C
	[Token(Token = "0x6001DE0")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x06001DE1 RID: 7649 RVA: 0x000A023C File Offset: 0x0009E43C
	[Token(Token = "0x6001DE1")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06001DE2 RID: 7650 RVA: 0x000A024C File Offset: 0x0009E44C
	[Token(Token = "0x6001DE2")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x06001DE3 RID: 7651 RVA: 0x000A025C File Offset: 0x0009E45C
	[Token(Token = "0x6001DE3")]
	[Address(RVA = "0x531AE0", Offset = "0x5300E0", VA = "0x180531AE0")]
	public BlackFootballZombie_c()
	{
	}
}
