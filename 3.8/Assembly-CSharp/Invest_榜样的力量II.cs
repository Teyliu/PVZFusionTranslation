using System;
using Cpp2IlInjected;

// Token: 0x0200004F RID: 79
[Token(Token = "0x200004F")]
public class Invest_榜样的力量II : InvestBuffData
{
	// Token: 0x0600014C RID: 332 RVA: 0x000056F4 File Offset: 0x000038F4
	[Token(Token = "0x600014C")]
	[Address(RVA = "0x3AC8C0", Offset = "0x3AAEC0", VA = "0x1803AC8C0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.榜样的力量II;
	}

	// Token: 0x0600014D RID: 333 RVA: 0x00005708 File Offset: 0x00003908
	[Token(Token = "0x600014D")]
	[Address(RVA = "0x3AC8D0", Offset = "0x3AAED0", VA = "0x1803AC8D0", Slot = "13")]
	public override string GetDescription()
	{
		return "伤害统计排名第一的植物称为【榜样】，攻击力增加40%，我方小队伤害增幅提高10%";
	}

	// Token: 0x0600014E RID: 334 RVA: 0x0000571C File Offset: 0x0000391C
	[Token(Token = "0x600014E")]
	[Address(RVA = "0x3AC900", Offset = "0x3AAF00", VA = "0x1803AC900", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		TravelMgr instance = TravelMgr.Instance;
		float damageAmplification = instance.damageAmplification;
		instance.damageAmplification = damageAmplification;
	}

	// Token: 0x0600014F RID: 335 RVA: 0x00005748 File Offset: 0x00003948
	[Token(Token = "0x600014F")]
	[Address(RVA = "0x3A6C80", Offset = "0x3A5280", VA = "0x1803A6C80", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x06000150 RID: 336 RVA: 0x00005758 File Offset: 0x00003958
	[Token(Token = "0x6000150")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_榜样的力量II()
	{
	}
}
