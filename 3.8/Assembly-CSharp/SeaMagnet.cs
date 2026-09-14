using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000416 RID: 1046
[Token(Token = "0x2000416")]
public class SeaMagnet : Magnetshroom
{
	// Token: 0x06001351 RID: 4945 RVA: 0x0006CBCC File Offset: 0x0006ADCC
	[Token(Token = "0x6001351")]
	[Address(RVA = "0x464F60", Offset = "0x463560", VA = "0x180464F60", Slot = "40")]
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

	// Token: 0x06001352 RID: 4946 RVA: 0x0006CC38 File Offset: 0x0006AE38
	[Token(Token = "0x6001352")]
	[Address(RVA = "0x465030", Offset = "0x463630", VA = "0x180465030")]
	private void Grow()
	{
		Animator anim = this.anim;
		this.isGrown = true;
		anim.SetTrigger("grow");
		GameAPP.PlaySound(56, 0.5f, 1f);
		this.attrackMaxTime = 10f;
	}

	// Token: 0x06001353 RID: 4947 RVA: 0x0006CC80 File Offset: 0x0006AE80
	[Token(Token = "0x6001353")]
	[Address(RVA = "0x4650D0", Offset = "0x4636D0", VA = "0x1804650D0")]
	public SeaMagnet()
	{
	}

	// Token: 0x04000C66 RID: 3174
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000C66")]
	private int attractTime;

	// Token: 0x04000C67 RID: 3175
	[FieldOffset(Offset = "0x23C")]
	[Token(Token = "0x4000C67")]
	private bool isGrown;
}
