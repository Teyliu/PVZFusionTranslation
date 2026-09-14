using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x02000911 RID: 2321
[Token(Token = "0x2000911")]
public class NightPoolSub6Strategy : BaseLevelStrategy
{
	// Token: 0x06002F99 RID: 12185 RVA: 0x000FF5E4 File Offset: 0x000FD7E4
	[Token(Token = "0x6002F99")]
	[Address(RVA = "0x69EEF0", Offset = "0x69D4F0", VA = "0x18069EEF0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.NightPool_sub6;
	}

	// Token: 0x06002F9A RID: 12186 RVA: 0x000FF5F4 File Offset: 0x000FD7F4
	[Token(Token = "0x6002F9A")]
	[Address(RVA = "0x69F320", Offset = "0x69D920", VA = "0x18069F320", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		BoardConfig config = board.config;
		board.timeUntilNextWave = 5f;
		config.waveInterval = 10f;
		board.config.zombieSpeedMultiplier = 2f;
	}

	// Token: 0x06002F9B RID: 12187 RVA: 0x000FF634 File Offset: 0x000FD834
	[Token(Token = "0x6002F9B")]
	[Address(RVA = "0x698EE0", Offset = "0x6974E0", VA = "0x180698EE0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 30;
	}

	// Token: 0x06002F9C RID: 12188 RVA: 0x000FF644 File Offset: 0x000FD844
	[Token(Token = "0x6002F9C")]
	[Address(RVA = "0x69EF00", Offset = "0x69D500", VA = "0x18069EF00", Slot = "24")]
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

	// Token: 0x06002F9D RID: 12189 RVA: 0x000FF6C8 File Offset: 0x000FD8C8
	[Token(Token = "0x6002F9D")]
	[Address(RVA = "0x69E470", Offset = "0x69CA70", VA = "0x18069E470", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.StarFruit;
	}

	// Token: 0x06002F9E RID: 12190 RVA: 0x000FF6D8 File Offset: 0x000FD8D8
	[Token(Token = "0x6002F9E")]
	[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.NightPool;
	}

	// Token: 0x06002F9F RID: 12191 RVA: 0x000FF6E8 File Offset: 0x000FD8E8
	[Token(Token = "0x6002F9F")]
	[Address(RVA = "0x69EE90", Offset = "0x69D490", VA = "0x18069EE90", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：最终决战";
	}

	// Token: 0x06002FA0 RID: 12192 RVA: 0x000FF6FC File Offset: 0x000FD8FC
	[Token(Token = "0x6002FA0")]
	[Address(RVA = "0x69EEC0", Offset = "0x69D4C0", VA = "0x18069EEC0", Slot = "31")]
	public override string GetLevelTip()
	{
		return "精英预警：强化闪电战";
	}

	// Token: 0x06002FA1 RID: 12193 RVA: 0x000FF710 File Offset: 0x000FD910
	[Token(Token = "0x6002FA1")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public NightPoolSub6Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
