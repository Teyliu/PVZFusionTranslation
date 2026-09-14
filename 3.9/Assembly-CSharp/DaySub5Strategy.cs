using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x02000910 RID: 2320
[Token(Token = "0x2000910")]
public class DaySub5Strategy : BaseLevelStrategy
{
	// Token: 0x06002F39 RID: 12089 RVA: 0x00100248 File Offset: 0x000FE448
	[Token(Token = "0x6002F39")]
	[Address(RVA = "0x3F9920", Offset = "0x3F7F20", VA = "0x1803F9920", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Day_sub5;
	}

	// Token: 0x06002F3A RID: 12090 RVA: 0x00100258 File Offset: 0x000FE458
	[Token(Token = "0x6002F3A")]
	[Address(RVA = "0x713940", Offset = "0x711F40", VA = "0x180713940", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		BoardConfig config = board.config;
		config.zombieDamageMultiplier = 1.5f;
		config.zombieCountMultiplier = 1.5f;
		config.zombieHealthMultiplier = 1.5f;
	}

	// Token: 0x06002F3B RID: 12091 RVA: 0x00100294 File Offset: 0x000FE494
	[Token(Token = "0x6002F3B")]
	[Address(RVA = "0x712FE0", Offset = "0x7115E0", VA = "0x180712FE0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 30;
	}

	// Token: 0x06002F3C RID: 12092 RVA: 0x001002A4 File Offset: 0x000FE4A4
	[Token(Token = "0x6002F3C")]
	[Address(RVA = "0x713620", Offset = "0x711C20", VA = "0x180713620", Slot = "24")]
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

	// Token: 0x06002F3D RID: 12093 RVA: 0x00100310 File Offset: 0x000FE510
	[Token(Token = "0x6002F3D")]
	[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Chomper;
	}

	// Token: 0x06002F3E RID: 12094 RVA: 0x00100320 File Offset: 0x000FE520
	[Token(Token = "0x6002F3E")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x06002F3F RID: 12095 RVA: 0x00100338 File Offset: 0x000FE538
	[Token(Token = "0x6002F3F")]
	[Address(RVA = "0x7135C0", Offset = "0x711BC0", VA = "0x1807135C0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：植物僵尸2";
	}

	// Token: 0x06002F40 RID: 12096 RVA: 0x0010034C File Offset: 0x000FE54C
	[Token(Token = "0x6002F40")]
	[Address(RVA = "0x7135F0", Offset = "0x711BF0", VA = "0x1807135F0", Slot = "31")]
	public override string GetLevelTip()
	{
		return "精英预警：僵尸强化1.5倍";
	}

	// Token: 0x06002F41 RID: 12097 RVA: 0x00100360 File Offset: 0x000FE560
	[Token(Token = "0x6002F41")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public DaySub5Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
