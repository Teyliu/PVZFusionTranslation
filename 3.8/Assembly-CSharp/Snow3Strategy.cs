using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200092C RID: 2348
[Token(Token = "0x200092C")]
public class Snow3Strategy : BaseLevelStrategy
{
	// Token: 0x06003045 RID: 12357 RVA: 0x00100FD8 File Offset: 0x000FF1D8
	[Token(Token = "0x6003045")]
	[Address(RVA = "0x4C8D50", Offset = "0x4C7350", VA = "0x1804C8D50", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Snow3;
	}

	// Token: 0x06003046 RID: 12358 RVA: 0x00100FE8 File Offset: 0x000FF1E8
	[Token(Token = "0x6003046")]
	[Address(RVA = "0x6AA940", Offset = "0x6A8F40", VA = "0x1806AA940", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x06003047 RID: 12359 RVA: 0x00101038 File Offset: 0x000FF238
	[Token(Token = "0x6003047")]
	[Address(RVA = "0x6A3620", Offset = "0x6A1C20", VA = "0x1806A3620", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Shulkflower;
	}

	// Token: 0x06003048 RID: 12360 RVA: 0x00101048 File Offset: 0x000FF248
	[Token(Token = "0x6003048")]
	[Address(RVA = "0x69BB30", Offset = "0x69A130", VA = "0x18069BB30", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Snow;
	}

	// Token: 0x06003049 RID: 12361 RVA: 0x00101058 File Offset: 0x000FF258
	[Token(Token = "0x6003049")]
	[Address(RVA = "0x6AA810", Offset = "0x6A8E10", VA = "0x1806AA810", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉雪原：第3关";
	}

	// Token: 0x0600304A RID: 12362 RVA: 0x0010106C File Offset: 0x000FF26C
	[Token(Token = "0x600304A")]
	[Address(RVA = "0x6AA8C0", Offset = "0x6A8EC0", VA = "0x1806AA8C0", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "坚盾如铁：使用钢叶草护盾缓和10000点伤害";
		}
		if (result == MissionResult.Second)
		{
			return "爆发输出：使用钢叶草在1秒内造成1000伤害";
		}
		return string.Empty;
	}

	// Token: 0x0600304B RID: 12363 RVA: 0x00101094 File Offset: 0x000FF294
	[Token(Token = "0x600304B")]
	[Address(RVA = "0x6AA840", Offset = "0x6A8E40", VA = "0x1806AA840", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "钢叶草的护盾上限翻倍，护盾获取效率翻倍";
		}
		if (result == MissionResult.Second)
		{
			return "钢叶草攻击群怪时伤害不再衰减";
		}
		return string.Empty;
	}

	// Token: 0x0600304C RID: 12364 RVA: 0x001010BC File Offset: 0x000FF2BC
	[Token(Token = "0x600304C")]
	[Address(RVA = "0x6AA670", Offset = "0x6A8C70", VA = "0x1806AA670", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		advantureMission.timer = -1f;
		AdvantureMission mission = advantureMission;
		AdvantureMission mission3 = mission;
		float startDamage = 0f;
		Func<MissionResult> func;
		mission3.target = func;
		AdvantureMission mission2 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x0600304D RID: 12365 RVA: 0x00101140 File Offset: 0x000FF340
	[Token(Token = "0x600304D")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x0600304E RID: 12366 RVA: 0x00101150 File Offset: 0x000FF350
	[Token(Token = "0x600304E")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Snow3Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
