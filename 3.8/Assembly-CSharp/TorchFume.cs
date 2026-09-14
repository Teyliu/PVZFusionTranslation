using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000593 RID: 1427
[Token(Token = "0x2000593")]
public class TorchFume : TorchWood
{
	// Token: 0x06001A66 RID: 6758 RVA: 0x0008E014 File Offset: 0x0008C214
	[Token(Token = "0x6001A66")]
	[Address(RVA = "0x4F1960", Offset = "0x4EFF60", VA = "0x1804F1960", Slot = "69")]
	protected override void OnTriggerEnter2D(Collider2D collision)
	{
		bool flag;
		bool flag2;
		if (flag && flag2)
		{
			if (this != 0)
			{
				while (collision != (ulong)15L)
				{
				}
				return;
			}
			int attributeCount = this.attributeCount;
			this.attributeCount = attributeCount;
			if (attributeCount > 300)
			{
				this.attributeCount = (int)((ulong)300L);
			}
			this.anim.SetTrigger("shoot");
		}
	}

	// Token: 0x06001A67 RID: 6759 RVA: 0x0008E070 File Offset: 0x0008C270
	[Token(Token = "0x6001A67")]
	[Address(RVA = "0x4F18B0", Offset = "0x4EFEB0", VA = "0x1804F18B0")]
	private void AnimShoot()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001A68 RID: 6760 RVA: 0x0008E090 File Offset: 0x0008C290
	[Token(Token = "0x6001A68")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public TorchFume()
	{
	}
}
