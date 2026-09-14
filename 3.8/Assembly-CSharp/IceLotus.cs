using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003B2 RID: 946
[Token(Token = "0x20003B2")]
public class IceLotus : Plant
{
	// Token: 0x06001157 RID: 4439 RVA: 0x00062A3C File Offset: 0x00060C3C
	[Token(Token = "0x6001157")]
	[Address(RVA = "0x440D20", Offset = "0x43F320", VA = "0x180440D20", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 10f;
		if (AdvantureConfig.data.GetResult((AdvantureLevel)((uint)64), (MissionResult)((uint)1)))
		{
			float attributeSpeed = this.attributeSpeed;
			this.attributeSpeed = attributeSpeed;
		}
	}

	// Token: 0x06001158 RID: 4440 RVA: 0x00062A80 File Offset: 0x00060C80
	[Token(Token = "0x6001158")]
	[Address(RVA = "0x440C80", Offset = "0x43F280", VA = "0x180440C80", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		base.AttributeCountdown = 10f;
		int num = this.attributeCount;
		num++;
		this.attributeCount = num;
		Animator anim = this.anim;
		num += -5;
		this.attributeCount = num;
		anim.SetTrigger("recover");
		throw new NullReferenceException();
	}

	// Token: 0x06001159 RID: 4441 RVA: 0x00062AD4 File Offset: 0x00060CD4
	[Token(Token = "0x6001159")]
	[Address(RVA = "0x440DD0", Offset = "0x43F3D0", VA = "0x180440DD0", Slot = "21")]
	public override void Charge()
	{
		int num = this.attributeCount;
		num++;
		this.attributeCount = num;
		Animator anim = this.anim;
		num += -5;
		this.attributeCount = num;
		anim.SetTrigger("recover");
		throw new NullReferenceException();
	}

	// Token: 0x0600115A RID: 4442 RVA: 0x00062B18 File Offset: 0x00060D18
	[Token(Token = "0x600115A")]
	[Address(RVA = "0x4409C0", Offset = "0x43EFC0", VA = "0x1804409C0", Slot = "69")]
	protected virtual void AnimRecover()
	{
		ulong num;
		do
		{
			AdvantureMission.TryAddCount((AdvantureLevel)((uint)64));
			bool result = AdvantureConfig.data.GetResult((AdvantureLevel)((uint)64), (MissionResult)((uint)2));
			int thePlantColumn = this.thePlantColumn;
			int thePlantRow = this.thePlantRow;
			if (result)
			{
				List<Plant> rangePlants = Lawnf.GetRangePlants(thePlantColumn, thePlantRow, 2);
			}
			List<Plant> list = Lawnf.Get3x3Plants(thePlantColumn, thePlantRow);
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
		ParticleManager instance = ParticleManager.Instance;
		int num2 = 0;
		int num3 = 0;
		ulong num4;
		Particle particle = instance.SetParticle((ParticleType)((uint)85), num2, 1, num4 != 0UL, (float)num3);
		GameAPP.PlaySound(94, 0.5f, 1f);
	}

	// Token: 0x0600115B RID: 4443 RVA: 0x00062BB4 File Offset: 0x00060DB4
	[Token(Token = "0x600115B")]
	[Address(RVA = "0x440E50", Offset = "0x43F450", VA = "0x180440E50", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x0600115C RID: 4444 RVA: 0x00062BD4 File Offset: 0x00060DD4
	[Token(Token = "0x600115C")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public IceLotus()
	{
	}
}
