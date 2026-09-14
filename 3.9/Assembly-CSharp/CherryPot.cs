using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000374 RID: 884
[Token(Token = "0x2000374")]
public class CherryPot : Pot
{
	// Token: 0x06001038 RID: 4152 RVA: 0x0005D0B0 File Offset: 0x0005B2B0
	[Token(Token = "0x6001038")]
	[Address(RVA = "0x47B630", Offset = "0x479C30", VA = "0x18047B630")]
	public void RecoverAll()
	{
		int num2;
		do
		{
			int num = 0;
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow);
			num2 = 0;
			bool flag;
			if (flag)
			{
				bool flag2;
				if ((flag2 <= true || (!flag2 && !flag2)) && !flag2 && !flag2)
				{
					while (!flag2)
					{
					}
				}
				bool flag3 = num.SetEffect((EffectType)((uint)106), 5f, 0.5f);
			}
		}
		while (num2 != 0);
	}

	// Token: 0x06001039 RID: 4153 RVA: 0x0005D11C File Offset: 0x0005B31C
	[Token(Token = "0x6001039")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public CherryPot()
	{
	}
}
