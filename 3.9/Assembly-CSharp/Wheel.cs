using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000890 RID: 2192
[Token(Token = "0x2000890")]
public class Wheel : InGameTool
{
	// Token: 0x06002CCE RID: 11470 RVA: 0x000F4188 File Offset: 0x000F2388
	[Token(Token = "0x6002CCE")]
	[Address(RVA = "0x6E14B0", Offset = "0x6DFAB0", VA = "0x1806E14B0", Slot = "7")]
	protected override void OnUpdate()
	{
		if (Input.GetKeyDownInt(KeyCodeManager.Wheel))
		{
		}
	}

	// Token: 0x06002CCF RID: 11471 RVA: 0x000F41A4 File Offset: 0x000F23A4
	[Token(Token = "0x6002CCF")]
	[Address(RVA = "0x6E1530", Offset = "0x6DFB30", VA = "0x1806E1530", Slot = "9")]
	public override void Use(Mouse mouse)
	{
		int num2;
		Transform child;
		Plant plant2;
		for (;;)
		{
			int num = 0;
			num2 = 0;
			base.PutDown();
			int num3 = 0;
			mouse.ClearItemOnMouse(num3 != 0);
			if (this.thePlantType == PlantType.Nothing)
			{
				Vector2 mousePosition = mouse.MousePosition;
				RaycastHit2D[] array;
				List<Plant> plantsOnMouse = mouse.GetPlantsOnMouse(array);
				Predicate<Plant> <>9__5_ = Wheel.<>c.<>9__5_0;
				if (<>9__5_ == 0)
				{
					Predicate<Plant> predicate;
					Wheel.<>c.<>9__5_0 = predicate;
				}
				int num4 = plantsOnMouse.RemoveAll(<>9__5_);
				int num5 = 0;
				Plant plant = plantsOnMouse[num5];
				SavePlantData savePlantData = new SavePlantData(plant);
				this.savedData = savePlantData;
				PlantType plantType = plant.thePlantType;
				this.thePlantType = plantType;
				RectTransform rectTransform = this.plantAxis;
				Vector3 vector;
				float z = vector.z;
				GameObject gameObject;
				this.plant = gameObject;
				Transform transform = this.plant.transform;
				int num6 = 0;
				child = transform.GetChild(num6);
				List<SpriteRenderer> sortedSpriteRenderers = global::Core.Lawnf.GetSortedSpriteRenderers(this.plant);
				bool flag;
				if (flag)
				{
					Transform transform2 = this.plant.transform;
					Transform transform3;
					transform3.parentInternal = transform2;
					Transform transform4;
					transform4.SetAsLastSibling();
					bool flag2;
					if (flag2)
					{
						global::UnityEngine.Object.Destroy(num2);
					}
					global::UnityEngine.Object.Destroy(num);
					Image image = num.AddComponent<Image>();
					Sprite sprite;
					image.sprite = sprite;
					ulong num7;
					image.useSpriteMesh = num7 != 0UL;
				}
				if (num2 == 0)
				{
					break;
				}
			}
			else
			{
				CreatePlant.canStarUp = num2 != 0;
				CreatePlant instance = CreatePlant.Instance;
				int num8 = 0;
				if (plant2 != num8)
				{
					goto Block_5;
				}
			}
		}
		global::UnityEngine.Object.Destroy(child.gameObject);
		return;
		Block_5:
		global::UnityEngine.Object.Destroy(this.plant);
		bool flag3;
		if (flag3)
		{
			this.fullCD = 3f;
		}
		this.CD = (float)num2;
		PlantType plantType2 = this.thePlantType;
		if (plant2.thePlantType == plantType2 && this.savedData != num2)
		{
			this.savedData.LoadData(plant2);
		}
		this.thePlantType = (PlantType)((ulong)4294967295L);
		this.savedData = num2;
		throw new NullReferenceException();
	}

	// Token: 0x06002CD0 RID: 11472 RVA: 0x000F4380 File Offset: 0x000F2580
	[Token(Token = "0x6002CD0")]
	[Address(RVA = "0x6E1CE0", Offset = "0x6E02E0", VA = "0x1806E1CE0")]
	public Wheel()
	{
		this.fullCD = 10f;
		this.avaliable = true;
		this.coolSpeed = 1f;
		base..ctor();
	}

	// Token: 0x04001AB9 RID: 6841
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001AB9")]
	public RectTransform plantAxis;

	// Token: 0x04001ABA RID: 6842
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001ABA")]
	public PlantType thePlantType = (PlantType)((ulong)4294967295L);

	// Token: 0x04001ABB RID: 6843
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001ABB")]
	private GameObject plant;

	// Token: 0x04001ABC RID: 6844
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001ABC")]
	private SavePlantData savedData;
}
