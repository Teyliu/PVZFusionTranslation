using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000927 RID: 2343
[Token(Token = "0x2000927")]
public class RoofSub6Strategy : BaseLevelStrategy
{
	// Token: 0x06003025 RID: 12325 RVA: 0x00100AD0 File Offset: 0x000FECD0
	[Token(Token = "0x6003025")]
	[Address(RVA = "0x519E20", Offset = "0x518420", VA = "0x180519E20", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Roof_sub6;
	}

	// Token: 0x06003026 RID: 12326 RVA: 0x00100AE0 File Offset: 0x000FECE0
	[Token(Token = "0x6003026")]
	[Address(RVA = "0x69CF20", Offset = "0x69B520", VA = "0x18069CF20", Slot = "23")]
	public override int GetMaxWave()
	{
		return 40;
	}

	// Token: 0x06003027 RID: 12327 RVA: 0x00100AF0 File Offset: 0x000FECF0
	[Token(Token = "0x6003027")]
	[Address(RVA = "0x6A9640", Offset = "0x6A7C40", VA = "0x1806A9640", Slot = "24")]
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
		int size9 = list._size;
		int size10 = list._size;
		int size11 = list._size;
		int size12 = list._size;
		int size13 = list._size;
		int size14 = list._size;
		int size15 = list._size;
		int size16 = list._size;
		int size17 = list._size;
		int size18 = list._size;
		int size19 = list._size;
		int size20 = list._size;
		int size21 = list._size;
		int size22 = list._size;
		int size23 = list._size;
		return list;
	}

	// Token: 0x06003028 RID: 12328 RVA: 0x00100BD4 File Offset: 0x000FEDD4
	[Token(Token = "0x6003028")]
	[Address(RVA = "0x698EE0", Offset = "0x6974E0", VA = "0x180698EE0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Umbrellaleaf;
	}

	// Token: 0x06003029 RID: 12329 RVA: 0x00100BE4 File Offset: 0x000FEDE4
	[Token(Token = "0x6003029")]
	[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Roof;
	}

	// Token: 0x0600302A RID: 12330 RVA: 0x00100BF4 File Offset: 0x000FEDF4
	[Token(Token = "0x600302A")]
	[Address(RVA = "0x6A95E0", Offset = "0x6A7BE0", VA = "0x1806A95E0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：终末之诗";
	}

	// Token: 0x0600302B RID: 12331 RVA: 0x00100C08 File Offset: 0x000FEE08
	[Token(Token = "0x600302B")]
	[Address(RVA = "0x6A9610", Offset = "0x6A7C10", VA = "0x1806A9610", Slot = "31")]
	public override string GetLevelTip()
	{
		return "危机预警：全军出击";
	}

	// Token: 0x0600302C RID: 12332 RVA: 0x00100C1C File Offset: 0x000FEE1C
	[Token(Token = "0x600302C")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public RoofSub6Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
