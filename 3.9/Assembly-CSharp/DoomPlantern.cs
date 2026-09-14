using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200038C RID: 908
[Token(Token = "0x200038C")]
public class DoomPlantern : IcePlantern
{
	// Token: 0x060010AC RID: 4268 RVA: 0x0005F090 File Offset: 0x0005D290
	[Token(Token = "0x60010AC")]
	[Address(RVA = "0x481A70", Offset = "0x480070", VA = "0x180481A70")]
	public void ChargeByLight(int value)
	{
	}

	// Token: 0x060010AD RID: 4269 RVA: 0x0005F0A0 File Offset: 0x0005D2A0
	[Token(Token = "0x60010AD")]
	[Address(RVA = "0x4818E0", Offset = "0x47FEE0", VA = "0x1804818E0", Slot = "39")]
	protected override void AttributeEvent()
	{
		int num2;
		do
		{
			int num = 0;
			base.AttributeCountdown = 3f;
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get3x3Plants(this.thePlantColumn, thePlantRow);
			num2 = 0;
			bool flag;
			if (flag)
			{
				while (num == 0)
				{
				}
				while (num == 0)
				{
				}
			}
		}
		while (num2 != 0);
	}

	// Token: 0x060010AE RID: 4270 RVA: 0x0005F0E8 File Offset: 0x0005D2E8
	[Token(Token = "0x60010AE")]
	[Address(RVA = "0x481A90", Offset = "0x480090", VA = "0x180481A90")]
	public DoomPlantern()
	{
	}
}
