using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004AF RID: 1199
[Token(Token = "0x20004AF")]
public class Marigold : Plant
{
	// Token: 0x060016A4 RID: 5796 RVA: 0x0007CF10 File Offset: 0x0007B110
	[Token(Token = "0x60016A4")]
	[Address(RVA = "0x4A3CF0", Offset = "0x4A22F0", VA = "0x1804A3CF0", Slot = "16")]
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

	// Token: 0x060016A5 RID: 5797 RVA: 0x0007CF88 File Offset: 0x0007B188
	[Token(Token = "0x60016A5")]
	[Address(RVA = "0x4A38B0", Offset = "0x4A1EB0", VA = "0x1804A38B0")]
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

	// Token: 0x060016A6 RID: 5798 RVA: 0x0007CFFC File Offset: 0x0007B1FC
	[Token(Token = "0x60016A6")]
	[Address(RVA = "0x4A3C80", Offset = "0x4A2280", VA = "0x1804A3C80")]
	private IEnumerator SunBright()
	{
		Marigold.<SunBright>d__2 <SunBright>d__;
		<SunBright>d__.System.IDisposable.Dispose();
		<SunBright>d__.<>1__state = (int)((ulong)0L);
		<SunBright>d__.<>4__this = this;
		return null;
	}

	// Token: 0x060016A7 RID: 5799 RVA: 0x0007D020 File Offset: 0x0007B220
	[Token(Token = "0x60016A7")]
	[Address(RVA = "0x4A3B20", Offset = "0x4A2120", VA = "0x1804A3B20")]
	private void Produce()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
		int num = global::UnityEngine.Random.Range(0, 100);
		GameAPP.PlaySound(97, 0.5f, 1f);
		CreateItem instance = CreateItem.Instance;
	}

	// Token: 0x060016A8 RID: 5800 RVA: 0x0007D070 File Offset: 0x0007B270
	[Token(Token = "0x60016A8")]
	[Address(RVA = "0x4A39E0", Offset = "0x4A1FE0", VA = "0x1804A39E0", Slot = "55")]
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

	// Token: 0x060016A9 RID: 5801 RVA: 0x0007D0CC File Offset: 0x0007B2CC
	[Token(Token = "0x60016A9")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public Marigold()
	{
	}
}
