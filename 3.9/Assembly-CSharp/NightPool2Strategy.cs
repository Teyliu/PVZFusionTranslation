using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;

// Token: 0x0200093D RID: 2365
[Token(Token = "0x200093D")]
public class NightPool2Strategy : BaseLevelStrategy
{
	// Token: 0x06003060 RID: 12384 RVA: 0x00103158 File Offset: 0x00101358
	[Token(Token = "0x6003060")]
	[Address(RVA = "0x716670", Offset = "0x714C70", VA = "0x180716670", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.NightPool2;
	}

	// Token: 0x06003061 RID: 12385 RVA: 0x00103168 File Offset: 0x00101368
	[Token(Token = "0x6003061")]
	[Address(RVA = "0x716780", Offset = "0x714D80", VA = "0x180716780", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x06003062 RID: 12386 RVA: 0x001031B4 File Offset: 0x001013B4
	[Token(Token = "0x6003062")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Plantern;
	}

	// Token: 0x06003063 RID: 12387 RVA: 0x001031C4 File Offset: 0x001013C4
	[Token(Token = "0x6003063")]
	[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.NightPool;
	}

	// Token: 0x06003064 RID: 12388 RVA: 0x001031D4 File Offset: 0x001013D4
	[Token(Token = "0x6003064")]
	[Address(RVA = "0x716640", Offset = "0x714C40", VA = "0x180716640", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉迷雾：第2关";
	}

	// Token: 0x06003065 RID: 12389 RVA: 0x001031E8 File Offset: 0x001013E8
	[Token(Token = "0x6003065")]
	[Address(RVA = "0x716700", Offset = "0x714D00", VA = "0x180716700", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "节能模式：不携带路灯花进入关卡";
		}
		if (result == MissionResult.Second)
		{
			return "灯火通明：使全场的光照等级之和大于100";
		}
		return string.Empty;
	}

	// Token: 0x06003066 RID: 12390 RVA: 0x00103210 File Offset: 0x00101410
	[Token(Token = "0x6003066")]
	[Address(RVA = "0x716680", Offset = "0x714C80", VA = "0x180716680", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "路灯花的阳光消耗降低10，冷却降低30%";
		}
		if (result == MissionResult.Second)
		{
			return "关卡开始时为全场提供1点光照等级";
		}
		return string.Empty;
	}

	// Token: 0x06003067 RID: 12391 RVA: 0x00103238 File Offset: 0x00101438
	[Token(Token = "0x6003067")]
	[Address(RVA = "0x716480", Offset = "0x714A80", VA = "0x180716480", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		Action action = delegate
		{
			int num;
			do
			{
				num = 0;
				IEnumerator<BoardGrid> enumerator = board.gridSystem.GetEnumerator();
				if (enumerator != 0)
				{
					if (num < typeof(IEnumerator).TypeHandle)
					{
						num += num;
						if (num != typeof(IEnumerator).TypeHandle)
						{
							num++;
						}
					}
					enumerator += enumerator;
				}
				if ("{il2cpp array field local6->}" != (ulong)0L)
				{
				}
			}
			while (num != 0);
			InGameText instance = InGameText.Instance;
			int num2;
			string text = string.Format("光照等级总和：{0}", num2);
		};
		advantureMission.onLook = action;
		Func<MissionResult> func = delegate
		{
			int num3;
			do
			{
				num3 = 0;
				List<CardUI> cards = InGameUI.Instance.Cards;
				Func<CardUI, bool> <>9__7_ = NightPool2Strategy.<>c.<>9__7_2;
				if (<>9__7_ == 0)
				{
					NightPool2Strategy.<>c.<>9__7_2 = (CardUI c) => c.thePlantType == PlantType.Plantern;
				}
				if (!Enumerable.FirstOrDefault<CardUI>(cards, <>9__7_))
				{
					break;
				}
				if (board.gridSystem.GetEnumerator() != 0)
				{
					if (num3 < typeof(IEnumerator).TypeHandle)
					{
						num3 += num3;
						if (num3 != typeof(IEnumerator).TypeHandle)
						{
							num3++;
						}
					}
					num3 += 312;
				}
				if ("{il2cpp array field local16->}" != (ulong)0L)
				{
				}
			}
			while (num3 != 0);
			throw new NullReferenceException();
		};
		advantureMission.target = func;
		AdvantureLevel level2 = this.GetLevel();
		return advantureMission;
	}

	// Token: 0x06003068 RID: 12392 RVA: 0x001032AC File Offset: 0x001014AC
	[Token(Token = "0x6003068")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public NightPool2Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
