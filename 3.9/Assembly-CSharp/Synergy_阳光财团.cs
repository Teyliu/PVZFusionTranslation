using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020009A8 RID: 2472
[Token(Token = "0x20009A8")]
public class Synergy_阳光财团 : BaseSynergyData
{
	// Token: 0x06003306 RID: 13062 RVA: 0x0010B6C8 File Offset: 0x001098C8
	[Token(Token = "0x6003306")]
	[Address(RVA = "0x3F9920", Offset = "0x3F7F20", VA = "0x1803F9920", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.阳光财团;
	}

	// Token: 0x06003307 RID: 13063 RVA: 0x0010B6D8 File Offset: 0x001098D8
	[Token(Token = "0x6003307")]
	[Address(RVA = "0x75D250", Offset = "0x75B850", VA = "0x18075D250", Slot = "8")]
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

	// Token: 0x06003308 RID: 13064 RVA: 0x0010B834 File Offset: 0x00109A34
	[Token(Token = "0x6003308")]
	[Address(RVA = "0x75D650", Offset = "0x75BC50", VA = "0x18075D650", Slot = "4")]
	public override void OnBoardStart(Board board)
	{
		SynergyLevelData data = base.GetData();
		float num = data.<Value>k__BackingField * 4E-05f;
		board.sunEfficiency = num;
		float num2 = data.<Value>k__BackingField * 4E-05f;
		board.moneyEfficiency = num2;
	}

	// Token: 0x06003309 RID: 13065 RVA: 0x0010B878 File Offset: 0x00109A78
	[Token(Token = "0x6003309")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Synergy_阳光财团()
	{
		int num = 0;
		base.OnBoardStart(num);
	}
}
