using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002D4 RID: 724
[Token(Token = "0x20002D4")]
public class PrismLight : MonoBehaviour
{
	// Token: 0x06000D00 RID: 3328 RVA: 0x0004B064 File Offset: 0x00049264
	[Token(Token = "0x6000D00")]
	[Address(RVA = "0x3F94E0", Offset = "0x3F7AE0", VA = "0x1803F94E0")]
	private void Awake()
	{
		LineRenderer component = base.GetComponent<LineRenderer>();
		this.r = component;
		LineRenderer lineRenderer = this.r;
	}

	// Token: 0x06000D01 RID: 3329 RVA: 0x0004B090 File Offset: 0x00049290
	[Token(Token = "0x6000D01")]
	[Address(RVA = "0x3F9550", Offset = "0x3F7B50", VA = "0x1803F9550")]
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

	// Token: 0x06000D02 RID: 3330 RVA: 0x0004B10C File Offset: 0x0004930C
	[Token(Token = "0x6000D02")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public PrismLight()
	{
	}

	// Token: 0x0400092B RID: 2347
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400092B")]
	private LineRenderer r;

	// Token: 0x0400092C RID: 2348
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400092C")]
	private float timer;

	// Token: 0x0400092D RID: 2349
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400092D")]
	private Color startColor;
}
