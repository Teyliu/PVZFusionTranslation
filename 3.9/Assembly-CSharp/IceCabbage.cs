using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000537 RID: 1335
[Token(Token = "0x2000537")]
public class IceCabbage : Cabbage
{
	// Token: 0x060018E9 RID: 6377 RVA: 0x00086BB0 File Offset: 0x00084DB0
	[Token(Token = "0x60018E9")]
	[Address(RVA = "0x480D00", Offset = "0x47F300", VA = "0x180480D00", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cabbage_ice;
	}

	// Token: 0x060018EA RID: 6378 RVA: 0x00086BC4 File Offset: 0x00084DC4
	[Token(Token = "0x60018EA")]
	[Address(RVA = "0x52AA50", Offset = "0x529050", VA = "0x18052AA50", Slot = "77")]
	protected override void UniqueEffect(Bullet bullet)
	{
		bullet.from = this;
		throw new NullReferenceException();
	}

	// Token: 0x060018EB RID: 6379 RVA: 0x00086BE0 File Offset: 0x00084DE0
	[Token(Token = "0x60018EB")]
	[Address(RVA = "0x52A960", Offset = "0x528F60", VA = "0x18052A960")]
	public void FastShoot()
	{
		IceCabbage.<IFastShoot>d__3 <IFastShoot>d__;
		<IFastShoot>d__.System.IDisposable.Dispose();
		<IFastShoot>d__.<>1__state = (int)((ulong)0L);
		<IFastShoot>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<IFastShoot>d__);
	}

	// Token: 0x060018EC RID: 6380 RVA: 0x00086C0C File Offset: 0x00084E0C
	[Token(Token = "0x60018EC")]
	[Address(RVA = "0x52A9E0", Offset = "0x528FE0", VA = "0x18052A9E0")]
	private IEnumerator IFastShoot()
	{
		IceCabbage.<IFastShoot>d__3 <IFastShoot>d__;
		<IFastShoot>d__.System.IDisposable.Dispose();
		<IFastShoot>d__.<>1__state = (int)((ulong)0L);
		<IFastShoot>d__.<>4__this = this;
		return null;
	}

	// Token: 0x060018ED RID: 6381 RVA: 0x00086C30 File Offset: 0x00084E30
	[Token(Token = "0x60018ED")]
	[Address(RVA = "0x4D6B50", Offset = "0x4D5150", VA = "0x1804D6B50")]
	public IceCabbage()
	{
	}
}
