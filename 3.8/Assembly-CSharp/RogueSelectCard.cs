using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020005F7 RID: 1527
[Token(Token = "0x20005F7")]
public class RogueSelectCard : UIButton
{
	// Token: 0x06001CC9 RID: 7369 RVA: 0x00099B14 File Offset: 0x00097D14
	[Token(Token = "0x6001CC9")]
	[Address(RVA = "0x51C7B0", Offset = "0x51ADB0", VA = "0x18051C7B0", Slot = "4")]
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

	// Token: 0x06001CCA RID: 7370 RVA: 0x00099B60 File Offset: 0x00097D60
	[Token(Token = "0x6001CCA")]
	[Address(RVA = "0x51C680", Offset = "0x51AC80", VA = "0x18051C680", Slot = "5")]
	protected override void OnMouseEnter()
	{
		this.image.material.SetFloat("_Brightness", 1.5f);
		CursorChange.SetClickCursor();
	}

	// Token: 0x06001CCB RID: 7371 RVA: 0x00099B94 File Offset: 0x00097D94
	[Token(Token = "0x6001CCB")]
	[Address(RVA = "0x51C700", Offset = "0x51AD00", VA = "0x18051C700", Slot = "6")]
	protected override void OnMouseExit()
	{
		this.image.material.SetFloat("_Brightness", 1f);
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06001CCC RID: 7372 RVA: 0x00099BC8 File Offset: 0x00097DC8
	[Token(Token = "0x6001CCC")]
	[Address(RVA = "0x51C780", Offset = "0x51AD80", VA = "0x18051C780", Slot = "9")]
	protected override void OnMouseUpAsButton()
	{
		base.OnMouseUpAsButton();
		this.menu.SelectPlant(this);
	}

	// Token: 0x06001CCD RID: 7373 RVA: 0x00099BF0 File Offset: 0x00097DF0
	[Token(Token = "0x6001CCD")]
	[Address(RVA = "0x51C590", Offset = "0x51AB90", VA = "0x18051C590")]
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

	// Token: 0x06001CCE RID: 7374 RVA: 0x00099C40 File Offset: 0x00097E40
	[Token(Token = "0x6001CCE")]
	[Address(RVA = "0x51C160", Offset = "0x51A760", VA = "0x18051C160")]
	public void SetColor(Color color)
	{
		Image image = this.image;
	}

	// Token: 0x06001CCF RID: 7375 RVA: 0x00099C5C File Offset: 0x00097E5C
	[Token(Token = "0x6001CCF")]
	[Address(RVA = "0x51C270", Offset = "0x51A870", VA = "0x18051C270")]
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

	// Token: 0x06001CD0 RID: 7376 RVA: 0x00099D24 File Offset: 0x00097F24
	[Token(Token = "0x6001CD0")]
	[Address(RVA = "0x51C260", Offset = "0x51A860", VA = "0x18051C260")]
	public RogueSelectCard()
	{
	}

	// Token: 0x04000F65 RID: 3941
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000F65")]
	public RogueSelectMenu menu;

	// Token: 0x04000F66 RID: 3942
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000F66")]
	public bool weakUlti;

	// Token: 0x04000F67 RID: 3943
	[FieldOffset(Offset = "0x81")]
	[Token(Token = "0x4000F67")]
	public bool random;

	// Token: 0x04000F68 RID: 3944
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000F68")]
	public PlantType thePlantType;

	// Token: 0x04000F69 RID: 3945
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000F69")]
	public bool get;
}
