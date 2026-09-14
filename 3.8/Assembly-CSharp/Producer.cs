using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004A6 RID: 1190
[Token(Token = "0x20004A6")]
public class Producer : Plant
{
	// Token: 0x06001674 RID: 5748 RVA: 0x0007C42C File Offset: 0x0007A62C
	[Token(Token = "0x6001674")]
	[Address(RVA = "0x4AA050", Offset = "0x4A8650", VA = "0x1804AA050", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		Animator anim = this.anim;
		float speed = anim.speed;
		if (anim != 0)
		{
		}
	}

	// Token: 0x06001675 RID: 5749 RVA: 0x0007C458 File Offset: 0x0007A658
	[Token(Token = "0x6001675")]
	[Address(RVA = "0x4A9F10", Offset = "0x4A8510", VA = "0x1804A9F10", Slot = "37")]
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

	// Token: 0x06001676 RID: 5750 RVA: 0x0007C4BC File Offset: 0x0007A6BC
	[Token(Token = "0x6001676")]
	[Address(RVA = "0x4A9FE0", Offset = "0x4A85E0", VA = "0x1804A9FE0", Slot = "69")]
	protected virtual IEnumerator SunBright()
	{
		Producer.<SunBright>d__2 <SunBright>d__;
		<SunBright>d__.System.IDisposable.Dispose();
		<SunBright>d__.<>1__state = (int)((ulong)0L);
		<SunBright>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06001677 RID: 5751 RVA: 0x0007C4E0 File Offset: 0x0007A6E0
	[Token(Token = "0x6001677")]
	[Address(RVA = "0x4A9E20", Offset = "0x4A8420", VA = "0x1804A9E20", Slot = "70")]
	protected virtual void ProduceSun()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.3f, 1f);
		CreateItem instance = CreateItem.Instance;
	}

	// Token: 0x06001678 RID: 5752 RVA: 0x0007C514 File Offset: 0x0007A714
	[Token(Token = "0x6001678")]
	[Address(RVA = "0x4A9D90", Offset = "0x4A8390", VA = "0x1804A9D90", Slot = "71")]
	protected virtual void ProduceSunWithNoSound()
	{
		CreateItem instance = CreateItem.Instance;
	}

	// Token: 0x06001679 RID: 5753 RVA: 0x0007C534 File Offset: 0x0007A734
	[Token(Token = "0x6001679")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public Producer()
	{
	}
}
