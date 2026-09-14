using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020008FA RID: 2298
[Token(Token = "0x20008FA")]
public class PoolSub2Strategy : BaseLevelStrategy
{
	// Token: 0x06002EF6 RID: 12022 RVA: 0x000FDBE8 File Offset: 0x000FBDE8
	[Token(Token = "0x6002EF6")]
	[Address(RVA = "0x6A3410", Offset = "0x6A1A10", VA = "0x1806A3410", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Pool_sub2;
	}

	// Token: 0x06002EF7 RID: 12023 RVA: 0x000FDBF8 File Offset: 0x000FBDF8
	[Token(Token = "0x6002EF7")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002EF8 RID: 12024 RVA: 0x000FDC08 File Offset: 0x000FBE08
	[Token(Token = "0x6002EF8")]
	[Address(RVA = "0x6A3420", Offset = "0x6A1A20", VA = "0x1806A3420", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x06002EF9 RID: 12025 RVA: 0x000FDC54 File Offset: 0x000FBE54
	[Token(Token = "0x6002EF9")]
	[Address(RVA = "0x3AAFC0", Offset = "0x3A95C0", VA = "0x1803AAFC0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Squash;
	}

	// Token: 0x06002EFA RID: 12026 RVA: 0x000FDC64 File Offset: 0x000FBE64
	[Token(Token = "0x6002EFA")]
	[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Pool;
	}

	// Token: 0x06002EFB RID: 12027 RVA: 0x000FDC74 File Offset: 0x000FBE74
	[Token(Token = "0x6002EFB")]
	[Address(RVA = "0x6A33E0", Offset = "0x6A19E0", VA = "0x1806A33E0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：海豚入侵";
	}

	// Token: 0x06002EFC RID: 12028 RVA: 0x000FDC88 File Offset: 0x000FBE88
	[Token(Token = "0x6002EFC")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public PoolSub2Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
