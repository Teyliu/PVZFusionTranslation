using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002E7 RID: 743
[Token(Token = "0x20002E7")]
public class LanternLaser : MonoBehaviour
{
	// Token: 0x06000D53 RID: 3411 RVA: 0x0004CFBC File Offset: 0x0004B1BC
	[Token(Token = "0x6000D53")]
	[Address(RVA = "0x3E4DC0", Offset = "0x3E33C0", VA = "0x1803E4DC0")]
	private void Awake()
	{
		SpriteRenderer spriteRenderer = this.spriteRenderer;
	}

	// Token: 0x06000D54 RID: 3412 RVA: 0x0004CFD8 File Offset: 0x0004B1D8
	[Token(Token = "0x6000D54")]
	[Address(RVA = "0x3E4E00", Offset = "0x3E3400", VA = "0x1803E4E00")]
	private void Update()
	{
		float deltaTime = Time.deltaTime;
		SpriteRenderer spriteRenderer = this.spriteRenderer;
		int num = 0;
		this.color = num;
		spriteRenderer.color = num;
		if (spriteRenderer == 0)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000D55 RID: 3413 RVA: 0x0004D01C File Offset: 0x0004B21C
	[Token(Token = "0x6000D55")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public LanternLaser()
	{
	}

	// Token: 0x04000982 RID: 2434
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000982")]
	public SpriteRenderer spriteRenderer;

	// Token: 0x04000983 RID: 2435
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000983")]
	private Color color;
}
