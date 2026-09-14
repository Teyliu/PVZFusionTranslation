using System;
using Cpp2IlInjected;

// Token: 0x0200006E RID: 110
[Token(Token = "0x200006E")]
public class Invest_星辉模仿卡 : InvestBuffData
{
	// Token: 0x060001DD RID: 477 RVA: 0x0000677C File Offset: 0x0000497C
	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x3F81A0", Offset = "0x3F67A0", VA = "0x1803F81A0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.星辉模仿卡;
	}

	// Token: 0x1700006E RID: 110
	// (get) Token: 0x060001DE RID: 478 RVA: 0x00006790 File Offset: 0x00004990
	[Token(Token = "0x1700006E")]
	public override string Description
	{
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x3F8320", Offset = "0x3F6920", VA = "0x1803F8320", Slot = "13")]
		get
		{
			return "每一轮开始时，获得一张星辉模仿卡（模仿植物时，如果植物有星辉形态，则会生成一张星辉植物卡）";
		}
	}

	// Token: 0x060001DF RID: 479 RVA: 0x000067A4 File Offset: 0x000049A4
	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x3F81B0", Offset = "0x3F67B0", VA = "0x1803F81B0", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		Action<Plant> <>9__3_ = Invest_星辉模仿卡.<>c.<>9__3_0;
		if (<>9__3_ == 0)
		{
			Action<Plant> action;
			Invest_星辉模仿卡.<>c.<>9__3_0 = action;
		}
		DroppedCard droppedCard;
		droppedCard.plantAction = <>9__3_;
		throw new NullReferenceException();
	}

	// Token: 0x060001E0 RID: 480 RVA: 0x000067D0 File Offset: 0x000049D0
	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x3F2BE0", Offset = "0x3F11E0", VA = "0x1803F2BE0", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x060001E1 RID: 481 RVA: 0x000067E0 File Offset: 0x000049E0
	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_星辉模仿卡()
	{
	}
}
