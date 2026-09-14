using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A36 RID: 2614
[Token(Token = "0x2000A36")]
public static class UIExtend
{
	// Token: 0x0600359C RID: 13724 RVA: 0x0011C964 File Offset: 0x0011AB64
	[Token(Token = "0x600359C")]
	[Address(RVA = "0x7AAA10", Offset = "0x7A9010", VA = "0x1807AAA10")]
	public static void SetIcon(this Image image, PlantType thePlantType, float theSize = 400f, float scale = 0.18f)
	{
		int num = 0;
		if (!image.TryGetComponent<RectTransform>(num))
		{
			RectTransform rectTransform = image.AddComponent<RectTransform>();
		}
		Dictionary<PlantType, GameObject> plantPreviews = GameAPP.resourcesManager.plantPreviews;
		bool flag;
		if (flag)
		{
			SpriteRenderer spriteRenderer;
			Sprite sprite = spriteRenderer.sprite;
			image.sprite = sprite;
		}
		image.SetNativeSize();
	}

	// Token: 0x0600359D RID: 13725 RVA: 0x0011C9B4 File Offset: 0x0011ABB4
	[Token(Token = "0x600359D")]
	[Address(RVA = "0x7AA880", Offset = "0x7A8E80", VA = "0x1807AA880")]
	public static void SetIcon(this Image image, Sprite sprite, float theSize = 400f, float scale = 0.18f)
	{
		Transform transform = image.transform;
		image.sprite = sprite;
		image.SetNativeSize();
	}
}
