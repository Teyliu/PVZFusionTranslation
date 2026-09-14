using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x0200092E RID: 2350
[Token(Token = "0x200092E")]
public class Pool4Strategy : BaseLevelStrategy
{
	// Token: 0x06002FF8 RID: 12280 RVA: 0x00101FA8 File Offset: 0x001001A8
	[Token(Token = "0x6002FF8")]
	[Address(RVA = "0x71BBC0", Offset = "0x71A1C0", VA = "0x18071BBC0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Pool4;
	}

	// Token: 0x06002FF9 RID: 12281 RVA: 0x00101FB8 File Offset: 0x001001B8
	[Token(Token = "0x6002FF9")]
	[Address(RVA = "0x71BCD0", Offset = "0x71A2D0", VA = "0x18071BCD0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06002FFA RID: 12282 RVA: 0x00101FFC File Offset: 0x001001FC
	[Token(Token = "0x6002FFA")]
	[Address(RVA = "0x5D3550", Offset = "0x5D1B50", VA = "0x1805D3550", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Tanglekelp;
	}

	// Token: 0x06002FFB RID: 12283 RVA: 0x0010200C File Offset: 0x0010020C
	[Token(Token = "0x6002FFB")]
	[Address(RVA = "0x716AF0", Offset = "0x7150F0", VA = "0x180716AF0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.ReversalPool;
	}

	// Token: 0x06002FFC RID: 12284 RVA: 0x0010201C File Offset: 0x0010021C
	[Token(Token = "0x6002FFC")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002FFD RID: 12285 RVA: 0x0010202C File Offset: 0x0010022C
	[Token(Token = "0x6002FFD")]
	[Address(RVA = "0x71BB90", Offset = "0x71A190", VA = "0x18071BB90", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉泳池：第4关";
	}

	// Token: 0x06002FFE RID: 12286 RVA: 0x00102040 File Offset: 0x00100240
	[Token(Token = "0x6002FFE")]
	[Address(RVA = "0x71BC50", Offset = "0x71A250", VA = "0x18071BC50", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "水上霸主：不在陆地上放置植物";
		}
		if (result == MissionResult.Second)
		{
			return "深渊猎手：使用水草拖拽15只僵尸下水";
		}
		return string.Empty;
	}

	// Token: 0x06002FFF RID: 12287 RVA: 0x00102068 File Offset: 0x00100268
	[Token(Token = "0x6002FFF")]
	[Address(RVA = "0x71BBD0", Offset = "0x71A1D0", VA = "0x18071BBD0", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "水生植物获得20%的伤害加成";
		}
		if (result == MissionResult.Second)
		{
			return "水草的冷却时间减少20%";
		}
		return string.Empty;
	}

	// Token: 0x06003000 RID: 12288 RVA: 0x00102090 File Offset: 0x00100290
	[Token(Token = "0x6003000")]
	[Address(RVA = "0x71B9F0", Offset = "0x719FF0", VA = "0x18071B9F0", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		advantureMission.endResult = (MissionResult)((ulong)1L);
		AdvantureMission mission = advantureMission;
		AdvantureMission mission4 = mission;
		Func<Plant, bool> <>9__1;
		Func<MissionResult> func = delegate
		{
			List<Plant> allPlants = Lawnf.GetAllPlants();
			Func<Plant, bool> <>9__ = <>9__1;
			if (<>9__ == 0)
			{
				Func<Plant, bool> func2 = delegate(Plant p)
				{
					GridSystem gridSystem = board.gridSystem;
					int thePlantRow = p.thePlantRow;
					int thePlantColumn = p.thePlantColumn;
					return gridSystem.GetGrid(thePlantColumn, thePlantRow).boxType == BoxType.Grass;
				};
				<>9__1 = func2;
			}
			bool flag = Enumerable.FirstOrDefault<Plant>(allPlants, <>9__);
			int num = 0;
			if (flag)
			{
				mission.endResult = (MissionResult)num;
			}
			AdvantureMission mission3 = mission;
			throw new NullReferenceException();
		};
		mission4.target = func;
		AdvantureMission mission2 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x06003001 RID: 12289 RVA: 0x00102114 File Offset: 0x00100314
	[Token(Token = "0x6003001")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Pool4Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
