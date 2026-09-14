using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020009A2 RID: 2466
[Token(Token = "0x20009A2")]
public class Synergy_前线壁垒 : BaseSynergyData
{
	// Token: 0x060032EA RID: 13034 RVA: 0x0010AAF4 File Offset: 0x00108CF4
	[Token(Token = "0x60032EA")]
	[Address(RVA = "0x714BD0", Offset = "0x7131D0", VA = "0x180714BD0", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.前线壁垒;
	}

	// Token: 0x060032EB RID: 13035 RVA: 0x0010AB04 File Offset: 0x00108D04
	[Token(Token = "0x60032EB")]
	[Address(RVA = "0x757640", Offset = "0x755C40", VA = "0x180757640", Slot = "8")]
	public override List<SynergyLevelData> GetAllData()
	{
		List<SynergyLevelData> list = new List();
		SynergyLevelData synergyLevelData = new SynergyLevelData();
		synergyLevelData.<ActiveCount>k__BackingField = (int)((ulong)1L);
		synergyLevelData.<Value>k__BackingField = 0.05f;
		synergyLevelData.<Description>k__BackingField = "我方小队获得5%伤害减免";
		int size = list._size;
		list._size = synergyLevelData;
		synergyLevelData.<Value>k__BackingField = synergyLevelData;
		SynergyLevelData synergyLevelData2 = new SynergyLevelData();
		synergyLevelData2.<ActiveCount>k__BackingField = (int)((ulong)2L);
		synergyLevelData2.<Value>k__BackingField = 0.1f;
		synergyLevelData2.<Description>k__BackingField = "10%伤害减免";
		int size2 = list._size;
		list._size = synergyLevelData2;
		synergyLevelData2.<Value>k__BackingField = synergyLevelData2;
		SynergyLevelData synergyLevelData3 = new SynergyLevelData();
		synergyLevelData3.<ActiveCount>k__BackingField = (int)((ulong)3L);
		synergyLevelData3.<Value>k__BackingField = 0.15f;
		synergyLevelData3.<Description>k__BackingField = "15%伤害减免";
		int size3 = list._size;
		return list;
	}

	// Token: 0x060032EC RID: 13036 RVA: 0x0010ABD8 File Offset: 0x00108DD8
	[Token(Token = "0x60032EC")]
	[Address(RVA = "0x7578E0", Offset = "0x755EE0", VA = "0x1807578E0", Slot = "4")]
	public override void OnBoardStart(Board board)
	{
		TravelMgr instance = TravelMgr.Instance;
		float damageReduction = instance.damageReduction;
		SynergyLevelData data = base.GetData();
		instance.damageReduction = damageReduction;
	}

	// Token: 0x060032ED RID: 13037 RVA: 0x0010AC08 File Offset: 0x00108E08
	[Token(Token = "0x60032ED")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Synergy_前线壁垒()
	{
		int num = 0;
		base.OnBoardStart(num);
	}
}
