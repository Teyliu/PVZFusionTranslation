using System;
using Cpp2IlInjected;
using TMPro;

// Token: 0x0200064A RID: 1610
[Token(Token = "0x200064A")]
[Serializable]
public class TreasureCardData
{
	// Token: 0x06001E74 RID: 7796 RVA: 0x000A1F98 File Offset: 0x000A0198
	[Token(Token = "0x6001E74")]
	[Address(RVA = "0x58FDF0", Offset = "0x58E3F0", VA = "0x18058FDF0")]
	public TreasureCardData(PlantType thePlantType, int durability, int maxDurability)
	{
		this.thePlantType = thePlantType;
		this.durability = durability;
		this.maxDurability = maxDurability;
	}

	// Token: 0x06001E75 RID: 7797 RVA: 0x000A1FC4 File Offset: 0x000A01C4
	[Token(Token = "0x6001E75")]
	[Address(RVA = "0x58FC10", Offset = "0x58E210", VA = "0x18058FC10")]
	public void Load(TreasureCard card)
	{
		PlantType plantType = this.thePlantType;
		card._plantType = plantType;
		card.SetIcon();
		int num = this.durability;
		TextMeshProUGUI durText = card.durText;
		card._durability = num;
		int num2 = card._maxDurability;
		string text = string.Format("{0}/{1}", "{0}/{1}", "{0}/{1}");
		durText.text = text;
		int num3 = this.maxDurability;
		int num4 = card._durability;
		TextMeshProUGUI durText2 = card.durText;
		card._maxDurability = num3;
		int num5 = card._maxDurability;
		num3 = num4;
		string text2 = string.Format("{0}/{1}", num3, num4);
		durText2.text = text2;
		card.data = this;
		throw new NullReferenceException();
	}

	// Token: 0x06001E76 RID: 7798 RVA: 0x000A2070 File Offset: 0x000A0270
	[Token(Token = "0x6001E76")]
	[Address(RVA = "0x58FBC0", Offset = "0x58E1C0", VA = "0x18058FBC0")]
	public void LoadGarden(BigGardenPlant plant)
	{
		if (this.stage == 0)
		{
			this.stage = (int)((ulong)1L);
		}
		ToolType toolType = this.needTool;
		plant.needTool = toolType;
		long num = this.nextTime;
		plant.nextTime = num;
		int num2 = this.stage;
		plant.stage = num2;
		int num3 = this.waterLevel;
		plant.waterLevel = num3;
		int num4 = this.cultivateLevel;
		plant.cultivateLevel = num4;
	}

	// Token: 0x06001E77 RID: 7799 RVA: 0x000A20E0 File Offset: 0x000A02E0
	[Token(Token = "0x6001E77")]
	[Address(RVA = "0x58FDB0", Offset = "0x58E3B0", VA = "0x18058FDB0")]
	public void SaveFromGarden(BigGardenPlant plant)
	{
		ToolType toolType = plant.needTool;
		this.needTool = toolType;
		long num = plant.nextTime;
		this.nextTime = num;
		int num2 = plant.stage;
		this.stage = num2;
		int num3 = plant.waterLevel;
		this.waterLevel = num3;
		int num4 = plant.cultivateLevel;
		this.cultivateLevel = num4;
	}

	// Token: 0x040010BD RID: 4285
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40010BD")]
	public PlantType thePlantType;

	// Token: 0x040010BE RID: 4286
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40010BE")]
	public int durability;

	// Token: 0x040010BF RID: 4287
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40010BF")]
	public int maxDurability;

	// Token: 0x040010C0 RID: 4288
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40010C0")]
	public long id;

	// Token: 0x040010C1 RID: 4289
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40010C1")]
	public bool equiped;

	// Token: 0x040010C2 RID: 4290
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x40010C2")]
	public bool inGraden;

	// Token: 0x040010C3 RID: 4291
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40010C3")]
	public int theColumn;

	// Token: 0x040010C4 RID: 4292
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40010C4")]
	public int theRow;

	// Token: 0x040010C5 RID: 4293
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40010C5")]
	public ToolType needTool;

	// Token: 0x040010C6 RID: 4294
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40010C6")]
	public long nextTime;

	// Token: 0x040010C7 RID: 4295
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40010C7")]
	public int stage;

	// Token: 0x040010C8 RID: 4296
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40010C8")]
	public int waterLevel;

	// Token: 0x040010C9 RID: 4297
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40010C9")]
	public int cultivateLevel;
}
