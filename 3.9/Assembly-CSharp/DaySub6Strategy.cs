using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x02000911 RID: 2321
[Token(Token = "0x2000911")]
public class DaySub6Strategy : BaseLevelStrategy
{
	// Token: 0x06002F42 RID: 12098 RVA: 0x00100378 File Offset: 0x000FE578
	[Token(Token = "0x6002F42")]
	[Address(RVA = "0x3F72C0", Offset = "0x3F58C0", VA = "0x1803F72C0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Day_sub6;
	}

	// Token: 0x06002F43 RID: 12099 RVA: 0x00100388 File Offset: 0x000FE588
	[Token(Token = "0x6002F43")]
	[Address(RVA = "0x713F00", Offset = "0x712500", VA = "0x180713F00", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		BoardConfig config = board.config;
		config.zombieDamageMultiplier = 2f;
		config.zombieHealthMultiplier = 2f;
		config.zombieCountMultiplier = 2f;
	}

	// Token: 0x06002F44 RID: 12100 RVA: 0x001003C4 File Offset: 0x000FE5C4
	[Token(Token = "0x6002F44")]
	[Address(RVA = "0x712FE0", Offset = "0x7115E0", VA = "0x180712FE0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 30;
	}

	// Token: 0x06002F45 RID: 12101 RVA: 0x001003D4 File Offset: 0x000FE5D4
	[Token(Token = "0x6002F45")]
	[Address(RVA = "0x7139E0", Offset = "0x711FE0", VA = "0x1807139E0", Slot = "24")]
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
		int size9 = list._size;
		int size10 = list._size;
		int size11 = list._size;
		int size12 = list._size;
		int size13 = list._size;
		int size14 = list._size;
		return list;
	}

	// Token: 0x06002F46 RID: 12102 RVA: 0x00100474 File Offset: 0x000FE674
	[Token(Token = "0x6002F46")]
	[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Chomper;
	}

	// Token: 0x06002F47 RID: 12103 RVA: 0x00100484 File Offset: 0x000FE684
	[Token(Token = "0x6002F47")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x06002F48 RID: 12104 RVA: 0x0010049C File Offset: 0x000FE69C
	[Token(Token = "0x6002F48")]
	[Address(RVA = "0x713980", Offset = "0x711F80", VA = "0x180713980", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：最终决战";
	}

	// Token: 0x06002F49 RID: 12105 RVA: 0x001004B0 File Offset: 0x000FE6B0
	[Token(Token = "0x6002F49")]
	[Address(RVA = "0x7139B0", Offset = "0x711FB0", VA = "0x1807139B0", Slot = "31")]
	public override string GetLevelTip()
	{
		return "精英预警：僵尸强化2倍";
	}

	// Token: 0x06002F4A RID: 12106 RVA: 0x001004C4 File Offset: 0x000FE6C4
	[Token(Token = "0x6002F4A")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public DaySub6Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
