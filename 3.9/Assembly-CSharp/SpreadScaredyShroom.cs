using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000594 RID: 1428
[Token(Token = "0x2000594")]
public class SpreadScaredyShroom : Plant
{
	// Token: 0x06001A8C RID: 6796 RVA: 0x0008E8DC File Offset: 0x0008CADC
	[Token(Token = "0x6001A8C")]
	[Address(RVA = "0x543690", Offset = "0x541C90", VA = "0x180543690", Slot = "15")]
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

	// Token: 0x06001A8D RID: 6797 RVA: 0x0008E9A0 File Offset: 0x0008CBA0
	[Token(Token = "0x6001A8D")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public SpreadScaredyShroom()
	{
	}
}
