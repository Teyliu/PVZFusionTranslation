using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000789 RID: 1929
[Token(Token = "0x2000789")]
public class AutoBugSpray : GardenEquipment
{
	// Token: 0x06002731 RID: 10033 RVA: 0x000CEEE0 File Offset: 0x000CD0E0
	[Token(Token = "0x6002731")]
	[Address(RVA = "0x636F10", Offset = "0x635510", VA = "0x180636F10", Slot = "4")]
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

	// Token: 0x06002732 RID: 10034 RVA: 0x000CEF60 File Offset: 0x000CD160
	[Token(Token = "0x6002732")]
	[Address(RVA = "0x6371C0", Offset = "0x6357C0", VA = "0x1806371C0")]
	public AutoBugSpray()
	{
	}
}
