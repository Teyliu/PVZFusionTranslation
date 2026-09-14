using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000595 RID: 1429
[Token(Token = "0x2000595")]
public class TorchSeaShroom : TorchWood
{
	// Token: 0x06001A6B RID: 6763 RVA: 0x0008E1F8 File Offset: 0x0008C3F8
	[Token(Token = "0x6001A6B")]
	[Address(RVA = "0x4F1AA0", Offset = "0x4F00A0", VA = "0x1804F1AA0", Slot = "69")]
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

	// Token: 0x06001A6C RID: 6764 RVA: 0x0008E284 File Offset: 0x0008C484
	[Token(Token = "0x6001A6C")]
	[Address(RVA = "0x4F1C40", Offset = "0x4F0240", VA = "0x1804F1C40")]
	private void Summon()
	{
		int num = this.thePlantColumn;
		int thePlantRow = this.thePlantRow;
		num++;
		List<Plant> list = Lawnf.Get1x1Plants(num, thePlantRow);
		Func<Plant, bool> <>9__2_ = TorchSeaShroom.<>c.<>9__2_0;
		if (<>9__2_ == 0)
		{
			Func<Plant, bool> func;
			TorchSeaShroom.<>c.<>9__2_0 = func;
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

	// Token: 0x06001A6D RID: 6765 RVA: 0x0008E324 File Offset: 0x0008C524
	[Token(Token = "0x6001A6D")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public TorchSeaShroom()
	{
	}

	// Token: 0x04000E66 RID: 3686
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000E66")]
	private int count;
}
