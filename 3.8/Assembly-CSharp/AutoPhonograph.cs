using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000752 RID: 1874
[Token(Token = "0x2000752")]
public class AutoPhonograph : GardenEquipment
{
	// Token: 0x0600260E RID: 9742 RVA: 0x000C9F98 File Offset: 0x000C8198
	[Token(Token = "0x600260E")]
	[Address(RVA = "0x5D5A20", Offset = "0x5D4020", VA = "0x1805D5A20", Slot = "4")]
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

	// Token: 0x0600260F RID: 9743 RVA: 0x000C9FF4 File Offset: 0x000C81F4
	[Token(Token = "0x600260F")]
	[Address(RVA = "0x5D58C0", Offset = "0x5D3EC0", VA = "0x1805D58C0")]
	public AutoPhonograph()
	{
	}
}
