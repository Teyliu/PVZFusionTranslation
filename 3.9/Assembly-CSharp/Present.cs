using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000421 RID: 1057
[Token(Token = "0x2000421")]
public class Present : Plant
{
	// Token: 0x06001373 RID: 4979 RVA: 0x0006CCE8 File Offset: 0x0006AEE8
	[Token(Token = "0x6001373")]
	[Address(RVA = "0x4B6150", Offset = "0x4B4750", VA = "0x1804B6150", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		if (!this.buff)
		{
			this.anim.Play("idle");
		}
		if (global::Lawnf.TravelUltimate((UltiBuff)((uint)29)) && global::UnityEngine.Random.Range(0, 10) == 0)
		{
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
		}
	}

	// Token: 0x06001374 RID: 4980 RVA: 0x0006CD40 File Offset: 0x0006AF40
	[Token(Token = "0x6001374")]
	[Address(RVA = "0x4B4B40", Offset = "0x4B3140", VA = "0x1804B4B40", Slot = "68")]
	public virtual void AnimEvent()
	{
		int num = 0;
		Transform axis = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		Vector3 vector;
		float z = vector.z;
		int thePlantRow = this.thePlantRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)11), num, thePlantRow, num3 != 0UL, (float)num2);
		int num4 = 0;
		base.Die((Plant.DieReason)num4);
		if ((this.board.isEveStarted ? 1 : 0) == num)
		{
			this.RandomPlant();
			return;
		}
		this.SuperRandomPlant(true);
	}

	// Token: 0x06001375 RID: 4981 RVA: 0x0006CDB0 File Offset: 0x0006AFB0
	[Token(Token = "0x6001375")]
	[Address(RVA = "0x4B54E0", Offset = "0x4B3AE0", VA = "0x1804B54E0")]
	protected void RandomPlant()
	{
		int num4;
		do
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			GridSystem gridSystem = this.board.gridSystem;
			int thePlantRow = this.thePlantRow;
			int thePlantColumn = this.thePlantColumn;
			if (gridSystem.GetBoxType(thePlantColumn, thePlantRow) == BoxType.Water)
			{
				GridSystem gridSystem2 = this.board.gridSystem;
				int thePlantRow2 = this.thePlantRow;
				int thePlantColumn2 = this.thePlantColumn;
				bool flag = gridSystem2.HasLily(thePlantColumn2, thePlantRow2);
			}
			List<PlantType> list = new List();
			List<PlantType> list2 = new List();
			HashSet<PlantType> baiscPlants = CoreEnums.baiscPlants;
			bool flag2;
			if (!flag2 || (num3 != 0 && !TypeMgr.IsWaterPlant((PlantType)num)) || !TypeMgr.IsWaterPlant((PlantType)num))
			{
			}
			if (num2 != 0)
			{
				goto IL_01E7;
			}
			num4 = 0;
			int theBoardLevel = GameAPP.theBoardLevel;
			int theBoardLevel2 = GameAPP.theBoardLevel;
			List<PlantType> list3;
			int num5 = list3._size;
			num5 = global::UnityEngine.Random.Range(0, num5);
			PlantType plantType = list3[num5];
			bool flag3;
			if (flag3)
			{
				int num6 = list3._size;
				int num7 = global::UnityEngine.Random.Range(0, num6);
				num6 = num7;
				PlantType plantType2 = list3[num6];
				bool flag4;
				while (flag4)
				{
				}
				num6 = num7;
				list3.RemoveAt(num6);
			}
		}
		while (num4 != 0);
		PlantType plantType3;
		if (plantType3 == PlantType.SmallPuff)
		{
			CreatePlant instance = CreatePlant.Instance;
			CreatePlant instance2 = CreatePlant.Instance;
		}
		CreatePlant instance3 = CreatePlant.Instance;
		int num8 = 0;
		Plant plant;
		if (plant == num8)
		{
			List<PlantType> list4 = new List(GameAPP.resourcesManager.allPlants);
			if (Present.<>c.<>9__5_1 != 0)
			{
				List<PlantType> list6;
				Func<PlantType, bool> func;
				List<PlantType> list5 = Enumerable.ToList<PlantType>(Enumerable.Where<PlantType>(list6, func));
				int num9 = list5._size;
				num9 = global::UnityEngine.Random.Range(0, num9);
				PlantType plantType4 = list5[num9];
				throw new NullReferenceException();
			}
			Present.<>c.<>9__5_1 = delegate(PlantType p)
			{
				bool flag5;
				return flag5;
			};
		}
		return;
		IL_01E7:
		throw new NullReferenceException();
	}

	// Token: 0x06001376 RID: 4982 RVA: 0x0006CFAC File Offset: 0x0006B1AC
	[Token(Token = "0x6001376")]
	[Address(RVA = "0x4B5210", Offset = "0x4B3810", VA = "0x1804B5210")]
	private void HappyRandomPlant()
	{
		int num = global::UnityEngine.Random.Range(0, 6);
		if (num == 0)
		{
			Glove instance = Glove.Instance;
			if (instance != 0)
			{
				float fullCD = instance.fullCD;
				instance.CD = fullCD;
				InGameText instance2 = InGameText.Instance;
			}
		}
		int randomPlantLevel = global::Lawnf.GetRandomPlantLevel();
		PlantType happyRandomPlantType = global::Lawnf.GetHappyRandomPlantType(this.board);
		GridSystem gridSystem = this.board.gridSystem;
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		if (gridSystem.GetBoxType(thePlantColumn, thePlantRow) == BoxType.Water)
		{
			GridSystem gridSystem2 = this.board.gridSystem;
			int thePlantRow2 = this.thePlantRow;
			int thePlantColumn2 = this.thePlantColumn;
			if (!gridSystem2.HasLily(thePlantColumn2, thePlantRow2))
			{
				CreatePlant instance3 = CreatePlant.Instance;
			}
		}
		CreatePlant instance4 = CreatePlant.Instance;
		bool flag;
		if (flag)
		{
		}
		bool flag2;
		if (!flag2)
		{
			Transform axis = this.axis;
		}
	}

	// Token: 0x06001377 RID: 4983 RVA: 0x0006D080 File Offset: 0x0006B280
	[Token(Token = "0x6001377")]
	[Address(RVA = "0x4B6030", Offset = "0x4B4630", VA = "0x1804B6030")]
	private bool SetLevelPlant(int theColumn, int theRow, PlantType theSeedType, int level)
	{
		CreatePlant instance = CreatePlant.Instance;
		int num = 0;
		Plant plant;
		bool flag = plant != num;
		if (!flag)
		{
			return flag;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001378 RID: 4984 RVA: 0x0006D0B4 File Offset: 0x0006B2B4
	[Token(Token = "0x6001378")]
	[Address(RVA = "0x4B6290", Offset = "0x4B4890", VA = "0x1804B6290")]
	public void SuperRandomPlant(bool free = true)
	{
		Board board = this.board;
		List<PlantType> plants = this.GetPlants();
		int num = plants._size;
		num = global::UnityEngine.Random.Range(0, num);
		PlantType plantType = plants[num];
		Board board2 = this.board;
		List<PlantType> list = new List(GameAPP.resourcesManager.allPlants);
		Predicate<PlantType> predicate;
		if (Present.<>c.<>9__10_0 == 0)
		{
			predicate = delegate(PlantType p)
			{
				List<PlantType> bannedInPVPScaryPot = GameAPP.bannedInPVPScaryPot;
				bool flag2;
				return flag2;
			};
			Present.<>c.<>9__10_0 = predicate;
		}
		int num2 = list.RemoveAll(predicate);
		int num3 = list._size;
		num3 = global::UnityEngine.Random.Range(0, num3);
		PlantType plantType2 = list[num3];
		GridSystem gridSystem = this.board.gridSystem;
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		BoxType boxType = gridSystem.GetBoxType(thePlantColumn, thePlantRow);
		if (boxType == BoxType.Water)
		{
			GridSystem gridSystem2 = this.board.gridSystem;
			int thePlantRow2 = this.thePlantRow;
			int thePlantColumn2 = this.thePlantColumn;
			if (!gridSystem2.HasLily(thePlantColumn2, thePlantRow2))
			{
				CreatePlant instance = CreatePlant.Instance;
			}
		}
		CreatePlant instance2 = CreatePlant.Instance;
		bool flag;
		if (flag)
		{
			CreatePlant instance3 = CreatePlant.Instance;
			CreatePlant instance4 = CreatePlant.Instance;
		}
		CreatePlant instance5 = CreatePlant.Instance;
		int num4 = 0;
		Plant plant;
		if (plant == num4)
		{
			Transform axis = this.axis;
		}
	}

	// Token: 0x06001379 RID: 4985 RVA: 0x0006D1F8 File Offset: 0x0006B3F8
	[Token(Token = "0x6001379")]
	[Address(RVA = "0x4B4E70", Offset = "0x4B3470", VA = "0x1804B4E70")]
	private List<PlantType> GetPlants()
	{
		List<PlantType> allPlantTypes = global::Lawnf.GetAllPlantTypes();
		Predicate<PlantType> <>9__9_ = Present.<>c.<>9__9_0;
		if (<>9__9_ == 0)
		{
			Present.<>c.<>9__9_0 = delegate(PlantType p)
			{
				bool flag;
				bool flag2;
				return flag || flag2;
			};
		}
		int num = allPlantTypes.RemoveAll(<>9__9_);
		if (!this.ulti)
		{
			Predicate<PlantType> predicate;
			if (Present.<>c.<>9__9_2 == 0)
			{
				predicate = delegate(PlantType p)
				{
					bool flag3;
					return flag3 || p == PlantType.AshThreePeater;
				};
				Present.<>c.<>9__9_2 = predicate;
			}
			int num2 = allPlantTypes.RemoveAll(predicate);
			if (this.minCost > 0)
			{
				Predicate<PlantType> predicate2 = delegate(PlantType p)
				{
					int num5 = this.minCost;
					PlantDataManager.PlantData plantData;
					return plantData.cost < num5;
				};
				int num3 = allPlantTypes.RemoveAll(predicate2);
			}
			return allPlantTypes;
		}
		Predicate<PlantType> predicate3;
		if (Present.<>c.<>9__9_1 == 0)
		{
			predicate3 = delegate(PlantType p)
			{
				bool flag4;
				return flag4;
			};
			Present.<>c.<>9__9_1 = predicate3;
		}
		int num4 = allPlantTypes.RemoveAll(predicate3);
		throw new NullReferenceException();
	}

	// Token: 0x0600137A RID: 4986 RVA: 0x0006D2C8 File Offset: 0x0006B4C8
	[Token(Token = "0x600137A")]
	[Address(RVA = "0x4B4CD0", Offset = "0x4B32D0", VA = "0x1804B4CD0")]
	public static List<PlantType> GetPlantTypes()
	{
		List<PlantType> list = new List(GameAPP.resourcesManager.allPlants);
		Predicate<PlantType> <>9__10_ = Present.<>c.<>9__10_0;
		if (<>9__10_ == 0)
		{
			Present.<>c.<>9__10_0 = delegate(PlantType p)
			{
				List<PlantType> bannedInPVPScaryPot = GameAPP.bannedInPVPScaryPot;
				bool flag;
				return flag;
			};
		}
		int num = list.RemoveAll(<>9__10_);
		return list;
	}

	// Token: 0x0600137B RID: 4987 RVA: 0x0006D320 File Offset: 0x0006B520
	[Token(Token = "0x600137B")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public Present()
	{
	}

	// Token: 0x04000CBB RID: 3259
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000CBB")]
	public bool buff;

	// Token: 0x04000CBC RID: 3260
	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x4000CBC")]
	public int minCost;

	// Token: 0x04000CBD RID: 3261
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000CBD")]
	public bool ulti;
}
