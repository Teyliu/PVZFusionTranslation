using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x02000937 RID: 2359
[Token(Token = "0x2000937")]
public class PoolSub3Strategy : BaseLevelStrategy
{
	// Token: 0x06003030 RID: 12336 RVA: 0x001028EC File Offset: 0x00100AEC
	[Token(Token = "0x6003030")]
	[Address(RVA = "0x71D780", Offset = "0x71BD80", VA = "0x18071D780", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Pool_sub3;
	}

	// Token: 0x06003031 RID: 12337 RVA: 0x001028FC File Offset: 0x00100AFC
	[Token(Token = "0x6003031")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06003032 RID: 12338 RVA: 0x0010290C File Offset: 0x00100B0C
	[Token(Token = "0x6003032")]
	[Address(RVA = "0x71D790", Offset = "0x71BD90", VA = "0x18071D790", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		int size6 = list._size;
		int size7 = list._size;
		int size8 = list._size;
		return list;
	}

	// Token: 0x06003033 RID: 12339 RVA: 0x00102978 File Offset: 0x00100B78
	[Token(Token = "0x6003033")]
	[Address(RVA = "0x3F6DC0", Offset = "0x3F53C0", VA = "0x1803F6DC0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Squash;
	}

	// Token: 0x06003034 RID: 12340 RVA: 0x00102988 File Offset: 0x00100B88
	[Token(Token = "0x6003034")]
	[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Pool;
	}

	// Token: 0x06003035 RID: 12341 RVA: 0x00102998 File Offset: 0x00100B98
	[Token(Token = "0x6003035")]
	[Address(RVA = "0x71D750", Offset = "0x71BD50", VA = "0x18071D750", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：排山倒海";
	}

	// Token: 0x06003036 RID: 12342 RVA: 0x001029AC File Offset: 0x00100BAC
	[Token(Token = "0x6003036")]
	[Address(RVA = "0x71DC30", Offset = "0x71C230", VA = "0x18071DC30", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.boardTag.disableSelectCard = true;
		board.boardTag.isColumn = true;
		BoardConfig config = board.config;
		board.timeUntilNextWave = 6f;
		config.waveInterval = 15f;
	}

	// Token: 0x06003037 RID: 12343 RVA: 0x001029F4 File Offset: 0x00100BF4
	[Token(Token = "0x6003037")]
	[Address(RVA = "0x71DAB0", Offset = "0x71C0B0", VA = "0x18071DAB0", Slot = "35")]
	public override void InitCard(InitBoard board)
	{
		int num = 0;
		CardUI cardUI = board.CreateCard((PlantType)((uint)1), true, num != 0);
		int num2 = 0;
		CardUI cardUI2 = board.CreateCard((PlantType)((uint)12), true, num2 != 0);
		int num3 = 0;
		CardUI cardUI3 = board.CreateCard((PlantType)((uint)12), true, num3 != 0);
		int num4 = 0;
		CardUI cardUI4 = board.CreateCard((PlantType)((uint)18), true, num4 != 0);
		int num5 = 0;
		CardUI cardUI5 = board.CreateCard((PlantType)((uint)16), true, num5 != 0);
		int num6 = 0;
		CardUI cardUI6 = board.CreateCard((PlantType)((uint)14), true, num6 != 0);
		int num7 = 0;
		int num8 = 0;
		CardUI cardUI7 = board.CreateCard((PlantType)num8, true, num7 != 0);
		int num9 = 0;
		CardUI cardUI8 = board.CreateCard((PlantType)((uint)17), true, num9 != 0);
		int num10 = 0;
		CardUI cardUI9 = board.CreateCard((PlantType)((uint)3), true, num10 != 0);
		int num11 = 0;
		CardUI cardUI10 = board.CreateCard((PlantType)((uint)1027), true, num11 != 0);
		int num12 = 0;
		CardUI cardUI11 = board.CreateCard((PlantType)((uint)4), true, num12 != 0);
		int num13 = 0;
		CardUI cardUI12 = board.CreateCard((PlantType)((uint)13), true, num13 != 0);
		int num14 = 0;
		CardUI cardUI13 = board.CreateCard((PlantType)((uint)15), true, num14 != 0);
		int num15 = 0;
		CardUI cardUI14 = board.CreateCard((PlantType)((uint)2), true, num15 != 0);
	}

	// Token: 0x06003038 RID: 12344 RVA: 0x00102AF4 File Offset: 0x00100CF4
	[Token(Token = "0x6003038")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public PoolSub3Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
