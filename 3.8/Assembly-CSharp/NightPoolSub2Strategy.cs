using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200090D RID: 2317
[Token(Token = "0x200090D")]
public class NightPoolSub2Strategy : BaseLevelStrategy
{
	// Token: 0x06002F78 RID: 12152 RVA: 0x000FF180 File Offset: 0x000FD380
	[Token(Token = "0x6002F78")]
	[Address(RVA = "0x69DF40", Offset = "0x69C540", VA = "0x18069DF40", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.NightPool_sub2;
	}

	// Token: 0x06002F79 RID: 12153 RVA: 0x000FF190 File Offset: 0x000FD390
	[Token(Token = "0x6002F79")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002F7A RID: 12154 RVA: 0x000FF1A0 File Offset: 0x000FD3A0
	[Token(Token = "0x6002F7A")]
	[Address(RVA = "0x69DF50", Offset = "0x69C550", VA = "0x18069DF50", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x06002F7B RID: 12155 RVA: 0x000FF1EC File Offset: 0x000FD3EC
	[Token(Token = "0x6002F7B")]
	[Address(RVA = "0x69C990", Offset = "0x69AF90", VA = "0x18069C990", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Cactus;
	}

	// Token: 0x06002F7C RID: 12156 RVA: 0x000FF1FC File Offset: 0x000FD3FC
	[Token(Token = "0x6002F7C")]
	[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.NightPool;
	}

	// Token: 0x06002F7D RID: 12157 RVA: 0x000FF20C File Offset: 0x000FD40C
	[Token(Token = "0x6002F7D")]
	[Address(RVA = "0x69DF10", Offset = "0x69C510", VA = "0x18069DF10", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：空袭";
	}

	// Token: 0x06002F7E RID: 12158 RVA: 0x000FF220 File Offset: 0x000FD420
	[Token(Token = "0x6002F7E")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public NightPoolSub2Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
