using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002F5 RID: 757
[Token(Token = "0x20002F5")]
public class LanternLaser : MonoBehaviour
{
	// Token: 0x06000D96 RID: 3478 RVA: 0x0004DC30 File Offset: 0x0004BE30
	[Token(Token = "0x6000D96")]
	[Address(RVA = "0x448DB0", Offset = "0x4473B0", VA = "0x180448DB0")]
	private void Awake()
	{
		SpriteRenderer spriteRenderer = this.spriteRenderer;
	}

	// Token: 0x06000D97 RID: 3479 RVA: 0x0004DC4C File Offset: 0x0004BE4C
	[Token(Token = "0x6000D97")]
	[Address(RVA = "0x448DF0", Offset = "0x4473F0", VA = "0x180448DF0")]
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

	// Token: 0x06000D98 RID: 3480 RVA: 0x0004DC90 File Offset: 0x0004BE90
	[Token(Token = "0x6000D98")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public LanternLaser()
	{
	}

	// Token: 0x040009BF RID: 2495
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009BF")]
	public SpriteRenderer spriteRenderer;

	// Token: 0x040009C0 RID: 2496
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009C0")]
	private Color color;
}
