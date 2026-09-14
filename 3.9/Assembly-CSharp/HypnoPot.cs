using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003B8 RID: 952
[Token(Token = "0x20003B8")]
public class HypnoPot : Pot
{
	// Token: 0x0600117C RID: 4476 RVA: 0x00062E90 File Offset: 0x00061090
	[Token(Token = "0x600117C")]
	[Address(RVA = "0x48FDD0", Offset = "0x48E3D0", VA = "0x18048FDD0", Slot = "17")]
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
					ulong num3;
					if (num3 != (ulong)0L)
					{
					}
				}
				num++;
			}
			this.a = num != 0;
		}
	}

	// Token: 0x0600117D RID: 4477 RVA: 0x00062F08 File Offset: 0x00061108
	[Token(Token = "0x600117D")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public HypnoPot()
	{
	}

	// Token: 0x04000C0E RID: 3086
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000C0E")]
	private bool a;
}
