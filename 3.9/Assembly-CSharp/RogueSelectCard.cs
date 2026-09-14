using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200062C RID: 1580
[Token(Token = "0x200062C")]
public class RogueSelectCard : UIButton
{
	// Token: 0x06001DC8 RID: 7624 RVA: 0x0009E66C File Offset: 0x0009C86C
	[Token(Token = "0x6001DC8")]
	[Address(RVA = "0x576940", Offset = "0x574F40", VA = "0x180576940", Slot = "4")]
	protected override void Start()
	{
		base.Start();
		Image image = this.image;
		Material material = new Material(image.material);
		image.material = material;
		this.ChangeSprite();
		if (this.get)
		{
			Image image2 = this.image;
		}
	}

	// Token: 0x06001DC9 RID: 7625 RVA: 0x0009E6B8 File Offset: 0x0009C8B8
	[Token(Token = "0x6001DC9")]
	[Address(RVA = "0x576810", Offset = "0x574E10", VA = "0x180576810", Slot = "5")]
	protected override void OnMouseEnter()
	{
		this.image.material.SetFloat("_Brightness", 1.5f);
		CursorChange.SetClickCursor();
	}

	// Token: 0x06001DCA RID: 7626 RVA: 0x0009E6EC File Offset: 0x0009C8EC
	[Token(Token = "0x6001DCA")]
	[Address(RVA = "0x576890", Offset = "0x574E90", VA = "0x180576890", Slot = "6")]
	protected override void OnMouseExit()
	{
		this.image.material.SetFloat("_Brightness", 1f);
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06001DCB RID: 7627 RVA: 0x0009E720 File Offset: 0x0009C920
	[Token(Token = "0x6001DCB")]
	[Address(RVA = "0x576910", Offset = "0x574F10", VA = "0x180576910", Slot = "9")]
	protected override void OnMouseUpAsButton()
	{
		base.OnMouseUpAsButton();
		this.menu.SelectPlant(this);
	}

	// Token: 0x06001DCC RID: 7628 RVA: 0x0009E748 File Offset: 0x0009C948
	[Token(Token = "0x6001DCC")]
	[Address(RVA = "0x576720", Offset = "0x574D20", VA = "0x180576720")]
	private void OnDestroy()
	{
		Image image = this.image;
		int num = 0;
		if (image != num)
		{
			Material material = this.image.material;
			int num2 = 0;
			if (material != num2)
			{
				global::UnityEngine.Object.DestroyImmediate(this.image.material);
			}
		}
	}

	// Token: 0x06001DCD RID: 7629 RVA: 0x0009E798 File Offset: 0x0009C998
	[Token(Token = "0x6001DCD")]
	[Address(RVA = "0x5762F0", Offset = "0x5748F0", VA = "0x1805762F0")]
	public void SetColor(Color color)
	{
		Image image = this.image;
	}

	// Token: 0x06001DCE RID: 7630 RVA: 0x0009E7B4 File Offset: 0x0009C9B4
	[Token(Token = "0x6001DCE")]
	[Address(RVA = "0x576400", Offset = "0x574A00", VA = "0x180576400")]
	private void ChangeSprite()
	{
		int num = 0;
		if ((this.random ? 1 : 0) != num)
		{
			this.thePlantType = (PlantType)((ulong)256L);
		}
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
		int num3 = 0;
		component2.anchoredPosition = num3;
		component2.sizeDelta = num3;
	}

	// Token: 0x06001DCF RID: 7631 RVA: 0x0009E87C File Offset: 0x0009CA7C
	[Token(Token = "0x6001DCF")]
	[Address(RVA = "0x5763F0", Offset = "0x5749F0", VA = "0x1805763F0")]
	public RogueSelectCard()
	{
	}

	// Token: 0x0400102D RID: 4141
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400102D")]
	public RogueSelectMenu menu;

	// Token: 0x0400102E RID: 4142
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400102E")]
	public bool weakUlti;

	// Token: 0x0400102F RID: 4143
	[FieldOffset(Offset = "0x81")]
	[Token(Token = "0x400102F")]
	public bool random;

	// Token: 0x04001030 RID: 4144
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4001030")]
	public PlantType thePlantType;

	// Token: 0x04001031 RID: 4145
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001031")]
	public bool get;
}
