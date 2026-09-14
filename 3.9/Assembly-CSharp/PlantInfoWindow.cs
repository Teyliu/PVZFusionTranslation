using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020008A3 RID: 2211
[Token(Token = "0x20008A3")]
public class PlantInfoWindow : BaseWindow
{
	// Token: 0x06002D2F RID: 11567 RVA: 0x000F6478 File Offset: 0x000F4678
	[Token(Token = "0x6002D2F")]
	[Address(RVA = "0x6D5E20", Offset = "0x6D4420", VA = "0x1806D5E20", Slot = "4")]
	protected override void Start()
	{
		base.Start();
		this.InitText();
	}

	// Token: 0x06002D30 RID: 11568 RVA: 0x000F6494 File Offset: 0x000F4694
	[Token(Token = "0x6002D30")]
	[Address(RVA = "0x6D58B0", Offset = "0x6D3EB0", VA = "0x1806D58B0")]
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

	// Token: 0x06002D31 RID: 11569 RVA: 0x000F65F4 File Offset: 0x000F47F4
	[Token(Token = "0x6002D31")]
	[Address(RVA = "0x6D5C70", Offset = "0x6D4270", VA = "0x1806D5C70", Slot = "11")]
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

	// Token: 0x06002D32 RID: 11570 RVA: 0x000F66A4 File Offset: 0x000F48A4
	[Token(Token = "0x6002D32")]
	[Address(RVA = "0x6BF110", Offset = "0x6BD710", VA = "0x1806BF110")]
	public PlantInfoWindow()
	{
	}

	// Token: 0x04001B11 RID: 6929
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4001B11")]
	public BigGardenPlant plant;

	// Token: 0x04001B12 RID: 6930
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4001B12")]
	public GardenEquipment equipment;
}
