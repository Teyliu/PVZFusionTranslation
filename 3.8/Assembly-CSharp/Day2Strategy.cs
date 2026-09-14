using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020008C5 RID: 2245
[Token(Token = "0x20008C5")]
public class Day2Strategy : BaseLevelStrategy
{
	// Token: 0x06002DA2 RID: 11682 RVA: 0x000FA840 File Offset: 0x000F8A40
	[Token(Token = "0x6002DA2")]
	[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Day2;
	}

	// Token: 0x06002DA3 RID: 11683 RVA: 0x000FA850 File Offset: 0x000F8A50
	[Token(Token = "0x6002DA3")]
	[Address(RVA = "0x697050", Offset = "0x695650", VA = "0x180697050", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		advantureMission.level = (AdvantureLevel)((ulong)2L);
		Func<MissionResult> func;
		advantureMission.target = func;
		AdvantureConfig.SubmitPlantConfig(advantureMission, (PlantType)((uint)1033), 5, (MissionResult)((uint)2));
		AdvantureConfig.SetMissionDescription(advantureMission, (AdvantureLevel)((uint)2));
		return advantureMission;
	}

	// Token: 0x06002DA4 RID: 11684 RVA: 0x000FA8A8 File Offset: 0x000F8AA8
	[Token(Token = "0x6002DA4")]
	[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 10;
	}

	// Token: 0x06002DA5 RID: 11685 RVA: 0x000FA8B8 File Offset: 0x000F8AB8
	[Token(Token = "0x6002DA5")]
	[Address(RVA = "0x6972E0", Offset = "0x6958E0", VA = "0x1806972E0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		return list;
	}

	// Token: 0x06002DA6 RID: 11686 RVA: 0x000FA8F0 File Offset: 0x000F8AF0
	[Token(Token = "0x6002DA6")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SunFlower;
	}

	// Token: 0x06002DA7 RID: 11687 RVA: 0x000FA900 File Offset: 0x000F8B00
	[Token(Token = "0x6002DA7")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x06002DA8 RID: 11688 RVA: 0x000FA918 File Offset: 0x000F8B18
	[Token(Token = "0x6002DA8")]
	[Address(RVA = "0x6971B0", Offset = "0x6957B0", VA = "0x1806971B0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉白天：第2关";
	}

	// Token: 0x06002DA9 RID: 11689 RVA: 0x000FA92C File Offset: 0x000F8B2C
	[Token(Token = "0x6002DA9")]
	[Address(RVA = "0x697260", Offset = "0x695860", VA = "0x180697260", Slot = "32")]
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

	// Token: 0x06002DAA RID: 11690 RVA: 0x000FA954 File Offset: 0x000F8B54
	[Token(Token = "0x6002DAA")]
	[Address(RVA = "0x6971E0", Offset = "0x6957E0", VA = "0x1806971E0", Slot = "33")]
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

	// Token: 0x06002DAB RID: 11691 RVA: 0x000FA97C File Offset: 0x000F8B7C
	[Token(Token = "0x6002DAB")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Day2Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
