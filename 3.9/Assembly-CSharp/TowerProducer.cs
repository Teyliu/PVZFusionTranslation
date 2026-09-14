using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000605 RID: 1541
[Token(Token = "0x2000605")]
public class TowerProducer : TowerPlant
{
	// Token: 0x06001CD9 RID: 7385 RVA: 0x00099A48 File Offset: 0x00097C48
	[Token(Token = "0x6001CD9")]
	[Address(RVA = "0x55E670", Offset = "0x55CC70", VA = "0x18055E670", Slot = "70")]
	public override void Shoot()
	{
		TowerProducer.<SunBright>d__3 <SunBright>d__;
		<SunBright>d__.System.IDisposable.Dispose();
		<SunBright>d__.<>1__state = (int)((ulong)0L);
		<SunBright>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<SunBright>d__);
		base.Invoke("ProduceSun", 0.5f);
	}

	// Token: 0x06001CDA RID: 7386 RVA: 0x00099A84 File Offset: 0x00097C84
	[Token(Token = "0x6001CDA")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "75")]
	protected virtual void ProduceSun()
	{
	}

	// Token: 0x06001CDB RID: 7387 RVA: 0x00099A94 File Offset: 0x00097C94
	[Token(Token = "0x6001CDB")]
	[Address(RVA = "0x3F1E60", Offset = "0x3F0460", VA = "0x1803F1E60", Slot = "46")]
	protected override bool Shootable()
	{
		return true;
	}

	// Token: 0x06001CDC RID: 7388 RVA: 0x00099AA4 File Offset: 0x00097CA4
	[Token(Token = "0x6001CDC")]
	[Address(RVA = "0x55E720", Offset = "0x55CD20", VA = "0x18055E720")]
	protected IEnumerator SunBright()
	{
		TowerProducer.<SunBright>d__3 <SunBright>d__;
		<SunBright>d__.System.IDisposable.Dispose();
		<SunBright>d__.<>1__state = (int)((ulong)0L);
		<SunBright>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06001CDD RID: 7389 RVA: 0x00099AC8 File Offset: 0x00097CC8
	[Token(Token = "0x6001CDD")]
	[Address(RVA = "0x55D890", Offset = "0x55BE90", VA = "0x18055D890")]
	public TowerProducer()
	{
		this.towards = (Towards)((ulong)1L);
		this.basicDamage = 1f;
		this.attackSpeed = 1f;
		base..ctor();
	}
}
