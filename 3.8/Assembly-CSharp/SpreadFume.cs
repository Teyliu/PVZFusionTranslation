using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000563 RID: 1379
[Token(Token = "0x2000563")]
public class SpreadFume : Plant
{
	// Token: 0x060019AA RID: 6570 RVA: 0x0008A750 File Offset: 0x00088950
	[Token(Token = "0x60019AA")]
	[Address(RVA = "0x4E4C10", Offset = "0x4E3210", VA = "0x1804E4C10", Slot = "15")]
	protected override void Start()
	{
		int num2;
		uint num3;
		do
		{
			base.Start();
			int num = 0;
			base.Die((Plant.DieReason)num);
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow);
			num2 = 0;
			bool flag;
			if (flag)
			{
				num3 += (uint)1;
			}
		}
		while (num2 != 0);
		if (num2 != 0)
		{
			if (num2 != 0)
			{
				if (num3 != (uint)1)
				{
					goto IL_009D;
				}
				CreatePlant instance = CreatePlant.Instance;
				CreatePlant instance2 = CreatePlant.Instance;
				CreatePlant instance3 = CreatePlant.Instance;
				CreatePlant instance4 = CreatePlant.Instance;
				CreatePlant instance5 = CreatePlant.Instance;
				CreatePlant instance6 = CreatePlant.Instance;
			}
			CreatePlant instance7 = CreatePlant.Instance;
			CreatePlant instance8 = CreatePlant.Instance;
			CreatePlant instance9 = CreatePlant.Instance;
		}
		CreatePlant instance10 = CreatePlant.Instance;
		IL_009D:
		CreatePlant instance11 = CreatePlant.Instance;
	}

	// Token: 0x060019AB RID: 6571 RVA: 0x0008A814 File Offset: 0x00088A14
	[Token(Token = "0x60019AB")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public SpreadFume()
	{
	}
}
