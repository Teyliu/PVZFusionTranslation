using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020008C0 RID: 2240
[Token(Token = "0x20008C0")]
public interface ILevelStrategy
{
	// Token: 0x06002D71 RID: 11633
	[Token(Token = "0x6002D71")]
	[Address(Slot = "0")]
	AdvantureLevel GetLevel();

	// Token: 0x06002D72 RID: 11634
	[Token(Token = "0x6002D72")]
	[Address(Slot = "1")]
	void SetupBoard(Board board);

	// Token: 0x06002D73 RID: 11635
	[Token(Token = "0x6002D73")]
	[Address(Slot = "2")]
	AdvantureMission CreateMission(Board board);

	// Token: 0x06002D74 RID: 11636
	[Token(Token = "0x6002D74")]
	[Address(Slot = "3")]
	int GetMaxWave();

	// Token: 0x06002D75 RID: 11637
	[Token(Token = "0x6002D75")]
	[Address(Slot = "4")]
	List<ZombieType> GetZombieTypes();

	// Token: 0x06002D76 RID: 11638
	[Token(Token = "0x6002D76")]
	[Address(Slot = "5")]
	PlantType GetBasePlant();

	// Token: 0x06002D77 RID: 11639
	[Token(Token = "0x6002D77")]
	[Address(Slot = "6")]
	List<PlantType> GetConveyPlants();

	// Token: 0x06002D78 RID: 11640
	[Token(Token = "0x6002D78")]
	[Address(Slot = "7")]
	List<PlantType> GetRandomPlantTypes();

	// Token: 0x06002D79 RID: 11641
	[Token(Token = "0x6002D79")]
	[Address(Slot = "8")]
	List<ZombieType> GetRandomZombieTypes();

	// Token: 0x06002D7A RID: 11642
	[Token(Token = "0x6002D7A")]
	[Address(Slot = "9")]
	SceneType GetSceneType();

	// Token: 0x06002D7B RID: 11643
	[Token(Token = "0x6002D7B")]
	[Address(Slot = "10")]
	string GetLevelName();

	// Token: 0x06002D7C RID: 11644
	[Token(Token = "0x6002D7C")]
	[Address(Slot = "11")]
	string GetLevelTip();

	// Token: 0x06002D7D RID: 11645
	[Token(Token = "0x6002D7D")]
	[Address(Slot = "12")]
	string GetMissionDescription(MissionResult result);

	// Token: 0x06002D7E RID: 11646
	[Token(Token = "0x6002D7E")]
	[Address(Slot = "13")]
	string GetMissionAwardDescription(MissionResult result);

	// Token: 0x06002D7F RID: 11647
	[Token(Token = "0x6002D7F")]
	[Address(Slot = "14")]
	void OnBoardStart(Board board);

	// Token: 0x06002D80 RID: 11648
	[Token(Token = "0x6002D80")]
	[Address(Slot = "15")]
	void InitCard(InitBoard initBoard);
}
