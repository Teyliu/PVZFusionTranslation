using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020001F3 RID: 499
[Token(Token = "0x20001F3")]
public class GardenCard : MonoBehaviour
{
	// Token: 0x06000881 RID: 2177 RVA: 0x0002C158 File Offset: 0x0002A358
	[Token(Token = "0x6000881")]
	[Address(RVA = "0x869AA0", Offset = "0x8680A0", VA = "0x180869AA0")]
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

	// Token: 0x06000882 RID: 2178 RVA: 0x0002C18C File Offset: 0x0002A38C
	[Token(Token = "0x6000882")]
	[Address(RVA = "0x869B20", Offset = "0x868120", VA = "0x180869B20")]
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

	// Token: 0x06000883 RID: 2179 RVA: 0x0002C1C0 File Offset: 0x0002A3C0
	[Token(Token = "0x6000883")]
	[Address(RVA = "0x869BA0", Offset = "0x8681A0", VA = "0x180869BA0")]
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

	// Token: 0x06000884 RID: 2180 RVA: 0x0002C210 File Offset: 0x0002A410
	[Token(Token = "0x6000884")]
	[Address(RVA = "0x869880", Offset = "0x867E80", VA = "0x180869880")]
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

	// Token: 0x06000885 RID: 2181 RVA: 0x0002C290 File Offset: 0x0002A490
	[Token(Token = "0x6000885")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public GardenCard()
	{
	}

	// Token: 0x04000410 RID: 1040
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000410")]
	[Header("引用")]
	public Garden garden;

	// Token: 0x04000411 RID: 1041
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000411")]
	public TreasureCardData data;

	// Token: 0x04000412 RID: 1042
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000412")]
	public Image image;

	// Token: 0x04000413 RID: 1043
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000413")]
	public GameObject shadow;

	// Token: 0x04000414 RID: 1044
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000414")]
	public TextMeshProUGUI text;
}
