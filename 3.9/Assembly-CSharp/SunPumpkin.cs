using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200045A RID: 1114
[Token(Token = "0x200045A")]
public class SunPumpkin : Pumpkin
{
	// Token: 0x06001483 RID: 5251 RVA: 0x00071FD4 File Offset: 0x000701D4
	[Token(Token = "0x6001483")]
	[Address(RVA = "0x4C81C0", Offset = "0x4C67C0", VA = "0x1804C81C0", Slot = "36")]
	public override void ProducerUpdate()
	{
		float thePlantProduceCountDown = this.thePlantProduceCountDown;
		float deltaTime = Time.deltaTime;
		int num = 0;
		this.thePlantProduceCountDown = thePlantProduceCountDown;
		if (num > (int)thePlantProduceCountDown)
		{
			float num2 = global::UnityEngine.Random.Range(0.95f, 1.05f);
			this.thePlantProduceCountDown = num2;
			SunPumpkin.<SunBright>d__1 <SunBright>d__;
			<SunBright>d__.System.IDisposable.Dispose();
			<SunBright>d__.<>1__state = (int)((ulong)0L);
			<SunBright>d__.<>4__this = this;
			Coroutine coroutine = base.StartCoroutine(<SunBright>d__);
			base.Invoke("ProduceSun", 0.5f);
		}
	}

	// Token: 0x06001484 RID: 5252 RVA: 0x0007204C File Offset: 0x0007024C
	[Token(Token = "0x6001484")]
	[Address(RVA = "0x4C82D0", Offset = "0x4C68D0", VA = "0x1804C82D0")]
	protected IEnumerator SunBright()
	{
		SunPumpkin.<SunBright>d__1 <SunBright>d__;
		<SunBright>d__.System.IDisposable.Dispose();
		<SunBright>d__.<>1__state = (int)((ulong)0L);
		<SunBright>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06001485 RID: 5253 RVA: 0x00072070 File Offset: 0x00070270
	[Token(Token = "0x6001485")]
	[Address(RVA = "0x4C7F90", Offset = "0x4C6590", VA = "0x1804C7F90", Slot = "69")]
	protected virtual void ProduceSun()
	{
		int num;
		do
		{
			GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.3f, 1f);
			CreateItem instance = CreateItem.Instance;
			num = 0;
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow);
			bool flag;
			if (flag)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x06001486 RID: 5254 RVA: 0x000720CC File Offset: 0x000702CC
	[Token(Token = "0x6001486")]
	[Address(RVA = "0x4C8340", Offset = "0x4C6940", VA = "0x1804C8340", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
		}
	}

	// Token: 0x06001487 RID: 5255 RVA: 0x000720E8 File Offset: 0x000702E8
	[Token(Token = "0x6001487")]
	[Address(RVA = "0x472EF0", Offset = "0x4714F0", VA = "0x180472EF0")]
	public SunPumpkin()
	{
	}
}
