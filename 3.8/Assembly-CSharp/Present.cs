using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000406 RID: 1030
[Token(Token = "0x2000406")]
public class Present : Plant
{
	// Token: 0x060012FD RID: 4861 RVA: 0x0006AEA4 File Offset: 0x000690A4
	[Token(Token = "0x60012FD")]
	[Address(RVA = "0x45FB70", Offset = "0x45E170", VA = "0x18045FB70", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		if (!this.buff)
		{
			this.anim.Play("idle");
			return;
		}
	}

	// Token: 0x060012FE RID: 4862 RVA: 0x0006AED8 File Offset: 0x000690D8
	[Token(Token = "0x60012FE")]
	[Address(RVA = "0x45E570", Offset = "0x45CB70", VA = "0x18045E570", Slot = "69")]
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

	// Token: 0x060012FF RID: 4863 RVA: 0x0006AF48 File Offset: 0x00069148
	[Token(Token = "0x60012FF")]
	[Address(RVA = "0x45EF00", Offset = "0x45D500", VA = "0x18045EF00")]
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

	// Token: 0x06001300 RID: 4864 RVA: 0x0006B144 File Offset: 0x00069344
	[Token(Token = "0x6001300")]
	[Address(RVA = "0x45EC40", Offset = "0x45D240", VA = "0x18045EC40")]
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

	// Token: 0x06001301 RID: 4865 RVA: 0x0006B218 File Offset: 0x00069418
	[Token(Token = "0x6001301")]
	[Address(RVA = "0x45FA50", Offset = "0x45E050", VA = "0x18045FA50")]
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

	// Token: 0x06001302 RID: 4866 RVA: 0x0006B24C File Offset: 0x0006944C
	[Token(Token = "0x6001302")]
	[Address(RVA = "0x45FBE0", Offset = "0x45E1E0", VA = "0x18045FBE0")]
	public void SuperRandomPlant(bool free = true)
	{
		Board board = this.board;
		List<PlantType> plants = this.GetPlants();
		int num = plants._size;
		num = global::UnityEngine.Random.Range(0, num);
		PlantType plantType = plants[num];
		Board board2 = this.board;
		List<PlantType> list = new List(GameAPP.resourcesManager.allPlants);
		Predicate<PlantType> <>9__10_ = Present.<>c.<>9__10_0;
		if (<>9__10_ == 0)
		{
			Present.<>c.<>9__10_0 = delegate(PlantType p)
			{
				List<PlantType> bannedInPVPScaryPot = GameAPP.bannedInPVPScaryPot;
				bool flag2;
				return flag2;
			};
		}
		int num2 = list.RemoveAll(<>9__10_);
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

	// Token: 0x06001303 RID: 4867 RVA: 0x0006B398 File Offset: 0x00069598
	[Token(Token = "0x6001303")]
	[Address(RVA = "0x45E8A0", Offset = "0x45CEA0", VA = "0x18045E8A0")]
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

	// Token: 0x06001304 RID: 4868 RVA: 0x0006B468 File Offset: 0x00069668
	[Token(Token = "0x6001304")]
	[Address(RVA = "0x45E700", Offset = "0x45CD00", VA = "0x18045E700")]
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

	// Token: 0x06001305 RID: 4869 RVA: 0x0006B4C0 File Offset: 0x000696C0
	[Token(Token = "0x6001305")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public Present()
	{
	}

	// Token: 0x04000C40 RID: 3136
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C40")]
	public bool buff;

	// Token: 0x04000C41 RID: 3137
	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x4000C41")]
	public int minCost;

	// Token: 0x04000C42 RID: 3138
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000C42")]
	public bool ulti;
}
