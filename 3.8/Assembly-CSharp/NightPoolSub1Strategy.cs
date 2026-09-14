using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200090C RID: 2316
[Token(Token = "0x200090C")]
public class NightPoolSub1Strategy : BaseLevelStrategy
{
	// Token: 0x06002F70 RID: 12144 RVA: 0x000FF088 File Offset: 0x000FD288
	[Token(Token = "0x6002F70")]
	[Address(RVA = "0x69DC40", Offset = "0x69C240", VA = "0x18069DC40", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.NightPool_sub1;
	}

	// Token: 0x06002F71 RID: 12145 RVA: 0x000FF098 File Offset: 0x000FD298
	[Token(Token = "0x6002F71")]
	[Address(RVA = "0x69DEC0", Offset = "0x69C4C0", VA = "0x18069DEC0", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.boardTag.isSeedRain = true;
		List<PlantType> randomPlantTypes = base.GetRandomPlantTypes();
		board.seedPool = randomPlantTypes;
		throw new NullReferenceException();
	}

	// Token: 0x06002F72 RID: 12146 RVA: 0x000FF0C4 File Offset: 0x000FD2C4
	[Token(Token = "0x6002F72")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002F73 RID: 12147 RVA: 0x000FF0D4 File Offset: 0x000FD2D4
	[Token(Token = "0x6002F73")]
	[Address(RVA = "0x69DC50", Offset = "0x69C250", VA = "0x18069DC50", Slot = "24")]
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

	// Token: 0x06002F74 RID: 12148 RVA: 0x000FF134 File Offset: 0x000FD334
	[Token(Token = "0x6002F74")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Plantern;
	}

	// Token: 0x06002F75 RID: 12149 RVA: 0x000FF144 File Offset: 0x000FD344
	[Token(Token = "0x6002F75")]
	[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.NightPool;
	}

	// Token: 0x06002F76 RID: 12150 RVA: 0x000FF154 File Offset: 0x000FD354
	[Token(Token = "0x6002F76")]
	[Address(RVA = "0x69DC10", Offset = "0x69C210", VA = "0x18069DC10", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：种子雨";
	}

	// Token: 0x06002F77 RID: 12151 RVA: 0x000FF168 File Offset: 0x000FD368
	[Token(Token = "0x6002F77")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public NightPoolSub1Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
