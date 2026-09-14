using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000808 RID: 2056
[Token(Token = "0x2000808")]
public class BlackMask : MonoBehaviour
{
	// Token: 0x060029EE RID: 10734 RVA: 0x000E557C File Offset: 0x000E377C
	[Token(Token = "0x60029EE")]
	[Address(RVA = "0x635050", Offset = "0x633650", VA = "0x180635050")]
	private void Awake()
	{
		BlackMask.Instance = this;
		SpriteRenderer component = base.GetComponent<SpriteRenderer>();
		this.r = component;
	}

	// Token: 0x060029EF RID: 10735 RVA: 0x000E55A0 File Offset: 0x000E37A0
	[Token(Token = "0x60029EF")]
	[Address(RVA = "0x634FB0", Offset = "0x6335B0", VA = "0x180634FB0")]
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

	// Token: 0x060029F0 RID: 10736 RVA: 0x000E55DC File Offset: 0x000E37DC
	[Token(Token = "0x60029F0")]
	[Address(RVA = "0x6350D0", Offset = "0x6336D0", VA = "0x1806350D0")]
	private IEnumerator ShowAndHide(Action midAction)
	{
		BlackMask.<ShowAndHide>d__4 <ShowAndHide>d__;
		<ShowAndHide>d__.System.IDisposable.Dispose();
		<ShowAndHide>d__.<>1__state = (int)((ulong)0L);
		<ShowAndHide>d__.<>4__this = this;
		<ShowAndHide>d__.midAction = midAction;
		return null;
	}

	// Token: 0x060029F1 RID: 10737 RVA: 0x000E5608 File Offset: 0x000E3808
	[Token(Token = "0x60029F1")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public BlackMask()
	{
	}

	// Token: 0x04001830 RID: 6192
	[Token(Token = "0x4001830")]
	public static BlackMask Instance;

	// Token: 0x04001831 RID: 6193
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001831")]
	private SpriteRenderer r;
}
