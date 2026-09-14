using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000877 RID: 2167
[Token(Token = "0x2000877")]
public class GardenPlantInfoMenu : BaseMenu
{
	// Token: 0x06002C27 RID: 11303 RVA: 0x000F0764 File Offset: 0x000EE964
	[Token(Token = "0x6002C27")]
	[Address(RVA = "0x6BFDD0", Offset = "0x6BE3D0", VA = "0x1806BFDD0")]
	public void Upgrade()
	{
		GardenEquipment equipment = this.window.equipment;
		GardenEquipment equip = equipment;
		GardenEquipment equip2 = equip;
		int num = 0;
		if (equip2 != num)
		{
			int level = equip.data.level;
			if (level >= 3)
			{
				GameAPP.PlaySound(26, 0.5f, 1f);
				InGameText instance = InGameText.Instance;
				return;
			}
			UIResourcesLoader uimanager = GameAPP.UIManager;
			Transform canvasUp = GameAPP.canvasUp;
			int num2 = 0;
			BaseMenu baseMenu = uimanager.Push((UIType)((uint)47), canvasUp, num2 != 0);
			EquipmentType theEquipmentType = equip.data.theEquipmentType;
			int num3 = level + 1;
			int cost = num3;
			ValueTuple<int, string> valueTuple;
			string text = string.Format("是否以{0}的价格升级？", valueTuple);
			Action action = delegate
			{
				int cost2 = cost;
				TreasureData.treasureMoney = TreasureData.treasureMoney;
				EquipmentData data = equip.data;
				this.window.InitText();
				InGameText instance2 = InGameText.Instance;
				uint num4;
				GameAPP.PlaySound((int)num4, 0.5f, 1f);
			};
		}
	}

	// Token: 0x06002C28 RID: 11304 RVA: 0x000F083C File Offset: 0x000EEA3C
	[Token(Token = "0x6002C28")]
	[Address(RVA = "0x6BFBA0", Offset = "0x6BE1A0", VA = "0x1806BFBA0")]
	public void Sell()
	{
		GardenEquipment equipment = this.window.equipment;
		int num = 0;
		if (equipment != num)
		{
			EquipmentType theEquipmentType = equipment.data.theEquipmentType;
			EquipmentData data = equipment.data;
			int level = data.level;
			if (data == 0 || data == 0 || level == 1)
			{
			}
			TreasureData.treasureMoney = TreasureData.treasureMoney;
			List<EquipmentData> equipmentData = TreasureData.equipmentData;
			EquipmentData data2 = equipment.data;
			bool flag = equipmentData.Remove(data2);
			global::UnityEngine.Object.Destroy(equipment.gameObject);
			Garden instance = Garden.Instance;
			EquipmentData data3 = equipment.data;
			Dictionary<ValueTuple<int, int>, GardenEquipment> equipments = instance.equipments;
			EquipmentData data4 = equipment.data;
			int theColumn = data3.theColumn;
			int theRow = data4.theRow;
			base.PopMenu();
		}
	}

	// Token: 0x06002C29 RID: 11305 RVA: 0x000F0900 File Offset: 0x000EEB00
	[Token(Token = "0x6002C29")]
	[Address(RVA = "0x6BF990", Offset = "0x6BDF90", VA = "0x1806BF990")]
	public void MovePlantToWareHouse()
	{
		BigGardenPlant plant = this.window.plant;
		int num = 0;
		if (plant != num)
		{
			if (!TreasureData.WareHouseUnfull)
			{
				GameAPP.PlaySound(26, 0.5f, 1f);
				InGameText instance = InGameText.Instance;
				return;
			}
			plant.data.inGraden = false;
			global::UnityEngine.Object.Destroy(plant.gameObject);
			Dictionary<ValueTuple<int, int>, BigGardenPlant> plants = plant.garden.plants;
			int theRow = plant.theRow;
			int theColumn = plant.theColumn;
			base.PopMenu();
		}
	}

	// Token: 0x06002C2A RID: 11306 RVA: 0x000F098C File Offset: 0x000EEB8C
	[Token(Token = "0x6002C2A")]
	[Address(RVA = "0x6BF920", Offset = "0x6BDF20", VA = "0x1806BF920")]
	private void Update()
	{
		if (!base.Interactable || Input.GetKeyDownInt((KeyCode)((uint)27)))
		{
		}
	}

	// Token: 0x06002C2B RID: 11307 RVA: 0x000F09B0 File Offset: 0x000EEBB0
	[Token(Token = "0x6002C2B")]
	[Address(RVA = "0x667800", Offset = "0x665E00", VA = "0x180667800")]
	public GardenPlantInfoMenu()
	{
	}

	// Token: 0x04001A11 RID: 6673
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001A11")]
	public PlantInfoWindow window;

	// Token: 0x04001A12 RID: 6674
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001A12")]
	public GameObject upgradeButton;

	// Token: 0x04001A13 RID: 6675
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001A13")]
	public GameObject sellButton;

	// Token: 0x04001A14 RID: 6676
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001A14")]
	public GameObject plantButton;
}
