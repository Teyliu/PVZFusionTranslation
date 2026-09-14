using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020001F9 RID: 505
[Token(Token = "0x20001F9")]
public class DroppedTreasureCard : MonoBehaviour, IClickable
{
	// Token: 0x170000AB RID: 171
	// (get) Token: 0x06000892 RID: 2194 RVA: 0x0002BDE0 File Offset: 0x00029FE0
	[Token(Token = "0x170000AB")]
	public int Priority
	{
		[Token(Token = "0x6000892")]
		[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "4")]
		get
		{
			return 2;
		}
	}

	// Token: 0x06000893 RID: 2195 RVA: 0x0002BDF0 File Offset: 0x00029FF0
	[Token(Token = "0x6000893")]
	[Address(RVA = "0x8F5E30", Offset = "0x8F4430", VA = "0x1808F5E30")]
	private void Awake()
	{
		Collider2D component = base.GetComponent<Collider2D>();
		this.col = component;
	}

	// Token: 0x06000894 RID: 2196 RVA: 0x0002BE0C File Offset: 0x0002A00C
	[Token(Token = "0x6000894")]
	[Address(RVA = "0x8F6120", Offset = "0x8F4720", VA = "0x1808F6120")]
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

	// Token: 0x06000895 RID: 2197 RVA: 0x0002BE94 File Offset: 0x0002A094
	[Token(Token = "0x6000895")]
	[Address(RVA = "0x8F60D0", Offset = "0x8F46D0", VA = "0x1808F60D0", Slot = "5")]
	public bool OnClick(Mouse mouse)
	{
		this.active = true;
		Collider2D collider2D = this.col;
		int num = 0;
		collider2D.enabled = num != 0;
		return true;
	}

	// Token: 0x06000896 RID: 2198 RVA: 0x0002BEC0 File Offset: 0x0002A0C0
	[Token(Token = "0x6000896")]
	[Address(RVA = "0x8F6230", Offset = "0x8F4830", VA = "0x1808F6230")]
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

	// Token: 0x06000897 RID: 2199 RVA: 0x0002C030 File Offset: 0x0002A230
	[Token(Token = "0x6000897")]
	[Address(RVA = "0x8F5E80", Offset = "0x8F4480", VA = "0x1808F5E80")]
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

	// Token: 0x06000898 RID: 2200 RVA: 0x0002C0BC File Offset: 0x0002A2BC
	[Token(Token = "0x6000898")]
	[Address(RVA = "0x8F6100", Offset = "0x8F4700", VA = "0x1808F6100")]
	private void OnMouseEnter()
	{
		if (!this.active)
		{
			CursorChange.SetClickCursor();
			return;
		}
	}

	// Token: 0x06000899 RID: 2201 RVA: 0x0002C0DC File Offset: 0x0002A2DC
	[Token(Token = "0x6000899")]
	[Address(RVA = "0x8F6110", Offset = "0x8F4710", VA = "0x1808F6110")]
	private void OnMouseExit()
	{
		if (!this.active)
		{
			CursorChange.SetDefaultCursor();
			return;
		}
	}

	// Token: 0x0600089A RID: 2202 RVA: 0x0002C0FC File Offset: 0x0002A2FC
	[Token(Token = "0x600089A")]
	[Address(RVA = "0x8F6640", Offset = "0x8F4C40", VA = "0x1808F6640")]
	public DroppedTreasureCard()
	{
		List<Sprite> list = new List();
		this.sprites = list;
		this.timer = 1f;
		this.maxTimer = 1f;
		base..ctor();
	}

	// Token: 0x04000412 RID: 1042
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000412")]
	public PlantType thePlantType;

	// Token: 0x04000413 RID: 1043
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000413")]
	public RectTransform shadow;

	// Token: 0x04000414 RID: 1044
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000414")]
	public List<Sprite> sprites;

	// Token: 0x04000415 RID: 1045
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000415")]
	public Image image;

	// Token: 0x04000416 RID: 1046
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000416")]
	private bool active;

	// Token: 0x04000417 RID: 1047
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000417")]
	private float timer;

	// Token: 0x04000418 RID: 1048
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000418")]
	private float maxTimer;

	// Token: 0x04000419 RID: 1049
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000419")]
	private Collider2D col;
}
