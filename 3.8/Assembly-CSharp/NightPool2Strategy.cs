using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;

// Token: 0x02000901 RID: 2305
[Token(Token = "0x2000901")]
public class NightPool2Strategy : BaseLevelStrategy
{
	// Token: 0x06002F2D RID: 12077 RVA: 0x000FE50C File Offset: 0x000FC70C
	[Token(Token = "0x6002F2D")]
	[Address(RVA = "0x69C510", Offset = "0x69AB10", VA = "0x18069C510", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.NightPool2;
	}

	// Token: 0x06002F2E RID: 12078 RVA: 0x000FE51C File Offset: 0x000FC71C
	[Token(Token = "0x6002F2E")]
	[Address(RVA = "0x69C620", Offset = "0x69AC20", VA = "0x18069C620", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x06002F2F RID: 12079 RVA: 0x000FE568 File Offset: 0x000FC768
	[Token(Token = "0x6002F2F")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Plantern;
	}

	// Token: 0x06002F30 RID: 12080 RVA: 0x000FE578 File Offset: 0x000FC778
	[Token(Token = "0x6002F30")]
	[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.NightPool;
	}

	// Token: 0x06002F31 RID: 12081 RVA: 0x000FE588 File Offset: 0x000FC788
	[Token(Token = "0x6002F31")]
	[Address(RVA = "0x69C4E0", Offset = "0x69AAE0", VA = "0x18069C4E0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉迷雾：第2关";
	}

	// Token: 0x06002F32 RID: 12082 RVA: 0x000FE59C File Offset: 0x000FC79C
	[Token(Token = "0x6002F32")]
	[Address(RVA = "0x69C5A0", Offset = "0x69ABA0", VA = "0x18069C5A0", Slot = "32")]
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

	// Token: 0x06002F33 RID: 12083 RVA: 0x000FE5C4 File Offset: 0x000FC7C4
	[Token(Token = "0x6002F33")]
	[Address(RVA = "0x69C520", Offset = "0x69AB20", VA = "0x18069C520", Slot = "33")]
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

	// Token: 0x06002F34 RID: 12084 RVA: 0x000FE5EC File Offset: 0x000FC7EC
	[Token(Token = "0x6002F34")]
	[Address(RVA = "0x69C320", Offset = "0x69A920", VA = "0x18069C320", Slot = "22")]
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
			int num3 = 0;
			instance.ShowText(text, 3f, num3 != 0);
		};
		advantureMission.onLook = action;
		Func<MissionResult> func;
		advantureMission.target = func;
		AdvantureLevel level2 = this.GetLevel();
		return advantureMission;
	}

	// Token: 0x06002F35 RID: 12085 RVA: 0x000FE650 File Offset: 0x000FC850
	[Token(Token = "0x6002F35")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public NightPool2Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
