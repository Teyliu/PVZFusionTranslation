using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003C9 RID: 969
[Token(Token = "0x20003C9")]
public class IcePot : Pot
{
	// Token: 0x060011C1 RID: 4545 RVA: 0x00064384 File Offset: 0x00062584
	[Token(Token = "0x60011C1")]
	[Address(RVA = "0x495340", Offset = "0x493940", VA = "0x180495340", Slot = "16")]
	protected override void Update()
	{
		int num;
		do
		{
			base.Update();
			if (!base.Active)
			{
				break;
			}
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow);
			num = 0;
			bool flag;
			if (flag)
			{
				if (flag > true)
				{
					if (flag)
					{
						float deltaTime = Time.deltaTime;
						this.coolTimer = deltaTime;
						if (deltaTime > 10f)
						{
							this.coolTimer = (float)num;
							CreatePlant instance = CreatePlant.Instance;
						}
					}
					while (!flag)
					{
					}
					float deltaTime2 = Time.deltaTime;
					this.coolTimer = deltaTime2;
					if (deltaTime2 > 10f)
					{
						this.coolTimer = (float)num;
						CreatePlant instance2 = CreatePlant.Instance;
						int num2 = 0;
						Plant plant;
						if (plant != num2)
						{
						}
					}
				}
				if (flag)
				{
					float deltaTime3 = Time.deltaTime;
					this.coolTimer = deltaTime3;
					if (deltaTime3 > 10f)
					{
						this.coolTimer = (float)num;
						CreatePlant instance3 = CreatePlant.Instance;
					}
				}
				while (!flag)
				{
				}
				float deltaTime4 = Time.deltaTime;
				this.coolTimer = deltaTime4;
				if (deltaTime4 > 10f)
				{
					this.coolTimer = (float)num;
					CreatePlant instance4 = CreatePlant.Instance;
				}
			}
		}
		while (num != 0);
	}

	// Token: 0x060011C2 RID: 4546 RVA: 0x000644D4 File Offset: 0x000626D4
	[Token(Token = "0x60011C2")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public IcePot()
	{
	}

	// Token: 0x04000C21 RID: 3105
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000C21")]
	private float coolTimer;
}
