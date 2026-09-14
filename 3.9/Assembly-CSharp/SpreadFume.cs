using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000593 RID: 1427
[Token(Token = "0x2000593")]
public class SpreadFume : Plant
{
	// Token: 0x06001A8A RID: 6794 RVA: 0x0008E804 File Offset: 0x0008CA04
	[Token(Token = "0x6001A8A")]
	[Address(RVA = "0x543080", Offset = "0x541680", VA = "0x180543080", Slot = "15")]
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

	// Token: 0x06001A8B RID: 6795 RVA: 0x0008E8C8 File Offset: 0x0008CAC8
	[Token(Token = "0x6001A8B")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public SpreadFume()
	{
	}
}
