using System;
using Cpp2IlInjected;

// Token: 0x0200003E RID: 62
[Token(Token = "0x200003E")]
public class Invest_无伤通关 : InvestBuffData
{
	// Token: 0x06000110 RID: 272 RVA: 0x00004FC0 File Offset: 0x000031C0
	[Token(Token = "0x6000110")]
	[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.无伤通关;
	}

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x06000111 RID: 273 RVA: 0x00004FD0 File Offset: 0x000031D0
	[Token(Token = "0x1700004A")]
	public override string Description
	{
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x3F7F80", Offset = "0x3F6580", VA = "0x1803F7F80", Slot = "13")]
		get
		{
			return "每一轮结束时，若没有植物血量低于0，获得1500积分，全体植物血量增加5%";
		}
	}

	// Token: 0x06000112 RID: 274 RVA: 0x00004FE4 File Offset: 0x000031E4
	[Token(Token = "0x6000112")]
	[Address(RVA = "0x3F7EA0", Offset = "0x3F64A0", VA = "0x1803F7EA0", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		int num = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)1), action, num != 0);
	}

	// Token: 0x06000113 RID: 275 RVA: 0x00005000 File Offset: 0x00003200
	[Token(Token = "0x6000113")]
	[Address(RVA = "0x3F7D50", Offset = "0x3F6350", VA = "0x1803F7D50")]
	private void Action(object obj)
	{
		TravelMgr.Instance.plantZeroHealth = true;
		Action<object> action;
		EventManager.RemoveListener((GameEvent)((uint)1), action);
	}

	// Token: 0x06000114 RID: 276 RVA: 0x0000502C File Offset: 0x0000322C
	[Token(Token = "0x6000114")]
	[Address(RVA = "0x3F7F40", Offset = "0x3F6540", VA = "0x1803F7F40", Slot = "18")]
	public override void ReinforcePlant(Board board, Plant plant)
	{
		int num = 0;
		int num2 = 0;
		plant.ModifyHealth((PlantHealthAdder)num2, 0.05f, num != 0);
	}

	// Token: 0x06000115 RID: 277 RVA: 0x00005050 File Offset: 0x00003250
	[Token(Token = "0x6000115")]
	[Address(RVA = "0x3F7E20", Offset = "0x3F6420", VA = "0x1803F7E20", Slot = "14")]
	public override void OnBoardEnd(Board board)
	{
		if (!TravelMgr.Instance.plantZeroHealth)
		{
			int num = 0;
			board.GetPoint(1500f, num != 0);
			return;
		}
	}

	// Token: 0x06000116 RID: 278 RVA: 0x00005084 File Offset: 0x00003284
	[Token(Token = "0x6000116")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_无伤通关()
	{
	}
}
