using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020001F2 RID: 498
[Token(Token = "0x20001F2")]
public class DroppedTreasureCard : MonoBehaviour, IClickable
{
	// Token: 0x1700006E RID: 110
	// (get) Token: 0x06000878 RID: 2168 RVA: 0x0002BE04 File Offset: 0x0002A004
	[Token(Token = "0x1700006E")]
	public int Priority
	{
		[Token(Token = "0x6000878")]
		[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "4")]
		get
		{
			return 2;
		}
	}

	// Token: 0x06000879 RID: 2169 RVA: 0x0002BE14 File Offset: 0x0002A014
	[Token(Token = "0x6000879")]
	[Address(RVA = "0x8670E0", Offset = "0x8656E0", VA = "0x1808670E0")]
	private void Awake()
	{
		Collider2D component = base.GetComponent<Collider2D>();
		this.col = component;
	}

	// Token: 0x0600087A RID: 2170 RVA: 0x0002BE30 File Offset: 0x0002A030
	[Token(Token = "0x600087A")]
	[Address(RVA = "0x8673D0", Offset = "0x8659D0", VA = "0x1808673D0")]
	private void Start()
	{
		int num = (int)this.thePlantType;
		CardLevel cardLevel;
		if (cardLevel <= CardLevel.Red)
		{
			this.maxTimer = 0.5f;
			this.maxTimer = 1.5f;
			this.maxTimer = 2f;
			this.maxTimer = 2.5f;
			this.maxTimer = 4f;
		}
		this.maxTimer = 1f;
		float num2 = this.maxTimer;
		this.timer = num2;
		Collider2D collider2D = this.col;
		this.active = true;
		int num3 = 0;
		collider2D.enabled = num3 != 0;
	}

	// Token: 0x0600087B RID: 2171 RVA: 0x0002BEB8 File Offset: 0x0002A0B8
	[Token(Token = "0x600087B")]
	[Address(RVA = "0x867380", Offset = "0x865980", VA = "0x180867380", Slot = "5")]
	public bool OnClick(Mouse mouse)
	{
		this.active = true;
		Collider2D collider2D = this.col;
		int num = 0;
		collider2D.enabled = num != 0;
		return true;
	}

	// Token: 0x0600087C RID: 2172 RVA: 0x0002BEE4 File Offset: 0x0002A0E4
	[Token(Token = "0x600087C")]
	[Address(RVA = "0x8674E0", Offset = "0x865AE0", VA = "0x1808674E0")]
	private void Update()
	{
		if (this.active)
		{
			float num = this.timer;
			int num2 = 0;
			if (num > (float)num2)
			{
				float deltaTime = Time.deltaTime;
				RectTransform rectTransform = this.shadow;
				this.timer = num;
				int num3 = 0;
				Vector2 anchoredPosition = rectTransform.anchoredPosition;
				float num4 = this.timer;
				if (num2 > (int)num4 || num4 > 1f)
				{
				}
				this.shadow.anchoredPosition = num3;
				int num5 = (int)this.thePlantType;
				CardLevel cardLevel;
				if (cardLevel <= CardLevel.Red)
				{
					List<Sprite> list = this.sprites;
					List<Sprite> list2 = this.sprites;
					List<Sprite> list3 = this.sprites;
					Image image = this.image;
					uint num6;
					Sprite sprite = list3[(int)num6];
					image.sprite = sprite;
					List<Sprite> list4 = this.sprites;
					Image image2 = this.image;
					uint num7;
					Sprite sprite2 = list4[(int)num7];
					image2.sprite = sprite2;
					List<Sprite> list5 = this.sprites;
					List<Sprite> list6 = this.sprites;
					Image image3 = this.image;
					uint num8;
					Sprite sprite3 = list6[(int)num8];
					image3.sprite = sprite3;
					uint num9;
					GameAPP.PlaySound((int)num9, 0.5f, 1f);
				}
				global::UnityEngine.Object.Destroy(base.gameObject, 3f);
				this.ChangeSprites();
				CursorChange.SetDefaultCursor();
				Transform transform = base.transform;
				Vector3 vector;
				float z = vector.z;
				PlantType plantType = this.thePlantType;
				TreasureManager instance = TreasureManager.Instance;
				uint num11;
				int num10 = global::UnityEngine.Random.Range(0, (int)num11);
				TreasureCardData treasureCardData;
				instance.GetCard(treasureCardData);
			}
		}
	}

	// Token: 0x0600087D RID: 2173 RVA: 0x0002C054 File Offset: 0x0002A254
	[Token(Token = "0x600087D")]
	[Address(RVA = "0x867130", Offset = "0x865730", VA = "0x180867130")]
	private void ChangeSprites()
	{
		Transform transform = base.transform;
		int num = 0;
		Image component = transform.GetChild(num).GetComponent<Image>();
		Transform transform2 = base.transform;
		int num2 = 0;
		RectTransform component2 = transform2.GetChild(num2).GetComponent<RectTransform>();
		Dictionary<PlantType, GameObject> plantPreviews = GameAPP.resourcesManager.plantPreviews;
		bool flag;
		if (flag)
		{
			SpriteRenderer spriteRenderer;
			Sprite sprite = spriteRenderer.sprite;
			component.sprite = sprite;
		}
		component.SetNativeSize();
		Vector2 sizeDelta = component2.sizeDelta;
		int num3 = 0;
		Vector2 sizeDelta2 = component2.sizeDelta;
		component2.sizeDelta = num3;
	}

	// Token: 0x0600087E RID: 2174 RVA: 0x0002C0E0 File Offset: 0x0002A2E0
	[Token(Token = "0x600087E")]
	[Address(RVA = "0x8673B0", Offset = "0x8659B0", VA = "0x1808673B0")]
	private void OnMouseEnter()
	{
		if (!this.active)
		{
			CursorChange.SetClickCursor();
			return;
		}
	}

	// Token: 0x0600087F RID: 2175 RVA: 0x0002C100 File Offset: 0x0002A300
	[Token(Token = "0x600087F")]
	[Address(RVA = "0x8673C0", Offset = "0x8659C0", VA = "0x1808673C0")]
	private void OnMouseExit()
	{
		if (!this.active)
		{
			CursorChange.SetDefaultCursor();
			return;
		}
	}

	// Token: 0x06000880 RID: 2176 RVA: 0x0002C120 File Offset: 0x0002A320
	[Token(Token = "0x6000880")]
	[Address(RVA = "0x8678F0", Offset = "0x865EF0", VA = "0x1808678F0")]
	public DroppedTreasureCard()
	{
		List<Sprite> list = new List();
		this.sprites = list;
		this.timer = 1f;
		this.maxTimer = 1f;
		base..ctor();
	}

	// Token: 0x04000408 RID: 1032
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000408")]
	public PlantType thePlantType;

	// Token: 0x04000409 RID: 1033
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000409")]
	public RectTransform shadow;

	// Token: 0x0400040A RID: 1034
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400040A")]
	public List<Sprite> sprites;

	// Token: 0x0400040B RID: 1035
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400040B")]
	public Image image;

	// Token: 0x0400040C RID: 1036
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400040C")]
	private bool active;

	// Token: 0x0400040D RID: 1037
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400040D")]
	private float timer;

	// Token: 0x0400040E RID: 1038
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400040E")]
	private float maxTimer;

	// Token: 0x0400040F RID: 1039
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400040F")]
	private Collider2D col;
}
