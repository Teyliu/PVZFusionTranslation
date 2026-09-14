using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000949 RID: 2377
[Token(Token = "0x2000949")]
public class NightPoolSub2Strategy : BaseLevelStrategy
{
	// Token: 0x060030AB RID: 12459 RVA: 0x00103E08 File Offset: 0x00102008
	[Token(Token = "0x60030AB")]
	[Address(RVA = "0x7180A0", Offset = "0x7166A0", VA = "0x1807180A0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.NightPool_sub2;
	}

	// Token: 0x060030AC RID: 12460 RVA: 0x00103E18 File Offset: 0x00102018
	[Token(Token = "0x60030AC")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x060030AD RID: 12461 RVA: 0x00103E28 File Offset: 0x00102028
	[Token(Token = "0x60030AD")]
	[Address(RVA = "0x7180B0", Offset = "0x7166B0", VA = "0x1807180B0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x060030AE RID: 12462 RVA: 0x00103E74 File Offset: 0x00102074
	[Token(Token = "0x60030AE")]
	[Address(RVA = "0x716AF0", Offset = "0x7150F0", VA = "0x180716AF0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Cactus;
	}

	// Token: 0x060030AF RID: 12463 RVA: 0x00103E84 File Offset: 0x00102084
	[Token(Token = "0x60030AF")]
	[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.NightPool;
	}

	// Token: 0x060030B0 RID: 12464 RVA: 0x00103E94 File Offset: 0x00102094
	[Token(Token = "0x60030B0")]
	[Address(RVA = "0x718070", Offset = "0x716670", VA = "0x180718070", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：空袭";
	}

	// Token: 0x060030B1 RID: 12465 RVA: 0x00103EA8 File Offset: 0x001020A8
	[Token(Token = "0x60030B1")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public NightPoolSub2Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
