using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020001FA RID: 506
[Token(Token = "0x20001FA")]
public class GardenCard : MonoBehaviour
{
	// Token: 0x0600089B RID: 2203 RVA: 0x0002C134 File Offset: 0x0002A334
	[Token(Token = "0x600089B")]
	[Address(RVA = "0x8F87F0", Offset = "0x8F6DF0", VA = "0x1808F87F0")]
	private void OnMouseEnter()
	{
		GardenCard cardOnMouse = this.garden.cardOnMouse;
		int num = 0;
		if (cardOnMouse == num)
		{
			CursorChange.SetClickCursor();
			return;
		}
	}

	// Token: 0x0600089C RID: 2204 RVA: 0x0002C168 File Offset: 0x0002A368
	[Token(Token = "0x600089C")]
	[Address(RVA = "0x8F8870", Offset = "0x8F6E70", VA = "0x1808F8870")]
	private void OnMouseExit()
	{
		GardenCard cardOnMouse = this.garden.cardOnMouse;
		int num = 0;
		if (cardOnMouse == num)
		{
			CursorChange.SetDefaultCursor();
			return;
		}
	}

	// Token: 0x0600089D RID: 2205 RVA: 0x0002C19C File Offset: 0x0002A39C
	[Token(Token = "0x600089D")]
	[Address(RVA = "0x8F88F0", Offset = "0x8F6EF0", VA = "0x1808F88F0")]
	private void Start()
	{
		this.ChangeCardSprite();
		TreasureCardData treasureCardData = this.data;
		TextMeshProUGUI textMeshProUGUI = this.text;
		int durability = treasureCardData.durability;
		int maxDurability = this.data.maxDurability;
		string text = string.Format("{0}/{1}", durability, durability);
		textMeshProUGUI.text = text;
	}

	// Token: 0x0600089E RID: 2206 RVA: 0x0002C1EC File Offset: 0x0002A3EC
	[Token(Token = "0x600089E")]
	[Address(RVA = "0x8F85D0", Offset = "0x8F6BD0", VA = "0x1808F85D0")]
	public void ChangeCardSprite()
	{
		Image image = this.image;
		int num = 0;
		Transform transform = image.transform;
		ResourcesManager resourcesManager = GameAPP.resourcesManager;
		TreasureCardData treasureCardData = this.data;
		Dictionary<PlantType, GameObject> plantPreviews = resourcesManager.plantPreviews;
		PlantType thePlantType = treasureCardData.thePlantType;
		if (plantPreviews.TryGetValue(thePlantType, num) || transform != 0)
		{
			if (transform != 0)
			{
			}
			Image image2 = this.image;
			SpriteRenderer spriteRenderer;
			Sprite sprite = spriteRenderer.sprite;
			image2.sprite = sprite;
		}
		this.image.SetNativeSize();
	}

	// Token: 0x0600089F RID: 2207 RVA: 0x0002C26C File Offset: 0x0002A46C
	[Token(Token = "0x600089F")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public GardenCard()
	{
	}

	// Token: 0x0400041A RID: 1050
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400041A")]
	[Header("引用")]
	public Garden garden;

	// Token: 0x0400041B RID: 1051
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400041B")]
	public TreasureCardData data;

	// Token: 0x0400041C RID: 1052
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400041C")]
	public Image image;

	// Token: 0x0400041D RID: 1053
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400041D")]
	public GameObject shadow;

	// Token: 0x0400041E RID: 1054
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400041E")]
	public TextMeshProUGUI text;
}
