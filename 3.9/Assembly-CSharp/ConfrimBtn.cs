using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using ZenGarden;

// Token: 0x02000798 RID: 1944
[Token(Token = "0x2000798")]
public class ConfrimBtn : UIBtn
{
	// Token: 0x06002778 RID: 10104 RVA: 0x000D1040 File Offset: 0x000CF240
	[Token(Token = "0x6002778")]
	[Address(RVA = "0x639490", Offset = "0x637A90", VA = "0x180639490", Slot = "7")]
	protected override void OnMouseUpAsButton()
	{
		int num = 0;
		base.OnMouseUpAsButton();
		if ((this.yes ? 1 : 0) != num)
		{
			GardenPlant gardenPlant = this.plant;
			int num2 = 0;
			if (gardenPlant != num2)
			{
				if ((this.buy ? 1 : 0) != num)
				{
					InGameText instance = InGameText.Instance;
					GardenUnifiedData data = GardenUI.Data;
					PlantType thePlantType = this.plant.data.thePlantType;
					int currentPage = GardenUI.Instance.currentPage;
					bool flag;
					if (!flag)
					{
						InGameText instance2 = InGameText.Instance;
					}
					GardenUnifiedData data2 = GardenUI.Data;
					string name = global::Lawnf.GetName(this.plant.data.thePlantType);
					string text = "购买植物：" + name;
					data2.Save(text);
					this.plant.Die();
					int num3 = 0;
					InGameText instance3 = InGameText.Instance;
					num3++;
					int num4;
					int num5;
					int num6;
					string text2 = string.Format("购买成功，植物已放在第{0}页的第{1}行{2}列格子中", num4, num5, num6);
					GameAPP.theMoneyCount = GameAPP.theMoneyCount;
				}
				List<GardenPlant> gardenPlants = GardenUI.Instance.gardenPlants;
				GardenPlant gardenPlant2 = this.plant;
				bool flag2 = gardenPlants.Remove(gardenPlant2);
				global::UnityEngine.Object.Destroy(this.plant.gameObject);
				GardenUnifiedData data3 = GardenUI.Data;
				GardenPlant gardenPlant3 = this.plant;
				List<GardenPlantData> allPlants = data3.allPlants;
				GardenPlantData data4 = gardenPlant3.data;
				bool flag3 = allPlants.Remove(data4);
				GardenUnifiedData data5 = GardenUI.Data;
				string name2 = global::Lawnf.GetName(this.plant.data.thePlantType);
				string text3 = "出售植物：" + name2;
				data5.Save(text3);
				int growStage = this.plant.data.growStage;
				if (growStage != 0)
				{
					if (growStage != 0)
					{
						if (growStage != 1)
						{
							goto IL_01F8;
						}
						Transform axis = this.plant.axis;
						Transform transform = GardenUI.Instance.background.transform;
						num++;
					}
					Transform axis2 = this.plant.axis;
					Transform transform2 = GardenUI.Instance.background.transform;
					num++;
				}
				Transform axis3 = this.plant.axis;
				Transform transform3 = GardenUI.Instance.background.transform;
			}
		}
		IL_01F8:
		GameAPP.UIManager.Pop();
	}

	// Token: 0x06002779 RID: 10105 RVA: 0x000D1258 File Offset: 0x000CF458
	[Token(Token = "0x6002779")]
	[Address(RVA = "0x5EDFC0", Offset = "0x5EC5C0", VA = "0x1805EDFC0")]
	public ConfrimBtn()
	{
	}

	// Token: 0x040014BA RID: 5306
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40014BA")]
	public GardenPlant plant;

	// Token: 0x040014BB RID: 5307
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40014BB")]
	public GardenTool gardenTool;

	// Token: 0x040014BC RID: 5308
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40014BC")]
	public bool yes;

	// Token: 0x040014BD RID: 5309
	[FieldOffset(Offset = "0x71")]
	[Token(Token = "0x40014BD")]
	public bool buy;
}
