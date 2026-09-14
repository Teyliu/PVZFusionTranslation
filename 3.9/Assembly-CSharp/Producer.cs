using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004C8 RID: 1224
[Token(Token = "0x20004C8")]
public class Producer : Plant
{
	// Token: 0x06001715 RID: 5909 RVA: 0x0007EEF4 File Offset: 0x0007D0F4
	[Token(Token = "0x6001715")]
	[Address(RVA = "0x515C80", Offset = "0x514280", VA = "0x180515C80", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		Animator anim = this.anim;
		float speed = anim.speed;
		if (anim != 0)
		{
		}
	}

	// Token: 0x06001716 RID: 5910 RVA: 0x0007EF20 File Offset: 0x0007D120
	[Token(Token = "0x6001716")]
	[Address(RVA = "0x515B40", Offset = "0x514140", VA = "0x180515B40", Slot = "36")]
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
			IEnumerator enumerator = this.SunBright();
			Coroutine coroutine = base.StartCoroutine(enumerator);
			base.Invoke("ProduceSun", 0.5f);
		}
	}

	// Token: 0x06001717 RID: 5911 RVA: 0x0007EF84 File Offset: 0x0007D184
	[Token(Token = "0x6001717")]
	[Address(RVA = "0x515C10", Offset = "0x514210", VA = "0x180515C10", Slot = "68")]
	protected virtual IEnumerator SunBright()
	{
		Producer.<SunBright>d__2 <SunBright>d__;
		<SunBright>d__.System.IDisposable.Dispose();
		<SunBright>d__.<>1__state = (int)((ulong)0L);
		<SunBright>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06001718 RID: 5912 RVA: 0x0007EFA8 File Offset: 0x0007D1A8
	[Token(Token = "0x6001718")]
	[Address(RVA = "0x515A50", Offset = "0x514050", VA = "0x180515A50", Slot = "69")]
	protected virtual void ProduceSun()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.3f, 1f);
		CreateItem instance = CreateItem.Instance;
	}

	// Token: 0x06001719 RID: 5913 RVA: 0x0007EFDC File Offset: 0x0007D1DC
	[Token(Token = "0x6001719")]
	[Address(RVA = "0x5159C0", Offset = "0x513FC0", VA = "0x1805159C0", Slot = "70")]
	protected virtual void ProduceSunWithNoSound()
	{
		CreateItem instance = CreateItem.Instance;
	}

	// Token: 0x0600171A RID: 5914 RVA: 0x0007EFFC File Offset: 0x0007D1FC
	[Token(Token = "0x600171A")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public Producer()
	{
	}
}
