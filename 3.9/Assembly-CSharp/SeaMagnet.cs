using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000433 RID: 1075
[Token(Token = "0x2000433")]
public class SeaMagnet : Magnetshroom
{
	// Token: 0x060013D1 RID: 5073 RVA: 0x0006EC18 File Offset: 0x0006CE18
	[Token(Token = "0x60013D1")]
	[Address(RVA = "0x4BBA10", Offset = "0x4BA010", VA = "0x1804BBA10", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.AttributeEvent();
		int num = this.attractTime;
		num++;
		this.attractTime = num;
		if (!this.isGrown)
		{
			Animator anim = this.anim;
			this.isGrown = true;
			anim.SetTrigger("grow");
			GameAPP.PlaySound(56, 0.5f, 1f);
			this.attrackMaxTime = 10f;
		}
	}

	// Token: 0x060013D2 RID: 5074 RVA: 0x0006EC84 File Offset: 0x0006CE84
	[Token(Token = "0x60013D2")]
	[Address(RVA = "0x4BBAE0", Offset = "0x4BA0E0", VA = "0x1804BBAE0")]
	private void Grow()
	{
		Animator anim = this.anim;
		this.isGrown = true;
		anim.SetTrigger("grow");
		GameAPP.PlaySound(56, 0.5f, 1f);
		this.attrackMaxTime = 10f;
	}

	// Token: 0x060013D3 RID: 5075 RVA: 0x0006ECCC File Offset: 0x0006CECC
	[Token(Token = "0x60013D3")]
	[Address(RVA = "0x4BBB80", Offset = "0x4BA180", VA = "0x1804BBB80")]
	public SeaMagnet()
	{
	}

	// Token: 0x04000CE5 RID: 3301
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000CE5")]
	private int attractTime;

	// Token: 0x04000CE6 RID: 3302
	[FieldOffset(Offset = "0x23C")]
	[Token(Token = "0x4000CE6")]
	private bool isGrown;
}
