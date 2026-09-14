using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000753 RID: 1875
[Token(Token = "0x2000753")]
public class AutoWater : GardenEquipment
{
	// Token: 0x06002610 RID: 9744 RVA: 0x000CA008 File Offset: 0x000C8208
	[Token(Token = "0x6002610")]
	[Address(RVA = "0x5D5B70", Offset = "0x5D4170", VA = "0x1805D5B70", Slot = "4")]
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

	// Token: 0x06002611 RID: 9745 RVA: 0x000CA064 File Offset: 0x000C8264
	[Token(Token = "0x6002611")]
	[Address(RVA = "0x5D58C0", Offset = "0x5D3EC0", VA = "0x1805D58C0")]
	public AutoWater()
	{
	}
}
