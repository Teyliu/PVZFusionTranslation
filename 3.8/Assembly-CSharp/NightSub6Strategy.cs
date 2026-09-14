using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x020008EA RID: 2282
[Token(Token = "0x20008EA")]
public class NightSub6Strategy : BaseLevelStrategy
{
	// Token: 0x06002E97 RID: 11927 RVA: 0x000FCC38 File Offset: 0x000FAE38
	[Token(Token = "0x6002E97")]
	[Address(RVA = "0x6A05B0", Offset = "0x69EBB0", VA = "0x1806A05B0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Night_sub6;
	}

	// Token: 0x06002E98 RID: 11928 RVA: 0x000FCC48 File Offset: 0x000FAE48
	[Token(Token = "0x6002E98")]
	[Address(RVA = "0x699E00", Offset = "0x698400", VA = "0x180699E00", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		BoardConfig config = board.config;
		config.zombieDamageMultiplier = 2f;
		config.zombieHealthMultiplier = 2f;
		config.zombieCountMultiplier = 2f;
	}

	// Token: 0x06002E99 RID: 11929 RVA: 0x000FCC84 File Offset: 0x000FAE84
	[Token(Token = "0x6002E99")]
	[Address(RVA = "0x698EE0", Offset = "0x6974E0", VA = "0x180698EE0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 30;
	}

	// Token: 0x06002E9A RID: 11930 RVA: 0x000FCC94 File Offset: 0x000FAE94
	[Token(Token = "0x6002E9A")]
	[Address(RVA = "0x6A05C0", Offset = "0x69EBC0", VA = "0x1806A05C0", Slot = "24")]
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

	// Token: 0x06002E9B RID: 11931 RVA: 0x000FCD00 File Offset: 0x000FAF00
	[Token(Token = "0x6002E9B")]
	[Address(RVA = "0x3AAD70", Offset = "0x3A9370", VA = "0x1803AAD70", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.HypnoShroom;
	}

	// Token: 0x06002E9C RID: 11932 RVA: 0x000FCD10 File Offset: 0x000FAF10
	[Token(Token = "0x6002E9C")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Night;
	}

	// Token: 0x06002E9D RID: 11933 RVA: 0x000FCD20 File Offset: 0x000FAF20
	[Token(Token = "0x6002E9D")]
	[Address(RVA = "0x6A0550", Offset = "0x69EB50", VA = "0x1806A0550", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：最终决战";
	}

	// Token: 0x06002E9E RID: 11934 RVA: 0x000FCD34 File Offset: 0x000FAF34
	[Token(Token = "0x6002E9E")]
	[Address(RVA = "0x6A0580", Offset = "0x69EB80", VA = "0x1806A0580", Slot = "31")]
	public override string GetLevelTip()
	{
		return "精英预警：僵尸强化2倍";
	}

	// Token: 0x06002E9F RID: 11935 RVA: 0x000FCD48 File Offset: 0x000FAF48
	[Token(Token = "0x6002E9F")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public NightSub6Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
