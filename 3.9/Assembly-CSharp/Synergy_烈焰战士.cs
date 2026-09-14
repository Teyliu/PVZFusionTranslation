using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020009AC RID: 2476
[Token(Token = "0x20009AC")]
public class Synergy_烈焰战士 : BaseSynergyData
{
	// Token: 0x0600331B RID: 13083 RVA: 0x0010BD64 File Offset: 0x00109F64
	[Token(Token = "0x600331B")]
	[Address(RVA = "0x715870", Offset = "0x713E70", VA = "0x180715870", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.烈焰战士;
	}

	// Token: 0x0600331C RID: 13084 RVA: 0x0010BD74 File Offset: 0x00109F74
	[Token(Token = "0x600331C")]
	[Address(RVA = "0x75AC80", Offset = "0x759280", VA = "0x18075AC80", Slot = "8")]
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

	// Token: 0x0600331D RID: 13085 RVA: 0x0010BEBC File Offset: 0x0010A0BC
	[Token(Token = "0x600331D")]
	[Address(RVA = "0x75AFF0", Offset = "0x7595F0", VA = "0x18075AFF0", Slot = "4")]
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

	// Token: 0x0600331E RID: 13086 RVA: 0x0010BF38 File Offset: 0x0010A138
	[Token(Token = "0x600331E")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Synergy_烈焰战士()
	{
		int num = 0;
		base.OnBoardStart(num);
	}
}
