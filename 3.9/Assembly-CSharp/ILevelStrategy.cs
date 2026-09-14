using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020008FC RID: 2300
[Token(Token = "0x20008FC")]
public interface ILevelStrategy
{
	// Token: 0x06002EA4 RID: 11940
	[Token(Token = "0x6002EA4")]
	[Address(Slot = "0")]
	AdvantureLevel GetLevel();

	// Token: 0x06002EA5 RID: 11941
	[Token(Token = "0x6002EA5")]
	[Address(Slot = "1")]
	void SetupBoard(Board board);

	// Token: 0x06002EA6 RID: 11942
	[Token(Token = "0x6002EA6")]
	[Address(Slot = "2")]
	AdvantureMission CreateMission(Board board);

	// Token: 0x06002EA7 RID: 11943
	[Token(Token = "0x6002EA7")]
	[Address(Slot = "3")]
	int GetMaxWave();

	// Token: 0x06002EA8 RID: 11944
	[Token(Token = "0x6002EA8")]
	[Address(Slot = "4")]
	List<ZombieType> GetZombieTypes();

	// Token: 0x06002EA9 RID: 11945
	[Token(Token = "0x6002EA9")]
	[Address(Slot = "5")]
	PlantType GetBasePlant();

	// Token: 0x06002EAA RID: 11946
	[Token(Token = "0x6002EAA")]
	[Address(Slot = "6")]
	List<PlantType> GetConveyPlants();

	// Token: 0x06002EAB RID: 11947
	[Token(Token = "0x6002EAB")]
	[Address(Slot = "7")]
	List<PlantType> GetRandomPlantTypes();

	// Token: 0x06002EAC RID: 11948
	[Token(Token = "0x6002EAC")]
	[Address(Slot = "8")]
	List<ZombieType> GetRandomZombieTypes();

	// Token: 0x06002EAD RID: 11949
	[Token(Token = "0x6002EAD")]
	[Address(Slot = "9")]
	SceneType GetSceneType();

	// Token: 0x06002EAE RID: 11950
	[Token(Token = "0x6002EAE")]
	[Address(Slot = "10")]
	string GetLevelName();

	// Token: 0x06002EAF RID: 11951
	[Token(Token = "0x6002EAF")]
	[Address(Slot = "11")]
	string GetLevelTip();

	// Token: 0x06002EB0 RID: 11952
	[Token(Token = "0x6002EB0")]
	[Address(Slot = "12")]
	string GetMissionDescription(MissionResult result);

	// Token: 0x06002EB1 RID: 11953
	[Token(Token = "0x6002EB1")]
	[Address(Slot = "13")]
	string GetMissionAwardDescription(MissionResult result);

	// Token: 0x06002EB2 RID: 11954
	[Token(Token = "0x6002EB2")]
	[Address(Slot = "14")]
	void OnBoardStart(Board board);

	// Token: 0x06002EB3 RID: 11955
	[Token(Token = "0x6002EB3")]
	[Address(Slot = "15")]
	void InitCard(InitBoard initBoard);
}
