using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x02000925 RID: 2341
[Token(Token = "0x2000925")]
public class NightSub5Strategy : BaseLevelStrategy
{
	// Token: 0x06002FC1 RID: 12225 RVA: 0x001016FC File Offset: 0x000FF8FC
	[Token(Token = "0x6002FC1")]
	[Address(RVA = "0x7185D0", Offset = "0x716BD0", VA = "0x1807185D0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Night_sub5;
	}

	// Token: 0x06002FC2 RID: 12226 RVA: 0x0010170C File Offset: 0x000FF90C
	[Token(Token = "0x6002FC2")]
	[Address(RVA = "0x713940", Offset = "0x711F40", VA = "0x180713940", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		BoardConfig config = board.config;
		config.zombieDamageMultiplier = 1.5f;
		config.zombieCountMultiplier = 1.5f;
		config.zombieHealthMultiplier = 1.5f;
	}

	// Token: 0x06002FC3 RID: 12227 RVA: 0x00101748 File Offset: 0x000FF948
	[Token(Token = "0x6002FC3")]
	[Address(RVA = "0x712FE0", Offset = "0x7115E0", VA = "0x180712FE0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 30;
	}

	// Token: 0x06002FC4 RID: 12228 RVA: 0x00101758 File Offset: 0x000FF958
	[Token(Token = "0x6002FC4")]
	[Address(RVA = "0x71A540", Offset = "0x718B40", VA = "0x18071A540", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06002FC5 RID: 12229 RVA: 0x0010179C File Offset: 0x000FF99C
	[Token(Token = "0x6002FC5")]
	[Address(RVA = "0x3F6B70", Offset = "0x3F5170", VA = "0x1803F6B70", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.HypnoShroom;
	}

	// Token: 0x06002FC6 RID: 12230 RVA: 0x001017AC File Offset: 0x000FF9AC
	[Token(Token = "0x6002FC6")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Night;
	}

	// Token: 0x06002FC7 RID: 12231 RVA: 0x001017BC File Offset: 0x000FF9BC
	[Token(Token = "0x6002FC7")]
	[Address(RVA = "0x71A4E0", Offset = "0x718AE0", VA = "0x18071A4E0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：狂欢派对";
	}

	// Token: 0x06002FC8 RID: 12232 RVA: 0x001017D0 File Offset: 0x000FF9D0
	[Token(Token = "0x6002FC8")]
	[Address(RVA = "0x71A510", Offset = "0x718B10", VA = "0x18071A510", Slot = "31")]
	public override string GetLevelTip()
	{
		return "精英预警：僵尸强化1.5倍";
	}

	// Token: 0x06002FC9 RID: 12233 RVA: 0x001017E4 File Offset: 0x000FF9E4
	[Token(Token = "0x6002FC9")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public NightSub5Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
