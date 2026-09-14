using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000966 RID: 2406
[Token(Token = "0x2000966")]
public class Synergy_前线壁垒 : BaseSynergyData
{
	// Token: 0x060031B7 RID: 12727 RVA: 0x00105D74 File Offset: 0x00103F74
	[Token(Token = "0x60031B7")]
	[Address(RVA = "0x69AA70", Offset = "0x699070", VA = "0x18069AA70", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.前线壁垒;
	}

	// Token: 0x060031B8 RID: 12728 RVA: 0x00105D84 File Offset: 0x00103F84
	[Token(Token = "0x60031B8")]
	[Address(RVA = "0x6F22B0", Offset = "0x6F08B0", VA = "0x1806F22B0", Slot = "8")]
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

	// Token: 0x060031B9 RID: 12729 RVA: 0x00105E58 File Offset: 0x00104058
	[Token(Token = "0x60031B9")]
	[Address(RVA = "0x6F2550", Offset = "0x6F0B50", VA = "0x1806F2550", Slot = "4")]
	public override void OnBoardStart(Board board)
	{
		TravelMgr instance = TravelMgr.Instance;
		float damageReduction = instance.damageReduction;
		SynergyLevelData data = base.GetData();
		instance.damageReduction = damageReduction;
	}

	// Token: 0x060031BA RID: 12730 RVA: 0x00105E88 File Offset: 0x00104088
	[Token(Token = "0x60031BA")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Synergy_前线壁垒()
	{
		int num = 0;
		base.OnBoardStart(num);
	}
}
