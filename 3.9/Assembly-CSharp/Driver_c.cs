using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000687 RID: 1671
[Token(Token = "0x2000687")]
public class Driver_c : Driver_b
{
	// Token: 0x06001FC4 RID: 8132 RVA: 0x000A8BE0 File Offset: 0x000A6DE0
	[Token(Token = "0x6001FC4")]
	[Address(RVA = "0x5A1990", Offset = "0x59FF90", VA = "0x1805A1990", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		base.DieParticle();
		Transform axis = this.axis;
		CreateZombie instance = CreateZombie.Instance;
	}

	// Token: 0x06001FC5 RID: 8133 RVA: 0x000A8C08 File Offset: 0x000A6E08
	[Token(Token = "0x6001FC5")]
	[Address(RVA = "0x5A1870", Offset = "0x59FE70", VA = "0x1805A1870")]
	public Driver_c()
	{
	}
}
