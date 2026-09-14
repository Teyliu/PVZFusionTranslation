using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000650 RID: 1616
[Token(Token = "0x2000650")]
public class Driver_b : Driver_a
{
	// Token: 0x06001EC0 RID: 7872 RVA: 0x000A444C File Offset: 0x000A264C
	[Token(Token = "0x6001EC0")]
	[Address(RVA = "0x53F270", Offset = "0x53D870", VA = "0x18053F270", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		base.DieParticle();
		Transform axis = this.axis;
		CreateZombie instance = CreateZombie.Instance;
	}

	// Token: 0x06001EC1 RID: 7873 RVA: 0x000A4474 File Offset: 0x000A2674
	[Token(Token = "0x6001EC1")]
	[Address(RVA = "0x53F220", Offset = "0x53D820", VA = "0x18053F220")]
	public Driver_b()
	{
	}
}
