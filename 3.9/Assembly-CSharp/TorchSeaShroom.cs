using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005C6 RID: 1478
[Token(Token = "0x20005C6")]
public class TorchSeaShroom : TorchWood
{
	// Token: 0x06001B51 RID: 6993 RVA: 0x000925A4 File Offset: 0x000907A4
	[Token(Token = "0x6001B51")]
	[Address(RVA = "0x550620", Offset = "0x54EC20", VA = "0x180550620", Slot = "68")]
	protected override void OnTriggerEnter2D(Collider2D collision)
	{
		int num = 0;
		if (collision.TryGetComponent<Bullet>(num))
		{
			bool flag = base.CheckFire(num);
			if (flag)
			{
				if (flag > true)
				{
					if (flag)
					{
						BoardAction boardAction = this.board.boardAction;
					}
					if (!flag)
					{
						goto IL_005F;
					}
					BoardAction boardAction2 = this.board.boardAction;
				}
				if (!flag)
				{
					BoardAction boardAction3 = this.board.boardAction;
				}
				if (flag)
				{
					BoardAction boardAction4 = this.board.boardAction;
				}
				IL_005F:
				if (this.count > 50)
				{
					this.count = num;
					this.Summon();
				}
			}
		}
	}

	// Token: 0x06001B52 RID: 6994 RVA: 0x00092630 File Offset: 0x00090830
	[Token(Token = "0x6001B52")]
	[Address(RVA = "0x5507C0", Offset = "0x54EDC0", VA = "0x1805507C0")]
	private void Summon()
	{
		int num = this.thePlantColumn;
		int thePlantRow = this.thePlantRow;
		num++;
		List<Plant> list = Lawnf.Get1x1Plants(num, thePlantRow);
		Func<Plant, bool> <>9__2_ = TorchSeaShroom.<>c.<>9__2_0;
		if (<>9__2_ == 0)
		{
			TorchSeaShroom.<>c.<>9__2_0 = (Plant p) => p.thePlantType == PlantType.FireSeaShroom;
		}
		Plant plant = Enumerable.FirstOrDefault<Plant>(Enumerable.Where<Plant>(list, <>9__2_));
		int num2 = 0;
		if (!(plant == num2))
		{
			Transform axis = plant.axis;
			Vector3 vector;
			float z = vector.z;
			Transform transform = plant.transform;
			Dictionary<PlantDamageAdder, float> damageAdder = plant.damageAdder;
			float num4;
			float num3 = num4 * 0.04f * 0.25f;
			return;
		}
		CreatePlant instance = CreatePlant.Instance;
		throw new NullReferenceException();
	}

	// Token: 0x06001B53 RID: 6995 RVA: 0x000926E0 File Offset: 0x000908E0
	[Token(Token = "0x6001B53")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public TorchSeaShroom()
	{
	}

	// Token: 0x04000F25 RID: 3877
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000F25")]
	private int count;
}
