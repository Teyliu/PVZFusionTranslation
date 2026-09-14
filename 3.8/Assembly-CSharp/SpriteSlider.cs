using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200087D RID: 2173
[Token(Token = "0x200087D")]
public class SpriteSlider : MonoBehaviour
{
	// Token: 0x06002C61 RID: 11361 RVA: 0x000F43D4 File Offset: 0x000F25D4
	[Token(Token = "0x6002C61")]
	[Address(RVA = "0x685280", Offset = "0x683880", VA = "0x180685280")]
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

	// Token: 0x06002C62 RID: 11362 RVA: 0x000F4430 File Offset: 0x000F2630
	[Token(Token = "0x6002C62")]
	[Address(RVA = "0x685280", Offset = "0x683880", VA = "0x180685280")]
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

	// Token: 0x06002C63 RID: 11363 RVA: 0x000F448C File Offset: 0x000F268C
	[Token(Token = "0x6002C63")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public SpriteSlider()
	{
	}

	// Token: 0x04001A7D RID: 6781
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001A7D")]
	[Range(0f, 1f)]
	public float value;

	// Token: 0x04001A7E RID: 6782
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001A7E")]
	public Vector2 startPosition;

	// Token: 0x04001A7F RID: 6783
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4001A7F")]
	public Vector2 originalSize;

	// Token: 0x04001A80 RID: 6784
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001A80")]
	public SpriteRenderer spriteRenderer;
}
