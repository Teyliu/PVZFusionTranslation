using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200078A RID: 1930
[Token(Token = "0x200078A")]
public class AutoFertilizer : GardenEquipment
{
	// Token: 0x06002733 RID: 10035 RVA: 0x000CEF74 File Offset: 0x000CD174
	[Token(Token = "0x6002733")]
	[Address(RVA = "0x6371D0", Offset = "0x6357D0", VA = "0x1806371D0", Slot = "4")]
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
			}
		}
		while (num != 0);
	}

	// Token: 0x06002734 RID: 10036 RVA: 0x000CEFD0 File Offset: 0x000CD1D0
	[Token(Token = "0x6002734")]
	[Address(RVA = "0x6371C0", Offset = "0x6357C0", VA = "0x1806371C0")]
	public AutoFertilizer()
	{
	}
}
