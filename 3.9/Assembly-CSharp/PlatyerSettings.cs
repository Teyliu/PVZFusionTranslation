using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020007E8 RID: 2024
[Token(Token = "0x20007E8")]
[Serializable]
public class PlatyerSettings
{
	// Token: 0x0600291C RID: 10524 RVA: 0x000DDED8 File Offset: 0x000DC0D8
	[Token(Token = "0x600291C")]
	[Address(RVA = "0x667810", Offset = "0x665E10", VA = "0x180667810")]
	public PlatyerSettings()
	{
		bool[] array = new bool[128];
		this.advLevelCompleted = array;
		bool[] array2 = new bool[256];
		this.clgLevelCompleted = array2;
		bool[] array3 = new bool[128];
		this.gameLevelCompleted = array3;
		bool[] array4 = new bool[128];
		this.survivalLevelCompleted = array4;
		List<int> list = new List();
		this.tutorLevelCompleted = list;
		List<int> list2 = new List();
		this.skinLevelCompleted = list2;
		List<int> list3 = new List();
		this.customCompleted = list3;
		List<string> list4 = new List();
		this.nameLevelCompleted = list4;
		List<PlantType> list5 = new List();
		this.randomPlantInZhouMu = list5;
		List<PlantType> list6 = new List();
		this.bannedInPVPScaryPot = list6;
		List<ZombieType> list7 = new List();
		this.bannedInPVPScaryPot_zombie = list7;
		List<PlantSkinData> list8 = new List();
		this.plantSkinData = list8;
		base..ctor();
	}

	// Token: 0x040016F9 RID: 5881
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40016F9")]
	public int advLevel;

	// Token: 0x040016FA RID: 5882
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40016FA")]
	public int advZhouMu;

	// Token: 0x040016FB RID: 5883
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40016FB")]
	public int newAdvArrivedLevel;

	// Token: 0x040016FC RID: 5884
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40016FC")]
	public int advanture2Level;

	// Token: 0x040016FD RID: 5885
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40016FD")]
	public int playerShootingArrivedLevel;

	// Token: 0x040016FE RID: 5886
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40016FE")]
	public int towerLevel;

	// Token: 0x040016FF RID: 5887
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40016FF")]
	public long theMoneyCount;

	// Token: 0x04001700 RID: 5888
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001700")]
	public bool[] advLevelCompleted;

	// Token: 0x04001701 RID: 5889
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001701")]
	public bool[] clgLevelCompleted;

	// Token: 0x04001702 RID: 5890
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001702")]
	public bool[] gameLevelCompleted;

	// Token: 0x04001703 RID: 5891
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001703")]
	public bool[] survivalLevelCompleted;

	// Token: 0x04001704 RID: 5892
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001704")]
	public List<int> tutorLevelCompleted;

	// Token: 0x04001705 RID: 5893
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001705")]
	public List<int> skinLevelCompleted;

	// Token: 0x04001706 RID: 5894
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001706")]
	public List<int> customCompleted;

	// Token: 0x04001707 RID: 5895
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001707")]
	public List<string> nameLevelCompleted;

	// Token: 0x04001708 RID: 5896
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001708")]
	public List<PlantType> randomPlantInZhouMu;

	// Token: 0x04001709 RID: 5897
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001709")]
	public List<PlantType> bannedInPVPScaryPot;

	// Token: 0x0400170A RID: 5898
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400170A")]
	public List<ZombieType> bannedInPVPScaryPot_zombie;

	// Token: 0x0400170B RID: 5899
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400170B")]
	public List<PlantSkinData> plantSkinData;

	// Token: 0x0400170C RID: 5900
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400170C")]
	public GodData godData;

	// Token: 0x0400170D RID: 5901
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400170D")]
	public TreasureSaveData treasureSaveData;

	// Token: 0x0400170E RID: 5902
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400170E")]
	public AdvantureData advantureData;

	// Token: 0x0400170F RID: 5903
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400170F")]
	public GameConfig config;
}
