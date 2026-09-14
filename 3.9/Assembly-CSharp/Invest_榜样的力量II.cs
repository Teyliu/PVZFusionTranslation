using System;
using Cpp2IlInjected;

// Token: 0x02000053 RID: 83
[Token(Token = "0x2000053")]
public class Invest_榜样的力量II : InvestBuffData
{
	// Token: 0x06000163 RID: 355 RVA: 0x00005978 File Offset: 0x00003B78
	[Token(Token = "0x6000163")]
	[Address(RVA = "0x3F8720", Offset = "0x3F6D20", VA = "0x1803F8720", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.榜样的力量II;
	}

	// Token: 0x1700005A RID: 90
	// (get) Token: 0x06000164 RID: 356 RVA: 0x0000598C File Offset: 0x00003B8C
	[Token(Token = "0x1700005A")]
	public override string Description
	{
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x3F8790", Offset = "0x3F6D90", VA = "0x1803F8790", Slot = "13")]
		get
		{
			return "伤害统计排名第一的植物称为【榜样】，攻击力增加40%，我方小队伤害增幅提高10%";
		}
	}

	// Token: 0x06000165 RID: 357 RVA: 0x000059A0 File Offset: 0x00003BA0
	[Token(Token = "0x6000165")]
	[Address(RVA = "0x3F8730", Offset = "0x3F6D30", VA = "0x1803F8730", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		TravelMgr instance = TravelMgr.Instance;
		float damageAmplification = instance.damageAmplification;
		instance.damageAmplification = damageAmplification;
	}

	// Token: 0x06000166 RID: 358 RVA: 0x000059CC File Offset: 0x00003BCC
	[Token(Token = "0x6000166")]
	[Address(RVA = "0x3F2BE0", Offset = "0x3F11E0", VA = "0x1803F2BE0", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x06000167 RID: 359 RVA: 0x000059DC File Offset: 0x00003BDC
	[Token(Token = "0x6000167")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_榜样的力量II()
	{
	}
}
