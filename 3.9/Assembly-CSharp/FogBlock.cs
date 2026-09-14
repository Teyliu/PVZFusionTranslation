using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000228 RID: 552
[Token(Token = "0x2000228")]
public class FogBlock : MonoBehaviour
{
	// Token: 0x0600097D RID: 2429 RVA: 0x0003356C File Offset: 0x0003176C
	[Token(Token = "0x600097D")]
	[Address(RVA = "0x908CB0", Offset = "0x9072B0", VA = "0x180908CB0")]
	private void Awake()
	{
		SpriteRenderer component = base.GetComponent<SpriteRenderer>();
		this.spriteRenderer = component;
		int num = global::UnityEngine.Random.Range(0, 4);
		Transform transform = base.transform;
	}

	// Token: 0x0600097E RID: 2430 RVA: 0x000335A0 File Offset: 0x000317A0
	[Token(Token = "0x600097E")]
	[Address(RVA = "0x908D60", Offset = "0x907360", VA = "0x180908D60")]
	private void SetLayer()
	{
		SpriteRenderer spriteRenderer = this.spriteRenderer;
		int num = this.fogRow;
		if (this.isOver)
		{
			SpriteRenderer spriteRenderer2 = this.spriteRenderer;
			int num2 = 0;
			int sortingOrder = spriteRenderer2.sortingOrder;
			spriteRenderer2.sortingOrder = num2;
			return;
		}
	}

	// Token: 0x0600097F RID: 2431 RVA: 0x000335E4 File Offset: 0x000317E4
	[Token(Token = "0x600097F")]
	[Address(RVA = "0x908D60", Offset = "0x907360", VA = "0x180908D60")]
	private void Start()
	{
		SpriteRenderer spriteRenderer = this.spriteRenderer;
		int num = this.fogRow;
		if (this.isOver)
		{
			SpriteRenderer spriteRenderer2 = this.spriteRenderer;
			int num2 = 0;
			int sortingOrder = spriteRenderer2.sortingOrder;
			spriteRenderer2.sortingOrder = num2;
			return;
		}
	}

	// Token: 0x06000980 RID: 2432 RVA: 0x00033628 File Offset: 0x00031828
	[Token(Token = "0x6000980")]
	[Address(RVA = "0x908DD0", Offset = "0x9073D0", VA = "0x180908DD0")]
	private void Update()
	{
		SpriteRenderer spriteRenderer = this.spriteRenderer;
		int num = 0;
		if ((this.fading ? 1 : 0) == num)
		{
			float deltaTime = Time.deltaTime;
			SpriteRenderer spriteRenderer2 = this.spriteRenderer;
			this.currentA = 1f;
			SpriteRenderer spriteRenderer3 = this.spriteRenderer;
			SpriteRenderer spriteRenderer4 = this.spriteRenderer;
			Color color;
			float g = color.g;
			float num2 = this.currentA;
			float deltaTime2 = Time.deltaTime;
			num2 = deltaTime2;
			float num3 = num2 * 0.1f;
			float num4 = deltaTime2 * 3.1415927f;
			this.lerpTime = num3;
			Color color2 = this.color2;
			int num5 = 0;
			float num6 = num3 * 0.5f;
			this.lerpT = num6;
			if (num5 > (int)num6 || num6 > 1f)
			{
			}
			float num7 = this.currentA;
			SpriteRenderer spriteRenderer5 = this.spriteRenderer;
			int num8 = 0;
			if (spriteRenderer5 != num8)
			{
				this.spriteRenderer.color = color2;
			}
			return;
		}
		Color color3;
		float a = color3.a;
		float deltaTime3 = Time.deltaTime;
		int num9 = 0;
		int num10;
		if (a <= (float)num9)
		{
			num10 = 0;
		}
		SpriteRenderer spriteRenderer6 = this.spriteRenderer;
		this.currentA = (float)num10;
		SpriteRenderer spriteRenderer7 = this.spriteRenderer;
		SpriteRenderer spriteRenderer8 = this.spriteRenderer;
		Color color4;
		float g2 = color4.g;
		throw new NullReferenceException();
	}

	// Token: 0x06000981 RID: 2433 RVA: 0x0003375C File Offset: 0x0003195C
	[Token(Token = "0x6000981")]
	[Address(RVA = "0x909100", Offset = "0x907700", VA = "0x180909100")]
	public FogBlock()
	{
	}

	// Token: 0x040004DD RID: 1245
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004DD")]
	public int fogColumn;

	// Token: 0x040004DE RID: 1246
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40004DE")]
	public int fogRow;

	// Token: 0x040004DF RID: 1247
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004DF")]
	public bool isOver;

	// Token: 0x040004E0 RID: 1248
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x40004E0")]
	public bool fading;

	// Token: 0x040004E1 RID: 1249
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004E1")]
	private SpriteRenderer spriteRenderer;

	// Token: 0x040004E2 RID: 1250
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40004E2")]
	public Color color1;

	// Token: 0x040004E3 RID: 1251
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40004E3")]
	public Color color2;

	// Token: 0x040004E4 RID: 1252
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40004E4")]
	private float lerpT;

	// Token: 0x040004E5 RID: 1253
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40004E5")]
	private float currentA;

	// Token: 0x040004E6 RID: 1254
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40004E6")]
	private float lerpTime;
}
