using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003D1 RID: 977
[Token(Token = "0x20003D1")]
public class IFVPumpkin : Pumpkin
{
	// Token: 0x060011DE RID: 4574 RVA: 0x00064B00 File Offset: 0x00062D00
	[Token(Token = "0x60011DE")]
	[Address(RVA = "0x491DA0", Offset = "0x4903A0", VA = "0x180491DA0", Slot = "16")]
	protected override void Update()
	{
		if (this.temp)
		{
			int num = 0;
			base.Die((Plant.DieReason)num);
		}
		base.Update();
	}

	// Token: 0x060011DF RID: 4575 RVA: 0x00064B28 File Offset: 0x00062D28
	[Token(Token = "0x60011DF")]
	[Address(RVA = "0x491C20", Offset = "0x490220", VA = "0x180491C20", Slot = "15")]
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

	// Token: 0x060011E0 RID: 4576 RVA: 0x00064B64 File Offset: 0x00062D64
	[Token(Token = "0x60011E0")]
	[Address(RVA = "0x491BC0", Offset = "0x4901C0", VA = "0x180491BC0", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (this.temp)
		{
			Transform axis = this.axis;
			return;
		}
	}

	// Token: 0x060011E1 RID: 4577 RVA: 0x00064B8C File Offset: 0x00062D8C
	[Token(Token = "0x60011E1")]
	[Address(RVA = "0x472EF0", Offset = "0x4714F0", VA = "0x180472EF0")]
	public IFVPumpkin()
	{
	}

	// Token: 0x04000C27 RID: 3111
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C27")]
	public bool temp;
}
