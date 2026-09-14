using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003EE RID: 1006
[Token(Token = "0x20003EE")]
public class NutPumpkin : Pumpkin
{
	// Token: 0x06001292 RID: 4754 RVA: 0x00068AA4 File Offset: 0x00066CA4
	[Token(Token = "0x6001292")]
	[Address(RVA = "0x456CF0", Offset = "0x4552F0", VA = "0x180456CF0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCount = (int)((ulong)3L);
	}

	// Token: 0x06001293 RID: 4755 RVA: 0x00068AC0 File Offset: 0x00066CC0
	[Token(Token = "0x6001293")]
	[Address(RVA = "0x456D10", Offset = "0x455310", VA = "0x180456D10", Slot = "16")]
	protected override void Update()
	{
		int num3;
		uint num4;
		do
		{
			int num = 0;
			base.Update();
			if (!base.Active)
			{
				return;
			}
			Transform transform = this.nut.transform;
			Transform transform2 = this.nut.transform;
			float num2 = Time.deltaTime * 0.02f;
			Transform transform3 = this.nut.transform;
			Transform transform4 = this.nut.transform;
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get3x3Plants(this.thePlantColumn, thePlantRow);
			num3 = 0;
			bool flag;
			if (flag)
			{
				bool flag2 = num != this;
				while (!flag2)
				{
				}
				if ((flag2 ? 1U : 0U) > num4)
				{
				}
				num4 -= (flag2 ? 1U : 0U);
			}
		}
		while (num3 != 0);
		if (num4 == (uint)1000)
		{
		}
	}

	// Token: 0x06001294 RID: 4756 RVA: 0x00068B84 File Offset: 0x00066D84
	[Token(Token = "0x6001294")]
	[Address(RVA = "0x41C050", Offset = "0x41A650", VA = "0x18041C050")]
	public NutPumpkin()
	{
	}

	// Token: 0x04000C1E RID: 3102
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C1E")]
	public GameObject nut;
}
