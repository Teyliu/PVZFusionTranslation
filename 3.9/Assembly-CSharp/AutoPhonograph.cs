using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200078B RID: 1931
[Token(Token = "0x200078B")]
public class AutoPhonograph : GardenEquipment
{
	// Token: 0x06002735 RID: 10037 RVA: 0x000CEFE4 File Offset: 0x000CD1E4
	[Token(Token = "0x6002735")]
	[Address(RVA = "0x637320", Offset = "0x635920", VA = "0x180637320", Slot = "4")]
	protected override void TimeUp()
	{
		int num;
		do
		{
			Garden garden = this.garden;
			EquipmentData data = this.data;
			int theColumn = data.theColumn;
			int theRow = data.theRow;
			num = 0;
			int level = data.level;
			List<BigGardenPlant> plants = garden.GetPlants(theColumn, theRow, level);
			bool flag;
			if (flag)
			{
				long realTime = GameAPP.RealTime;
				uint num2;
				GameAPP.PlaySound((int)num2, 0.5f, 1f);
			}
		}
		while (num != 0);
	}

	// Token: 0x06002736 RID: 10038 RVA: 0x000CF064 File Offset: 0x000CD264
	[Token(Token = "0x6002736")]
	[Address(RVA = "0x6371C0", Offset = "0x6357C0", VA = "0x1806371C0")]
	public AutoPhonograph()
	{
	}
}
