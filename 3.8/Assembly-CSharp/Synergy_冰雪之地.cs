using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000963 RID: 2403
[Token(Token = "0x2000963")]
public class Synergy_冰雪之地 : BaseSynergyData
{
	// Token: 0x060031A8 RID: 12712 RVA: 0x001058EC File Offset: 0x00103AEC
	[Token(Token = "0x60031A8")]
	[Address(RVA = "0x3A5EC0", Offset = "0x3A44C0", VA = "0x1803A5EC0", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.冰雪之地;
	}

	// Token: 0x060031A9 RID: 12713 RVA: 0x001058FC File Offset: 0x00103AFC
	[Token(Token = "0x60031A9")]
	[Address(RVA = "0x6F2170", Offset = "0x6F0770", VA = "0x1806F2170", Slot = "8")]
	public override List<SynergyLevelData> GetAllData()
	{
		List<SynergyLevelData> list = new List();
		SynergyLevelData synergyLevelData = new SynergyLevelData();
		synergyLevelData.<ActiveCount>k__BackingField = (int)((ulong)1L);
		synergyLevelData.<Value>k__BackingField = 0.2f;
		synergyLevelData.<Description>k__BackingField = "激活该羁绊后，可以使场上的植物在雪原地图免受沉默和冻结效果";
		int size = list._size;
		return list;
	}

	// Token: 0x060031AA RID: 12714 RVA: 0x00105954 File Offset: 0x00103B54
	[Token(Token = "0x60031AA")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Synergy_冰雪之地()
	{
		int num = 0;
		base.OnBoardStart(num);
	}
}
