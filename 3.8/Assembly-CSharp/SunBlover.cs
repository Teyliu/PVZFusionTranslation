using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000435 RID: 1077
[Token(Token = "0x2000435")]
public class SunBlover : Blover
{
	// Token: 0x060013E1 RID: 5089 RVA: 0x0006F840 File Offset: 0x0006DA40
	[Token(Token = "0x60013E1")]
	[Address(RVA = "0x46FFC0", Offset = "0x46E5C0", VA = "0x18046FFC0", Slot = "69")]
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

	// Token: 0x060013E2 RID: 5090 RVA: 0x0006F8AC File Offset: 0x0006DAAC
	[Token(Token = "0x60013E2")]
	[Address(RVA = "0x470110", Offset = "0x46E710", VA = "0x180470110")]
	private IEnumerator Blowing()
	{
		SunBlover.<Blowing>d__1 <Blowing>d__;
		<Blowing>d__.System.IDisposable.Dispose();
		<Blowing>d__.<>1__state = (int)((ulong)0L);
		<Blowing>d__.<>4__this = this;
		return null;
	}

	// Token: 0x060013E3 RID: 5091 RVA: 0x0006F8D0 File Offset: 0x0006DAD0
	[Token(Token = "0x60013E3")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public SunBlover()
	{
	}
}
