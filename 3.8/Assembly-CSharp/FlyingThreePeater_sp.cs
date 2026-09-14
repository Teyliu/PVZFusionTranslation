using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004F2 RID: 1266
[Token(Token = "0x20004F2")]
public class FlyingThreePeater_sp : SuperThreePeater_sp
{
	// Token: 0x060017B9 RID: 6073 RVA: 0x00081734 File Offset: 0x0007F934
	[Token(Token = "0x60017B9")]
	[Address(RVA = "0x4C8550", Offset = "0x4C6B50", VA = "0x1804C8550", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (reason == Plant.DieReason.ByShovel)
		{
			Transform shoot = this.shoot;
			return;
		}
	}

	// Token: 0x060017BA RID: 6074 RVA: 0x00081754 File Offset: 0x0007F954
	[Token(Token = "0x60017BA")]
	[Address(RVA = "0x4C8670", Offset = "0x4C6C70", VA = "0x1804C8670", Slot = "73")]
	protected override void Zhnahou8()
	{
	}

	// Token: 0x060017BB RID: 6075 RVA: 0x00081764 File Offset: 0x0007F964
	[Token(Token = "0x60017BB")]
	[Address(RVA = "0x4C85B0", Offset = "0x4C6BB0", VA = "0x1804C85B0", Slot = "52")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x060017BC RID: 6076 RVA: 0x00081784 File Offset: 0x0007F984
	[Token(Token = "0x60017BC")]
	[Address(RVA = "0x4C8690", Offset = "0x4C6C90", VA = "0x1804C8690")]
	public FlyingThreePeater_sp()
	{
	}
}
