using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000335 RID: 821
[Token(Token = "0x2000335")]
public class SunChomper : Chomper
{
	// Token: 0x06000EFD RID: 3837 RVA: 0x00057924 File Offset: 0x00055B24
	[Token(Token = "0x6000EFD")]
	[Address(RVA = "0x429B60", Offset = "0x428160", VA = "0x180429B60", Slot = "70")]
	protected override void Swallow()
	{
		this.anim.SetTrigger("swallow");
		Animator anim = this.anim;
		int num = 0;
		anim.SetBool("chew", num != 0);
		base.Invoke("Produce", 1.5f);
	}

	// Token: 0x06000EFE RID: 3838 RVA: 0x0005796C File Offset: 0x00055B6C
	[Token(Token = "0x6000EFE")]
	[Address(RVA = "0x429A40", Offset = "0x428040", VA = "0x180429A40")]
	private void Produce()
	{
		SunChomper.<SunBright>d__2 <SunBright>d__;
		<SunBright>d__.System.IDisposable.Dispose();
		<SunBright>d__.<>1__state = (int)((ulong)0L);
		<SunBright>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<SunBright>d__);
		base.Invoke("ProduceSun", 0.5f);
	}

	// Token: 0x06000EFF RID: 3839 RVA: 0x000579A8 File Offset: 0x00055BA8
	[Token(Token = "0x6000EFF")]
	[Address(RVA = "0x429AF0", Offset = "0x4280F0", VA = "0x180429AF0")]
	private IEnumerator SunBright()
	{
		SunChomper.<SunBright>d__2 <SunBright>d__;
		<SunBright>d__.System.IDisposable.Dispose();
		<SunBright>d__.<>1__state = (int)((ulong)0L);
		<SunBright>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000F00 RID: 3840 RVA: 0x000579CC File Offset: 0x00055BCC
	[Token(Token = "0x6000F00")]
	[Address(RVA = "0x429890", Offset = "0x427E90", VA = "0x180429890")]
	private void ProduceSun()
	{
		CreateItem instance = CreateItem.Instance;
		CreateItem instance2 = CreateItem.Instance;
		CreateItem instance3 = CreateItem.Instance;
		CreateItem instance4 = CreateItem.Instance;
	}

	// Token: 0x06000F01 RID: 3841 RVA: 0x00057A00 File Offset: 0x00055C00
	[Token(Token = "0x6000F01")]
	[Address(RVA = "0x41A920", Offset = "0x418F20", VA = "0x18041A920")]
	public SunChomper()
	{
		this.swallowMaxCountDown = 40f;
		base..ctor();
	}
}
