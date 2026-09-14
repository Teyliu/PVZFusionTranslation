using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000686 RID: 1670
[Token(Token = "0x2000686")]
public class Driver_b : Driver_a
{
	// Token: 0x06001FC2 RID: 8130 RVA: 0x000A8BA4 File Offset: 0x000A6DA4
	[Token(Token = "0x6001FC2")]
	[Address(RVA = "0x5A18C0", Offset = "0x59FEC0", VA = "0x1805A18C0", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		base.DieParticle();
		Transform axis = this.axis;
		CreateZombie instance = CreateZombie.Instance;
	}

	// Token: 0x06001FC3 RID: 8131 RVA: 0x000A8BCC File Offset: 0x000A6DCC
	[Token(Token = "0x6001FC3")]
	[Address(RVA = "0x5A1870", Offset = "0x59FE70", VA = "0x1805A1870")]
	public Driver_b()
	{
	}
}
