using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x020008FE RID: 2302
[Token(Token = "0x20008FE")]
public class PoolSub6Strategy : BaseLevelStrategy
{
	// Token: 0x06002F18 RID: 12056 RVA: 0x000FE190 File Offset: 0x000FC390
	[Token(Token = "0x6002F18")]
	[Address(RVA = "0x6A44C0", Offset = "0x6A2AC0", VA = "0x1806A44C0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Pool_sub6;
	}

	// Token: 0x06002F19 RID: 12057 RVA: 0x000FE1A0 File Offset: 0x000FC3A0
	[Token(Token = "0x6002F19")]
	[Address(RVA = "0x69F320", Offset = "0x69D920", VA = "0x18069F320", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		BoardConfig config = board.config;
		board.timeUntilNextWave = 5f;
		config.waveInterval = 10f;
		board.config.zombieSpeedMultiplier = 2f;
	}

	// Token: 0x06002F1A RID: 12058 RVA: 0x000FE1E0 File Offset: 0x000FC3E0
	[Token(Token = "0x6002F1A")]
	[Address(RVA = "0x698EE0", Offset = "0x6974E0", VA = "0x180698EE0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 30;
	}

	// Token: 0x06002F1B RID: 12059 RVA: 0x000FE1F0 File Offset: 0x000FC3F0
	[Token(Token = "0x6002F1B")]
	[Address(RVA = "0x6A44D0", Offset = "0x6A2AD0", VA = "0x1806A44D0", Slot = "24")]
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

	// Token: 0x06002F1C RID: 12060 RVA: 0x000FE274 File Offset: 0x000FC474
	[Token(Token = "0x6002F1C")]
	[Address(RVA = "0x69AA70", Offset = "0x699070", VA = "0x18069AA70", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.ThreePeater;
	}

	// Token: 0x06002F1D RID: 12061 RVA: 0x000FE284 File Offset: 0x000FC484
	[Token(Token = "0x6002F1D")]
	[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Pool;
	}

	// Token: 0x06002F1E RID: 12062 RVA: 0x000FE294 File Offset: 0x000FC494
	[Token(Token = "0x6002F1E")]
	[Address(RVA = "0x6A4460", Offset = "0x6A2A60", VA = "0x1806A4460", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：最终决战";
	}

	// Token: 0x06002F1F RID: 12063 RVA: 0x000FE2A8 File Offset: 0x000FC4A8
	[Token(Token = "0x6002F1F")]
	[Address(RVA = "0x6A4490", Offset = "0x6A2A90", VA = "0x1806A4490", Slot = "31")]
	public override string GetLevelTip()
	{
		return "精英预警：强化闪电战";
	}

	// Token: 0x06002F20 RID: 12064 RVA: 0x000FE2BC File Offset: 0x000FC4BC
	[Token(Token = "0x6002F20")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public PoolSub6Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
