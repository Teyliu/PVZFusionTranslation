using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000005 RID: 5
[Token(Token = "0x2000005")]
public class FlashEffect : IEffect
{
	// Token: 0x0600000F RID: 15 RVA: 0x000025E4 File Offset: 0x000007E4
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x3A9CD0", Offset = "0x3A82D0", VA = "0x1803A9CD0")]
	public FlashEffect(List<SpriteRenderer> spriteRenderers)
	{
		this.OnUpdate();
		this.spriteRenderers = spriteRenderers;
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00002600 File Offset: 0x00000800
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x3A9B70", Offset = "0x3A8170", VA = "0x1803A9B70", Slot = "6")]
	public void Main()
	{
		this.flashTimer = 0.2f;
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002618 File Offset: 0x00000818
	[Token(Token = "0x6000011")]
	[Address(RVA = "0x3A9B80", Offset = "0x3A8180", VA = "0x1803A9B80", Slot = "5")]
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

	// Token: 0x06000012 RID: 18 RVA: 0x0000267C File Offset: 0x0000087C
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x3A9C70", Offset = "0x3A8270", VA = "0x1803A9C70")]
	private void SetBrightness(float b)
	{
		GameMaterial.SetBrightness(this.spriteRenderers, b);
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002698 File Offset: 0x00000898
	[Token(Token = "0x6000013")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "4")]
	public void OnUpdate()
	{
	}

	// Token: 0x04000005 RID: 5
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000005")]
	[SerializeField]
	private float flashTimer;

	// Token: 0x04000006 RID: 6
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000006")]
	[SerializeField]
	private List<SpriteRenderer> spriteRenderers;
}
