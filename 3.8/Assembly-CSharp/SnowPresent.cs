using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000421 RID: 1057
[Token(Token = "0x2000421")]
public class SnowPresent : Present
{
	// Token: 0x0600137A RID: 4986 RVA: 0x0006D4AC File Offset: 0x0006B6AC
	[Token(Token = "0x600137A")]
	[Address(RVA = "0x466D00", Offset = "0x465300", VA = "0x180466D00", Slot = "69")]
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

	// Token: 0x0600137B RID: 4987 RVA: 0x0006D5D0 File Offset: 0x0006B7D0
	[Token(Token = "0x600137B")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public SnowPresent()
	{
	}
}
