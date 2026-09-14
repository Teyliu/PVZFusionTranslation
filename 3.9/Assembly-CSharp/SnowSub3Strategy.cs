using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000973 RID: 2419
[Token(Token = "0x2000973")]
public class SnowSub3Strategy : BaseLevelStrategy
{
	// Token: 0x060031BE RID: 12734 RVA: 0x001069E8 File Offset: 0x00104BE8
	[Token(Token = "0x60031BE")]
	[Address(RVA = "0x7267E0", Offset = "0x724DE0", VA = "0x1807267E0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Snow_sub3;
	}

	// Token: 0x060031BF RID: 12735 RVA: 0x001069F8 File Offset: 0x00104BF8
	[Token(Token = "0x60031BF")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x060031C0 RID: 12736 RVA: 0x00106A08 File Offset: 0x00104C08
	[Token(Token = "0x60031C0")]
	[Address(RVA = "0x7267F0", Offset = "0x724DF0", VA = "0x1807267F0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		return list;
	}

	// Token: 0x060031C1 RID: 12737 RVA: 0x00106A5C File Offset: 0x00104C5C
	[Token(Token = "0x60031C1")]
	[Address(RVA = "0x71E620", Offset = "0x71CC20", VA = "0x18071E620", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SpruceShooter;
	}

	// Token: 0x060031C2 RID: 12738 RVA: 0x00106A6C File Offset: 0x00104C6C
	[Token(Token = "0x60031C2")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Snow_6;
	}

	// Token: 0x060031C3 RID: 12739 RVA: 0x00106A7C File Offset: 0x00104C7C
	[Token(Token = "0x60031C3")]
	[Address(RVA = "0x7267B0", Offset = "0x724DB0", VA = "0x1807267B0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：无僵尸之地";
	}

	// Token: 0x060031C4 RID: 12740 RVA: 0x00106A90 File Offset: 0x00104C90
	[Token(Token = "0x60031C4")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public SnowSub3Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
