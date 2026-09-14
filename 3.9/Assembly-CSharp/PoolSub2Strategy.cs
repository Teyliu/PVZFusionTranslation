using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000936 RID: 2358
[Token(Token = "0x2000936")]
public class PoolSub2Strategy : BaseLevelStrategy
{
	// Token: 0x06003029 RID: 12329 RVA: 0x00102834 File Offset: 0x00100A34
	[Token(Token = "0x6003029")]
	[Address(RVA = "0x71D570", Offset = "0x71BB70", VA = "0x18071D570", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Pool_sub2;
	}

	// Token: 0x0600302A RID: 12330 RVA: 0x00102844 File Offset: 0x00100A44
	[Token(Token = "0x600302A")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x0600302B RID: 12331 RVA: 0x00102854 File Offset: 0x00100A54
	[Token(Token = "0x600302B")]
	[Address(RVA = "0x71D580", Offset = "0x71BB80", VA = "0x18071D580", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x0600302C RID: 12332 RVA: 0x001028A0 File Offset: 0x00100AA0
	[Token(Token = "0x600302C")]
	[Address(RVA = "0x3F6DC0", Offset = "0x3F53C0", VA = "0x1803F6DC0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Squash;
	}

	// Token: 0x0600302D RID: 12333 RVA: 0x001028B0 File Offset: 0x00100AB0
	[Token(Token = "0x600302D")]
	[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Pool;
	}

	// Token: 0x0600302E RID: 12334 RVA: 0x001028C0 File Offset: 0x00100AC0
	[Token(Token = "0x600302E")]
	[Address(RVA = "0x71D540", Offset = "0x71BB40", VA = "0x18071D540", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：海豚入侵";
	}

	// Token: 0x0600302F RID: 12335 RVA: 0x001028D4 File Offset: 0x00100AD4
	[Token(Token = "0x600302F")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public PoolSub2Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
