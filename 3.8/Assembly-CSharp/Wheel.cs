using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000854 RID: 2132
[Token(Token = "0x2000854")]
public class Wheel : InGameTool
{
	// Token: 0x06002B9C RID: 11164 RVA: 0x000EF530 File Offset: 0x000ED730
	[Token(Token = "0x6002B9C")]
	[Address(RVA = "0x67CF00", Offset = "0x67B500", VA = "0x18067CF00", Slot = "7")]
	protected override void OnUpdate()
	{
		if (Input.GetKeyDownInt(KeyCodeManager.Wheel))
		{
		}
	}

	// Token: 0x06002B9D RID: 11165 RVA: 0x000EF54C File Offset: 0x000ED74C
	[Token(Token = "0x6002B9D")]
	[Address(RVA = "0x67CF80", Offset = "0x67B580", VA = "0x18067CF80", Slot = "9")]
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

	// Token: 0x06002B9E RID: 11166 RVA: 0x000EF728 File Offset: 0x000ED928
	[Token(Token = "0x6002B9E")]
	[Address(RVA = "0x67D730", Offset = "0x67BD30", VA = "0x18067D730")]
	public Wheel()
	{
		this.fullCD = 10f;
		this.avaliable = true;
		this.coolSpeed = 1f;
		base..ctor();
	}

	// Token: 0x040019CB RID: 6603
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40019CB")]
	public RectTransform plantAxis;

	// Token: 0x040019CC RID: 6604
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40019CC")]
	public PlantType thePlantType = (PlantType)((ulong)4294967295L);

	// Token: 0x040019CD RID: 6605
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40019CD")]
	private GameObject plant;

	// Token: 0x040019CE RID: 6606
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40019CE")]
	private SavePlantData savedData;
}
