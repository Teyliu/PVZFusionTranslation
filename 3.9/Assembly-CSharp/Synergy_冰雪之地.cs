using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200099F RID: 2463
[Token(Token = "0x200099F")]
public class Synergy_冰雪之地 : BaseSynergyData
{
	// Token: 0x060032DB RID: 13019 RVA: 0x0010A66C File Offset: 0x0010886C
	[Token(Token = "0x60032DB")]
	[Address(RVA = "0x3F1E50", Offset = "0x3F0450", VA = "0x1803F1E50", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.冰雪之地;
	}

	// Token: 0x060032DC RID: 13020 RVA: 0x0010A67C File Offset: 0x0010887C
	[Token(Token = "0x60032DC")]
	[Address(RVA = "0x757500", Offset = "0x755B00", VA = "0x180757500", Slot = "8")]
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

	// Token: 0x060032DD RID: 13021 RVA: 0x0010A6D4 File Offset: 0x001088D4
	[Token(Token = "0x60032DD")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Synergy_冰雪之地()
	{
		int num = 0;
		base.OnBoardStart(num);
	}
}
