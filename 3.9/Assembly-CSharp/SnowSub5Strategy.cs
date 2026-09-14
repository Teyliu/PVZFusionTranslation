using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000975 RID: 2421
[Token(Token = "0x2000975")]
public class SnowSub5Strategy : BaseLevelStrategy
{
	// Token: 0x060031CE RID: 12750 RVA: 0x00106C44 File Offset: 0x00104E44
	[Token(Token = "0x60031CE")]
	[Address(RVA = "0x549950", Offset = "0x547F50", VA = "0x180549950", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Snow_sub5;
	}

	// Token: 0x060031CF RID: 12751 RVA: 0x00106C54 File Offset: 0x00104E54
	[Token(Token = "0x60031CF")]
	[Address(RVA = "0x712FE0", Offset = "0x7115E0", VA = "0x180712FE0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 30;
	}

	// Token: 0x060031D0 RID: 12752 RVA: 0x00106C64 File Offset: 0x00104E64
	[Token(Token = "0x60031D0")]
	[Address(RVA = "0x7271F0", Offset = "0x7257F0", VA = "0x1807271F0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		int size6 = list._size;
		return list;
	}

	// Token: 0x060031D1 RID: 12753 RVA: 0x00106CC0 File Offset: 0x00104EC0
	[Token(Token = "0x60031D1")]
	[Address(RVA = "0x71E400", Offset = "0x71CA00", VA = "0x18071E400", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.PineFurnace;
	}

	// Token: 0x060031D2 RID: 12754 RVA: 0x00106CD0 File Offset: 0x00104ED0
	[Token(Token = "0x60031D2")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Snow_6;
	}

	// Token: 0x060031D3 RID: 12755 RVA: 0x00106CE0 File Offset: 0x00104EE0
	[Token(Token = "0x60031D3")]
	[Address(RVA = "0x727190", Offset = "0x725790", VA = "0x180727190", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：雪皇之怒";
	}

	// Token: 0x060031D4 RID: 12756 RVA: 0x00106CF4 File Offset: 0x00104EF4
	[Token(Token = "0x60031D4")]
	[Address(RVA = "0x7271C0", Offset = "0x7257C0", VA = "0x1807271C0", Slot = "31")]
	public override string GetLevelTip()
	{
		return "危机预警：资源短缺";
	}

	// Token: 0x060031D5 RID: 12757 RVA: 0x00106D08 File Offset: 0x00104F08
	[Token(Token = "0x60031D5")]
	[Address(RVA = "0x727460", Offset = "0x725A60", VA = "0x180727460", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.boardTag.snowBoss = true;
		board.boardTag.lessSun = true;
		int num = board.theSun;
		num -= board;
		board.theSun = num;
		int num2 = board.theMoney;
		num2 -= board;
		board.theMoney = num2;
	}

	// Token: 0x060031D6 RID: 12758 RVA: 0x00106D58 File Offset: 0x00104F58
	[Token(Token = "0x60031D6")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public SnowSub5Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
