using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020008B9 RID: 2233
[Token(Token = "0x20008B9")]
public class SpriteSlider : MonoBehaviour
{
	// Token: 0x06002D93 RID: 11667 RVA: 0x000F9068 File Offset: 0x000F7268
	[Token(Token = "0x6002D93")]
	[Address(RVA = "0x6FE840", Offset = "0x6FCE40", VA = "0x1806FE840")]
	private void OnDrawGizmos()
	{
		SpriteRenderer spriteRenderer = this.spriteRenderer;
		int num = 0;
		Vector2 size = spriteRenderer.size;
		float num2 = this.value;
		int num3 = 0;
		Vector2 vector = this.originalSize;
		if (num3 > (int)num2 || num2 > 1f)
		{
		}
		this.spriteRenderer.size = num;
		Transform transform = this.spriteRenderer.transform;
	}

	// Token: 0x06002D94 RID: 11668 RVA: 0x000F90C4 File Offset: 0x000F72C4
	[Token(Token = "0x6002D94")]
	[Address(RVA = "0x6FE840", Offset = "0x6FCE40", VA = "0x1806FE840")]
	private void Update()
	{
		SpriteRenderer spriteRenderer = this.spriteRenderer;
		int num = 0;
		Vector2 size = spriteRenderer.size;
		float num2 = this.value;
		int num3 = 0;
		Vector2 vector = this.originalSize;
		if (num3 > (int)num2 || num2 > 1f)
		{
		}
		this.spriteRenderer.size = num;
		Transform transform = this.spriteRenderer.transform;
	}

	// Token: 0x06002D95 RID: 11669 RVA: 0x000F9120 File Offset: 0x000F7320
	[Token(Token = "0x6002D95")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public SpriteSlider()
	{
	}

	// Token: 0x04001B6B RID: 7019
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001B6B")]
	[Range(0f, 1f)]
	public float value;

	// Token: 0x04001B6C RID: 7020
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001B6C")]
	public Vector2 startPosition;

	// Token: 0x04001B6D RID: 7021
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4001B6D")]
	public Vector2 originalSize;

	// Token: 0x04001B6E RID: 7022
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001B6E")]
	public SpriteRenderer spriteRenderer;
}
