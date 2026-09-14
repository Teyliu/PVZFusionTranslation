using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002E6 RID: 742
[Token(Token = "0x20002E6")]
public class IceExplodeControl : MonoBehaviour
{
	// Token: 0x06000D50 RID: 3408 RVA: 0x0004CF3C File Offset: 0x0004B13C
	[Token(Token = "0x6000D50")]
	[Address(RVA = "0x3E4140", Offset = "0x3E2740", VA = "0x1803E4140")]
	private void Start()
	{
		SpriteRenderer component = base.GetComponent<SpriteRenderer>();
		this.r = component;
		SpriteRenderer spriteRenderer = this.r;
	}

	// Token: 0x06000D51 RID: 3409 RVA: 0x0004CF68 File Offset: 0x0004B168
	[Token(Token = "0x6000D51")]
	[Address(RVA = "0x3E40F0", Offset = "0x3E26F0", VA = "0x1803E40F0")]
	private void FixedUpdate()
	{
		float a = this.color.a;
		this.color.a = a;
		SpriteRenderer spriteRenderer = this.r;
		Color color = this.color;
		spriteRenderer.color = color;
	}

	// Token: 0x06000D52 RID: 3410 RVA: 0x0004CFA8 File Offset: 0x0004B1A8
	[Token(Token = "0x6000D52")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public IceExplodeControl()
	{
	}

	// Token: 0x04000980 RID: 2432
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000980")]
	private SpriteRenderer r;

	// Token: 0x04000981 RID: 2433
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000981")]
	private Color color;
}
