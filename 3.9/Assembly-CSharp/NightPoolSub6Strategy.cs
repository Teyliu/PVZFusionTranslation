using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x0200094D RID: 2381
[Token(Token = "0x200094D")]
public class NightPoolSub6Strategy : BaseLevelStrategy
{
	// Token: 0x060030CC RID: 12492 RVA: 0x0010426C File Offset: 0x0010246C
	[Token(Token = "0x60030CC")]
	[Address(RVA = "0x719050", Offset = "0x717650", VA = "0x180719050", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.NightPool_sub6;
	}

	// Token: 0x060030CD RID: 12493 RVA: 0x0010427C File Offset: 0x0010247C
	[Token(Token = "0x60030CD")]
	[Address(RVA = "0x719480", Offset = "0x717A80", VA = "0x180719480", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		BoardConfig config = board.config;
		board.timeUntilNextWave = 5f;
		config.waveInterval = 10f;
		board.config.zombieSpeedMultiplier = 2f;
	}

	// Token: 0x060030CE RID: 12494 RVA: 0x001042BC File Offset: 0x001024BC
	[Token(Token = "0x60030CE")]
	[Address(RVA = "0x712FE0", Offset = "0x7115E0", VA = "0x180712FE0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 30;
	}

	// Token: 0x060030CF RID: 12495 RVA: 0x001042CC File Offset: 0x001024CC
	[Token(Token = "0x60030CF")]
	[Address(RVA = "0x719060", Offset = "0x717660", VA = "0x180719060", Slot = "24")]
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

	// Token: 0x060030D0 RID: 12496 RVA: 0x00104350 File Offset: 0x00102550
	[Token(Token = "0x60030D0")]
	[Address(RVA = "0x7185D0", Offset = "0x716BD0", VA = "0x1807185D0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.StarFruit;
	}

	// Token: 0x060030D1 RID: 12497 RVA: 0x00104360 File Offset: 0x00102560
	[Token(Token = "0x60030D1")]
	[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.NightPool;
	}

	// Token: 0x060030D2 RID: 12498 RVA: 0x00104370 File Offset: 0x00102570
	[Token(Token = "0x60030D2")]
	[Address(RVA = "0x718FF0", Offset = "0x7175F0", VA = "0x180718FF0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：最终决战";
	}

	// Token: 0x060030D3 RID: 12499 RVA: 0x00104384 File Offset: 0x00102584
	[Token(Token = "0x60030D3")]
	[Address(RVA = "0x719020", Offset = "0x717620", VA = "0x180719020", Slot = "31")]
	public override string GetLevelTip()
	{
		return "精英预警：强化闪电战";
	}

	// Token: 0x060030D4 RID: 12500 RVA: 0x00104398 File Offset: 0x00102598
	[Token(Token = "0x60030D4")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public NightPoolSub6Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
