using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000612 RID: 1554
[Token(Token = "0x2000612")]
[Serializable]
public class TreasureSaveData
{
	// Token: 0x06001D72 RID: 7538 RVA: 0x0009D4A8 File Offset: 0x0009B6A8
	[Token(Token = "0x6001D72")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public TreasureSaveData()
	{
	}

	// Token: 0x04000FE9 RID: 4073
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000FE9")]
	public List<PlantType> collectedPlants;

	// Token: 0x04000FEA RID: 4074
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000FEA")]
	public List<TreasureCardData> treasureCards;

	// Token: 0x04000FEB RID: 4075
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000FEB")]
	public List<EquipmentData> equipmentData;

	// Token: 0x04000FEC RID: 4076
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000FEC")]
	public BigGardenData gardenData;

	// Token: 0x04000FED RID: 4077
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000FED")]
	public int treasureMoney;

	// Token: 0x04000FEE RID: 4078
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000FEE")]
	public int wareHouseLevel;
}
