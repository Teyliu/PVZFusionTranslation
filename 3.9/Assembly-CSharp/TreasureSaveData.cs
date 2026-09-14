using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000647 RID: 1607
[Token(Token = "0x2000647")]
[Serializable]
public class TreasureSaveData
{
	// Token: 0x06001E71 RID: 7793 RVA: 0x000A1F54 File Offset: 0x000A0154
	[Token(Token = "0x6001E71")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public TreasureSaveData()
	{
	}

	// Token: 0x040010B1 RID: 4273
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40010B1")]
	public List<PlantType> collectedPlants;

	// Token: 0x040010B2 RID: 4274
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40010B2")]
	public List<TreasureCardData> treasureCards;

	// Token: 0x040010B3 RID: 4275
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40010B3")]
	public List<EquipmentData> equipmentData;

	// Token: 0x040010B4 RID: 4276
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40010B4")]
	public BigGardenData gardenData;

	// Token: 0x040010B5 RID: 4277
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40010B5")]
	public int treasureMoney;

	// Token: 0x040010B6 RID: 4278
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40010B6")]
	public int wareHouseLevel;
}
