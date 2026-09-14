using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000867 RID: 2151
[Token(Token = "0x2000867")]
public class PlantInfoWindow : BaseWindow
{
	// Token: 0x06002BFD RID: 11261 RVA: 0x000F17E8 File Offset: 0x000EF9E8
	[Token(Token = "0x6002BFD")]
	[Address(RVA = "0x671250", Offset = "0x66F850", VA = "0x180671250", Slot = "4")]
	protected override void Start()
	{
		base.Start();
		this.InitText();
	}

	// Token: 0x06002BFE RID: 11262 RVA: 0x000F1804 File Offset: 0x000EFA04
	[Token(Token = "0x6002BFE")]
	[Address(RVA = "0x670CE0", Offset = "0x66F2E0", VA = "0x180670CE0")]
	public void InitText()
	{
		BigGardenPlant bigGardenPlant = this.plant;
		int num = 0;
		if (!(bigGardenPlant != num))
		{
			GardenEquipment gardenEquipment = this.equipment;
			int num2 = 0;
			if (gardenEquipment != num2)
			{
				EquipmentData data = this.equipment.data;
				EquipmentType theEquipmentType = data.theEquipmentType;
				int level = data.level;
				string text = string.Format("\n等级：{0}", level);
				string text3;
				string text2 = string.Format("\n生效范围：\n{0}x{1}", text3, text3);
				string text4 = text3 + text2 + "\n生效间隔：\n3秒";
				base.SetDescription(text4);
			}
			return;
		}
		TreasureCardData data2 = this.plant.data;
		string name = Lawnf.GetName(data2.thePlantType);
		int durability = data2.durability;
		int maxDurability = data2.maxDurability;
		string text5 = string.Format("\n耐久：{0}/{1}", name, name);
		string text6 = name + text5;
		int thePlantType = (int)data2.thePlantType;
		int num3;
		string text7 = string.Format("\n参考价值：{0}", num3);
		string text8 = text6 + text7;
		CardLevel cardLevel = TreasureData.GetCardLevel(data2.thePlantType);
		string text9 = string.Format("\n植物品质：{0}", cardLevel);
		string text10 = text8 + text9;
		int stage = data2.stage;
		string text11 = string.Format("\n生长阶段：{0}", text10);
		string text12 = text10 + text11;
		int cultivateLevel = data2.cultivateLevel;
		string text13 = string.Format("\n成长值：{0}", text12);
		throw new NullReferenceException();
	}

	// Token: 0x06002BFF RID: 11263 RVA: 0x000F1964 File Offset: 0x000EFB64
	[Token(Token = "0x6002BFF")]
	[Address(RVA = "0x6710A0", Offset = "0x66F6A0", VA = "0x1806710A0", Slot = "11")]
	public override void OnAnimOver()
	{
		BigGardenPlant bigGardenPlant = this.plant;
		int num = 0;
		if (bigGardenPlant != num)
		{
			PlantType thePlantType = this.plant.thePlantType;
			GameObject gameObject = base.SetPlant(thePlantType);
		}
		GardenEquipment gardenEquipment = this.equipment;
		int num2 = 0;
		if (gardenEquipment != num2)
		{
			GameObject gameObject2 = GardenEquipment.SetEquipmentPreviewWithShadow(this.equipment.data.theEquipmentType);
			Transform transform = gameObject2.transform;
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			gameObject2.GetComponent<SortingGroup>().sortingLayerName = "UI";
			Transform transform2 = gameObject2.transform;
			Transform transform3 = base.transform;
			transform2.parentInternal = transform3;
		}
	}

	// Token: 0x06002C00 RID: 11264 RVA: 0x000F1A14 File Offset: 0x000EFC14
	[Token(Token = "0x6002C00")]
	[Address(RVA = "0x65B2B0", Offset = "0x6598B0", VA = "0x18065B2B0")]
	public PlantInfoWindow()
	{
	}

	// Token: 0x04001A23 RID: 6691
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4001A23")]
	public BigGardenPlant plant;

	// Token: 0x04001A24 RID: 6692
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4001A24")]
	public GardenEquipment equipment;
}
