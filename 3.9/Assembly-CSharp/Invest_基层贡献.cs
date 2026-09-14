using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x02000049 RID: 73
[Token(Token = "0x2000049")]
public class Invest_基层贡献 : InvestBuffData
{
	// Token: 0x0600013A RID: 314 RVA: 0x000054AC File Offset: 0x000036AC
	[Token(Token = "0x600013A")]
	[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.基层贡献;
	}

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x0600013B RID: 315 RVA: 0x000054BC File Offset: 0x000036BC
	[Token(Token = "0x17000052")]
	public override string Description
	{
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x3F7290", Offset = "0x3F5890", VA = "0x1803F7290", Slot = "13")]
		get
		{
			return "每一轮开始时，场上每有一种非究极植物，我方植物获得3%伤害减免，最多计入10种";
		}
	}

	// Token: 0x0600013C RID: 316 RVA: 0x000054D0 File Offset: 0x000036D0
	[Token(Token = "0x600013C")]
	[Address(RVA = "0x3F70E0", Offset = "0x3F56E0", VA = "0x1803F70E0", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		HashSet<PlantType> plantTypes = Lawnf.GetPlantTypes();
		Func<PlantType, bool> <>9__3_ = Invest_基层贡献.<>c.<>9__3_0;
		if (<>9__3_ == 0)
		{
			Invest_基层贡献.<>c.<>9__3_0 = delegate(PlantType p)
			{
				bool flag;
				return flag;
			};
		}
		int size = Enumerable.ToList<PlantType>(Enumerable.Where<PlantType>(plantTypes, <>9__3_))._size;
		float num;
		TravelMgr.Instance.damageReduction = num;
	}

	// Token: 0x0600013D RID: 317 RVA: 0x0000552C File Offset: 0x0000372C
	[Token(Token = "0x600013D")]
	[Address(RVA = "0x3F2BE0", Offset = "0x3F11E0", VA = "0x1803F2BE0", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x0600013E RID: 318 RVA: 0x0000553C File Offset: 0x0000373C
	[Token(Token = "0x600013E")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_基层贡献()
	{
	}
}
