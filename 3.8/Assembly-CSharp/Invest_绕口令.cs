using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x02000052 RID: 82
[Token(Token = "0x2000052")]
public class Invest_绕口令 : InvestBuffData
{
	// Token: 0x06000158 RID: 344 RVA: 0x00005898 File Offset: 0x00003A98
	[Token(Token = "0x6000158")]
	[Address(RVA = "0x3AD6D0", Offset = "0x3ABCD0", VA = "0x1803AD6D0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.绕口令;
	}

	// Token: 0x06000159 RID: 345 RVA: 0x000058AC File Offset: 0x00003AAC
	[Token(Token = "0x6000159")]
	[Address(RVA = "0x3AD6E0", Offset = "0x3ABCE0", VA = "0x1803AD6E0", Slot = "13")]
	public override string GetDescription()
	{
		return "每一轮开始时，每行最靠左的常规植物获得每行最靠右的常规植物最大生命值0.1%的攻击力加成，每行最靠右的常规植物获得每行最靠左的常规植物攻击力1000%的血量加成";
	}

	// Token: 0x0600015A RID: 346 RVA: 0x000058C0 File Offset: 0x00003AC0
	[Token(Token = "0x600015A")]
	[Address(RVA = "0x3AD710", Offset = "0x3ABD10", VA = "0x1803AD710", Slot = "16")]
	public override void OnBoardLateStart(Board board)
	{
		int num = 0;
		if (num < board.rowNum)
		{
			List<Plant> plantsByRow = Lawnf.GetPlantsByRow(board, num);
			Func<Plant, int> <>9__2_ = Invest_绕口令.<>c.<>9__2_0;
			if (<>9__2_ == 0)
			{
				Func<Plant, int> func;
				Invest_绕口令.<>c.<>9__2_0 = func;
			}
			List<Plant> list = Enumerable.ToList<Plant>(Enumerable.OrderBy<Plant, int>(plantsByRow, <>9__2_));
			Predicate<Plant> predicate;
			if (Invest_绕口令.<>c.<>9__2_1 == 0)
			{
				Invest_绕口令.<>c.<>9__2_1 = predicate;
			}
			int num2 = list.RemoveAll(predicate);
			int num3 = 0;
			Plant plant = list[num3];
			int size = list._size;
			int thePlantType = (int)list[size].thePlantType;
			PlantType plantType = plant.thePlantType;
			PlantDataManager.PlantData plantData = PlantDataManager.GetPlantData(plantType);
			plantType += (int)plantType;
			num++;
		}
	}

	// Token: 0x0600015B RID: 347 RVA: 0x00005968 File Offset: 0x00003B68
	[Token(Token = "0x600015B")]
	[Address(RVA = "0x3ADA90", Offset = "0x3AC090", VA = "0x1803ADA90", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x0600015C RID: 348 RVA: 0x00005978 File Offset: 0x00003B78
	[Token(Token = "0x600015C")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_绕口令()
	{
	}
}
