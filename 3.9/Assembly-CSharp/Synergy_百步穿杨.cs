using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020009A5 RID: 2469
[Token(Token = "0x20009A5")]
public class Synergy_百步穿杨 : BaseSynergyData
{
	// Token: 0x060032F8 RID: 13048 RVA: 0x0010B05C File Offset: 0x0010925C
	[Token(Token = "0x60032F8")]
	[Address(RVA = "0x3F6DC0", Offset = "0x3F53C0", VA = "0x1803F6DC0", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.百步穿杨;
	}

	// Token: 0x060032F9 RID: 13049 RVA: 0x0010B06C File Offset: 0x0010926C
	[Token(Token = "0x60032F9")]
	[Address(RVA = "0x75C1C0", Offset = "0x75A7C0", VA = "0x18075C1C0", Slot = "8")]
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

	// Token: 0x060032FA RID: 13050 RVA: 0x0010B100 File Offset: 0x00109300
	[Token(Token = "0x60032FA")]
	[Address(RVA = "0x75C3B0", Offset = "0x75A9B0", VA = "0x18075C3B0", Slot = "4")]
	public override void OnBoardStart(Board board)
	{
		TravelData data = TravelMgr.Instance.data;
		float <Value>k__BackingField = base.GetData().<Value>k__BackingField;
		data.ArmorPiercing = <Value>k__BackingField;
	}

	// Token: 0x060032FB RID: 13051 RVA: 0x0010B134 File Offset: 0x00109334
	[Token(Token = "0x60032FB")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Synergy_百步穿杨()
	{
		int num = 0;
		base.OnBoardStart(num);
	}
}
