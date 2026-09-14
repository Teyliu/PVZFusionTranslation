using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004D3 RID: 1235
[Token(Token = "0x20004D3")]
public class Marigold : Plant
{
	// Token: 0x0600174D RID: 5965 RVA: 0x0007FB68 File Offset: 0x0007DD68
	[Token(Token = "0x600174D")]
	[Address(RVA = "0x50F790", Offset = "0x50DD90", VA = "0x18050F790", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		float thePlantProduceCountDown = this.thePlantProduceCountDown;
		float deltaTime = Time.deltaTime;
		this.thePlantProduceCountDown = thePlantProduceCountDown;
		float num;
		this.thePlantProduceCountDown = num;
		Marigold.<SunBright>d__2 <SunBright>d__;
		<SunBright>d__.System.IDisposable.Dispose();
		<SunBright>d__.<>1__state = (int)((ulong)0L);
		<SunBright>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<SunBright>d__);
		base.Invoke("Produce", 0.5f);
		base.Invoke("Produce", 0.5f);
	}

	// Token: 0x0600174E RID: 5966 RVA: 0x0007FBE0 File Offset: 0x0007DDE0
	[Token(Token = "0x600174E")]
	[Address(RVA = "0x50F350", Offset = "0x50D950", VA = "0x18050F350")]
	private void MarigoldUpdate()
	{
		float thePlantProduceCountDown = this.thePlantProduceCountDown;
		float deltaTime = Time.deltaTime;
		this.thePlantProduceCountDown = thePlantProduceCountDown;
		float num;
		this.thePlantProduceCountDown = num;
		Marigold.<SunBright>d__2 <SunBright>d__;
		<SunBright>d__.System.IDisposable.Dispose();
		<SunBright>d__.<>1__state = (int)((ulong)0L);
		<SunBright>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<SunBright>d__);
		base.Invoke("Produce", 0.5f);
		base.Invoke("Produce", 0.5f);
	}

	// Token: 0x0600174F RID: 5967 RVA: 0x0007FC54 File Offset: 0x0007DE54
	[Token(Token = "0x600174F")]
	[Address(RVA = "0x50F720", Offset = "0x50DD20", VA = "0x18050F720")]
	private IEnumerator SunBright()
	{
		Marigold.<SunBright>d__2 <SunBright>d__;
		<SunBright>d__.System.IDisposable.Dispose();
		<SunBright>d__.<>1__state = (int)((ulong)0L);
		<SunBright>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06001750 RID: 5968 RVA: 0x0007FC78 File Offset: 0x0007DE78
	[Token(Token = "0x6001750")]
	[Address(RVA = "0x50F5C0", Offset = "0x50DBC0", VA = "0x18050F5C0")]
	private void Produce()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
		int num = global::UnityEngine.Random.Range(0, 100);
		GameAPP.PlaySound(97, 0.5f, 1f);
		CreateItem instance = CreateItem.Instance;
	}

	// Token: 0x06001751 RID: 5969 RVA: 0x0007FCC8 File Offset: 0x0007DEC8
	[Token(Token = "0x6001751")]
	[Address(RVA = "0x50F480", Offset = "0x50DA80", VA = "0x18050F480", Slot = "54")]
	public override void OnCreate(int theColumn, int theRow)
	{
		base.OnCreate(theColumn, theRow);
		Money instance = Money.Instance;
		int num = 0;
		if (!(instance != num))
		{
			InGameUI instance2 = InGameUI.Instance;
			int num2 = 0;
			if (instance2 != num2)
			{
				InGameUI.Instance.MoneyBank.SetActive(true);
			}
			return;
		}
		Money.Instance.EnableMoneyBank();
	}

	// Token: 0x06001752 RID: 5970 RVA: 0x0007FD24 File Offset: 0x0007DF24
	[Token(Token = "0x6001752")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public Marigold()
	{
	}
}
