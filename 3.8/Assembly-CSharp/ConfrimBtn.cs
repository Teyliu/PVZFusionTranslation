using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using ZenGarden;

// Token: 0x0200075F RID: 1887
[Token(Token = "0x200075F")]
public class ConfrimBtn : UIBtn
{
	// Token: 0x06002651 RID: 9809 RVA: 0x000CBFBC File Offset: 0x000CA1BC
	[Token(Token = "0x6002651")]
	[Address(RVA = "0x5D65D0", Offset = "0x5D4BD0", VA = "0x1805D65D0", Slot = "7")]
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
					int num3 = 0;
					instance.ShowText("余额不足，购买需要：10000", 3f, num3 != 0);
					GardenUnifiedData data = GardenUI.Data;
					PlantType thePlantType = this.plant.data.thePlantType;
					int currentPage = GardenUI.Instance.currentPage;
					bool flag;
					if (!flag)
					{
						InGameText instance2 = InGameText.Instance;
						int num4 = 0;
						instance2.ShowText("购买失败，花园已满", 3f, num4 != 0);
					}
					GardenUnifiedData data2 = GardenUI.Data;
					string name = global::Lawnf.GetName(this.plant.data.thePlantType);
					string text = "购买植物：" + name;
					data2.Save(text);
					this.plant.Die();
					int num5 = 0;
					InGameText instance3 = InGameText.Instance;
					num5++;
					int num6;
					int num7;
					int num8;
					string text2 = string.Format("购买成功，植物已放在第{0}页的第{1}行{2}列格子中", num6, num7, num8);
					int num9 = 0;
					instance3.ShowText(text2, 3f, num9 != 0);
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
							goto IL_0237;
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
		IL_0237:
		GameAPP.UIManager.Pop();
	}

	// Token: 0x06002652 RID: 9810 RVA: 0x000CC214 File Offset: 0x000CA414
	[Token(Token = "0x6002652")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public ConfrimBtn()
	{
	}

	// Token: 0x040013E2 RID: 5090
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40013E2")]
	public GardenPlant plant;

	// Token: 0x040013E3 RID: 5091
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40013E3")]
	public GardenTool gardenTool;

	// Token: 0x040013E4 RID: 5092
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40013E4")]
	public bool yes;

	// Token: 0x040013E5 RID: 5093
	[FieldOffset(Offset = "0x71")]
	[Token(Token = "0x40013E5")]
	public bool buy;
}
