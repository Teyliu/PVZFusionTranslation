using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006E8 RID: 1768
[Token(Token = "0x20006E8")]
public class SuperPolevaulter : PolevaulterZombie
{
	// Token: 0x060022EE RID: 8942 RVA: 0x000B7540 File Offset: 0x000B5740
	[Token(Token = "0x60022EE")]
	[Address(RVA = "0x57C080", Offset = "0x57A680", VA = "0x18057C080", Slot = "17")]
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

	// Token: 0x060022EF RID: 8943 RVA: 0x000B758C File Offset: 0x000B578C
	[Token(Token = "0x60022EF")]
	[Address(RVA = "0x57C110", Offset = "0x57A710", VA = "0x18057C110", Slot = "77")]
	protected override void JumpFail()
	{
		base.JumpFail();
	}

	// Token: 0x060022F0 RID: 8944 RVA: 0x000B75A0 File Offset: 0x000B57A0
	[Token(Token = "0x60022F0")]
	[Address(RVA = "0x57C130", Offset = "0x57A730", VA = "0x18057C130", Slot = "75")]
	public override void JumpOver()
	{
		base.JumpOver();
		this.uniqueSpeed = 1f;
	}

	// Token: 0x060022F1 RID: 8945 RVA: 0x000B75C0 File Offset: 0x000B57C0
	[Token(Token = "0x60022F1")]
	[Address(RVA = "0x53A440", Offset = "0x538A40", VA = "0x18053A440")]
	public SuperPolevaulter()
	{
	}

	// Token: 0x04001150 RID: 4432
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x4001150")]
	private float moreSpeed;
}
