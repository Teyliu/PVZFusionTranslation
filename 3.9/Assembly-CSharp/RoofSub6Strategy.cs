using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000963 RID: 2403
[Token(Token = "0x2000963")]
public class RoofSub6Strategy : BaseLevelStrategy
{
	// Token: 0x06003158 RID: 12632 RVA: 0x00105820 File Offset: 0x00103A20
	[Token(Token = "0x6003158")]
	[Address(RVA = "0x56F770", Offset = "0x56DD70", VA = "0x18056F770", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Roof_sub6;
	}

	// Token: 0x06003159 RID: 12633 RVA: 0x00105830 File Offset: 0x00103A30
	[Token(Token = "0x6003159")]
	[Address(RVA = "0x717080", Offset = "0x715680", VA = "0x180717080", Slot = "23")]
	public override int GetMaxWave()
	{
		return 40;
	}

	// Token: 0x0600315A RID: 12634 RVA: 0x00105840 File Offset: 0x00103A40
	[Token(Token = "0x600315A")]
	[Address(RVA = "0x7237A0", Offset = "0x721DA0", VA = "0x1807237A0", Slot = "24")]
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

	// Token: 0x0600315B RID: 12635 RVA: 0x00105924 File Offset: 0x00103B24
	[Token(Token = "0x600315B")]
	[Address(RVA = "0x712FE0", Offset = "0x7115E0", VA = "0x180712FE0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Umbrellaleaf;
	}

	// Token: 0x0600315C RID: 12636 RVA: 0x00105934 File Offset: 0x00103B34
	[Token(Token = "0x600315C")]
	[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Roof;
	}

	// Token: 0x0600315D RID: 12637 RVA: 0x00105944 File Offset: 0x00103B44
	[Token(Token = "0x600315D")]
	[Address(RVA = "0x723740", Offset = "0x721D40", VA = "0x180723740", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：终末之诗";
	}

	// Token: 0x0600315E RID: 12638 RVA: 0x00105958 File Offset: 0x00103B58
	[Token(Token = "0x600315E")]
	[Address(RVA = "0x723770", Offset = "0x721D70", VA = "0x180723770", Slot = "31")]
	public override string GetLevelTip()
	{
		return "危机预警：全军出击";
	}

	// Token: 0x0600315F RID: 12639 RVA: 0x0010596C File Offset: 0x00103B6C
	[Token(Token = "0x600315F")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public RoofSub6Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
