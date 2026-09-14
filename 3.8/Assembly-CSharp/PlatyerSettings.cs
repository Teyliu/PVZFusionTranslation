using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020007AF RID: 1967
[Token(Token = "0x20007AF")]
[Serializable]
public class PlatyerSettings
{
	// Token: 0x060027ED RID: 10221 RVA: 0x000D8F1C File Offset: 0x000D711C
	[Token(Token = "0x60027ED")]
	[Address(RVA = "0x604000", Offset = "0x602600", VA = "0x180604000")]
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

	// Token: 0x0400161D RID: 5661
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400161D")]
	public int advLevel;

	// Token: 0x0400161E RID: 5662
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400161E")]
	public int advZhouMu;

	// Token: 0x0400161F RID: 5663
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400161F")]
	public int newAdvArrivedLevel;

	// Token: 0x04001620 RID: 5664
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001620")]
	public int advanture2Level;

	// Token: 0x04001621 RID: 5665
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001621")]
	public int playerShootingArrivedLevel;

	// Token: 0x04001622 RID: 5666
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001622")]
	public int towerLevel;

	// Token: 0x04001623 RID: 5667
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001623")]
	public long theMoneyCount;

	// Token: 0x04001624 RID: 5668
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001624")]
	public bool[] advLevelCompleted;

	// Token: 0x04001625 RID: 5669
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001625")]
	public bool[] clgLevelCompleted;

	// Token: 0x04001626 RID: 5670
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001626")]
	public bool[] gameLevelCompleted;

	// Token: 0x04001627 RID: 5671
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001627")]
	public bool[] survivalLevelCompleted;

	// Token: 0x04001628 RID: 5672
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001628")]
	public List<int> tutorLevelCompleted;

	// Token: 0x04001629 RID: 5673
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001629")]
	public List<int> skinLevelCompleted;

	// Token: 0x0400162A RID: 5674
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400162A")]
	public List<int> customCompleted;

	// Token: 0x0400162B RID: 5675
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400162B")]
	public List<string> nameLevelCompleted;

	// Token: 0x0400162C RID: 5676
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400162C")]
	public List<PlantType> randomPlantInZhouMu;

	// Token: 0x0400162D RID: 5677
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400162D")]
	public List<PlantType> bannedInPVPScaryPot;

	// Token: 0x0400162E RID: 5678
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400162E")]
	public List<ZombieType> bannedInPVPScaryPot_zombie;

	// Token: 0x0400162F RID: 5679
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400162F")]
	public List<PlantSkinData> plantSkinData;

	// Token: 0x04001630 RID: 5680
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001630")]
	public GodData godData;

	// Token: 0x04001631 RID: 5681
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001631")]
	public TreasureSaveData treasureSaveData;

	// Token: 0x04001632 RID: 5682
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4001632")]
	public AdvantureData advantureData;

	// Token: 0x04001633 RID: 5683
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4001633")]
	public GameConfig config;
}
