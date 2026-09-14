using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200099E RID: 2462
[Token(Token = "0x200099E")]
public class Synergy_屋顶守卫 : BaseSynergyData
{
	// Token: 0x060032D6 RID: 13014 RVA: 0x0010A414 File Offset: 0x00108614
	[Token(Token = "0x60032D6")]
	[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.屋顶守卫;
	}

	// Token: 0x060032D7 RID: 13015 RVA: 0x0010A424 File Offset: 0x00108624
	[Token(Token = "0x60032D7")]
	[Address(RVA = "0x758FF0", Offset = "0x7575F0", VA = "0x180758FF0", Slot = "8")]
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

	// Token: 0x060032D8 RID: 13016 RVA: 0x0010A580 File Offset: 0x00108780
	[Token(Token = "0x60032D8")]
	[Address(RVA = "0x7593F0", Offset = "0x7579F0", VA = "0x1807593F0", Slot = "4")]
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

	// Token: 0x060032D9 RID: 13017 RVA: 0x0010A5F8 File Offset: 0x001087F8
	[Token(Token = "0x60032D9")]
	[Address(RVA = "0x7596C0", Offset = "0x757CC0", VA = "0x1807596C0", Slot = "5")]
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

	// Token: 0x060032DA RID: 13018 RVA: 0x0010A654 File Offset: 0x00108854
	[Token(Token = "0x60032DA")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Synergy_屋顶守卫()
	{
		int num = 0;
		base.OnBoardStart(num);
	}
}
