using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200078C RID: 1932
[Token(Token = "0x200078C")]
public class AutoWater : GardenEquipment
{
	// Token: 0x06002737 RID: 10039 RVA: 0x000CF078 File Offset: 0x000CD278
	[Token(Token = "0x6002737")]
	[Address(RVA = "0x6375D0", Offset = "0x635BD0", VA = "0x1806375D0", Slot = "4")]
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

	// Token: 0x06002738 RID: 10040 RVA: 0x000CF0D4 File Offset: 0x000CD2D4
	[Token(Token = "0x6002738")]
	[Address(RVA = "0x6371C0", Offset = "0x6357C0", VA = "0x1806371C0")]
	public AutoWater()
	{
	}
}
