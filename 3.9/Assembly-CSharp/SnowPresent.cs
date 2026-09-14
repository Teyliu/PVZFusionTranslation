using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000440 RID: 1088
[Token(Token = "0x2000440")]
public class SnowPresent : Present
{
	// Token: 0x06001404 RID: 5124 RVA: 0x0006F754 File Offset: 0x0006D954
	[Token(Token = "0x6001404")]
	[Address(RVA = "0x4BDCF0", Offset = "0x4BC2F0", VA = "0x1804BDCF0", Slot = "68")]
	public override void AnimEvent()
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		int num = 0;
		base.Die((Plant.DieReason)num);
		List<PlantType> list = new List();
		Board board = this.board;
		List<PlantType> allPlantTypes = Lawnf.GetAllPlantTypes();
		HashSet<PlantType> baiscPlants = CoreEnums.baiscPlants;
		list.AddRange(baiscPlants);
		GridSystem gridSystem = this.board.gridSystem;
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		BoxType boxType = gridSystem.GetGrid(thePlantColumn, thePlantRow).boxType;
		if (SnowPresent.<>c.<>9__0_0 != 0)
		{
		}
		bool flag = boxType == BoxType.Water;
		Predicate<PlantType> predicate = delegate(PlantType p)
		{
			bool flag2;
			bool flag3;
			bool flag4;
			bool flag5;
			bool flag6;
			bool flag7;
			bool flag8;
			bool flag9;
			bool flag10;
			return flag2 || flag3 || flag4 || flag5 || flag6 || flag7 || flag8 || flag9 || flag10;
		};
		SnowPresent.<>c.<>9__0_0 = predicate;
		int num2 = list.RemoveAll(predicate);
		if (flag)
		{
			Predicate<PlantType> predicate2;
			if (SnowPresent.<>c.<>9__0_1 == 0)
			{
				predicate2 = delegate(PlantType p)
				{
					bool flag11;
					bool flag12;
					return flag11 || flag12;
				};
				SnowPresent.<>c.<>9__0_1 = predicate2;
			}
			int num3 = list.RemoveAll(predicate2);
		}
		int num4 = list._size;
		num4 = global::UnityEngine.Random.Range(0, num4);
		PlantType plantType = list[num4];
		int thePlantColumn2 = this.thePlantColumn;
		int num5 = (int)plantType;
		num5 += num5;
		if (num5 > 10000)
		{
		}
	}

	// Token: 0x06001405 RID: 5125 RVA: 0x0006F878 File Offset: 0x0006DA78
	[Token(Token = "0x6001405")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public SnowPresent()
	{
	}
}
