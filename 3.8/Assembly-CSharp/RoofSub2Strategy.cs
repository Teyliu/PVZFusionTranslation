using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000923 RID: 2339
[Token(Token = "0x2000923")]
public class RoofSub2Strategy : BaseLevelStrategy
{
	// Token: 0x06003003 RID: 12291 RVA: 0x00100620 File Offset: 0x000FE820
	[Token(Token = "0x6003003")]
	[Address(RVA = "0x49F990", Offset = "0x49DF90", VA = "0x18049F990", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Roof_sub2;
	}

	// Token: 0x06003004 RID: 12292 RVA: 0x00100630 File Offset: 0x000FE830
	[Token(Token = "0x6003004")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06003005 RID: 12293 RVA: 0x00100640 File Offset: 0x000FE840
	[Token(Token = "0x6003005")]
	[Address(RVA = "0x6A8560", Offset = "0x6A6B60", VA = "0x1806A8560", Slot = "24")]
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

	// Token: 0x06003006 RID: 12294 RVA: 0x001006AC File Offset: 0x000FE8AC
	[Token(Token = "0x6003006")]
	[Address(RVA = "0x698EE0", Offset = "0x6974E0", VA = "0x180698EE0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Umbrellaleaf;
	}

	// Token: 0x06003007 RID: 12295 RVA: 0x001006BC File Offset: 0x000FE8BC
	[Token(Token = "0x6003007")]
	[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Roof;
	}

	// Token: 0x06003008 RID: 12296 RVA: 0x001006CC File Offset: 0x000FE8CC
	[Token(Token = "0x6003008")]
	[Address(RVA = "0x6A8530", Offset = "0x6A6B30", VA = "0x1806A8530", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：钢铁洪流";
	}

	// Token: 0x06003009 RID: 12297 RVA: 0x001006E0 File Offset: 0x000FE8E0
	[Token(Token = "0x6003009")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public RoofSub2Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
