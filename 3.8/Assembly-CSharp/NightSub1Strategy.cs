using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x020008E5 RID: 2277
[Token(Token = "0x20008E5")]
public class NightSub1Strategy : BaseLevelStrategy
{
	// Token: 0x06002E6B RID: 11883 RVA: 0x000FC564 File Offset: 0x000FA764
	[Token(Token = "0x6002E6B")]
	[Address(RVA = "0x69F390", Offset = "0x69D990", VA = "0x18069F390", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Night_sub1;
	}

	// Token: 0x06002E6C RID: 11884 RVA: 0x000FC574 File Offset: 0x000FA774
	[Token(Token = "0x6002E6C")]
	[Address(RVA = "0x69F6C0", Offset = "0x69DCC0", VA = "0x18069F6C0", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.theSun = (int)((ulong)0L);
		board.boardTag.isHammerZombie = true;
		board.boardTag.disableInInterlude = true;
		BoardConfig config = board.config;
		board.timeUntilNextWave = 3f;
		config.zombieCountMultiplier = 1.5f;
		board.config.waveInterval = 30f;
	}

	// Token: 0x06002E6D RID: 11885 RVA: 0x000FC5D8 File Offset: 0x000FA7D8
	[Token(Token = "0x6002E6D")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002E6E RID: 11886 RVA: 0x000FC5E8 File Offset: 0x000FA7E8
	[Token(Token = "0x6002E6E")]
	[Address(RVA = "0x69F3A0", Offset = "0x69D9A0", VA = "0x18069F3A0", Slot = "24")]
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

	// Token: 0x06002E6F RID: 11887 RVA: 0x000FC648 File Offset: 0x000FA848
	[Token(Token = "0x6002E6F")]
	[Address(RVA = "0x3AAD70", Offset = "0x3A9370", VA = "0x1803AAD70", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.HypnoShroom;
	}

	// Token: 0x06002E70 RID: 11888 RVA: 0x000FC658 File Offset: 0x000FA858
	[Token(Token = "0x6002E70")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Night;
	}

	// Token: 0x06002E71 RID: 11889 RVA: 0x000FC668 File Offset: 0x000FA868
	[Token(Token = "0x6002E71")]
	[Address(RVA = "0x69F360", Offset = "0x69D960", VA = "0x18069F360", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：锤僵尸";
	}

	// Token: 0x06002E72 RID: 11890 RVA: 0x000FC67C File Offset: 0x000FA87C
	[Token(Token = "0x6002E72")]
	[Address(RVA = "0x69F610", Offset = "0x69DC10", VA = "0x18069F610", Slot = "35")]
	public override void InitCard(InitBoard board)
	{
		int num = 0;
		CardUI cardUI = board.CreateCard((PlantType)((uint)4), true, num != 0);
		int num2 = 0;
		CardUI cardUI2 = board.CreateCard((PlantType)((uint)1002), true, num2 != 0);
		int num3 = 0;
		CardUI cardUI3 = board.CreateCard((PlantType)((uint)239), true, num3 != 0);
		int num4 = 0;
		CardUI cardUI4 = board.CreateCard((PlantType)((uint)239), true, num4 != 0);
		int num5 = 0;
		CardUI cardUI5 = board.CreateCard((PlantType)((uint)10), true, num5 != 0);
	}

	// Token: 0x06002E73 RID: 11891 RVA: 0x000FC6EC File Offset: 0x000FA8EC
	[Token(Token = "0x6002E73")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public NightSub1Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
