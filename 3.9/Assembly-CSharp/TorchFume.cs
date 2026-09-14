using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005C4 RID: 1476
[Token(Token = "0x20005C4")]
public class TorchFume : TorchWood
{
	// Token: 0x06001B4C RID: 6988 RVA: 0x000923C0 File Offset: 0x000905C0
	[Token(Token = "0x6001B4C")]
	[Address(RVA = "0x5504E0", Offset = "0x54EAE0", VA = "0x1805504E0", Slot = "68")]
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

	// Token: 0x06001B4D RID: 6989 RVA: 0x0009241C File Offset: 0x0009061C
	[Token(Token = "0x6001B4D")]
	[Address(RVA = "0x550430", Offset = "0x54EA30", VA = "0x180550430")]
	private void AnimShoot()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001B4E RID: 6990 RVA: 0x0009243C File Offset: 0x0009063C
	[Token(Token = "0x6001B4E")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public TorchFume()
	{
	}
}
