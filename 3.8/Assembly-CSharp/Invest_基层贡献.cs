using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x02000045 RID: 69
[Token(Token = "0x2000045")]
public class Invest_基层贡献 : InvestBuffData
{
	// Token: 0x06000123 RID: 291 RVA: 0x00005228 File Offset: 0x00003428
	[Token(Token = "0x6000123")]
	[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.基层贡献;
	}

	// Token: 0x06000124 RID: 292 RVA: 0x00005238 File Offset: 0x00003438
	[Token(Token = "0x6000124")]
	[Address(RVA = "0x3AB2E0", Offset = "0x3A98E0", VA = "0x1803AB2E0", Slot = "13")]
	public override string GetDescription()
	{
		return "每一轮开始时，场上每有一种非究极植物，我方植物获得3%伤害减免，最多计入10种";
	}

	// Token: 0x06000125 RID: 293 RVA: 0x0000524C File Offset: 0x0000344C
	[Token(Token = "0x6000125")]
	[Address(RVA = "0x3AB310", Offset = "0x3A9910", VA = "0x1803AB310", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		HashSet<PlantType> plantTypes = Lawnf.GetPlantTypes();
		Func<PlantType, bool> <>9__2_ = Invest_基层贡献.<>c.<>9__2_0;
		if (<>9__2_ == 0)
		{
			Invest_基层贡献.<>c.<>9__2_0 = delegate(PlantType p)
			{
				bool flag;
				return flag;
			};
		}
		int size = Enumerable.ToList<PlantType>(Enumerable.Where<PlantType>(plantTypes, <>9__2_))._size;
		float num;
		TravelMgr.Instance.damageReduction = num;
	}

	// Token: 0x06000126 RID: 294 RVA: 0x000052A8 File Offset: 0x000034A8
	[Token(Token = "0x6000126")]
	[Address(RVA = "0x3A6C80", Offset = "0x3A5280", VA = "0x1803A6C80", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x06000127 RID: 295 RVA: 0x000052B8 File Offset: 0x000034B8
	[Token(Token = "0x6000127")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_基层贡献()
	{
	}
}
