using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002E2 RID: 738
[Token(Token = "0x20002E2")]
public class PrismLight : MonoBehaviour
{
	// Token: 0x06000D43 RID: 3395 RVA: 0x0004BC38 File Offset: 0x00049E38
	[Token(Token = "0x6000D43")]
	[Address(RVA = "0x43D1E0", Offset = "0x43B7E0", VA = "0x18043D1E0")]
	private void Awake()
	{
		LineRenderer component = base.GetComponent<LineRenderer>();
		this.r = component;
		LineRenderer lineRenderer = this.r;
	}

	// Token: 0x06000D44 RID: 3396 RVA: 0x0004BC64 File Offset: 0x00049E64
	[Token(Token = "0x6000D44")]
	[Address(RVA = "0x43D250", Offset = "0x43B850", VA = "0x18043D250")]
	private void Update()
	{
		float deltaTime = Time.deltaTime;
		this.timer = deltaTime;
		Color color = this.startColor;
		float g = this.startColor.g;
		float b = this.startColor.b;
		float a = this.startColor.a;
		float deltaTime2 = Time.deltaTime;
		this.r.startColor = color;
		this.r.endColor = color;
		this.startColor = color;
	}

	// Token: 0x06000D45 RID: 3397 RVA: 0x0004BCE0 File Offset: 0x00049EE0
	[Token(Token = "0x6000D45")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public PrismLight()
	{
	}

	// Token: 0x04000968 RID: 2408
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000968")]
	private LineRenderer r;

	// Token: 0x04000969 RID: 2409
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000969")]
	private float timer;

	// Token: 0x0400096A RID: 2410
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400096A")]
	private Color startColor;
}
