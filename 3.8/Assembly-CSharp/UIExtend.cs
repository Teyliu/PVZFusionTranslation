using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009FA RID: 2554
[Token(Token = "0x20009FA")]
public static class UIExtend
{
	// Token: 0x06003467 RID: 13415 RVA: 0x00117A64 File Offset: 0x00115C64
	[Token(Token = "0x6003467")]
	[Address(RVA = "0x7440E0", Offset = "0x7426E0", VA = "0x1807440E0")]
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

	// Token: 0x06003468 RID: 13416 RVA: 0x00117AB4 File Offset: 0x00115CB4
	[Token(Token = "0x6003468")]
	[Address(RVA = "0x743F50", Offset = "0x742550", VA = "0x180743F50")]
	public static void SetIcon(this Image image, Sprite sprite, float theSize = 400f, float scale = 0.18f)
	{
		Transform transform = image.transform;
		image.sprite = sprite;
		image.SetNativeSize();
	}
}
