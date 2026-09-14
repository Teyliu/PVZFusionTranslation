using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004D5 RID: 1237
[Token(Token = "0x20004D5")]
public class MoneyPot : Pot
{
	// Token: 0x06001759 RID: 5977 RVA: 0x0007FE7C File Offset: 0x0007E07C
	[Token(Token = "0x6001759")]
	[Address(RVA = "0x50FE00", Offset = "0x50E400", VA = "0x18050FE00", Slot = "16")]
	protected override void Update()
	{
		base.Update();
	}

	// Token: 0x0600175A RID: 5978 RVA: 0x0007FE90 File Offset: 0x0007E090
	[Token(Token = "0x600175A")]
	[Address(RVA = "0x50FC00", Offset = "0x50E200", VA = "0x18050FC00", Slot = "68")]
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

	// Token: 0x0600175B RID: 5979 RVA: 0x0007FF04 File Offset: 0x0007E104
	[Token(Token = "0x600175B")]
	[Address(RVA = "0x50FB90", Offset = "0x50E190", VA = "0x18050FB90")]
	protected IEnumerator Bright()
	{
		MoneyPot.<Bright>d__2 <Bright>d__;
		<Bright>d__.System.IDisposable.Dispose();
		<Bright>d__.<>1__state = (int)((ulong)0L);
		<Bright>d__.<>4__this = this;
		return null;
	}

	// Token: 0x0600175C RID: 5980 RVA: 0x0007FF28 File Offset: 0x0007E128
	[Token(Token = "0x600175C")]
	[Address(RVA = "0x50FD10", Offset = "0x50E310", VA = "0x18050FD10", Slot = "69")]
	protected virtual void Produce()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
		CreateItem instance = CreateItem.Instance;
	}

	// Token: 0x0600175D RID: 5981 RVA: 0x0007FF5C File Offset: 0x0007E15C
	[Token(Token = "0x600175D")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public MoneyPot()
	{
	}
}
