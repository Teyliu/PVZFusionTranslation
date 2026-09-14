using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000564 RID: 1380
[Token(Token = "0x2000564")]
public class SpreadScaredyShroom : Plant
{
	// Token: 0x060019AC RID: 6572 RVA: 0x0008A828 File Offset: 0x00088A28
	[Token(Token = "0x60019AC")]
	[Address(RVA = "0x4E5220", Offset = "0x4E3820", VA = "0x1804E5220", Slot = "15")]
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

	// Token: 0x060019AD RID: 6573 RVA: 0x0008A8EC File Offset: 0x00088AEC
	[Token(Token = "0x60019AD")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public SpreadScaredyShroom()
	{
	}
}
