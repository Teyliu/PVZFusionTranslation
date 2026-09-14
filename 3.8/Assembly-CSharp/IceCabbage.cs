using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200050C RID: 1292
[Token(Token = "0x200050C")]
public class IceCabbage : Cabbage
{
	// Token: 0x06001820 RID: 6176 RVA: 0x00083360 File Offset: 0x00081560
	[Token(Token = "0x6001820")]
	[Address(RVA = "0x430540", Offset = "0x42EB40", VA = "0x180430540", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cabbage_ice;
	}

	// Token: 0x06001821 RID: 6177 RVA: 0x00083374 File Offset: 0x00081574
	[Token(Token = "0x6001821")]
	[Address(RVA = "0x4CE690", Offset = "0x4CCC90", VA = "0x1804CE690", Slot = "78")]
	protected override void UniqueEffect(Bullet bullet)
	{
		bullet.from = this;
		throw new NullReferenceException();
	}

	// Token: 0x06001822 RID: 6178 RVA: 0x00083390 File Offset: 0x00081590
	[Token(Token = "0x6001822")]
	[Address(RVA = "0x4CE5A0", Offset = "0x4CCBA0", VA = "0x1804CE5A0")]
	public void FastShoot()
	{
		IceCabbage.<IFastShoot>d__3 <IFastShoot>d__;
		<IFastShoot>d__.System.IDisposable.Dispose();
		<IFastShoot>d__.<>1__state = (int)((ulong)0L);
		<IFastShoot>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<IFastShoot>d__);
	}

	// Token: 0x06001823 RID: 6179 RVA: 0x000833BC File Offset: 0x000815BC
	[Token(Token = "0x6001823")]
	[Address(RVA = "0x4CE620", Offset = "0x4CCC20", VA = "0x1804CE620")]
	private IEnumerator IFastShoot()
	{
		IceCabbage.<IFastShoot>d__3 <IFastShoot>d__;
		<IFastShoot>d__.System.IDisposable.Dispose();
		<IFastShoot>d__.<>1__state = (int)((ulong)0L);
		<IFastShoot>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06001824 RID: 6180 RVA: 0x000833E0 File Offset: 0x000815E0
	[Token(Token = "0x6001824")]
	[Address(RVA = "0x47E9D0", Offset = "0x47CFD0", VA = "0x18047E9D0")]
	public IceCabbage()
	{
	}
}
