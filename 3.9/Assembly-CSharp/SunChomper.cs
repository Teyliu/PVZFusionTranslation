using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000345 RID: 837
[Token(Token = "0x2000345")]
public class SunChomper : Chomper
{
	// Token: 0x06000F48 RID: 3912 RVA: 0x000588E0 File Offset: 0x00056AE0
	[Token(Token = "0x6000F48")]
	[Address(RVA = "0x46A280", Offset = "0x468880", VA = "0x18046A280", Slot = "70")]
	protected override void Swallow()
	{
		base.Swallow();
		base.Invoke("Produce", 1.5f);
	}

	// Token: 0x06000F49 RID: 3913 RVA: 0x00058904 File Offset: 0x00056B04
	[Token(Token = "0x6000F49")]
	[Address(RVA = "0x46A160", Offset = "0x468760", VA = "0x18046A160")]
	private void Produce()
	{
		SunChomper.<SunBright>d__2 <SunBright>d__;
		<SunBright>d__.System.IDisposable.Dispose();
		<SunBright>d__.<>1__state = (int)((ulong)0L);
		<SunBright>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<SunBright>d__);
		base.Invoke("ProduceSun", 0.5f);
	}

	// Token: 0x06000F4A RID: 3914 RVA: 0x00058940 File Offset: 0x00056B40
	[Token(Token = "0x6000F4A")]
	[Address(RVA = "0x46A210", Offset = "0x468810", VA = "0x18046A210")]
	private IEnumerator SunBright()
	{
		SunChomper.<SunBright>d__2 <SunBright>d__;
		<SunBright>d__.System.IDisposable.Dispose();
		<SunBright>d__.<>1__state = (int)((ulong)0L);
		<SunBright>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000F4B RID: 3915 RVA: 0x00058964 File Offset: 0x00056B64
	[Token(Token = "0x6000F4B")]
	[Address(RVA = "0x469FB0", Offset = "0x4685B0", VA = "0x180469FB0")]
	private void ProduceSun()
	{
		CreateItem instance = CreateItem.Instance;
		CreateItem instance2 = CreateItem.Instance;
		CreateItem instance3 = CreateItem.Instance;
		CreateItem instance4 = CreateItem.Instance;
	}

	// Token: 0x06000F4C RID: 3916 RVA: 0x00058998 File Offset: 0x00056B98
	[Token(Token = "0x6000F4C")]
	[Address(RVA = "0x458C10", Offset = "0x457210", VA = "0x180458C10")]
	public SunChomper()
	{
	}
}
