using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200095C RID: 2396
[Token(Token = "0x200095C")]
public class Synergy_前院守卫 : BaseSynergyData
{
	// Token: 0x0600318D RID: 12685 RVA: 0x00104CFC File Offset: 0x00102EFC
	[Token(Token = "0x600318D")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.前院守卫;
	}

	// Token: 0x0600318E RID: 12686 RVA: 0x00104D0C File Offset: 0x00102F0C
	[Token(Token = "0x600318E")]
	[Address(RVA = "0x6F25F0", Offset = "0x6F0BF0", VA = "0x1806F25F0", Slot = "8")]
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

	// Token: 0x0600318F RID: 12687 RVA: 0x00104E68 File Offset: 0x00103068
	[Token(Token = "0x600318F")]
	[Address(RVA = "0x6F29F0", Offset = "0x6F0FF0", VA = "0x1806F29F0", Slot = "4")]
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

	// Token: 0x06003190 RID: 12688 RVA: 0x00104EC8 File Offset: 0x001030C8
	[Token(Token = "0x6003190")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Synergy_前院守卫()
	{
		int num = 0;
		base.OnBoardStart(num);
	}
}
