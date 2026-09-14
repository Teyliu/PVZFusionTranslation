using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004AC RID: 1196
[Token(Token = "0x20004AC")]
public class GoldSunflower : Plant
{
	// Token: 0x06001696 RID: 5782 RVA: 0x0007CCAC File Offset: 0x0007AEAC
	[Token(Token = "0x6001696")]
	[Address(RVA = "0x44CAC0", Offset = "0x44B0C0", VA = "0x18044CAC0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 5f;
	}

	// Token: 0x06001697 RID: 5783 RVA: 0x0007CCCC File Offset: 0x0007AECC
	[Token(Token = "0x6001697")]
	[Address(RVA = "0x4A3640", Offset = "0x4A1C40", VA = "0x1804A3640", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		base.AttributeCountdown = 10f;
		int num = this.attributeCount;
		num++;
		this.attributeCount = num;
		if (num > 200)
		{
			this.attributeCount = (int)((ulong)200L);
		}
	}

	// Token: 0x06001698 RID: 5784 RVA: 0x0007CD14 File Offset: 0x0007AF14
	[Token(Token = "0x6001698")]
	[Address(RVA = "0x4A3700", Offset = "0x4A1D00", VA = "0x1804A3700", Slot = "43")]
	public override bool SuperSkill()
	{
		float flashCountDown = this.flashCountDown;
		int num = 0;
		if (flashCountDown <= (float)num)
		{
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			int num2 = 0;
			ulong num3;
			base.Recover(z, (DamageType)num2, true, num3 != 0UL);
			GameAPP.PlaySound(66, 0.5f, 1f);
			GoldSunflower.<ContinueProduce>d__3 <ContinueProduce>d__;
			<ContinueProduce>d__.System.IDisposable.Dispose();
			<ContinueProduce>d__.<>1__state = (int)((ulong)0L);
			<ContinueProduce>d__.<>4__this = this;
			Coroutine coroutine = base.StartCoroutine(<ContinueProduce>d__);
			float num4 = flashCountDown * 0.1f;
			this.flashCountDown = num4;
			return true;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001699 RID: 5785 RVA: 0x0007CDA0 File Offset: 0x0007AFA0
	[Token(Token = "0x6001699")]
	[Address(RVA = "0x4A3690", Offset = "0x4A1C90", VA = "0x1804A3690")]
	private IEnumerator ContinueProduce()
	{
		GoldSunflower.<ContinueProduce>d__3 <ContinueProduce>d__;
		<ContinueProduce>d__.System.IDisposable.Dispose();
		<ContinueProduce>d__.<>1__state = (int)((ulong)0L);
		<ContinueProduce>d__.<>4__this = this;
		return null;
	}

	// Token: 0x0600169A RID: 5786 RVA: 0x0007CDC4 File Offset: 0x0007AFC4
	[Token(Token = "0x600169A")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public GoldSunflower()
	{
	}
}
