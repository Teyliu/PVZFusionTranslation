using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000846 RID: 2118
[Token(Token = "0x2000846")]
public class BlackMask : MonoBehaviour
{
	// Token: 0x06002B2C RID: 11052 RVA: 0x000EA8E0 File Offset: 0x000E8AE0
	[Token(Token = "0x6002B2C")]
	[Address(RVA = "0x6995C0", Offset = "0x697BC0", VA = "0x1806995C0")]
	private void Awake()
	{
		BlackMask.Instance = this;
		SpriteRenderer component = base.GetComponent<SpriteRenderer>();
		this.r = component;
	}

	// Token: 0x06002B2D RID: 11053 RVA: 0x000EA904 File Offset: 0x000E8B04
	[Token(Token = "0x6002B2D")]
	[Address(RVA = "0x699520", Offset = "0x697B20", VA = "0x180699520")]
	public void Active(Action midAction)
	{
		base.StopAllCoroutines();
		BlackMask.<ShowAndHide>d__4 <ShowAndHide>d__;
		<ShowAndHide>d__.System.IDisposable.Dispose();
		<ShowAndHide>d__.<>1__state = (int)((ulong)0L);
		<ShowAndHide>d__.<>4__this = this;
		<ShowAndHide>d__.midAction = midAction;
		Coroutine coroutine = base.StartCoroutine(<ShowAndHide>d__);
	}

	// Token: 0x06002B2E RID: 11054 RVA: 0x000EA940 File Offset: 0x000E8B40
	[Token(Token = "0x6002B2E")]
	[Address(RVA = "0x699640", Offset = "0x697C40", VA = "0x180699640")]
	private IEnumerator ShowAndHide(Action midAction)
	{
		BlackMask.<ShowAndHide>d__4 <ShowAndHide>d__;
		<ShowAndHide>d__.System.IDisposable.Dispose();
		<ShowAndHide>d__.<>1__state = (int)((ulong)0L);
		<ShowAndHide>d__.<>4__this = this;
		<ShowAndHide>d__.midAction = midAction;
		return null;
	}

	// Token: 0x06002B2F RID: 11055 RVA: 0x000EA96C File Offset: 0x000E8B6C
	[Token(Token = "0x6002B2F")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public BlackMask()
	{
	}

	// Token: 0x0400192C RID: 6444
	[Token(Token = "0x400192C")]
	public static BlackMask Instance;

	// Token: 0x0400192D RID: 6445
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400192D")]
	private SpriteRenderer r;
}
