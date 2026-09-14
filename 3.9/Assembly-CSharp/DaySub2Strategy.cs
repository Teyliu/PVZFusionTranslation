using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200090D RID: 2317
[Token(Token = "0x200090D")]
public class DaySub2Strategy : BaseLevelStrategy
{
	// Token: 0x06002F1E RID: 12062 RVA: 0x000FFE60 File Offset: 0x000FE060
	[Token(Token = "0x6002F1E")]
	[Address(RVA = "0x3F6B70", Offset = "0x3F5170", VA = "0x1803F6B70", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Day_sub2;
	}

	// Token: 0x06002F1F RID: 12063 RVA: 0x000FFE70 File Offset: 0x000FE070
	[Token(Token = "0x6002F1F")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002F20 RID: 12064 RVA: 0x000FFE80 File Offset: 0x000FE080
	[Token(Token = "0x6002F20")]
	[Address(RVA = "0x712960", Offset = "0x710F60", VA = "0x180712960", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		return list;
	}

	// Token: 0x06002F21 RID: 12065 RVA: 0x000FFEBC File Offset: 0x000FE0BC
	[Token(Token = "0x6002F21")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SunFlower;
	}

	// Token: 0x06002F22 RID: 12066 RVA: 0x000FFECC File Offset: 0x000FE0CC
	[Token(Token = "0x6002F22")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x06002F23 RID: 12067 RVA: 0x000FFEE4 File Offset: 0x000FE0E4
	[Token(Token = "0x6002F23")]
	[Address(RVA = "0x712930", Offset = "0x710F30", VA = "0x180712930", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：植物僵尸";
	}

	// Token: 0x06002F24 RID: 12068 RVA: 0x000FFEF8 File Offset: 0x000FE0F8
	[Token(Token = "0x6002F24")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public DaySub2Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
