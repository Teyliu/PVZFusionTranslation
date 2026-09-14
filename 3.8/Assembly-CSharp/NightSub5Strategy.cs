using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x020008E9 RID: 2281
[Token(Token = "0x20008E9")]
public class NightSub5Strategy : BaseLevelStrategy
{
	// Token: 0x06002E8E RID: 11918 RVA: 0x000FCB38 File Offset: 0x000FAD38
	[Token(Token = "0x6002E8E")]
	[Address(RVA = "0x69E470", Offset = "0x69CA70", VA = "0x18069E470", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Night_sub5;
	}

	// Token: 0x06002E8F RID: 11919 RVA: 0x000FCB48 File Offset: 0x000FAD48
	[Token(Token = "0x6002E8F")]
	[Address(RVA = "0x699840", Offset = "0x697E40", VA = "0x180699840", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		BoardConfig config = board.config;
		config.zombieDamageMultiplier = 1.5f;
		config.zombieCountMultiplier = 1.5f;
		config.zombieHealthMultiplier = 1.5f;
	}

	// Token: 0x06002E90 RID: 11920 RVA: 0x000FCB84 File Offset: 0x000FAD84
	[Token(Token = "0x6002E90")]
	[Address(RVA = "0x698EE0", Offset = "0x6974E0", VA = "0x180698EE0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 30;
	}

	// Token: 0x06002E91 RID: 11921 RVA: 0x000FCB94 File Offset: 0x000FAD94
	[Token(Token = "0x6002E91")]
	[Address(RVA = "0x6A03E0", Offset = "0x69E9E0", VA = "0x1806A03E0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06002E92 RID: 11922 RVA: 0x000FCBD8 File Offset: 0x000FADD8
	[Token(Token = "0x6002E92")]
	[Address(RVA = "0x3AAD70", Offset = "0x3A9370", VA = "0x1803AAD70", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.HypnoShroom;
	}

	// Token: 0x06002E93 RID: 11923 RVA: 0x000FCBE8 File Offset: 0x000FADE8
	[Token(Token = "0x6002E93")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Night;
	}

	// Token: 0x06002E94 RID: 11924 RVA: 0x000FCBF8 File Offset: 0x000FADF8
	[Token(Token = "0x6002E94")]
	[Address(RVA = "0x6A0380", Offset = "0x69E980", VA = "0x1806A0380", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：狂欢派对";
	}

	// Token: 0x06002E95 RID: 11925 RVA: 0x000FCC0C File Offset: 0x000FAE0C
	[Token(Token = "0x6002E95")]
	[Address(RVA = "0x6A03B0", Offset = "0x69E9B0", VA = "0x1806A03B0", Slot = "31")]
	public override string GetLevelTip()
	{
		return "精英预警：僵尸强化1.5倍";
	}

	// Token: 0x06002E96 RID: 11926 RVA: 0x000FCC20 File Offset: 0x000FAE20
	[Token(Token = "0x6002E96")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public NightSub5Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
