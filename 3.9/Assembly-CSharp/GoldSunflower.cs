using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004D0 RID: 1232
[Token(Token = "0x20004D0")]
public class GoldSunflower : Plant
{
	// Token: 0x0600173F RID: 5951 RVA: 0x0007F904 File Offset: 0x0007DB04
	[Token(Token = "0x600173F")]
	[Address(RVA = "0x4A1280", Offset = "0x49F880", VA = "0x1804A1280", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 5f;
	}

	// Token: 0x06001740 RID: 5952 RVA: 0x0007F924 File Offset: 0x0007DB24
	[Token(Token = "0x6001740")]
	[Address(RVA = "0x50F0E0", Offset = "0x50D6E0", VA = "0x18050F0E0", Slot = "39")]
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

	// Token: 0x06001741 RID: 5953 RVA: 0x0007F96C File Offset: 0x0007DB6C
	[Token(Token = "0x6001741")]
	[Address(RVA = "0x50F1A0", Offset = "0x50D7A0", VA = "0x18050F1A0", Slot = "42")]
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

	// Token: 0x06001742 RID: 5954 RVA: 0x0007F9F8 File Offset: 0x0007DBF8
	[Token(Token = "0x6001742")]
	[Address(RVA = "0x50F130", Offset = "0x50D730", VA = "0x18050F130")]
	private IEnumerator ContinueProduce()
	{
		GoldSunflower.<ContinueProduce>d__3 <ContinueProduce>d__;
		<ContinueProduce>d__.System.IDisposable.Dispose();
		<ContinueProduce>d__.<>1__state = (int)((ulong)0L);
		<ContinueProduce>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06001743 RID: 5955 RVA: 0x0007FA1C File Offset: 0x0007DC1C
	[Token(Token = "0x6001743")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public GoldSunflower()
	{
	}
}
