using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000750 RID: 1872
[Token(Token = "0x2000750")]
public class AutoBugSpray : GardenEquipment
{
	// Token: 0x0600260A RID: 9738 RVA: 0x000C9EB8 File Offset: 0x000C80B8
	[Token(Token = "0x600260A")]
	[Address(RVA = "0x5D5770", Offset = "0x5D3D70", VA = "0x1805D5770", Slot = "4")]
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

	// Token: 0x0600260B RID: 9739 RVA: 0x000C9F14 File Offset: 0x000C8114
	[Token(Token = "0x600260B")]
	[Address(RVA = "0x5D58C0", Offset = "0x5D3EC0", VA = "0x1805D58C0")]
	public AutoBugSpray()
	{
	}
}
