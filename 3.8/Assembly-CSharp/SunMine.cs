using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000337 RID: 823
[Token(Token = "0x2000337")]
public class SunMine : PotatoMine
{
	// Token: 0x06000F08 RID: 3848 RVA: 0x00057B64 File Offset: 0x00055D64
	[Token(Token = "0x6000F08")]
	[Address(RVA = "0x429F90", Offset = "0x428590", VA = "0x180429F90", Slot = "16")]
	protected override void Update()
	{
		base.Update();
	}

	// Token: 0x06000F09 RID: 3849 RVA: 0x00057B78 File Offset: 0x00055D78
	[Token(Token = "0x6000F09")]
	[Address(RVA = "0x429E00", Offset = "0x428400", VA = "0x180429E00", Slot = "37")]
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

	// Token: 0x06000F0A RID: 3850 RVA: 0x00057BF8 File Offset: 0x00055DF8
	[Token(Token = "0x6000F0A")]
	[Address(RVA = "0x429F20", Offset = "0x428520", VA = "0x180429F20")]
	private IEnumerator SunBright()
	{
		SunMine.<SunBright>d__2 <SunBright>d__;
		<SunBright>d__.System.IDisposable.Dispose();
		<SunBright>d__.<>1__state = (int)((ulong)0L);
		<SunBright>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000F0B RID: 3851 RVA: 0x00057C1C File Offset: 0x00055E1C
	[Token(Token = "0x6000F0B")]
	[Address(RVA = "0x429D10", Offset = "0x428310", VA = "0x180429D10", Slot = "76")]
	protected virtual void ProduceSun()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.3f, 1f);
		CreateItem instance = CreateItem.Instance;
	}

	// Token: 0x06000F0C RID: 3852 RVA: 0x00057C50 File Offset: 0x00055E50
	[Token(Token = "0x6000F0C")]
	[Address(RVA = "0x429C10", Offset = "0x428210", VA = "0x180429C10", Slot = "52")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		CreateItem instance = CreateItem.Instance;
		CreateItem instance2 = CreateItem.Instance;
	}

	// Token: 0x06000F0D RID: 3853 RVA: 0x00057C78 File Offset: 0x00055E78
	[Token(Token = "0x6000F0D")]
	[Address(RVA = "0x42A010", Offset = "0x428610", VA = "0x18042A010")]
	public SunMine()
	{
	}
}
