using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004B1 RID: 1201
[Token(Token = "0x20004B1")]
public class UltimateSunMagnet : SunMagnetShroom
{
	// Token: 0x0600166A RID: 5738 RVA: 0x0007B8C8 File Offset: 0x00079AC8
	[Token(Token = "0x600166A")]
	[Address(RVA = "0x4ED380", Offset = "0x4EB980", VA = "0x1804ED380", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
		}
	}

	// Token: 0x0600166B RID: 5739 RVA: 0x0007B8E8 File Offset: 0x00079AE8
	[Token(Token = "0x600166B")]
	[Address(RVA = "0x4ED2C0", Offset = "0x4EB8C0", VA = "0x1804ED2C0", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.AttributeEvent();
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)26)))
		{
			float num = this.attributeCountdown * 0.5f;
			base.AttributeCountdown = num;
			return;
		}
	}

	// Token: 0x0600166C RID: 5740 RVA: 0x0007B91C File Offset: 0x00079B1C
	[Token(Token = "0x600166C")]
	[Address(RVA = "0x4ED240", Offset = "0x4EB840", VA = "0x1804ED240", Slot = "71")]
	protected override void AnimProduce()
	{
		base.AnimProduce();
		UltimateSunMagnet.<SunRepair>d__3 <SunRepair>d__;
		<SunRepair>d__.<>1__state = (int)((ulong)0L);
		<SunRepair>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<SunRepair>d__);
	}

	// Token: 0x0600166D RID: 5741 RVA: 0x0007B948 File Offset: 0x00079B48
	[Token(Token = "0x600166D")]
	[Address(RVA = "0x4ED310", Offset = "0x4EB910", VA = "0x1804ED310")]
	private IEnumerator SunRepair()
	{
		UltimateSunMagnet.<SunRepair>d__3 <SunRepair>d__;
		<SunRepair>d__.<>1__state = (int)((ulong)0L);
		<SunRepair>d__.<>4__this = this;
		return null;
	}

	// Token: 0x0600166E RID: 5742 RVA: 0x0007B968 File Offset: 0x00079B68
	[Token(Token = "0x600166E")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public UltimateSunMagnet()
	{
	}
}
