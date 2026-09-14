using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200043B RID: 1083
[Token(Token = "0x200043B")]
public class SunPumpkin : Pumpkin
{
	// Token: 0x060013F9 RID: 5113 RVA: 0x0006FD24 File Offset: 0x0006DF24
	[Token(Token = "0x60013F9")]
	[Address(RVA = "0x470960", Offset = "0x46EF60", VA = "0x180470960", Slot = "37")]
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

	// Token: 0x060013FA RID: 5114 RVA: 0x0006FD9C File Offset: 0x0006DF9C
	[Token(Token = "0x60013FA")]
	[Address(RVA = "0x470A70", Offset = "0x46F070", VA = "0x180470A70")]
	protected IEnumerator SunBright()
	{
		SunPumpkin.<SunBright>d__1 <SunBright>d__;
		<SunBright>d__.System.IDisposable.Dispose();
		<SunBright>d__.<>1__state = (int)((ulong)0L);
		<SunBright>d__.<>4__this = this;
		return null;
	}

	// Token: 0x060013FB RID: 5115 RVA: 0x0006FDC0 File Offset: 0x0006DFC0
	[Token(Token = "0x60013FB")]
	[Address(RVA = "0x470730", Offset = "0x46ED30", VA = "0x180470730", Slot = "70")]
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

	// Token: 0x060013FC RID: 5116 RVA: 0x0006FE1C File Offset: 0x0006E01C
	[Token(Token = "0x60013FC")]
	[Address(RVA = "0x470AE0", Offset = "0x46F0E0", VA = "0x180470AE0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
		}
	}

	// Token: 0x060013FD RID: 5117 RVA: 0x0006FE38 File Offset: 0x0006E038
	[Token(Token = "0x60013FD")]
	[Address(RVA = "0x41C050", Offset = "0x41A650", VA = "0x18041C050")]
	public SunPumpkin()
	{
	}
}
