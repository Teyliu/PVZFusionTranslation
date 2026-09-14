using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000454 RID: 1108
[Token(Token = "0x2000454")]
public class SunBlover : Blover
{
	// Token: 0x0600146B RID: 5227 RVA: 0x00071AEC File Offset: 0x0006FCEC
	[Token(Token = "0x600146B")]
	[Address(RVA = "0x4C7810", Offset = "0x4C5E10", VA = "0x1804C7810", Slot = "68")]
	protected override void AnimBlow()
	{
		GameAPP.PlaySound(87, 0.5f, 1f);
		base.BlowZombie();
		GameObject fog = this.board.fog;
		int num = 0;
		if (fog != num)
		{
			FogMgr.Instance.Blown();
		}
		SunBlover.<Blowing>d__1 <Blowing>d__;
		<Blowing>d__.System.IDisposable.Dispose();
		<Blowing>d__.<>1__state = (int)((ulong)0L);
		<Blowing>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<Blowing>d__);
	}

	// Token: 0x0600146C RID: 5228 RVA: 0x00071B58 File Offset: 0x0006FD58
	[Token(Token = "0x600146C")]
	[Address(RVA = "0x4C7960", Offset = "0x4C5F60", VA = "0x1804C7960")]
	private IEnumerator Blowing()
	{
		SunBlover.<Blowing>d__1 <Blowing>d__;
		<Blowing>d__.System.IDisposable.Dispose();
		<Blowing>d__.<>1__state = (int)((ulong)0L);
		<Blowing>d__.<>4__this = this;
		return null;
	}

	// Token: 0x0600146D RID: 5229 RVA: 0x00071B7C File Offset: 0x0006FD7C
	[Token(Token = "0x600146D")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public SunBlover()
	{
	}
}
