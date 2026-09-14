using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200051A RID: 1306
[Token(Token = "0x200051A")]
public class FlyingThreePeater_sp : SuperThreePeater_sp
{
	// Token: 0x06001878 RID: 6264 RVA: 0x00084C80 File Offset: 0x00082E80
	[Token(Token = "0x6001878")]
	[Address(RVA = "0x5242B0", Offset = "0x5228B0", VA = "0x1805242B0", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (reason == Plant.DieReason.ByShovel)
		{
			Transform shoot = this.shoot;
			return;
		}
	}

	// Token: 0x06001879 RID: 6265 RVA: 0x00084CA0 File Offset: 0x00082EA0
	[Token(Token = "0x6001879")]
	[Address(RVA = "0x5243D0", Offset = "0x5229D0", VA = "0x1805243D0", Slot = "72")]
	protected override void Zhnahou8()
	{
	}

	// Token: 0x0600187A RID: 6266 RVA: 0x00084CB0 File Offset: 0x00082EB0
	[Token(Token = "0x600187A")]
	[Address(RVA = "0x524310", Offset = "0x522910", VA = "0x180524310", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x0600187B RID: 6267 RVA: 0x00084CD0 File Offset: 0x00082ED0
	[Token(Token = "0x600187B")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public FlyingThreePeater_sp()
	{
	}
}
