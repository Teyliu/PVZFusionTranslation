using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002D2 RID: 722
[Token(Token = "0x20002D2")]
public class PotatoSeed : MonoBehaviour
{
	// Token: 0x06000CF7 RID: 3319 RVA: 0x0004AE90 File Offset: 0x00049090
	[Token(Token = "0x6000CF7")]
	[Address(RVA = "0x3F9380", Offset = "0x3F7980", VA = "0x1803F9380")]
	private IEnumerator Start()
	{
		PotatoSeed.<Start>d__6 <Start>d__;
		<Start>d__.System.IDisposable.Dispose();
		<Start>d__.<>1__state = (int)((ulong)0L);
		<Start>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000CF8 RID: 3320 RVA: 0x0004AEB4 File Offset: 0x000490B4
	[Token(Token = "0x6000CF8")]
	[Address(RVA = "0x3F93F0", Offset = "0x3F79F0", VA = "0x1803F93F0")]
	private void Update()
	{
		Transform transform = base.transform;
		float deltaTime = Time.deltaTime;
		float vy = this.Vy;
		float deltaTime2 = Time.deltaTime;
		this.Vy = vy;
	}

	// Token: 0x06000CF9 RID: 3321 RVA: 0x0004AEF4 File Offset: 0x000490F4
	[Token(Token = "0x6000CF9")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public PotatoSeed()
	{
	}

	// Token: 0x04000922 RID: 2338
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000922")]
	public Board board;

	// Token: 0x04000923 RID: 2339
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000923")]
	public int theRow;

	// Token: 0x04000924 RID: 2340
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000924")]
	public int theColumn;

	// Token: 0x04000925 RID: 2341
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000925")]
	private float Vx;

	// Token: 0x04000926 RID: 2342
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000926")]
	private float Vy;

	// Token: 0x04000927 RID: 2343
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000927")]
	private float detaVy;
}
