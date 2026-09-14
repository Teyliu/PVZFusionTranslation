using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002F4 RID: 756
[Token(Token = "0x20002F4")]
public class IceExplodeControl : MonoBehaviour
{
	// Token: 0x06000D93 RID: 3475 RVA: 0x0004DBB0 File Offset: 0x0004BDB0
	[Token(Token = "0x6000D93")]
	[Address(RVA = "0x434DE0", Offset = "0x4333E0", VA = "0x180434DE0")]
	private void Start()
	{
		SpriteRenderer component = base.GetComponent<SpriteRenderer>();
		this.r = component;
		SpriteRenderer spriteRenderer = this.r;
	}

	// Token: 0x06000D94 RID: 3476 RVA: 0x0004DBDC File Offset: 0x0004BDDC
	[Token(Token = "0x6000D94")]
	[Address(RVA = "0x434D90", Offset = "0x433390", VA = "0x180434D90")]
	private void FixedUpdate()
	{
		float a = this.color.a;
		this.color.a = a;
		SpriteRenderer spriteRenderer = this.r;
		Color color = this.color;
		spriteRenderer.color = color;
	}

	// Token: 0x06000D95 RID: 3477 RVA: 0x0004DC1C File Offset: 0x0004BE1C
	[Token(Token = "0x6000D95")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public IceExplodeControl()
	{
	}

	// Token: 0x040009BD RID: 2493
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009BD")]
	private SpriteRenderer r;

	// Token: 0x040009BE RID: 2494
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009BE")]
	private Color color;
}
