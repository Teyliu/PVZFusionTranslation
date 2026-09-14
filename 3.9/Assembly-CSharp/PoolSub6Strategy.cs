using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x0200093A RID: 2362
[Token(Token = "0x200093A")]
public class PoolSub6Strategy : BaseLevelStrategy
{
	// Token: 0x0600304B RID: 12363 RVA: 0x00102DDC File Offset: 0x00100FDC
	[Token(Token = "0x600304B")]
	[Address(RVA = "0x71E620", Offset = "0x71CC20", VA = "0x18071E620", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Pool_sub6;
	}

	// Token: 0x0600304C RID: 12364 RVA: 0x00102DEC File Offset: 0x00100FEC
	[Token(Token = "0x600304C")]
	[Address(RVA = "0x719480", Offset = "0x717A80", VA = "0x180719480", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		BoardConfig config = board.config;
		board.timeUntilNextWave = 5f;
		config.waveInterval = 10f;
		board.config.zombieSpeedMultiplier = 2f;
	}

	// Token: 0x0600304D RID: 12365 RVA: 0x00102E2C File Offset: 0x0010102C
	[Token(Token = "0x600304D")]
	[Address(RVA = "0x712FE0", Offset = "0x7115E0", VA = "0x180712FE0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 30;
	}

	// Token: 0x0600304E RID: 12366 RVA: 0x00102E3C File Offset: 0x0010103C
	[Token(Token = "0x600304E")]
	[Address(RVA = "0x71E630", Offset = "0x71CC30", VA = "0x18071E630", Slot = "24")]
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
		return list;
	}

	// Token: 0x0600304F RID: 12367 RVA: 0x00102EC0 File Offset: 0x001010C0
	[Token(Token = "0x600304F")]
	[Address(RVA = "0x714BD0", Offset = "0x7131D0", VA = "0x180714BD0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.ThreePeater;
	}

	// Token: 0x06003050 RID: 12368 RVA: 0x00102ED0 File Offset: 0x001010D0
	[Token(Token = "0x6003050")]
	[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Pool;
	}

	// Token: 0x06003051 RID: 12369 RVA: 0x00102EE0 File Offset: 0x001010E0
	[Token(Token = "0x6003051")]
	[Address(RVA = "0x71E5C0", Offset = "0x71CBC0", VA = "0x18071E5C0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：最终决战";
	}

	// Token: 0x06003052 RID: 12370 RVA: 0x00102EF4 File Offset: 0x001010F4
	[Token(Token = "0x6003052")]
	[Address(RVA = "0x71E5F0", Offset = "0x71CBF0", VA = "0x18071E5F0", Slot = "31")]
	public override string GetLevelTip()
	{
		return "精英预警：强化闪电战";
	}

	// Token: 0x06003053 RID: 12371 RVA: 0x00102F08 File Offset: 0x00101108
	[Token(Token = "0x6003053")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public PoolSub6Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
