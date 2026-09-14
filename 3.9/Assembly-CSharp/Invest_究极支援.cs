using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000040 RID: 64
[Token(Token = "0x2000040")]
public class Invest_究极支援 : InvestBuffData
{
	// Token: 0x0600011B RID: 283 RVA: 0x0000517C File Offset: 0x0000337C
	[Token(Token = "0x600011B")]
	[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.究极支援;
	}

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x0600011C RID: 284 RVA: 0x0000518C File Offset: 0x0000338C
	[Token(Token = "0x1700004C")]
	public override string Description
	{
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x3F9440", Offset = "0x3F7A40", VA = "0x1803F9440", Slot = "13")]
		get
		{
			return "立即获取10个随机究级植物";
		}
	}

	// Token: 0x0600011D RID: 285 RVA: 0x000051A0 File Offset: 0x000033A0
	[Token(Token = "0x600011D")]
	[Address(RVA = "0x3F9260", Offset = "0x3F7860", VA = "0x1803F9260", Slot = "17")]
	public override void OnSelect(Board board)
	{
		List<PlantType> ultimatePlants = Lawnf.GetUltimatePlants();
		Predicate<PlantType> <>9__3_ = Invest_究极支援.<>c.<>9__3_0;
		if (<>9__3_ == 0)
		{
			Invest_究极支援.<>c.<>9__3_0 = delegate(PlantType p)
			{
				bool flag;
				return flag;
			};
		}
		int num = ultimatePlants.RemoveAll(<>9__3_);
		PlantType random = ListExtensions.GetRandom<PlantType>(ultimatePlants);
	}

	// Token: 0x0600011E RID: 286 RVA: 0x000051EC File Offset: 0x000033EC
	[Token(Token = "0x600011E")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_究极支援()
	{
	}
}
