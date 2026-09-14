using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x020008D4 RID: 2260
[Token(Token = "0x20008D4")]
public class DaySub5Strategy : BaseLevelStrategy
{
	// Token: 0x06002E06 RID: 11782 RVA: 0x000FB714 File Offset: 0x000F9914
	[Token(Token = "0x6002E06")]
	[Address(RVA = "0x3ADAB0", Offset = "0x3AC0B0", VA = "0x1803ADAB0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Day_sub5;
	}

	// Token: 0x06002E07 RID: 11783 RVA: 0x000FB724 File Offset: 0x000F9924
	[Token(Token = "0x6002E07")]
	[Address(RVA = "0x699840", Offset = "0x697E40", VA = "0x180699840", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		BoardConfig config = board.config;
		config.zombieDamageMultiplier = 1.5f;
		config.zombieCountMultiplier = 1.5f;
		config.zombieHealthMultiplier = 1.5f;
	}

	// Token: 0x06002E08 RID: 11784 RVA: 0x000FB760 File Offset: 0x000F9960
	[Token(Token = "0x6002E08")]
	[Address(RVA = "0x698EE0", Offset = "0x6974E0", VA = "0x180698EE0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 30;
	}

	// Token: 0x06002E09 RID: 11785 RVA: 0x000FB770 File Offset: 0x000F9970
	[Token(Token = "0x6002E09")]
	[Address(RVA = "0x699520", Offset = "0x697B20", VA = "0x180699520", Slot = "24")]
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

	// Token: 0x06002E0A RID: 11786 RVA: 0x000FB7DC File Offset: 0x000F99DC
	[Token(Token = "0x6002E0A")]
	[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Chomper;
	}

	// Token: 0x06002E0B RID: 11787 RVA: 0x000FB7EC File Offset: 0x000F99EC
	[Token(Token = "0x6002E0B")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x06002E0C RID: 11788 RVA: 0x000FB804 File Offset: 0x000F9A04
	[Token(Token = "0x6002E0C")]
	[Address(RVA = "0x6994C0", Offset = "0x697AC0", VA = "0x1806994C0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：植物僵尸2";
	}

	// Token: 0x06002E0D RID: 11789 RVA: 0x000FB818 File Offset: 0x000F9A18
	[Token(Token = "0x6002E0D")]
	[Address(RVA = "0x6994F0", Offset = "0x697AF0", VA = "0x1806994F0", Slot = "31")]
	public override string GetLevelTip()
	{
		return "精英预警：僵尸强化1.5倍";
	}

	// Token: 0x06002E0E RID: 11790 RVA: 0x000FB82C File Offset: 0x000F9A2C
	[Token(Token = "0x6002E0E")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public DaySub5Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
