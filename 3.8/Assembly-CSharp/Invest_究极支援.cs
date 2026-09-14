using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200003C RID: 60
[Token(Token = "0x200003C")]
public class Invest_究极支援 : InvestBuffData
{
	// Token: 0x06000104 RID: 260 RVA: 0x00004F00 File Offset: 0x00003100
	[Token(Token = "0x6000104")]
	[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.究极支援;
	}

	// Token: 0x06000105 RID: 261 RVA: 0x00004F10 File Offset: 0x00003110
	[Token(Token = "0x6000105")]
	[Address(RVA = "0x3AD3F0", Offset = "0x3AB9F0", VA = "0x1803AD3F0", Slot = "13")]
	public override string GetDescription()
	{
		return "立即获取10个随机究级植物";
	}

	// Token: 0x06000106 RID: 262 RVA: 0x00004F24 File Offset: 0x00003124
	[Token(Token = "0x6000106")]
	[Address(RVA = "0x3AD420", Offset = "0x3ABA20", VA = "0x1803AD420", Slot = "17")]
	public override void OnSelect(Board board)
	{
		List<PlantType> ultimatePlants = Lawnf.GetUltimatePlants();
		Predicate<PlantType> <>9__2_ = Invest_究极支援.<>c.<>9__2_0;
		if (<>9__2_ == 0)
		{
			Invest_究极支援.<>c.<>9__2_0 = delegate(PlantType p)
			{
				bool flag;
				return flag;
			};
		}
		int num = ultimatePlants.RemoveAll(<>9__2_);
		PlantType random = ListExtensions.GetRandom<PlantType>(ultimatePlants);
	}

	// Token: 0x06000107 RID: 263 RVA: 0x00004F70 File Offset: 0x00003170
	[Token(Token = "0x6000107")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_究极支援()
	{
	}
}
