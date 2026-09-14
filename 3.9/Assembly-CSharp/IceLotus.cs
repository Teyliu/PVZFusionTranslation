using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003C6 RID: 966
[Token(Token = "0x20003C6")]
public class IceLotus : Plant
{
	// Token: 0x060011B3 RID: 4531 RVA: 0x0006405C File Offset: 0x0006225C
	[Token(Token = "0x60011B3")]
	[Address(RVA = "0x494B50", Offset = "0x493150", VA = "0x180494B50", Slot = "10")]
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

	// Token: 0x060011B4 RID: 4532 RVA: 0x000640A0 File Offset: 0x000622A0
	[Token(Token = "0x60011B4")]
	[Address(RVA = "0x494AB0", Offset = "0x4930B0", VA = "0x180494AB0", Slot = "39")]
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

	// Token: 0x060011B5 RID: 4533 RVA: 0x000640F4 File Offset: 0x000622F4
	[Token(Token = "0x60011B5")]
	[Address(RVA = "0x494C00", Offset = "0x493200", VA = "0x180494C00", Slot = "21")]
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

	// Token: 0x060011B6 RID: 4534 RVA: 0x00064138 File Offset: 0x00062338
	[Token(Token = "0x60011B6")]
	[Address(RVA = "0x4947F0", Offset = "0x492DF0", VA = "0x1804947F0", Slot = "68")]
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

	// Token: 0x060011B7 RID: 4535 RVA: 0x000641D4 File Offset: 0x000623D4
	[Token(Token = "0x60011B7")]
	[Address(RVA = "0x494C80", Offset = "0x493280", VA = "0x180494C80", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x060011B8 RID: 4536 RVA: 0x000641F4 File Offset: 0x000623F4
	[Token(Token = "0x60011B8")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public IceLotus()
	{
	}
}
