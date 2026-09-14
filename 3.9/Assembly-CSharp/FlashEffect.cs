using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200000A RID: 10
[Token(Token = "0x200000A")]
public class FlashEffect : IEffect
{
	// Token: 0x06000029 RID: 41 RVA: 0x0000292C File Offset: 0x00000B2C
	[Token(Token = "0x6000029")]
	[Address(RVA = "0x3F5AD0", Offset = "0x3F40D0", VA = "0x1803F5AD0")]
	public FlashEffect(List<SpriteRenderer> spriteRenderers)
	{
		this.OnUpdate();
		this.spriteRenderers = spriteRenderers;
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002948 File Offset: 0x00000B48
	[Token(Token = "0x600002A")]
	[Address(RVA = "0x3F5970", Offset = "0x3F3F70", VA = "0x1803F5970", Slot = "6")]
	public void Main()
	{
		this.flashTimer = 0.2f;
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002960 File Offset: 0x00000B60
	[Token(Token = "0x600002B")]
	[Address(RVA = "0x3F5980", Offset = "0x3F3F80", VA = "0x1803F5980", Slot = "5")]
	public void OnFixedUpdate()
	{
		float num = this.flashTimer;
		int num2 = 0;
		if (num > (float)num2)
		{
			float fixedDeltaTime = Time.fixedDeltaTime;
			this.flashTimer = num;
			if (num > 0.2f || num > (float)num2)
			{
				float num3 = num * -30f;
				this.SetBrightness(num3);
			}
			GameMaterial.SetBrightness(this.spriteRenderers, 1f);
			this.flashTimer = 0f;
		}
	}

	// Token: 0x0600002C RID: 44 RVA: 0x000029C4 File Offset: 0x00000BC4
	[Token(Token = "0x600002C")]
	[Address(RVA = "0x3F5A70", Offset = "0x3F4070", VA = "0x1803F5A70")]
	private void SetBrightness(float b)
	{
		GameMaterial.SetBrightness(this.spriteRenderers, b);
	}

	// Token: 0x0600002D RID: 45 RVA: 0x000029E0 File Offset: 0x00000BE0
	[Token(Token = "0x600002D")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "4")]
	public void OnUpdate()
	{
	}

	// Token: 0x0400000E RID: 14
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400000E")]
	[SerializeField]
	private float flashTimer;

	// Token: 0x0400000F RID: 15
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400000F")]
	[SerializeField]
	private List<SpriteRenderer> spriteRenderers;
}
