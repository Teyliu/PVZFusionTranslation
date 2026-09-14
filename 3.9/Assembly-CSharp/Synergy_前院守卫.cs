using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000998 RID: 2456
[Token(Token = "0x2000998")]
public class Synergy_前院守卫 : BaseSynergyData
{
	// Token: 0x060032C0 RID: 12992 RVA: 0x00109A7C File Offset: 0x00107C7C
	[Token(Token = "0x60032C0")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.前院守卫;
	}

	// Token: 0x060032C1 RID: 12993 RVA: 0x00109A8C File Offset: 0x00107C8C
	[Token(Token = "0x60032C1")]
	[Address(RVA = "0x757980", Offset = "0x755F80", VA = "0x180757980", Slot = "8")]
	public override List<SynergyLevelData> GetAllData()
	{
		List<SynergyLevelData> list = new List();
		SynergyLevelData synergyLevelData = new SynergyLevelData();
		synergyLevelData.<ActiveCount>k__BackingField = (int)((ulong)2L);
		synergyLevelData.<Value>k__BackingField = 0.5f;
		synergyLevelData.<Description>k__BackingField = "羁绊队员获得50%独立伤害增幅";
		int size = list._size;
		list._size = synergyLevelData;
		synergyLevelData.<Value>k__BackingField = synergyLevelData;
		SynergyLevelData synergyLevelData2 = new SynergyLevelData();
		synergyLevelData2.<ActiveCount>k__BackingField = (int)((ulong)4L);
		synergyLevelData2.<Value>k__BackingField = 0.8f;
		synergyLevelData2.<Description>k__BackingField = "80%独立伤害增幅";
		int size2 = list._size;
		list._size = synergyLevelData2;
		synergyLevelData2.<Value>k__BackingField = synergyLevelData2;
		SynergyLevelData synergyLevelData3 = new SynergyLevelData();
		synergyLevelData3.<ActiveCount>k__BackingField = (int)((ulong)7L);
		synergyLevelData3.<Value>k__BackingField = 1.2f;
		synergyLevelData3.<Description>k__BackingField = "120%独立伤害增幅";
		int size3 = list._size;
		list._size = synergyLevelData3;
		synergyLevelData3.<Value>k__BackingField = synergyLevelData3;
		SynergyLevelData synergyLevelData4 = new SynergyLevelData();
		synergyLevelData4.<ActiveCount>k__BackingField = (int)((ulong)10L);
		synergyLevelData4.<Value>k__BackingField = 2f;
		synergyLevelData4.<Description>k__BackingField = "200%独立伤害增幅";
		int size4 = list._size;
		list._size = synergyLevelData4;
		synergyLevelData4.<Value>k__BackingField = synergyLevelData4;
		SynergyLevelData synergyLevelData5 = new SynergyLevelData();
		synergyLevelData5.<ActiveCount>k__BackingField = (int)((ulong)14L);
		synergyLevelData5.<Value>k__BackingField = 3f;
		synergyLevelData5.<Description>k__BackingField = "300%独立伤害增幅";
		int size5 = list._size;
		return list;
	}

	// Token: 0x060032C2 RID: 12994 RVA: 0x00109BE8 File Offset: 0x00107DE8
	[Token(Token = "0x60032C2")]
	[Address(RVA = "0x757D80", Offset = "0x756380", VA = "0x180757D80", Slot = "4")]
	public override void OnBoardStart(Board board)
	{
		ulong num2;
		do
		{
			int num = 0;
			SynergyLevelData data = base.GetData();
			HashSet<PlantType> plantsContained = this.plantsContained;
			bool flag;
			if (flag)
			{
				TravelData data2 = TravelMgr.Instance.data;
				float <Value>k__BackingField = data.<Value>k__BackingField;
				data2.AddDamage((PlantType)num, <Value>k__BackingField);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x060032C3 RID: 12995 RVA: 0x00109C48 File Offset: 0x00107E48
	[Token(Token = "0x60032C3")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Synergy_前院守卫()
	{
		int num = 0;
		base.OnBoardStart(num);
	}
}
