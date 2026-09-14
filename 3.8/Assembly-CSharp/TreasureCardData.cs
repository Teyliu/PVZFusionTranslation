using System;
using Cpp2IlInjected;
using TMPro;

// Token: 0x02000615 RID: 1557
[Token(Token = "0x2000615")]
[Serializable]
public class TreasureCardData
{
	// Token: 0x06001D75 RID: 7541 RVA: 0x0009D4EC File Offset: 0x0009B6EC
	[Token(Token = "0x6001D75")]
	[Address(RVA = "0x524C70", Offset = "0x523270", VA = "0x180524C70")]
	public TreasureCardData(PlantType thePlantType, int durability, int maxDurability)
	{
		this.thePlantType = thePlantType;
		this.durability = durability;
		this.maxDurability = maxDurability;
	}

	// Token: 0x06001D76 RID: 7542 RVA: 0x0009D518 File Offset: 0x0009B718
	[Token(Token = "0x6001D76")]
	[Address(RVA = "0x524A90", Offset = "0x523090", VA = "0x180524A90")]
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

	// Token: 0x06001D77 RID: 7543 RVA: 0x0009D5C4 File Offset: 0x0009B7C4
	[Token(Token = "0x6001D77")]
	[Address(RVA = "0x524A40", Offset = "0x523040", VA = "0x180524A40")]
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

	// Token: 0x06001D78 RID: 7544 RVA: 0x0009D634 File Offset: 0x0009B834
	[Token(Token = "0x6001D78")]
	[Address(RVA = "0x524C30", Offset = "0x523230", VA = "0x180524C30")]
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

	// Token: 0x04000FF5 RID: 4085
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000FF5")]
	public PlantType thePlantType;

	// Token: 0x04000FF6 RID: 4086
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000FF6")]
	public int durability;

	// Token: 0x04000FF7 RID: 4087
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000FF7")]
	public int maxDurability;

	// Token: 0x04000FF8 RID: 4088
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000FF8")]
	public long id;

	// Token: 0x04000FF9 RID: 4089
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000FF9")]
	public bool equiped;

	// Token: 0x04000FFA RID: 4090
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x4000FFA")]
	public bool inGraden;

	// Token: 0x04000FFB RID: 4091
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000FFB")]
	public int theColumn;

	// Token: 0x04000FFC RID: 4092
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000FFC")]
	public int theRow;

	// Token: 0x04000FFD RID: 4093
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000FFD")]
	public ToolType needTool;

	// Token: 0x04000FFE RID: 4094
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000FFE")]
	public long nextTime;

	// Token: 0x04000FFF RID: 4095
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000FFF")]
	public int stage;

	// Token: 0x04001000 RID: 4096
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4001000")]
	public int waterLevel;

	// Token: 0x04001001 RID: 4097
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001001")]
	public int cultivateLevel;
}
