using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020007EB RID: 2027
[Token(Token = "0x20007EB")]
[Serializable]
public class SurvivalData
{
	// Token: 0x0600291F RID: 10527 RVA: 0x000DDFD4 File Offset: 0x000DC1D4
	[Token(Token = "0x600291F")]
	[Address(RVA = "0x670A10", Offset = "0x66F010", VA = "0x180670A10")]
	public SurvivalData()
	{
		List<ZombieType> list = new List();
		this.zombie_a = list;
		List<ZombieType> list2 = new List();
		this.zombie_b = list2;
		List<ZombieType> list3 = new List();
		this.zombie_c = list3;
		List<PlantType> list4 = new List();
		this.rogueCards = list4;
		base..ctor();
	}

	// Token: 0x04001714 RID: 5908
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001714")]
	public string name;

	// Token: 0x04001715 RID: 5909
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001715")]
	public string version;

	// Token: 0x04001716 RID: 5910
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001716")]
	public long savedTime;

	// Token: 0x04001717 RID: 5911
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001717")]
	public List<SavePlantData> plants;

	// Token: 0x04001718 RID: 5912
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001718")]
	public SaveBoardData boardData;

	// Token: 0x04001719 RID: 5913
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001719")]
	public TravelData travelData;

	// Token: 0x0400171A RID: 5914
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400171A")]
	public List<PlantType> cardOnBank;

	// Token: 0x0400171B RID: 5915
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400171B")]
	public PetData petData;

	// Token: 0x0400171C RID: 5916
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400171C")]
	public GodData godData;

	// Token: 0x0400171D RID: 5917
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400171D")]
	public CampType campType;

	// Token: 0x0400171E RID: 5918
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400171E")]
	public LeaderType leaderType;

	// Token: 0x0400171F RID: 5919
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400171F")]
	public List<ZombieType> zombie_a;

	// Token: 0x04001720 RID: 5920
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001720")]
	public List<ZombieType> zombie_b;

	// Token: 0x04001721 RID: 5921
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001721")]
	public List<ZombieType> zombie_c;

	// Token: 0x04001722 RID: 5922
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001722")]
	public ZombieType bossType;

	// Token: 0x04001723 RID: 5923
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001723")]
	public List<PlantType> rogueCards;
}
