using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005D0 RID: 1488
[Token(Token = "0x20005D0")]
public class TowerProducer : TowerPlant
{
	// Token: 0x06001BDA RID: 7130 RVA: 0x00094E30 File Offset: 0x00093030
	[Token(Token = "0x6001BDA")]
	[Address(RVA = "0x50D420", Offset = "0x50BA20", VA = "0x18050D420", Slot = "71")]
	public override void Shoot()
	{
		TowerProducer.<SunBright>d__3 <SunBright>d__;
		<SunBright>d__.System.IDisposable.Dispose();
		<SunBright>d__.<>1__state = (int)((ulong)0L);
		<SunBright>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<SunBright>d__);
		base.Invoke("ProduceSun", 0.5f);
	}

	// Token: 0x06001BDB RID: 7131 RVA: 0x00094E6C File Offset: 0x0009306C
	[Token(Token = "0x6001BDB")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "76")]
	protected virtual void ProduceSun()
	{
	}

	// Token: 0x06001BDC RID: 7132 RVA: 0x00094E7C File Offset: 0x0009307C
	[Token(Token = "0x6001BDC")]
	[Address(RVA = "0x3A5ED0", Offset = "0x3A44D0", VA = "0x1803A5ED0", Slot = "47")]
	protected override bool Shootable()
	{
		return true;
	}

	// Token: 0x06001BDD RID: 7133 RVA: 0x00094E8C File Offset: 0x0009308C
	[Token(Token = "0x6001BDD")]
	[Address(RVA = "0x50D4D0", Offset = "0x50BAD0", VA = "0x18050D4D0")]
	protected IEnumerator SunBright()
	{
		TowerProducer.<SunBright>d__3 <SunBright>d__;
		<SunBright>d__.System.IDisposable.Dispose();
		<SunBright>d__.<>1__state = (int)((ulong)0L);
		<SunBright>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06001BDE RID: 7134 RVA: 0x00094EB0 File Offset: 0x000930B0
	[Token(Token = "0x6001BDE")]
	[Address(RVA = "0x50C640", Offset = "0x50AC40", VA = "0x18050C640")]
	public TowerProducer()
	{
		this.towards = (Towards)((ulong)1L);
		this.basicDamage = 1f;
		this.attackSpeed = 1f;
		base..ctor();
	}
}
