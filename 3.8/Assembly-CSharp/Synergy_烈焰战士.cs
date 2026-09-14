using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000970 RID: 2416
[Token(Token = "0x2000970")]
public class Synergy_烈焰战士 : BaseSynergyData
{
	// Token: 0x060031E8 RID: 12776 RVA: 0x00106FE0 File Offset: 0x001051E0
	[Token(Token = "0x60031E8")]
	[Address(RVA = "0x69B710", Offset = "0x699D10", VA = "0x18069B710", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.烈焰战士;
	}

	// Token: 0x060031E9 RID: 12777 RVA: 0x00106FF0 File Offset: 0x001051F0
	[Token(Token = "0x60031E9")]
	[Address(RVA = "0x6F58F0", Offset = "0x6F3EF0", VA = "0x1806F58F0", Slot = "8")]
	public override List<SynergyLevelData> GetAllData()
	{
		List<SynergyLevelData> list = new List();
		SynergyLevelData synergyLevelData = new SynergyLevelData();
		synergyLevelData.<ActiveCount>k__BackingField = (int)((ulong)3L);
		synergyLevelData.<Value>k__BackingField = 0.1f;
		synergyLevelData.<Value2>k__BackingField = 0.4f;
		synergyLevelData.<Description>k__BackingField = "羁绊队员获得10%独立伤害增幅，红温伤害增幅提高40%";
		int size = list._size;
		list._size = synergyLevelData;
		synergyLevelData.<Value>k__BackingField = synergyLevelData;
		SynergyLevelData synergyLevelData2 = new SynergyLevelData();
		synergyLevelData2.<ActiveCount>k__BackingField = (int)((ulong)5L);
		synergyLevelData2.<Value>k__BackingField = 0.2f;
		synergyLevelData2.<Value2>k__BackingField = 0.8f;
		synergyLevelData2.<Description>k__BackingField = "20%独立伤害增幅，80%伤害增幅";
		int size2 = list._size;
		list._size = synergyLevelData2;
		synergyLevelData2.<Value>k__BackingField = synergyLevelData2;
		SynergyLevelData synergyLevelData3 = new SynergyLevelData();
		synergyLevelData3.<ActiveCount>k__BackingField = (int)((ulong)7L);
		synergyLevelData3.<Value>k__BackingField = 0.3f;
		synergyLevelData3.<Value2>k__BackingField = 1.2f;
		synergyLevelData3.<Description>k__BackingField = "30%独立伤害增幅，120%伤害增幅";
		int size3 = list._size;
		list._size = synergyLevelData3;
		synergyLevelData3.<Value>k__BackingField = synergyLevelData3;
		SynergyLevelData synergyLevelData4 = new SynergyLevelData();
		synergyLevelData4.<ActiveCount>k__BackingField = (int)((ulong)9L);
		synergyLevelData4.<Value>k__BackingField = 0.5f;
		synergyLevelData4.<Value2>k__BackingField = 2f;
		synergyLevelData4.<Description>k__BackingField = "50%独立伤害增幅，200%伤害增幅";
		int size4 = list._size;
		return list;
	}

	// Token: 0x060031EA RID: 12778 RVA: 0x00107138 File Offset: 0x00105338
	[Token(Token = "0x60031EA")]
	[Address(RVA = "0x6F5C60", Offset = "0x6F4260", VA = "0x1806F5C60", Slot = "4")]
	public override void OnBoardStart(Board board)
	{
		ulong num2;
		do
		{
			int num = 0;
			SynergyLevelData data = base.GetData();
			TravelData data2 = TravelMgr.Instance.data;
			float <Value2>k__BackingField = data.<Value2>k__BackingField;
			data2.jalaMore = <Value2>k__BackingField;
			HashSet<PlantType> plantsContained = this.plantsContained;
			bool flag;
			if (flag)
			{
				TravelData data3 = TravelMgr.Instance.data;
				float <Value>k__BackingField = data.<Value>k__BackingField;
				data3.AddDamage((PlantType)num, <Value>k__BackingField);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x060031EB RID: 12779 RVA: 0x001071B4 File Offset: 0x001053B4
	[Token(Token = "0x60031EB")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Synergy_烈焰战士()
	{
		int num = 0;
		base.OnBoardStart(num);
	}
}
