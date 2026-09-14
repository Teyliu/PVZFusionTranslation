using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x020008C1 RID: 2241
[Token(Token = "0x20008C1")]
public abstract class BaseLevelStrategy : ILevelStrategy
{
	// Token: 0x06002D81 RID: 11649 RVA: 0x000FA3F0 File Offset: 0x000F85F0
	[Token(Token = "0x6002D81")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "20")]
	public virtual AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Day1;
	}

	// Token: 0x06002D82 RID: 11650 RVA: 0x000FA400 File Offset: 0x000F8600
	[Token(Token = "0x6002D82")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "21")]
	public virtual void SetupBoard(Board board)
	{
	}

	// Token: 0x06002D83 RID: 11651 RVA: 0x000FA410 File Offset: 0x000F8610
	[Token(Token = "0x6002D83")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "22")]
	public virtual AdvantureMission CreateMission(Board board)
	{
		return null;
	}

	// Token: 0x06002D84 RID: 11652 RVA: 0x000FA420 File Offset: 0x000F8620
	[Token(Token = "0x6002D84")]
	[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "23")]
	public virtual int GetMaxWave()
	{
		return 10;
	}

	// Token: 0x06002D85 RID: 11653 RVA: 0x000FA430 File Offset: 0x000F8630
	[Token(Token = "0x6002D85")]
	[Address(RVA = "0x696C20", Offset = "0x695220", VA = "0x180696C20", Slot = "24")]
	public virtual List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		return list;
	}

	// Token: 0x06002D86 RID: 11654 RVA: 0x000FA468 File Offset: 0x000F8668
	[Token(Token = "0x6002D86")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "25")]
	public virtual PlantType GetBasePlant()
	{
		return PlantType.SunFlower;
	}

	// Token: 0x06002D87 RID: 11655 RVA: 0x000FA478 File Offset: 0x000F8678
	[Token(Token = "0x6002D87")]
	[Address(RVA = "0x6965E0", Offset = "0x694BE0", VA = "0x1806965E0", Slot = "26")]
	public virtual List<PlantType> GetConveyPlants()
	{
		List<PlantType> list = new List();
		int size = list._size;
		return list;
	}

	// Token: 0x06002D88 RID: 11656 RVA: 0x000FA4B0 File Offset: 0x000F86B0
	[Token(Token = "0x6002D88")]
	[Address(RVA = "0x6967A0", Offset = "0x694DA0", VA = "0x1806967A0", Slot = "27")]
	public virtual List<PlantType> GetRandomPlantTypes()
	{
		List<PlantType> list;
		bool flag;
		for (;;)
		{
			int num = 0;
			list = new List();
			List<PlantType> allPlantTypes = Lawnf.GetAllPlantTypes();
			Func<PlantType, bool> <>9__7_ = BaseLevelStrategy.<>c.<>9__7_0;
			if (<>9__7_ == 0)
			{
				BaseLevelStrategy.<>c.<>9__7_0 = delegate(PlantType a)
				{
					bool flag2;
					return flag2;
				};
			}
			IEnumerable<PlantType> enumerable = Enumerable.Where<PlantType>(allPlantTypes, <>9__7_);
			if (num >= <>9__7_)
			{
				goto IL_004D;
			}
			num += num;
			if (num != <>9__7_)
			{
				num++;
				goto IL_004D;
			}
			goto IL_006A;
			IL_006E:
			flag += flag;
			if ("{il2cpp array field local12->}" != (ulong)0L)
			{
			}
			if (num == 0)
			{
				break;
			}
			continue;
			IL_004D:
			if (num < typeof(IEnumerator).TypeHandle)
			{
				num += num;
				if (num == typeof(IEnumerator).TypeHandle)
				{
					goto IL_006E;
				}
				num++;
			}
			while (!flag)
			{
			}
			IL_006A:
			list += list;
			goto IL_006E;
		}
		int size = list._size;
		list._size = (flag ? 1 : 0);
		return list;
	}

	// Token: 0x06002D89 RID: 11657 RVA: 0x000FA580 File Offset: 0x000F8780
	[Token(Token = "0x6002D89")]
	[Address(RVA = "0x696BC0", Offset = "0x6951C0", VA = "0x180696BC0", Slot = "28")]
	public virtual List<ZombieType> GetRandomZombieTypes()
	{
		return new List();
	}

	// Token: 0x06002D8A RID: 11658 RVA: 0x000FA59C File Offset: 0x000F879C
	[Token(Token = "0x6002D8A")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "29")]
	public virtual SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x06002D8B RID: 11659 RVA: 0x000FA5B4 File Offset: 0x000F87B4
	[Token(Token = "0x6002D8B")]
	[Address(RVA = "0x6966B0", Offset = "0x694CB0", VA = "0x1806966B0", Slot = "30")]
	public virtual string GetLevelName()
	{
		return "未命名关卡";
	}

	// Token: 0x06002D8C RID: 11660 RVA: 0x000FA5C8 File Offset: 0x000F87C8
	[Token(Token = "0x6002D8C")]
	[Address(RVA = "0x6966E0", Offset = "0x694CE0", VA = "0x1806966E0", Slot = "31")]
	public virtual string GetLevelTip()
	{
		return string.Empty;
	}

	// Token: 0x06002D8D RID: 11661 RVA: 0x000FA5DC File Offset: 0x000F87DC
	[Token(Token = "0x6002D8D")]
	[Address(RVA = "0x696760", Offset = "0x694D60", VA = "0x180696760", Slot = "32")]
	public virtual string GetMissionDescription(MissionResult result)
	{
		return string.Empty;
	}

	// Token: 0x06002D8E RID: 11662 RVA: 0x000FA5F0 File Offset: 0x000F87F0
	[Token(Token = "0x6002D8E")]
	[Address(RVA = "0x696720", Offset = "0x694D20", VA = "0x180696720", Slot = "33")]
	public virtual string GetMissionAwardDescription(MissionResult result)
	{
		return string.Empty;
	}

	// Token: 0x06002D8F RID: 11663 RVA: 0x000FA604 File Offset: 0x000F8804
	[Token(Token = "0x6002D8F")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "34")]
	public virtual void OnBoardStart(Board board)
	{
	}

	// Token: 0x06002D90 RID: 11664 RVA: 0x000FA614 File Offset: 0x000F8814
	[Token(Token = "0x6002D90")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "35")]
	public virtual void InitCard(InitBoard board)
	{
	}

	// Token: 0x06002D91 RID: 11665 RVA: 0x000FA624 File Offset: 0x000F8824
	[Token(Token = "0x6002D91")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	protected BaseLevelStrategy()
	{
		int num = 0;
		this.SetupBoard(num);
	}
}
