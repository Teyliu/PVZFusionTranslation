using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000969 RID: 2409
[Token(Token = "0x2000969")]
public class Synergy_百步穿杨 : BaseSynergyData
{
	// Token: 0x060031C5 RID: 12741 RVA: 0x001062DC File Offset: 0x001044DC
	[Token(Token = "0x60031C5")]
	[Address(RVA = "0x3AAFC0", Offset = "0x3A95C0", VA = "0x1803AAFC0", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.百步穿杨;
	}

	// Token: 0x060031C6 RID: 12742 RVA: 0x001062EC File Offset: 0x001044EC
	[Token(Token = "0x60031C6")]
	[Address(RVA = "0x6F6E10", Offset = "0x6F5410", VA = "0x1806F6E10", Slot = "8")]
	public override List<SynergyLevelData> GetAllData()
	{
		List<SynergyLevelData> list = new List();
		SynergyLevelData synergyLevelData = new SynergyLevelData();
		synergyLevelData.<ActiveCount>k__BackingField = (int)((ulong)2L);
		synergyLevelData.<Value>k__BackingField = 0.1f;
		synergyLevelData.<Description>k__BackingField = "我方获得10%减伤穿透（针对领袖）";
		int size = list._size;
		list._size = synergyLevelData;
		synergyLevelData.<Value>k__BackingField = synergyLevelData;
		SynergyLevelData synergyLevelData2 = new SynergyLevelData();
		synergyLevelData2.<ActiveCount>k__BackingField = (int)((ulong)4L);
		synergyLevelData2.<Value>k__BackingField = 0.3f;
		synergyLevelData2.<Description>k__BackingField = "30%减伤穿透";
		int size2 = list._size;
		return list;
	}

	// Token: 0x060031C7 RID: 12743 RVA: 0x00106380 File Offset: 0x00104580
	[Token(Token = "0x60031C7")]
	[Address(RVA = "0x6F7000", Offset = "0x6F5600", VA = "0x1806F7000", Slot = "4")]
	public override void OnBoardStart(Board board)
	{
		TravelData data = TravelMgr.Instance.data;
		float <Value>k__BackingField = base.GetData().<Value>k__BackingField;
		data.ArmorPiercing = <Value>k__BackingField;
	}

	// Token: 0x060031C8 RID: 12744 RVA: 0x001063B4 File Offset: 0x001045B4
	[Token(Token = "0x60031C8")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Synergy_百步穿杨()
	{
		int num = 0;
		base.OnBoardStart(num);
	}
}
