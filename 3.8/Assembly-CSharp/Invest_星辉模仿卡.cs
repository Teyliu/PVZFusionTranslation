using System;
using Cpp2IlInjected;

// Token: 0x0200006A RID: 106
[Token(Token = "0x200006A")]
public class Invest_星辉模仿卡 : InvestBuffData
{
	// Token: 0x060001C6 RID: 454 RVA: 0x000064E0 File Offset: 0x000046E0
	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x3AC3A0", Offset = "0x3AA9A0", VA = "0x1803AC3A0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.星辉模仿卡;
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x000064F4 File Offset: 0x000046F4
	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x3AC3B0", Offset = "0x3AA9B0", VA = "0x1803AC3B0", Slot = "13")]
	public override string GetDescription()
	{
		return "每一轮开始时，获得一张星辉模仿卡（模仿植物时，如果植物有星辉形态，则会生成一张星辉植物卡）";
	}

	// Token: 0x060001C8 RID: 456 RVA: 0x00006508 File Offset: 0x00004708
	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x3AC3E0", Offset = "0x3AA9E0", VA = "0x1803AC3E0", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		Action<Plant> <>9__2_ = Invest_星辉模仿卡.<>c.<>9__2_0;
		if (<>9__2_ == 0)
		{
			Action<Plant> action;
			Invest_星辉模仿卡.<>c.<>9__2_0 = action;
		}
		DroppedCard droppedCard;
		droppedCard.plantAction = <>9__2_;
		throw new NullReferenceException();
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x00006534 File Offset: 0x00004734
	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x3A6C80", Offset = "0x3A5280", VA = "0x1803A6C80", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x060001CA RID: 458 RVA: 0x00006544 File Offset: 0x00004744
	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_星辉模仿卡()
	{
	}
}
