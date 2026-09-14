using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000976 RID: 2422
[Token(Token = "0x2000976")]
public class SnowSub6Strategy : BaseLevelStrategy
{
	// Token: 0x060031D7 RID: 12759 RVA: 0x00106D70 File Offset: 0x00104F70
	[Token(Token = "0x60031D7")]
	[Address(RVA = "0x568120", Offset = "0x566720", VA = "0x180568120", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Snow_sub6;
	}

	// Token: 0x060031D8 RID: 12760 RVA: 0x00106D80 File Offset: 0x00104F80
	[Token(Token = "0x60031D8")]
	[Address(RVA = "0x717080", Offset = "0x715680", VA = "0x180717080", Slot = "23")]
	public override int GetMaxWave()
	{
		return 40;
	}

	// Token: 0x060031D9 RID: 12761 RVA: 0x00106D90 File Offset: 0x00104F90
	[Token(Token = "0x60031D9")]
	[Address(RVA = "0x727510", Offset = "0x725B10", VA = "0x180727510", Slot = "24")]
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

	// Token: 0x060031DA RID: 12762 RVA: 0x00106E24 File Offset: 0x00105024
	[Token(Token = "0x60031DA")]
	[Address(RVA = "0x7279E0", Offset = "0x725FE0", VA = "0x1807279E0", Slot = "34")]
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

	// Token: 0x060031DB RID: 12763 RVA: 0x00106E5C File Offset: 0x0010505C
	[Token(Token = "0x60031DB")]
	[Address(RVA = "0x71E400", Offset = "0x71CA00", VA = "0x18071E400", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.PineFurnace;
	}

	// Token: 0x060031DC RID: 12764 RVA: 0x00106E6C File Offset: 0x0010506C
	[Token(Token = "0x60031DC")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Snow_6;
	}

	// Token: 0x060031DD RID: 12765 RVA: 0x00106E7C File Offset: 0x0010507C
	[Token(Token = "0x60031DD")]
	[Address(RVA = "0x7274B0", Offset = "0x725AB0", VA = "0x1807274B0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：终末之诗";
	}

	// Token: 0x060031DE RID: 12766 RVA: 0x00106E90 File Offset: 0x00105090
	[Token(Token = "0x60031DE")]
	[Address(RVA = "0x7274E0", Offset = "0x725AE0", VA = "0x1807274E0", Slot = "31")]
	public override string GetLevelTip()
	{
		return "危机预警：极冰之地";
	}

	// Token: 0x060031DF RID: 12767 RVA: 0x00106EA4 File Offset: 0x001050A4
	[Token(Token = "0x60031DF")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public SnowSub6Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
