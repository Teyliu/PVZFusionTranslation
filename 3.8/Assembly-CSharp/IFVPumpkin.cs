using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003BD RID: 957
[Token(Token = "0x20003BD")]
public class IFVPumpkin : Pumpkin
{
	// Token: 0x06001182 RID: 4482 RVA: 0x000634E0 File Offset: 0x000616E0
	[Token(Token = "0x6001182")]
	[Address(RVA = "0x4433D0", Offset = "0x4419D0", VA = "0x1804433D0", Slot = "16")]
	protected override void Update()
	{
		if (this.temp)
		{
			int num = 0;
			base.Die((Plant.DieReason)num);
		}
		base.Update();
	}

	// Token: 0x06001183 RID: 4483 RVA: 0x00063508 File Offset: 0x00061708
	[Token(Token = "0x6001183")]
	[Address(RVA = "0x443250", Offset = "0x441850", VA = "0x180443250", Slot = "15")]
	protected override void Start()
	{
		ulong num;
		do
		{
			base.Start();
			if (!Lawnf.TravelAdvanced((AdvBuff)((uint)34)))
			{
				break;
			}
			List<Plant> plants = MagnetSystem.GetPlants(this);
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06001184 RID: 4484 RVA: 0x00063544 File Offset: 0x00061744
	[Token(Token = "0x6001184")]
	[Address(RVA = "0x4431F0", Offset = "0x4417F0", VA = "0x1804431F0", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (this.temp)
		{
			Transform axis = this.axis;
			return;
		}
	}

	// Token: 0x06001185 RID: 4485 RVA: 0x0006356C File Offset: 0x0006176C
	[Token(Token = "0x6001185")]
	[Address(RVA = "0x41C050", Offset = "0x41A650", VA = "0x18041C050")]
	public IFVPumpkin()
	{
	}

	// Token: 0x04000BC1 RID: 3009
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000BC1")]
	public bool temp;
}
