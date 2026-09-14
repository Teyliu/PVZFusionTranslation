using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200083B RID: 2107
[Token(Token = "0x200083B")]
public class GardenPlantInfoMenu : BaseMenu
{
	// Token: 0x06002AF5 RID: 10997 RVA: 0x000EBA24 File Offset: 0x000E9C24
	[Token(Token = "0x6002AF5")]
	[Address(RVA = "0x65BF60", Offset = "0x65A560", VA = "0x18065BF60")]
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
				int num2 = 0;
				instance.ShowText("已满级", 3f, num2 != 0);
				return;
			}
			UIResourcesLoader uimanager = GameAPP.UIManager;
			Transform canvasUp = GameAPP.canvasUp;
			int num3 = 0;
			BaseMenu baseMenu = uimanager.Push((UIType)((uint)47), canvasUp, num3 != 0);
			EquipmentType theEquipmentType = equip.data.theEquipmentType;
			int num4 = level + 1;
			int cost = num4;
			ValueTuple<int, string> valueTuple;
			string text = string.Format("是否以{0}的价格升级？", valueTuple);
			Action action = delegate
			{
				int cost2 = cost;
				TreasureData.treasureMoney = TreasureData.treasureMoney;
				EquipmentData data = equip.data;
				this.window.InitText();
				InGameText instance2 = InGameText.Instance;
				uint num5;
				GameAPP.PlaySound((int)num5, 0.5f, 1f);
			};
		}
	}

	// Token: 0x06002AF6 RID: 10998 RVA: 0x000EBB14 File Offset: 0x000E9D14
	[Token(Token = "0x6002AF6")]
	[Address(RVA = "0x65BD30", Offset = "0x65A330", VA = "0x18065BD30")]
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

	// Token: 0x06002AF7 RID: 10999 RVA: 0x000EBBD8 File Offset: 0x000E9DD8
	[Token(Token = "0x6002AF7")]
	[Address(RVA = "0x65BB30", Offset = "0x65A130", VA = "0x18065BB30")]
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
				int num2 = 0;
				instance.ShowText("仓库已满", 3f, num2 != 0);
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

	// Token: 0x06002AF8 RID: 11000 RVA: 0x000EBC7C File Offset: 0x000E9E7C
	[Token(Token = "0x6002AF8")]
	[Address(RVA = "0x65BAC0", Offset = "0x65A0C0", VA = "0x18065BAC0")]
	private void Update()
	{
		if (!base.Interactable || Input.GetKeyDownInt((KeyCode)((uint)27)))
		{
		}
	}

	// Token: 0x06002AF9 RID: 11001 RVA: 0x000EBCA0 File Offset: 0x000E9EA0
	[Token(Token = "0x6002AF9")]
	[Address(RVA = "0x603FF0", Offset = "0x6025F0", VA = "0x180603FF0")]
	public GardenPlantInfoMenu()
	{
	}

	// Token: 0x04001923 RID: 6435
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001923")]
	public PlantInfoWindow window;

	// Token: 0x04001924 RID: 6436
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001924")]
	public GameObject upgradeButton;

	// Token: 0x04001925 RID: 6437
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001925")]
	public GameObject sellButton;

	// Token: 0x04001926 RID: 6438
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001926")]
	public GameObject plantButton;
}
