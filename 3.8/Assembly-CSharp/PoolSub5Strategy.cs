using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x020008FD RID: 2301
[Token(Token = "0x20008FD")]
public class PoolSub5Strategy : BaseLevelStrategy
{
	// Token: 0x06002F0F RID: 12047 RVA: 0x000FE08C File Offset: 0x000FC28C
	[Token(Token = "0x6002F0F")]
	[Address(RVA = "0x6A42A0", Offset = "0x6A28A0", VA = "0x1806A42A0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Pool_sub5;
	}

	// Token: 0x06002F10 RID: 12048 RVA: 0x000FE09C File Offset: 0x000FC29C
	[Token(Token = "0x6002F10")]
	[Address(RVA = "0x6A4420", Offset = "0x6A2A20", VA = "0x1806A4420", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		BoardConfig config = board.config;
		board.timeUntilNextWave = 10f;
		config.waveInterval = 15f;
		board.config.zombieSpeedMultiplier = 1.5f;
	}

	// Token: 0x06002F11 RID: 12049 RVA: 0x000FE0DC File Offset: 0x000FC2DC
	[Token(Token = "0x6002F11")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002F12 RID: 12050 RVA: 0x000FE0EC File Offset: 0x000FC2EC
	[Token(Token = "0x6002F12")]
	[Address(RVA = "0x6A42B0", Offset = "0x6A28B0", VA = "0x1806A42B0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06002F13 RID: 12051 RVA: 0x000FE130 File Offset: 0x000FC330
	[Token(Token = "0x6002F13")]
	[Address(RVA = "0x69B710", Offset = "0x699D10", VA = "0x18069B710", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Caltrop;
	}

	// Token: 0x06002F14 RID: 12052 RVA: 0x000FE140 File Offset: 0x000FC340
	[Token(Token = "0x6002F14")]
	[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Pool;
	}

	// Token: 0x06002F15 RID: 12053 RVA: 0x000FE150 File Offset: 0x000FC350
	[Token(Token = "0x6002F15")]
	[Address(RVA = "0x6A4270", Offset = "0x6A2870", VA = "0x1806A4270", Slot = "31")]
	public override string GetLevelTip()
	{
		return "精英预警：闪电战";
	}

	// Token: 0x06002F16 RID: 12054 RVA: 0x000FE164 File Offset: 0x000FC364
	[Token(Token = "0x6002F16")]
	[Address(RVA = "0x6A4240", Offset = "0x6A2840", VA = "0x1806A4240", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：泳池激斗";
	}

	// Token: 0x06002F17 RID: 12055 RVA: 0x000FE178 File Offset: 0x000FC378
	[Token(Token = "0x6002F17")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public PoolSub5Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
