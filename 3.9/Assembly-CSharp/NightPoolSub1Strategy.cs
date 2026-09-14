using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000948 RID: 2376
[Token(Token = "0x2000948")]
public class NightPoolSub1Strategy : BaseLevelStrategy
{
	// Token: 0x060030A3 RID: 12451 RVA: 0x00103D10 File Offset: 0x00101F10
	[Token(Token = "0x60030A3")]
	[Address(RVA = "0x717DA0", Offset = "0x7163A0", VA = "0x180717DA0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.NightPool_sub1;
	}

	// Token: 0x060030A4 RID: 12452 RVA: 0x00103D20 File Offset: 0x00101F20
	[Token(Token = "0x60030A4")]
	[Address(RVA = "0x718020", Offset = "0x716620", VA = "0x180718020", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.boardTag.isSeedRain = true;
		List<PlantType> randomPlantTypes = base.GetRandomPlantTypes();
		board.seedPool = randomPlantTypes;
		throw new NullReferenceException();
	}

	// Token: 0x060030A5 RID: 12453 RVA: 0x00103D4C File Offset: 0x00101F4C
	[Token(Token = "0x60030A5")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x060030A6 RID: 12454 RVA: 0x00103D5C File Offset: 0x00101F5C
	[Token(Token = "0x60030A6")]
	[Address(RVA = "0x717DB0", Offset = "0x7163B0", VA = "0x180717DB0", Slot = "24")]
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

	// Token: 0x060030A7 RID: 12455 RVA: 0x00103DBC File Offset: 0x00101FBC
	[Token(Token = "0x60030A7")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Plantern;
	}

	// Token: 0x060030A8 RID: 12456 RVA: 0x00103DCC File Offset: 0x00101FCC
	[Token(Token = "0x60030A8")]
	[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.NightPool;
	}

	// Token: 0x060030A9 RID: 12457 RVA: 0x00103DDC File Offset: 0x00101FDC
	[Token(Token = "0x60030A9")]
	[Address(RVA = "0x717D70", Offset = "0x716370", VA = "0x180717D70", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：种子雨";
	}

	// Token: 0x060030AA RID: 12458 RVA: 0x00103DF0 File Offset: 0x00101FF0
	[Token(Token = "0x60030AA")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public NightPoolSub1Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
