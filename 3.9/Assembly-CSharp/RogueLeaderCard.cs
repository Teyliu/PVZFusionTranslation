using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200062B RID: 1579
[Token(Token = "0x200062B")]
public class RogueLeaderCard : UIButton
{
	// Token: 0x06001DC0 RID: 7616 RVA: 0x0009E404 File Offset: 0x0009C604
	[Token(Token = "0x6001DC0")]
	[Address(RVA = "0x576330", Offset = "0x574930", VA = "0x180576330", Slot = "4")]
	protected override void Start()
	{
		base.Start();
		Image image = this.image;
		Material material = new Material(image.material);
		image.material = material;
		this.ChangeSprite();
	}

	// Token: 0x06001DC1 RID: 7617 RVA: 0x0009E440 File Offset: 0x0009C640
	[Token(Token = "0x6001DC1")]
	[Address(RVA = "0x5761F0", Offset = "0x5747F0", VA = "0x1805761F0", Slot = "5")]
	protected override void OnMouseEnter()
	{
		this.image.material.SetFloat("_Brightness", 1.5f);
		CursorChange.SetClickCursor();
	}

	// Token: 0x06001DC2 RID: 7618 RVA: 0x0009E474 File Offset: 0x0009C674
	[Token(Token = "0x6001DC2")]
	[Address(RVA = "0x576270", Offset = "0x574870", VA = "0x180576270", Slot = "6")]
	protected override void OnMouseExit()
	{
		this.image.material.SetFloat("_Brightness", 1f);
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06001DC3 RID: 7619 RVA: 0x0009E4A8 File Offset: 0x0009C6A8
	[Token(Token = "0x6001DC3")]
	[Address(RVA = "0x576100", Offset = "0x574700", VA = "0x180576100")]
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

	// Token: 0x06001DC4 RID: 7620 RVA: 0x0009E4F8 File Offset: 0x0009C6F8
	[Token(Token = "0x6001DC4")]
	[Address(RVA = "0x5762F0", Offset = "0x5748F0", VA = "0x1805762F0")]
	public void SetColor(Color color)
	{
		Image image = this.image;
	}

	// Token: 0x06001DC5 RID: 7621 RVA: 0x0009E514 File Offset: 0x0009C714
	[Token(Token = "0x6001DC5")]
	[Address(RVA = "0x575FD0", Offset = "0x5745D0", VA = "0x180575FD0")]
	private PlantType GetPlantType()
	{
		Type typeFromHandle = typeof(LeaderType);
		LeaderType leaderType = this.leaderType;
		string name = Enum.GetName(typeFromHandle, typeFromHandle);
		object obj = Enum.Parse(typeof(PlantType), name);
		throw new NullReferenceException();
	}

	// Token: 0x06001DC6 RID: 7622 RVA: 0x0009E55C File Offset: 0x0009C75C
	[Token(Token = "0x6001DC6")]
	[Address(RVA = "0x575AB0", Offset = "0x5740B0", VA = "0x180575AB0")]
	private void ChangeSprite()
	{
		int num = 0;
		Transform transform = base.transform;
		int num2 = 0;
		Transform child = transform.GetChild(num2);
		Image component = child.GetComponent<Image>();
		RectTransform component2 = child.GetComponent<RectTransform>();
		Dictionary<PlantType, GameObject> plantPreviews = GameAPP.resourcesManager.plantPreviews;
		Type typeFromHandle = typeof(LeaderType);
		LeaderType leaderType = this.leaderType;
		string name = Enum.GetName(typeFromHandle, typeFromHandle);
		object obj = Enum.Parse(typeof(PlantType), name);
		bool flag;
		if (!flag)
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

	// Token: 0x06001DC7 RID: 7623 RVA: 0x0009E658 File Offset: 0x0009C858
	[Token(Token = "0x6001DC7")]
	[Address(RVA = "0x5763F0", Offset = "0x5749F0", VA = "0x1805763F0")]
	public RogueLeaderCard()
	{
	}

	// Token: 0x0400102B RID: 4139
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400102B")]
	public RogueSelectMenu menu;

	// Token: 0x0400102C RID: 4140
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400102C")]
	public LeaderType leaderType;
}
