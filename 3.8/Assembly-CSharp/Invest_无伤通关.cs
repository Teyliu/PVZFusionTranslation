using System;
using Cpp2IlInjected;

// Token: 0x0200003A RID: 58
[Token(Token = "0x200003A")]
public class Invest_无伤通关 : InvestBuffData
{
	// Token: 0x060000F9 RID: 249 RVA: 0x00004D30 File Offset: 0x00002F30
	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.无伤通关;
	}

	// Token: 0x060000FA RID: 250 RVA: 0x00004D40 File Offset: 0x00002F40
	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x3AC020", Offset = "0x3AA620", VA = "0x1803AC020", Slot = "13")]
	public override string GetDescription()
	{
		return "每一轮结束时，若没有植物血量低于0，获得1500积分，全体植物血量增加5%";
	}

	// Token: 0x060000FB RID: 251 RVA: 0x00004D54 File Offset: 0x00002F54
	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x3AC0D0", Offset = "0x3AA6D0", VA = "0x1803AC0D0", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		int num = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)1), action, num != 0);
	}

	// Token: 0x060000FC RID: 252 RVA: 0x00004D70 File Offset: 0x00002F70
	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x3ABF50", Offset = "0x3AA550", VA = "0x1803ABF50")]
	private void Action(object obj)
	{
		TravelMgr.Instance.plantZeroHealth = true;
		Action<object> action;
		EventManager.RemoveListener((GameEvent)((uint)1), action);
	}

	// Token: 0x060000FD RID: 253 RVA: 0x00004D9C File Offset: 0x00002F9C
	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x3AC170", Offset = "0x3AA770", VA = "0x1803AC170", Slot = "18")]
	public override void ReinforcePlant(Board board, Plant plant)
	{
		int num = 0;
		int num2 = 0;
		plant.ModifyHealth((PlantHealthAdder)num2, 0.05f, num != 0);
	}

	// Token: 0x060000FE RID: 254 RVA: 0x00004DC0 File Offset: 0x00002FC0
	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x3AC050", Offset = "0x3AA650", VA = "0x1803AC050", Slot = "14")]
	public override void OnBoardEnd(Board board)
	{
		if (!TravelMgr.Instance.plantZeroHealth)
		{
			int num = 0;
			board.GetPoint(1500f, num != 0);
			return;
		}
	}

	// Token: 0x060000FF RID: 255 RVA: 0x00004DF4 File Offset: 0x00002FF4
	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_无伤通关()
	{
	}
}
