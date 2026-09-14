using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000962 RID: 2402
[Token(Token = "0x2000962")]
public class Synergy_屋顶守卫 : BaseSynergyData
{
	// Token: 0x060031A3 RID: 12707 RVA: 0x00105694 File Offset: 0x00103894
	[Token(Token = "0x60031A3")]
	[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.屋顶守卫;
	}

	// Token: 0x060031A4 RID: 12708 RVA: 0x001056A4 File Offset: 0x001038A4
	[Token(Token = "0x60031A4")]
	[Address(RVA = "0x6F3C60", Offset = "0x6F2260", VA = "0x1806F3C60", Slot = "8")]
	public override List<SynergyLevelData> GetAllData()
	{
		List<SynergyLevelData> list = new List();
		SynergyLevelData synergyLevelData = new SynergyLevelData();
		synergyLevelData.<ActiveCount>k__BackingField = (int)((ulong)2L);
		synergyLevelData.<Value>k__BackingField = 0.2f;
		synergyLevelData.<Description>k__BackingField = "羁绊队员获得20%速度增幅";
		int size = list._size;
		list._size = synergyLevelData;
		synergyLevelData.<Value>k__BackingField = synergyLevelData;
		SynergyLevelData synergyLevelData2 = new SynergyLevelData();
		synergyLevelData2.<ActiveCount>k__BackingField = (int)((ulong)4L);
		synergyLevelData2.<Value>k__BackingField = 0.4f;
		synergyLevelData2.<Description>k__BackingField = "40%速度增幅";
		int size2 = list._size;
		list._size = synergyLevelData2;
		synergyLevelData2.<Value>k__BackingField = synergyLevelData2;
		SynergyLevelData synergyLevelData3 = new SynergyLevelData();
		synergyLevelData3.<ActiveCount>k__BackingField = (int)((ulong)6L);
		synergyLevelData3.<Value>k__BackingField = 0.6f;
		synergyLevelData3.<Description>k__BackingField = "60%速度增幅";
		int size3 = list._size;
		list._size = synergyLevelData3;
		synergyLevelData3.<Value>k__BackingField = synergyLevelData3;
		SynergyLevelData synergyLevelData4 = new SynergyLevelData();
		synergyLevelData4.<ActiveCount>k__BackingField = (int)((ulong)8L);
		synergyLevelData4.<Value>k__BackingField = 1f;
		synergyLevelData4.<Description>k__BackingField = "100%速度增幅";
		int size4 = list._size;
		list._size = synergyLevelData4;
		synergyLevelData4.<Value>k__BackingField = synergyLevelData4;
		SynergyLevelData synergyLevelData5 = new SynergyLevelData();
		synergyLevelData5.<ActiveCount>k__BackingField = (int)((ulong)11L);
		synergyLevelData5.<Value>k__BackingField = 1.5f;
		synergyLevelData5.<Description>k__BackingField = "200%速度增幅";
		int size5 = list._size;
		return list;
	}

	// Token: 0x060031A5 RID: 12709 RVA: 0x00105800 File Offset: 0x00103A00
	[Token(Token = "0x60031A5")]
	[Address(RVA = "0x6F4060", Offset = "0x6F2660", VA = "0x1806F4060", Slot = "4")]
	public override void OnBoardStart(Board board)
	{
		for (;;)
		{
			int num = 0;
			SynergyLevelData data = base.GetData();
			HashSet<PlantType> plantsContained = this.plantsContained;
			bool flag;
			if (flag)
			{
				TravelData data2 = TravelMgr.Instance.data;
				float <Value>k__BackingField = data.<Value>k__BackingField;
				data2.AddSpeed((PlantType)num, <Value>k__BackingField);
			}
			ulong num2;
			if (num2 == (ulong)0L)
			{
				List<Plant> allPlants = Lawnf.GetAllPlants();
				bool flag2;
				if (flag2)
				{
				}
				ulong num3;
				if (num3 == (ulong)0L)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060031A6 RID: 12710 RVA: 0x00105878 File Offset: 0x00103A78
	[Token(Token = "0x60031A6")]
	[Address(RVA = "0x6F4330", Offset = "0x6F2930", VA = "0x1806F4330", Slot = "5")]
	public override void ReinforcePlant(Board board, Plant plant)
	{
		TravelData data = TravelMgr.Instance.data;
		PlantType thePlantType = plant.thePlantType;
		float speed = data.GetSpeed(thePlantType);
		float num = speed * plant.thePlantSpeed;
		plant.thePlantSpeed = num;
		float num2 = speed * plant.attributeSpeed;
		plant.attributeSpeed = num2;
		plant.attackSpeedAdder = speed;
	}

	// Token: 0x060031A7 RID: 12711 RVA: 0x001058D4 File Offset: 0x00103AD4
	[Token(Token = "0x60031A7")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Synergy_屋顶守卫()
	{
		int num = 0;
		base.OnBoardStart(num);
	}
}
