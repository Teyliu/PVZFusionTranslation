using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000901 RID: 2305
[Token(Token = "0x2000901")]
public class Day2Strategy : BaseLevelStrategy
{
	// Token: 0x06002ED5 RID: 11989 RVA: 0x000FF320 File Offset: 0x000FD520
	[Token(Token = "0x6002ED5")]
	[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Day2;
	}

	// Token: 0x06002ED6 RID: 11990 RVA: 0x000FF330 File Offset: 0x000FD530
	[Token(Token = "0x6002ED6")]
	[Address(RVA = "0x711150", Offset = "0x70F750", VA = "0x180711150", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		advantureMission.level = (AdvantureLevel)((ulong)2L);
		Func<MissionResult> func = delegate
		{
			Board board3 = board;
			if (board3.theSun < 1500)
			{
			}
			board3.UseSun(1500f);
			return MissionResult.First;
		};
		advantureMission.target = func;
		AdvantureConfig.SubmitPlantConfig(advantureMission, (PlantType)((uint)1033), 5, (MissionResult)((uint)2));
		AdvantureConfig.SetMissionDescription(advantureMission, (AdvantureLevel)((uint)2));
		return advantureMission;
	}

	// Token: 0x06002ED7 RID: 11991 RVA: 0x000FF394 File Offset: 0x000FD594
	[Token(Token = "0x6002ED7")]
	[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 10;
	}

	// Token: 0x06002ED8 RID: 11992 RVA: 0x000FF3A4 File Offset: 0x000FD5A4
	[Token(Token = "0x6002ED8")]
	[Address(RVA = "0x7113E0", Offset = "0x70F9E0", VA = "0x1807113E0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		return list;
	}

	// Token: 0x06002ED9 RID: 11993 RVA: 0x000FF3DC File Offset: 0x000FD5DC
	[Token(Token = "0x6002ED9")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SunFlower;
	}

	// Token: 0x06002EDA RID: 11994 RVA: 0x000FF3EC File Offset: 0x000FD5EC
	[Token(Token = "0x6002EDA")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x06002EDB RID: 11995 RVA: 0x000FF404 File Offset: 0x000FD604
	[Token(Token = "0x6002EDB")]
	[Address(RVA = "0x7112B0", Offset = "0x70F8B0", VA = "0x1807112B0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉白天：第2关";
	}

	// Token: 0x06002EDC RID: 11996 RVA: 0x000FF418 File Offset: 0x000FD618
	[Token(Token = "0x6002EDC")]
	[Address(RVA = "0x711360", Offset = "0x70F960", VA = "0x180711360", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "阳光储备：提交1500阳光（存到1500后自动扣除）";
		}
		if (result == MissionResult.Second)
		{
			return "向日葵爱好者：提交5个双子向日葵";
		}
		return string.Empty;
	}

	// Token: 0x06002EDD RID: 11997 RVA: 0x000FF440 File Offset: 0x000FD640
	[Token(Token = "0x6002EDD")]
	[Address(RVA = "0x7112E0", Offset = "0x70F8E0", VA = "0x1807112E0", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "每局开始给予75点初始阳光";
		}
		if (result == MissionResult.Second)
		{
			return "每局开始额外赠送一个向日葵";
		}
		return string.Empty;
	}

	// Token: 0x06002EDE RID: 11998 RVA: 0x000FF468 File Offset: 0x000FD668
	[Token(Token = "0x6002EDE")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Day2Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
