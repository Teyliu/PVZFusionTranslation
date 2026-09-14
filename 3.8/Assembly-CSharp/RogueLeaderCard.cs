using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020005F6 RID: 1526
[Token(Token = "0x20005F6")]
public class RogueLeaderCard : UIButton
{
	// Token: 0x06001CC1 RID: 7361 RVA: 0x000998AC File Offset: 0x00097AAC
	[Token(Token = "0x6001CC1")]
	[Address(RVA = "0x51C1A0", Offset = "0x51A7A0", VA = "0x18051C1A0", Slot = "4")]
	protected override void Start()
	{
		base.Start();
		Image image = this.image;
		Material material = new Material(image.material);
		image.material = material;
		this.ChangeSprite();
	}

	// Token: 0x06001CC2 RID: 7362 RVA: 0x000998E8 File Offset: 0x00097AE8
	[Token(Token = "0x6001CC2")]
	[Address(RVA = "0x51C060", Offset = "0x51A660", VA = "0x18051C060", Slot = "5")]
	protected override void OnMouseEnter()
	{
		this.image.material.SetFloat("_Brightness", 1.5f);
		CursorChange.SetClickCursor();
	}

	// Token: 0x06001CC3 RID: 7363 RVA: 0x0009991C File Offset: 0x00097B1C
	[Token(Token = "0x6001CC3")]
	[Address(RVA = "0x51C0E0", Offset = "0x51A6E0", VA = "0x18051C0E0", Slot = "6")]
	protected override void OnMouseExit()
	{
		this.image.material.SetFloat("_Brightness", 1f);
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06001CC4 RID: 7364 RVA: 0x00099950 File Offset: 0x00097B50
	[Token(Token = "0x6001CC4")]
	[Address(RVA = "0x51BF70", Offset = "0x51A570", VA = "0x18051BF70")]
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

	// Token: 0x06001CC5 RID: 7365 RVA: 0x000999A0 File Offset: 0x00097BA0
	[Token(Token = "0x6001CC5")]
	[Address(RVA = "0x51C160", Offset = "0x51A760", VA = "0x18051C160")]
	public void SetColor(Color color)
	{
		Image image = this.image;
	}

	// Token: 0x06001CC6 RID: 7366 RVA: 0x000999BC File Offset: 0x00097BBC
	[Token(Token = "0x6001CC6")]
	[Address(RVA = "0x51BE40", Offset = "0x51A440", VA = "0x18051BE40")]
	private PlantType GetPlantType()
	{
		Type typeFromHandle = typeof(LeaderType);
		LeaderType leaderType = this.leaderType;
		string name = Enum.GetName(typeFromHandle, typeFromHandle);
		object obj = Enum.Parse(typeof(PlantType), name);
		throw new NullReferenceException();
	}

	// Token: 0x06001CC7 RID: 7367 RVA: 0x00099A04 File Offset: 0x00097C04
	[Token(Token = "0x6001CC7")]
	[Address(RVA = "0x51B920", Offset = "0x519F20", VA = "0x18051B920")]
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

	// Token: 0x06001CC8 RID: 7368 RVA: 0x00099B00 File Offset: 0x00097D00
	[Token(Token = "0x6001CC8")]
	[Address(RVA = "0x51C260", Offset = "0x51A860", VA = "0x18051C260")]
	public RogueLeaderCard()
	{
	}

	// Token: 0x04000F63 RID: 3939
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000F63")]
	public RogueSelectMenu menu;

	// Token: 0x04000F64 RID: 3940
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000F64")]
	public LeaderType leaderType;
}
