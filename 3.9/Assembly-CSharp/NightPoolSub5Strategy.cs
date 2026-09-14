using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x0200094C RID: 2380
[Token(Token = "0x200094C")]
public class NightPoolSub5Strategy : BaseLevelStrategy
{
	// Token: 0x060030C3 RID: 12483 RVA: 0x0010414C File Offset: 0x0010234C
	[Token(Token = "0x60030C3")]
	[Address(RVA = "0x718CD0", Offset = "0x7172D0", VA = "0x180718CD0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.NightPool_sub5;
	}

	// Token: 0x060030C4 RID: 12484 RVA: 0x0010415C File Offset: 0x0010235C
	[Token(Token = "0x60030C4")]
	[Address(RVA = "0x718FB0", Offset = "0x7175B0", VA = "0x180718FB0", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		BoardConfig config = board.config;
		config.zombieCountMultiplier = 2f;
		config.zombieDamageMultiplier = 2f;
		config.zombieHealthMultiplier = 2f;
	}

	// Token: 0x060030C5 RID: 12485 RVA: 0x00104198 File Offset: 0x00102398
	[Token(Token = "0x60030C5")]
	[Address(RVA = "0x712FE0", Offset = "0x7115E0", VA = "0x180712FE0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 30;
	}

	// Token: 0x060030C6 RID: 12486 RVA: 0x001041A8 File Offset: 0x001023A8
	[Token(Token = "0x60030C6")]
	[Address(RVA = "0x718CE0", Offset = "0x7172E0", VA = "0x180718CE0", Slot = "24")]
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
		return list;
	}

	// Token: 0x060030C7 RID: 12487 RVA: 0x0010420C File Offset: 0x0010240C
	[Token(Token = "0x60030C7")]
	[Address(RVA = "0x718280", Offset = "0x716880", VA = "0x180718280", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Magnetshroom;
	}

	// Token: 0x060030C8 RID: 12488 RVA: 0x0010421C File Offset: 0x0010241C
	[Token(Token = "0x60030C8")]
	[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.NightPool;
	}

	// Token: 0x060030C9 RID: 12489 RVA: 0x0010422C File Offset: 0x0010242C
	[Token(Token = "0x60030C9")]
	[Address(RVA = "0x718CA0", Offset = "0x7172A0", VA = "0x180718CA0", Slot = "31")]
	public override string GetLevelTip()
	{
		return "精英预警：僵尸强化2倍";
	}

	// Token: 0x060030CA RID: 12490 RVA: 0x00104240 File Offset: 0x00102440
	[Token(Token = "0x60030CA")]
	[Address(RVA = "0x718C70", Offset = "0x717270", VA = "0x180718C70", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：危机四伏";
	}

	// Token: 0x060030CB RID: 12491 RVA: 0x00104254 File Offset: 0x00102454
	[Token(Token = "0x60030CB")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public NightPoolSub5Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
