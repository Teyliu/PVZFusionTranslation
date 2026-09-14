using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004B1 RID: 1201
[Token(Token = "0x20004B1")]
public class MoneyPot : Pot
{
	// Token: 0x060016B0 RID: 5808 RVA: 0x0007D224 File Offset: 0x0007B424
	[Token(Token = "0x60016B0")]
	[Address(RVA = "0x4A4360", Offset = "0x4A2960", VA = "0x1804A4360", Slot = "16")]
	protected override void Update()
	{
		base.Update();
	}

	// Token: 0x060016B1 RID: 5809 RVA: 0x0007D238 File Offset: 0x0007B438
	[Token(Token = "0x60016B1")]
	[Address(RVA = "0x4A4160", Offset = "0x4A2760", VA = "0x1804A4160", Slot = "69")]
	protected virtual void MarigoldUpdate()
	{
		float thePlantProduceCountDown = this.thePlantProduceCountDown;
		float deltaTime = Time.deltaTime;
		this.thePlantProduceCountDown = thePlantProduceCountDown;
		float num = global::UnityEngine.Random.Range(0.9f, 1.1f);
		this.thePlantProduceCountDown = num;
		MoneyPot.<Bright>d__2 <Bright>d__;
		<Bright>d__.System.IDisposable.Dispose();
		<Bright>d__.<>1__state = (int)((ulong)0L);
		<Bright>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<Bright>d__);
		base.Invoke("Produce", 0.5f);
	}

	// Token: 0x060016B2 RID: 5810 RVA: 0x0007D2AC File Offset: 0x0007B4AC
	[Token(Token = "0x60016B2")]
	[Address(RVA = "0x4A40F0", Offset = "0x4A26F0", VA = "0x1804A40F0")]
	protected IEnumerator Bright()
	{
		MoneyPot.<Bright>d__2 <Bright>d__;
		<Bright>d__.System.IDisposable.Dispose();
		<Bright>d__.<>1__state = (int)((ulong)0L);
		<Bright>d__.<>4__this = this;
		return null;
	}

	// Token: 0x060016B3 RID: 5811 RVA: 0x0007D2D0 File Offset: 0x0007B4D0
	[Token(Token = "0x60016B3")]
	[Address(RVA = "0x4A4270", Offset = "0x4A2870", VA = "0x1804A4270", Slot = "70")]
	protected virtual void Produce()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
		CreateItem instance = CreateItem.Instance;
	}

	// Token: 0x060016B4 RID: 5812 RVA: 0x0007D304 File Offset: 0x0007B504
	[Token(Token = "0x60016B4")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public MoneyPot()
	{
	}
}
