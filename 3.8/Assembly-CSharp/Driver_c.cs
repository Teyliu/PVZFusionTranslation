using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000651 RID: 1617
[Token(Token = "0x2000651")]
public class Driver_c : Driver_b
{
	// Token: 0x06001EC2 RID: 7874 RVA: 0x000A4488 File Offset: 0x000A2688
	[Token(Token = "0x6001EC2")]
	[Address(RVA = "0x53F340", Offset = "0x53D940", VA = "0x18053F340", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		base.DieParticle();
		Transform axis = this.axis;
		CreateZombie instance = CreateZombie.Instance;
	}

	// Token: 0x06001EC3 RID: 7875 RVA: 0x000A44B0 File Offset: 0x000A26B0
	[Token(Token = "0x6001EC3")]
	[Address(RVA = "0x53F220", Offset = "0x53D820", VA = "0x18053F220")]
	public Driver_c()
	{
	}
}
