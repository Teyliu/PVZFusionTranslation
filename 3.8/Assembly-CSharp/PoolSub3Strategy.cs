using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x020008FB RID: 2299
[Token(Token = "0x20008FB")]
public class PoolSub3Strategy : BaseLevelStrategy
{
	// Token: 0x06002EFD RID: 12029 RVA: 0x000FDCA0 File Offset: 0x000FBEA0
	[Token(Token = "0x6002EFD")]
	[Address(RVA = "0x6A3620", Offset = "0x6A1C20", VA = "0x1806A3620", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Pool_sub3;
	}

	// Token: 0x06002EFE RID: 12030 RVA: 0x000FDCB0 File Offset: 0x000FBEB0
	[Token(Token = "0x6002EFE")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002EFF RID: 12031 RVA: 0x000FDCC0 File Offset: 0x000FBEC0
	[Token(Token = "0x6002EFF")]
	[Address(RVA = "0x6A3630", Offset = "0x6A1C30", VA = "0x1806A3630", Slot = "24")]
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

	// Token: 0x06002F00 RID: 12032 RVA: 0x000FDD2C File Offset: 0x000FBF2C
	[Token(Token = "0x6002F00")]
	[Address(RVA = "0x3AAFC0", Offset = "0x3A95C0", VA = "0x1803AAFC0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Squash;
	}

	// Token: 0x06002F01 RID: 12033 RVA: 0x000FDD3C File Offset: 0x000FBF3C
	[Token(Token = "0x6002F01")]
	[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Pool;
	}

	// Token: 0x06002F02 RID: 12034 RVA: 0x000FDD4C File Offset: 0x000FBF4C
	[Token(Token = "0x6002F02")]
	[Address(RVA = "0x6A35F0", Offset = "0x6A1BF0", VA = "0x1806A35F0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：排山倒海";
	}

	// Token: 0x06002F03 RID: 12035 RVA: 0x000FDD60 File Offset: 0x000FBF60
	[Token(Token = "0x6002F03")]
	[Address(RVA = "0x6A3AD0", Offset = "0x6A20D0", VA = "0x1806A3AD0", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.boardTag.disableSelectCard = true;
		board.boardTag.isColumn = true;
		BoardConfig config = board.config;
		board.timeUntilNextWave = 6f;
		config.waveInterval = 15f;
	}

	// Token: 0x06002F04 RID: 12036 RVA: 0x000FDDA8 File Offset: 0x000FBFA8
	[Token(Token = "0x6002F04")]
	[Address(RVA = "0x6A3950", Offset = "0x6A1F50", VA = "0x1806A3950", Slot = "35")]
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

	// Token: 0x06002F05 RID: 12037 RVA: 0x000FDEA8 File Offset: 0x000FC0A8
	[Token(Token = "0x6002F05")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public PoolSub3Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
