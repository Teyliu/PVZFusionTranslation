using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003A4 RID: 932
[Token(Token = "0x20003A4")]
public class HypnoPot : Pot
{
	// Token: 0x06001120 RID: 4384 RVA: 0x00061838 File Offset: 0x0005FA38
	[Token(Token = "0x6001120")]
	[Address(RVA = "0x43C580", Offset = "0x43AB80", VA = "0x18043C580", Slot = "17")]
	protected override void FixedUpdate()
	{
		int num = 0;
		base.FixedUpdate();
		if (base.Active)
		{
			if ((this.a ? 1 : 0) == num)
			{
				this.a = true;
				return;
			}
			Transform axis = this.axis;
			int num2 = this.plantLayer;
			Collider2D[] array;
			if (num < array.Length)
			{
				bool flag;
				if (flag)
				{
					int thePlantRow = this.thePlantRow;
					bool flag2;
					if (flag2)
					{
					}
				}
				num++;
			}
			this.a = num != 0;
		}
	}

	// Token: 0x06001121 RID: 4385 RVA: 0x000618AC File Offset: 0x0005FAAC
	[Token(Token = "0x6001121")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public HypnoPot()
	{
	}

	// Token: 0x04000BA8 RID: 2984
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000BA8")]
	private bool a;
}
