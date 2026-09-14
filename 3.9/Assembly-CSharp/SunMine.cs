using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000347 RID: 839
[Token(Token = "0x2000347")]
public class SunMine : PotatoMine
{
	// Token: 0x06000F53 RID: 3923 RVA: 0x00058AF0 File Offset: 0x00056CF0
	[Token(Token = "0x6000F53")]
	[Address(RVA = "0x46AB10", Offset = "0x469110", VA = "0x18046AB10", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
			base.PotatoUpdate();
		}
	}

	// Token: 0x06000F54 RID: 3924 RVA: 0x00058B14 File Offset: 0x00056D14
	[Token(Token = "0x6000F54")]
	[Address(RVA = "0x46A980", Offset = "0x468F80", VA = "0x18046A980", Slot = "36")]
	public override void ProducerUpdate()
	{
		float thePlantProduceCountDown = this.thePlantProduceCountDown;
		float deltaTime = Time.deltaTime;
		int num = 0;
		this.thePlantProduceCountDown = thePlantProduceCountDown;
		if (num > (int)thePlantProduceCountDown)
		{
			float thePlantProduceInterval = this.thePlantProduceInterval;
			this.thePlantProduceCountDown = thePlantProduceInterval;
			int num2 = global::UnityEngine.Random.Range(-2, 3);
			this.thePlantProduceCountDown = (float)num;
			SunMine.<SunBright>d__2 <SunBright>d__;
			<SunBright>d__.System.IDisposable.Dispose();
			<SunBright>d__.<>1__state = (int)((ulong)0L);
			<SunBright>d__.<>4__this = this;
			Coroutine coroutine = base.StartCoroutine(<SunBright>d__);
			base.Invoke("ProduceSun", 0.5f);
		}
	}

	// Token: 0x06000F55 RID: 3925 RVA: 0x00058B94 File Offset: 0x00056D94
	[Token(Token = "0x6000F55")]
	[Address(RVA = "0x46AAA0", Offset = "0x4690A0", VA = "0x18046AAA0")]
	private IEnumerator SunBright()
	{
		SunMine.<SunBright>d__2 <SunBright>d__;
		<SunBright>d__.System.IDisposable.Dispose();
		<SunBright>d__.<>1__state = (int)((ulong)0L);
		<SunBright>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000F56 RID: 3926 RVA: 0x00058BB8 File Offset: 0x00056DB8
	[Token(Token = "0x6000F56")]
	[Address(RVA = "0x46A890", Offset = "0x468E90", VA = "0x18046A890", Slot = "75")]
	protected virtual void ProduceSun()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.3f, 1f);
		CreateItem instance = CreateItem.Instance;
	}

	// Token: 0x06000F57 RID: 3927 RVA: 0x00058BEC File Offset: 0x00056DEC
	[Token(Token = "0x6000F57")]
	[Address(RVA = "0x46A790", Offset = "0x468D90", VA = "0x18046A790", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		CreateItem instance = CreateItem.Instance;
		CreateItem instance2 = CreateItem.Instance;
	}

	// Token: 0x06000F58 RID: 3928 RVA: 0x00058C14 File Offset: 0x00056E14
	[Token(Token = "0x6000F58")]
	[Address(RVA = "0x467BF0", Offset = "0x4661F0", VA = "0x180467BF0")]
	public SunMine()
	{
		this.flashInterval = 3f;
		base..ctor();
	}
}
