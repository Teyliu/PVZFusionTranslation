using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020007B2 RID: 1970
[Token(Token = "0x20007B2")]
[Serializable]
public class SurvivalData
{
	// Token: 0x060027F0 RID: 10224 RVA: 0x000D9018 File Offset: 0x000D7218
	[Token(Token = "0x60027F0")]
	[Address(RVA = "0x60D1C0", Offset = "0x60B7C0", VA = "0x18060D1C0")]
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

	// Token: 0x04001638 RID: 5688
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001638")]
	public string name;

	// Token: 0x04001639 RID: 5689
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001639")]
	public string version;

	// Token: 0x0400163A RID: 5690
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400163A")]
	public long savedTime;

	// Token: 0x0400163B RID: 5691
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400163B")]
	public List<SavePlantData> plants;

	// Token: 0x0400163C RID: 5692
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400163C")]
	public SaveBoardData boardData;

	// Token: 0x0400163D RID: 5693
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400163D")]
	public TravelData travelData;

	// Token: 0x0400163E RID: 5694
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400163E")]
	public List<PlantType> cardOnBank;

	// Token: 0x0400163F RID: 5695
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400163F")]
	public PetData petData;

	// Token: 0x04001640 RID: 5696
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001640")]
	public GodData godData;

	// Token: 0x04001641 RID: 5697
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001641")]
	public CampType campType;

	// Token: 0x04001642 RID: 5698
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4001642")]
	public LeaderType leaderType;

	// Token: 0x04001643 RID: 5699
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001643")]
	public List<ZombieType> zombie_a;

	// Token: 0x04001644 RID: 5700
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001644")]
	public List<ZombieType> zombie_b;

	// Token: 0x04001645 RID: 5701
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001645")]
	public List<ZombieType> zombie_c;

	// Token: 0x04001646 RID: 5702
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001646")]
	public ZombieType bossType;

	// Token: 0x04001647 RID: 5703
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001647")]
	public List<PlantType> rogueCards;
}
