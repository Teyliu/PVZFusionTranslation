using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000751 RID: 1873
[Token(Token = "0x2000751")]
public class AutoFertilizer : GardenEquipment
{
	// Token: 0x0600260C RID: 9740 RVA: 0x000C9F28 File Offset: 0x000C8128
	[Token(Token = "0x600260C")]
	[Address(RVA = "0x5D58D0", Offset = "0x5D3ED0", VA = "0x1805D58D0", Slot = "4")]
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

	// Token: 0x0600260D RID: 9741 RVA: 0x000C9F84 File Offset: 0x000C8184
	[Token(Token = "0x600260D")]
	[Address(RVA = "0x5D58C0", Offset = "0x5D3EC0", VA = "0x1805D58C0")]
	public AutoFertilizer()
	{
	}
}
