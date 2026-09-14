using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003B5 RID: 949
[Token(Token = "0x20003B5")]
public class IcePot : Pot
{
	// Token: 0x06001165 RID: 4453 RVA: 0x00062D64 File Offset: 0x00060F64
	[Token(Token = "0x6001165")]
	[Address(RVA = "0x443410", Offset = "0x441A10", VA = "0x180443410", Slot = "16")]
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

	// Token: 0x06001166 RID: 4454 RVA: 0x00062EB4 File Offset: 0x000610B4
	[Token(Token = "0x6001166")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public IcePot()
	{
	}

	// Token: 0x04000BBB RID: 3003
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000BBB")]
	private float coolTimer;
}
