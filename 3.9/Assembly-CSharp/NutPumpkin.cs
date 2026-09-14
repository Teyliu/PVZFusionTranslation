using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000408 RID: 1032
[Token(Token = "0x2000408")]
public class NutPumpkin : Pumpkin
{
	// Token: 0x06001305 RID: 4869 RVA: 0x0006A850 File Offset: 0x00068A50
	[Token(Token = "0x6001305")]
	[Address(RVA = "0x4AC180", Offset = "0x4AA780", VA = "0x1804AC180", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCount = (int)((ulong)3L);
	}

	// Token: 0x06001306 RID: 4870 RVA: 0x0006A86C File Offset: 0x00068A6C
	[Token(Token = "0x6001306")]
	[Address(RVA = "0x4AC1A0", Offset = "0x4AA7A0", VA = "0x1804AC1A0", Slot = "16")]
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
				bool flag3;
				num4 -= (flag3 ? 1U : 0U);
			}
		}
		while (num3 != 0);
		if (num4 == (uint)1000)
		{
		}
	}

	// Token: 0x06001307 RID: 4871 RVA: 0x0006A930 File Offset: 0x00068B30
	[Token(Token = "0x6001307")]
	[Address(RVA = "0x472EF0", Offset = "0x4714F0", VA = "0x180472EF0")]
	public NutPumpkin()
	{
	}

	// Token: 0x04000C95 RID: 3221
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C95")]
	public GameObject nut;
}
