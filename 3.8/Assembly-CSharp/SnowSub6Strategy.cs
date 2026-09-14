using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200093A RID: 2362
[Token(Token = "0x200093A")]
public class SnowSub6Strategy : BaseLevelStrategy
{
	// Token: 0x060030A4 RID: 12452 RVA: 0x00102000 File Offset: 0x00100200
	[Token(Token = "0x60030A4")]
	[Address(RVA = "0x5012C0", Offset = "0x4FF8C0", VA = "0x1805012C0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Snow_sub6;
	}

	// Token: 0x060030A5 RID: 12453 RVA: 0x00102010 File Offset: 0x00100210
	[Token(Token = "0x60030A5")]
	[Address(RVA = "0x69CF20", Offset = "0x69B520", VA = "0x18069CF20", Slot = "23")]
	public override int GetMaxWave()
	{
		return 40;
	}

	// Token: 0x060030A6 RID: 12454 RVA: 0x00102020 File Offset: 0x00100220
	[Token(Token = "0x60030A6")]
	[Address(RVA = "0x6AD390", Offset = "0x6AB990", VA = "0x1806AD390", Slot = "24")]
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
		return list;
	}

	// Token: 0x060030A7 RID: 12455 RVA: 0x001020B4 File Offset: 0x001002B4
	[Token(Token = "0x60030A7")]
	[Address(RVA = "0x6AD860", Offset = "0x6ABE60", VA = "0x1806AD860", Slot = "34")]
	public override void OnBoardStart(Board board)
	{
		Action <>9__3_ = SnowSub6Strategy.<>c.<>9__3_0;
		if (<>9__3_ == 0)
		{
			SnowSub6Strategy.<>c.<>9__3_0 = delegate
			{
				ulong num2;
				do
				{
					List<Plant> allPlants = Lawnf.GetAllPlants();
					bool flag;
					if (flag)
					{
					}
				}
				while (num2 != (ulong)0L);
			};
		}
		int num = 0;
		EventManager.AddListener(GameEvent.BoardWaveAdd, <>9__3_, num != 0);
	}

	// Token: 0x060030A8 RID: 12456 RVA: 0x001020EC File Offset: 0x001002EC
	[Token(Token = "0x60030A8")]
	[Address(RVA = "0x6A42A0", Offset = "0x6A28A0", VA = "0x1806A42A0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.PineFurnace;
	}

	// Token: 0x060030A9 RID: 12457 RVA: 0x001020FC File Offset: 0x001002FC
	[Token(Token = "0x60030A9")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Snow_6;
	}

	// Token: 0x060030AA RID: 12458 RVA: 0x0010210C File Offset: 0x0010030C
	[Token(Token = "0x60030AA")]
	[Address(RVA = "0x6AD330", Offset = "0x6AB930", VA = "0x1806AD330", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：终末之诗";
	}

	// Token: 0x060030AB RID: 12459 RVA: 0x00102120 File Offset: 0x00100320
	[Token(Token = "0x60030AB")]
	[Address(RVA = "0x6AD360", Offset = "0x6AB960", VA = "0x1806AD360", Slot = "31")]
	public override string GetLevelTip()
	{
		return "危机预警：极冰之地";
	}

	// Token: 0x060030AC RID: 12460 RVA: 0x00102134 File Offset: 0x00100334
	[Token(Token = "0x60030AC")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public SnowSub6Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
