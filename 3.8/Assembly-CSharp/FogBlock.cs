using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000223 RID: 547
[Token(Token = "0x2000223")]
public class FogBlock : MonoBehaviour
{
	// Token: 0x06000967 RID: 2407 RVA: 0x0003372C File Offset: 0x0003192C
	[Token(Token = "0x6000967")]
	[Address(RVA = "0x879220", Offset = "0x877820", VA = "0x180879220")]
	private void Awake()
	{
		SpriteRenderer component = base.GetComponent<SpriteRenderer>();
		this.spriteRenderer = component;
		int num = global::UnityEngine.Random.Range(0, 4);
		Transform transform = base.transform;
	}

	// Token: 0x06000968 RID: 2408 RVA: 0x00033760 File Offset: 0x00031960
	[Token(Token = "0x6000968")]
	[Address(RVA = "0x8792D0", Offset = "0x8778D0", VA = "0x1808792D0")]
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

	// Token: 0x06000969 RID: 2409 RVA: 0x000337A4 File Offset: 0x000319A4
	[Token(Token = "0x6000969")]
	[Address(RVA = "0x8792D0", Offset = "0x8778D0", VA = "0x1808792D0")]
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

	// Token: 0x0600096A RID: 2410 RVA: 0x000337E8 File Offset: 0x000319E8
	[Token(Token = "0x600096A")]
	[Address(RVA = "0x879340", Offset = "0x877940", VA = "0x180879340")]
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

	// Token: 0x0600096B RID: 2411 RVA: 0x0003391C File Offset: 0x00031B1C
	[Token(Token = "0x600096B")]
	[Address(RVA = "0x879670", Offset = "0x877C70", VA = "0x180879670")]
	public FogBlock()
	{
	}

	// Token: 0x040004D7 RID: 1239
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004D7")]
	public int fogColumn;

	// Token: 0x040004D8 RID: 1240
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40004D8")]
	public int fogRow;

	// Token: 0x040004D9 RID: 1241
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004D9")]
	public bool isOver;

	// Token: 0x040004DA RID: 1242
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x40004DA")]
	public bool fading;

	// Token: 0x040004DB RID: 1243
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004DB")]
	private SpriteRenderer spriteRenderer;

	// Token: 0x040004DC RID: 1244
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40004DC")]
	public Color color1;

	// Token: 0x040004DD RID: 1245
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40004DD")]
	public Color color2;

	// Token: 0x040004DE RID: 1246
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40004DE")]
	private float lerpT;

	// Token: 0x040004DF RID: 1247
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40004DF")]
	private float currentA;

	// Token: 0x040004E0 RID: 1248
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40004E0")]
	private float lerpTime;
}
