using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x02000056 RID: 86
[Token(Token = "0x2000056")]
public class Invest_绕口令 : InvestBuffData
{
	// Token: 0x0600016F RID: 367 RVA: 0x00005B1C File Offset: 0x00003D1C
	[Token(Token = "0x600016F")]
	[Address(RVA = "0x3F9540", Offset = "0x3F7B40", VA = "0x1803F9540", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.绕口令;
	}

	// Token: 0x1700005C RID: 92
	// (get) Token: 0x06000170 RID: 368 RVA: 0x00005B30 File Offset: 0x00003D30
	[Token(Token = "0x1700005C")]
	public override string Description
	{
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x3F98F0", Offset = "0x3F7EF0", VA = "0x1803F98F0", Slot = "13")]
		get
		{
			return "每一轮开始时，每行最靠左的常规植物获得每行最靠右的常规植物最大生命值0.1%的攻击力加成，每行最靠右的常规植物获得每行最靠左的常规植物攻击力1000%的血量加成";
		}
	}

	// Token: 0x06000171 RID: 369 RVA: 0x00005B44 File Offset: 0x00003D44
	[Token(Token = "0x6000171")]
	[Address(RVA = "0x3F9550", Offset = "0x3F7B50", VA = "0x1803F9550", Slot = "16")]
	public override void OnBoardLateStart(Board board)
	{
		int num = 0;
		if (num < board.rowNum)
		{
			List<Plant> plantsByRow = Lawnf.GetPlantsByRow(board, num);
			Func<Plant, int> <>9__3_ = Invest_绕口令.<>c.<>9__3_0;
			if (<>9__3_ == 0)
			{
				Func<Plant, int> func;
				Invest_绕口令.<>c.<>9__3_0 = func;
			}
			List<Plant> list = Enumerable.ToList<Plant>(Enumerable.OrderBy<Plant, int>(plantsByRow, <>9__3_));
			Predicate<Plant> predicate;
			if (Invest_绕口令.<>c.<>9__3_1 == 0)
			{
				Invest_绕口令.<>c.<>9__3_1 = predicate;
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

	// Token: 0x06000172 RID: 370 RVA: 0x00005BEC File Offset: 0x00003DEC
	[Token(Token = "0x6000172")]
	[Address(RVA = "0x3F98D0", Offset = "0x3F7ED0", VA = "0x1803F98D0", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x06000173 RID: 371 RVA: 0x00005BFC File Offset: 0x00003DFC
	[Token(Token = "0x6000173")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_绕口令()
	{
	}
}
