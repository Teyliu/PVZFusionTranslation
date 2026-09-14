using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x02000927 RID: 2343
[Token(Token = "0x2000927")]
public class Pool1Strategy : BaseLevelStrategy
{
	// Token: 0x06002FD3 RID: 12243 RVA: 0x00101924 File Offset: 0x000FFB24
	[Token(Token = "0x6002FD3")]
	[Address(RVA = "0x718280", Offset = "0x716880", VA = "0x180718280", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Pool1;
	}

	// Token: 0x06002FD4 RID: 12244 RVA: 0x00101934 File Offset: 0x000FFB34
	[Token(Token = "0x6002FD4")]
	[Address(RVA = "0x71AFD0", Offset = "0x7195D0", VA = "0x18071AFD0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06002FD5 RID: 12245 RVA: 0x0010197C File Offset: 0x000FFB7C
	[Token(Token = "0x6002FD5")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SunFlower;
	}

	// Token: 0x06002FD6 RID: 12246 RVA: 0x0010198C File Offset: 0x000FFB8C
	[Token(Token = "0x6002FD6")]
	[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Pool;
	}

	// Token: 0x06002FD7 RID: 12247 RVA: 0x0010199C File Offset: 0x000FFB9C
	[Token(Token = "0x6002FD7")]
	[Address(RVA = "0x71AEA0", Offset = "0x7194A0", VA = "0x18071AEA0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉泳池：第1关";
	}

	// Token: 0x06002FD8 RID: 12248 RVA: 0x001019B0 File Offset: 0x000FFBB0
	[Token(Token = "0x6002FD8")]
	[Address(RVA = "0x71AF50", Offset = "0x719550", VA = "0x18071AF50", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "整装待发：在第一波僵尸到达前，在水路种植8株植物";
		}
		if (result == MissionResult.Second)
		{
			return "睡莲爱好者：用睡莲铺满整个水池";
		}
		return string.Empty;
	}

	// Token: 0x06002FD9 RID: 12249 RVA: 0x001019D8 File Offset: 0x000FFBD8
	[Token(Token = "0x6002FD9")]
	[Address(RVA = "0x71AED0", Offset = "0x7194D0", VA = "0x18071AED0", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "特殊睡莲的生产速度增加20%";
		}
		if (result == MissionResult.Second)
		{
			return "种植睡莲不再消耗阳光";
		}
		return string.Empty;
	}

	// Token: 0x06002FDA RID: 12250 RVA: 0x00101A00 File Offset: 0x000FFC00
	[Token(Token = "0x6002FDA")]
	[Address(RVA = "0x71AD20", Offset = "0x719320", VA = "0x18071AD20", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		Func<MissionResult> func = delegate
		{
			while (board.theWave == 0)
			{
				int num = 0;
				List<Plant> allPlants = Lawnf.GetAllPlants();
				bool flag;
				if (flag)
				{
					GridSystem gridSystem = board.gridSystem;
					BoardGrid boardGrid;
					while (boardGrid.boxType != BoxType.Water)
					{
					}
					num++;
				}
				if (num == 0)
				{
					break;
				}
			}
			int num2 = 0;
			int num3 = 0;
			Board board3 = board;
			if (num3 < board3.columnNum)
			{
				int num4 = 0;
				Board board4 = board;
				Board board5 = board;
				if (num4 < board4.rowNum)
				{
					if (board5.gridSystem.GetGrid(num2, num4).boxType == BoxType.Water)
					{
						List<Plant> list = Lawnf.Get1x1Plants(num2, num4);
						Func<Plant, bool> <>9__7_ = Pool1Strategy.<>c.<>9__7_1;
						if (<>9__7_ == 0)
						{
							Pool1Strategy.<>c.<>9__7_1 = delegate(Plant p)
							{
								int thePlantType = (int)p.thePlantType;
								bool flag2;
								return flag2;
							};
						}
						if (!Enumerable.FirstOrDefault<Plant>(list, <>9__7_))
						{
							goto IL_00E0;
						}
					}
					num4++;
				}
				num2++;
				IL_00E0:;
			}
			throw new NullReferenceException();
		};
		advantureMission.target = func;
		AdvantureLevel level2 = this.GetLevel();
		return advantureMission;
	}

	// Token: 0x06002FDB RID: 12251 RVA: 0x00101A5C File Offset: 0x000FFC5C
	[Token(Token = "0x6002FDB")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Pool1Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
