using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200096C RID: 2412
[Token(Token = "0x200096C")]
public class Synergy_阳光财团 : BaseSynergyData
{
	// Token: 0x060031D3 RID: 12755 RVA: 0x00106944 File Offset: 0x00104B44
	[Token(Token = "0x60031D3")]
	[Address(RVA = "0x3ADAB0", Offset = "0x3AC0B0", VA = "0x1803ADAB0", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.阳光财团;
	}

	// Token: 0x060031D4 RID: 12756 RVA: 0x00106954 File Offset: 0x00104B54
	[Token(Token = "0x60031D4")]
	[Address(RVA = "0x6F7EA0", Offset = "0x6F64A0", VA = "0x1806F7EA0", Slot = "8")]
	public override List<SynergyLevelData> GetAllData()
	{
		List<SynergyLevelData> list = new List();
		SynergyLevelData synergyLevelData = new SynergyLevelData();
		synergyLevelData.<ActiveCount>k__BackingField = (int)((ulong)2L);
		synergyLevelData.<Value>k__BackingField = 10000f;
		synergyLevelData.<Description>k__BackingField = "阳光、金币上限增加10000，获取效率增加40%";
		int size = list._size;
		list._size = synergyLevelData;
		synergyLevelData.<Value>k__BackingField = synergyLevelData;
		SynergyLevelData synergyLevelData2 = new SynergyLevelData();
		synergyLevelData2.<ActiveCount>k__BackingField = (int)((ulong)4L);
		synergyLevelData2.<Value>k__BackingField = 30000f;
		synergyLevelData2.<Description>k__BackingField = "20000上限，80%效率";
		int size2 = list._size;
		list._size = synergyLevelData2;
		synergyLevelData2.<Value>k__BackingField = synergyLevelData2;
		SynergyLevelData synergyLevelData3 = new SynergyLevelData();
		synergyLevelData3.<ActiveCount>k__BackingField = (int)((ulong)6L);
		synergyLevelData3.<Value>k__BackingField = 50000f;
		synergyLevelData3.<Description>k__BackingField = "30000上限，120%效率";
		int size3 = list._size;
		list._size = synergyLevelData3;
		synergyLevelData3.<Value>k__BackingField = synergyLevelData3;
		SynergyLevelData synergyLevelData4 = new SynergyLevelData();
		synergyLevelData4.<ActiveCount>k__BackingField = (int)((ulong)8L);
		synergyLevelData4.<Value>k__BackingField = 40000f;
		synergyLevelData4.<Description>k__BackingField = "40000上限，160%效率";
		int size4 = list._size;
		list._size = synergyLevelData4;
		synergyLevelData4.<Value>k__BackingField = synergyLevelData4;
		SynergyLevelData synergyLevelData5 = new SynergyLevelData();
		synergyLevelData5.<ActiveCount>k__BackingField = (int)((ulong)10L);
		synergyLevelData5.<Value>k__BackingField = 500000f;
		synergyLevelData5.<Description>k__BackingField = "50000上限，200%效率";
		int size5 = list._size;
		return list;
	}

	// Token: 0x060031D5 RID: 12757 RVA: 0x00106AB0 File Offset: 0x00104CB0
	[Token(Token = "0x60031D5")]
	[Address(RVA = "0x6F82A0", Offset = "0x6F68A0", VA = "0x1806F82A0", Slot = "4")]
	public override void OnBoardStart(Board board)
	{
		SynergyLevelData data = base.GetData();
		float num = data.<Value>k__BackingField * 4E-05f;
		board.sunEfficiency = num;
		float num2 = data.<Value>k__BackingField * 4E-05f;
		board.moneyEfficiency = num2;
	}

	// Token: 0x060031D6 RID: 12758 RVA: 0x00106AF4 File Offset: 0x00104CF4
	[Token(Token = "0x60031D6")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Synergy_阳光财团()
	{
		int num = 0;
		base.OnBoardStart(num);
	}
}
