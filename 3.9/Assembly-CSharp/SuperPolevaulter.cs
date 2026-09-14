using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000720 RID: 1824
[Token(Token = "0x2000720")]
public class SuperPolevaulter : PolevaulterZombie
{
	// Token: 0x0600240A RID: 9226 RVA: 0x000BC388 File Offset: 0x000BA588
	[Token(Token = "0x600240A")]
	[Address(RVA = "0x5F6660", Offset = "0x5F4C60", VA = "0x1805F6660", Slot = "18")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		float num = Time.fixedDeltaTime * 0.1f;
		this.moreSpeed = num;
		if (num > 1f)
		{
			this.moreSpeed = 1f;
		}
		float num2 = this.moreSpeed;
		this.uniqueSpeed = num2;
	}

	// Token: 0x0600240B RID: 9227 RVA: 0x000BC3D4 File Offset: 0x000BA5D4
	[Token(Token = "0x600240B")]
	[Address(RVA = "0x5F66F0", Offset = "0x5F4CF0", VA = "0x1805F66F0", Slot = "79")]
	protected override void JumpFail()
	{
		base.JumpFail();
	}

	// Token: 0x0600240C RID: 9228 RVA: 0x000BC3E8 File Offset: 0x000BA5E8
	[Token(Token = "0x600240C")]
	[Address(RVA = "0x5F6710", Offset = "0x5F4D10", VA = "0x1805F6710", Slot = "77")]
	public override void JumpOver()
	{
		base.JumpOver();
		this.uniqueSpeed = 1f;
	}

	// Token: 0x0600240D RID: 9229 RVA: 0x000BC408 File Offset: 0x000BA608
	[Token(Token = "0x600240D")]
	[Address(RVA = "0x59CA20", Offset = "0x59B020", VA = "0x18059CA20")]
	public SuperPolevaulter()
	{
	}

	// Token: 0x0400121D RID: 4637
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x400121D")]
	private float moreSpeed;
}
