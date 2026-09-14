using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020001FD RID: 509
[Token(Token = "0x20001FD")]
public class ShootingCard : UIButton
{
	// Token: 0x060008A7 RID: 2215 RVA: 0x0002C560 File Offset: 0x0002A760
	[Token(Token = "0x60008A7")]
	[Address(RVA = "0x8FCD70", Offset = "0x8FB370", VA = "0x1808FCD70", Slot = "4")]
	protected override void Start()
	{
		base.Start();
		this.ChangeSprite();
	}

	// Token: 0x060008A8 RID: 2216 RVA: 0x0002C57C File Offset: 0x0002A77C
	[Token(Token = "0x60008A8")]
	[Address(RVA = "0x8FC990", Offset = "0x8FAF90", VA = "0x1808FC990")]
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

	// Token: 0x060008A9 RID: 2217 RVA: 0x0002C658 File Offset: 0x0002A858
	[Token(Token = "0x60008A9")]
	[Address(RVA = "0x5763F0", Offset = "0x5749F0", VA = "0x1805763F0")]
	public ShootingCard()
	{
	}

	// Token: 0x04000422 RID: 1058
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000422")]
	public PlantType thePlantType;
}
