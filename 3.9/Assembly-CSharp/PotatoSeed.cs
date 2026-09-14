using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002E0 RID: 736
[Token(Token = "0x20002E0")]
public class PotatoSeed : MonoBehaviour
{
	// Token: 0x06000D3A RID: 3386 RVA: 0x0004BA64 File Offset: 0x00049C64
	[Token(Token = "0x6000D3A")]
	[Address(RVA = "0x43D080", Offset = "0x43B680", VA = "0x18043D080")]
	private IEnumerator Start()
	{
		PotatoSeed.<Start>d__6 <Start>d__;
		<Start>d__.System.IDisposable.Dispose();
		<Start>d__.<>1__state = (int)((ulong)0L);
		<Start>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000D3B RID: 3387 RVA: 0x0004BA88 File Offset: 0x00049C88
	[Token(Token = "0x6000D3B")]
	[Address(RVA = "0x43D0F0", Offset = "0x43B6F0", VA = "0x18043D0F0")]
	private void Update()
	{
		Transform transform = base.transform;
		float deltaTime = Time.deltaTime;
		float vy = this.Vy;
		float deltaTime2 = Time.deltaTime;
		this.Vy = vy;
	}

	// Token: 0x06000D3C RID: 3388 RVA: 0x0004BAC8 File Offset: 0x00049CC8
	[Token(Token = "0x6000D3C")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public PotatoSeed()
	{
	}

	// Token: 0x0400095F RID: 2399
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400095F")]
	public Board board;

	// Token: 0x04000960 RID: 2400
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000960")]
	public int theRow;

	// Token: 0x04000961 RID: 2401
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000961")]
	public int theColumn;

	// Token: 0x04000962 RID: 2402
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000962")]
	private float Vx;

	// Token: 0x04000963 RID: 2403
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000963")]
	private float Vy;

	// Token: 0x04000964 RID: 2404
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000964")]
	private float detaVy;
}
