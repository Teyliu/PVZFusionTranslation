using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000364 RID: 868
[Token(Token = "0x2000364")]
public class CherryPot : Pot
{
	// Token: 0x06000FEC RID: 4076 RVA: 0x0005C0F0 File Offset: 0x0005A2F0
	[Token(Token = "0x6000FEC")]
	[Address(RVA = "0x424950", Offset = "0x422F50", VA = "0x180424950")]
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

	// Token: 0x06000FED RID: 4077 RVA: 0x0005C15C File Offset: 0x0005A35C
	[Token(Token = "0x6000FED")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public CherryPot()
	{
	}
}
