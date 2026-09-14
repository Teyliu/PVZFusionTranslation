using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x02000910 RID: 2320
[Token(Token = "0x2000910")]
public class NightPoolSub5Strategy : BaseLevelStrategy
{
	// Token: 0x06002F90 RID: 12176 RVA: 0x000FF4C4 File Offset: 0x000FD6C4
	[Token(Token = "0x6002F90")]
	[Address(RVA = "0x69EB70", Offset = "0x69D170", VA = "0x18069EB70", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.NightPool_sub5;
	}

	// Token: 0x06002F91 RID: 12177 RVA: 0x000FF4D4 File Offset: 0x000FD6D4
	[Token(Token = "0x6002F91")]
	[Address(RVA = "0x69EE50", Offset = "0x69D450", VA = "0x18069EE50", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		BoardConfig config = board.config;
		config.zombieCountMultiplier = 2f;
		config.zombieDamageMultiplier = 2f;
		config.zombieHealthMultiplier = 2f;
	}

	// Token: 0x06002F92 RID: 12178 RVA: 0x000FF510 File Offset: 0x000FD710
	[Token(Token = "0x6002F92")]
	[Address(RVA = "0x698EE0", Offset = "0x6974E0", VA = "0x180698EE0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 30;
	}

	// Token: 0x06002F93 RID: 12179 RVA: 0x000FF520 File Offset: 0x000FD720
	[Token(Token = "0x6002F93")]
	[Address(RVA = "0x69EB80", Offset = "0x69D180", VA = "0x18069EB80", Slot = "24")]
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

	// Token: 0x06002F94 RID: 12180 RVA: 0x000FF584 File Offset: 0x000FD784
	[Token(Token = "0x6002F94")]
	[Address(RVA = "0x69E120", Offset = "0x69C720", VA = "0x18069E120", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Magnetshroom;
	}

	// Token: 0x06002F95 RID: 12181 RVA: 0x000FF594 File Offset: 0x000FD794
	[Token(Token = "0x6002F95")]
	[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.NightPool;
	}

	// Token: 0x06002F96 RID: 12182 RVA: 0x000FF5A4 File Offset: 0x000FD7A4
	[Token(Token = "0x6002F96")]
	[Address(RVA = "0x69EB40", Offset = "0x69D140", VA = "0x18069EB40", Slot = "31")]
	public override string GetLevelTip()
	{
		return "精英预警：僵尸强化2倍";
	}

	// Token: 0x06002F97 RID: 12183 RVA: 0x000FF5B8 File Offset: 0x000FD7B8
	[Token(Token = "0x6002F97")]
	[Address(RVA = "0x69EB10", Offset = "0x69D110", VA = "0x18069EB10", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：危机四伏";
	}

	// Token: 0x06002F98 RID: 12184 RVA: 0x000FF5CC File Offset: 0x000FD7CC
	[Token(Token = "0x6002F98")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public NightPoolSub5Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
