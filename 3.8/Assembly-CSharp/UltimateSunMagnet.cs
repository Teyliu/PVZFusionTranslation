using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200048F RID: 1167
[Token(Token = "0x200048F")]
public class UltimateSunMagnet : SunMagnetShroom
{
	// Token: 0x060015CA RID: 5578 RVA: 0x00078F44 File Offset: 0x00077144
	[Token(Token = "0x60015CA")]
	[Address(RVA = "0x493ED0", Offset = "0x4924D0", VA = "0x180493ED0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
		}
	}

	// Token: 0x060015CB RID: 5579 RVA: 0x00078F64 File Offset: 0x00077164
	[Token(Token = "0x60015CB")]
	[Address(RVA = "0x493E10", Offset = "0x492410", VA = "0x180493E10", Slot = "40")]
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

	// Token: 0x060015CC RID: 5580 RVA: 0x00078F98 File Offset: 0x00077198
	[Token(Token = "0x60015CC")]
	[Address(RVA = "0x493D90", Offset = "0x492390", VA = "0x180493D90", Slot = "72")]
	protected override void AnimProduce()
	{
		base.AnimProduce();
		UltimateSunMagnet.<SunRepair>d__3 <SunRepair>d__;
		<SunRepair>d__.<>1__state = (int)((ulong)0L);
		<SunRepair>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<SunRepair>d__);
	}

	// Token: 0x060015CD RID: 5581 RVA: 0x00078FC4 File Offset: 0x000771C4
	[Token(Token = "0x60015CD")]
	[Address(RVA = "0x493E60", Offset = "0x492460", VA = "0x180493E60")]
	private IEnumerator SunRepair()
	{
		UltimateSunMagnet.<SunRepair>d__3 <SunRepair>d__;
		<SunRepair>d__.<>1__state = (int)((ulong)0L);
		<SunRepair>d__.<>4__this = this;
		return null;
	}

	// Token: 0x060015CE RID: 5582 RVA: 0x00078FE4 File Offset: 0x000771E4
	[Token(Token = "0x60015CE")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public UltimateSunMagnet()
	{
	}
}
