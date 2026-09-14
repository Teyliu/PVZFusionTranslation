using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x02000926 RID: 2342
[Token(Token = "0x2000926")]
public class NightSub6Strategy : BaseLevelStrategy
{
	// Token: 0x06002FCA RID: 12234 RVA: 0x001017FC File Offset: 0x000FF9FC
	[Token(Token = "0x6002FCA")]
	[Address(RVA = "0x71A710", Offset = "0x718D10", VA = "0x18071A710", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Night_sub6;
	}

	// Token: 0x06002FCB RID: 12235 RVA: 0x0010180C File Offset: 0x000FFA0C
	[Token(Token = "0x6002FCB")]
	[Address(RVA = "0x713F00", Offset = "0x712500", VA = "0x180713F00", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		BoardConfig config = board.config;
		config.zombieDamageMultiplier = 2f;
		config.zombieHealthMultiplier = 2f;
		config.zombieCountMultiplier = 2f;
	}

	// Token: 0x06002FCC RID: 12236 RVA: 0x00101848 File Offset: 0x000FFA48
	[Token(Token = "0x6002FCC")]
	[Address(RVA = "0x712FE0", Offset = "0x7115E0", VA = "0x180712FE0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 30;
	}

	// Token: 0x06002FCD RID: 12237 RVA: 0x00101858 File Offset: 0x000FFA58
	[Token(Token = "0x6002FCD")]
	[Address(RVA = "0x71A720", Offset = "0x718D20", VA = "0x18071A720", Slot = "24")]
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

	// Token: 0x06002FCE RID: 12238 RVA: 0x001018C4 File Offset: 0x000FFAC4
	[Token(Token = "0x6002FCE")]
	[Address(RVA = "0x3F6B70", Offset = "0x3F5170", VA = "0x1803F6B70", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.HypnoShroom;
	}

	// Token: 0x06002FCF RID: 12239 RVA: 0x001018D4 File Offset: 0x000FFAD4
	[Token(Token = "0x6002FCF")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Night;
	}

	// Token: 0x06002FD0 RID: 12240 RVA: 0x001018E4 File Offset: 0x000FFAE4
	[Token(Token = "0x6002FD0")]
	[Address(RVA = "0x71A6B0", Offset = "0x718CB0", VA = "0x18071A6B0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：最终决战";
	}

	// Token: 0x06002FD1 RID: 12241 RVA: 0x001018F8 File Offset: 0x000FFAF8
	[Token(Token = "0x6002FD1")]
	[Address(RVA = "0x71A6E0", Offset = "0x718CE0", VA = "0x18071A6E0", Slot = "31")]
	public override string GetLevelTip()
	{
		return "精英预警：僵尸强化2倍";
	}

	// Token: 0x06002FD2 RID: 12242 RVA: 0x0010190C File Offset: 0x000FFB0C
	[Token(Token = "0x6002FD2")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public NightSub6Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
