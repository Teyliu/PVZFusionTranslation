using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020008D1 RID: 2257
[Token(Token = "0x20008D1")]
public class DaySub2Strategy : BaseLevelStrategy
{
	// Token: 0x06002DEB RID: 11755 RVA: 0x000FB32C File Offset: 0x000F952C
	[Token(Token = "0x6002DEB")]
	[Address(RVA = "0x3AAD70", Offset = "0x3A9370", VA = "0x1803AAD70", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Day_sub2;
	}

	// Token: 0x06002DEC RID: 11756 RVA: 0x000FB33C File Offset: 0x000F953C
	[Token(Token = "0x6002DEC")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002DED RID: 11757 RVA: 0x000FB34C File Offset: 0x000F954C
	[Token(Token = "0x6002DED")]
	[Address(RVA = "0x698860", Offset = "0x696E60", VA = "0x180698860", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		return list;
	}

	// Token: 0x06002DEE RID: 11758 RVA: 0x000FB388 File Offset: 0x000F9588
	[Token(Token = "0x6002DEE")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SunFlower;
	}

	// Token: 0x06002DEF RID: 11759 RVA: 0x000FB398 File Offset: 0x000F9598
	[Token(Token = "0x6002DEF")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x06002DF0 RID: 11760 RVA: 0x000FB3B0 File Offset: 0x000F95B0
	[Token(Token = "0x6002DF0")]
	[Address(RVA = "0x698830", Offset = "0x696E30", VA = "0x180698830", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：植物僵尸";
	}

	// Token: 0x06002DF1 RID: 11761 RVA: 0x000FB3C4 File Offset: 0x000F95C4
	[Token(Token = "0x6002DF1")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public DaySub2Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
