using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020001F6 RID: 502
[Token(Token = "0x20001F6")]
public class ShootingCard : UIButton
{
	// Token: 0x0600088D RID: 2189 RVA: 0x0002C584 File Offset: 0x0002A784
	[Token(Token = "0x600088D")]
	[Address(RVA = "0x86D270", Offset = "0x86B870", VA = "0x18086D270", Slot = "4")]
	protected override void Start()
	{
		base.Start();
		this.ChangeSprite();
	}

	// Token: 0x0600088E RID: 2190 RVA: 0x0002C5A0 File Offset: 0x0002A7A0
	[Token(Token = "0x600088E")]
	[Address(RVA = "0x86CE90", Offset = "0x86B490", VA = "0x18086CE90")]
	private void ChangeSprite()
	{
		int num = 0;
		Transform transform = base.transform;
		int num2 = 0;
		Transform child = transform.GetChild(num2);
		Image component = child.GetComponent<Image>();
		RectTransform component2 = child.GetComponent<RectTransform>();
		Dictionary<PlantType, GameObject> plantPreviews = GameAPP.resourcesManager.plantPreviews;
		PlantType plantType = this.thePlantType;
		if (!plantPreviews.TryGetValue(plantType, num))
		{
			Sprite[] spritePrefab = GameAPP.spritePrefab;
		}
		SpriteRenderer spriteRenderer;
		Sprite sprite = spriteRenderer.sprite;
		component.sprite = sprite;
		component.SetNativeSize();
		Vector2 sizeDelta = component2.sizeDelta;
		Vector2 sizeDelta2 = component2.sizeDelta;
		Transform transform2 = base.transform;
		Transform transform3 = base.transform;
		Transform parent = base.transform.parent;
		int num3 = 0;
		if (!(parent != num3) || base.transform.parent.TryGetComponent<GridLayoutGroup>(num))
		{
		}
		component2.anchoredPosition = num;
		component2.sizeDelta = num;
	}

	// Token: 0x0600088F RID: 2191 RVA: 0x0002C67C File Offset: 0x0002A87C
	[Token(Token = "0x600088F")]
	[Address(RVA = "0x51C260", Offset = "0x51A860", VA = "0x18051C260")]
	public ShootingCard()
	{
	}

	// Token: 0x04000418 RID: 1048
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000418")]
	public PlantType thePlantType;
}
