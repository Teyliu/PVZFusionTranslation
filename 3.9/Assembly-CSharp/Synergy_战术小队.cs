using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200099D RID: 2461
[Token(Token = "0x200099D")]
public class Synergy_战术小队 : BaseSynergyData
{
	// Token: 0x060032D2 RID: 13010 RVA: 0x0010A200 File Offset: 0x00108400
	[Token(Token = "0x60032D2")]
	[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.战术小队;
	}

	// Token: 0x060032D3 RID: 13011 RVA: 0x0010A210 File Offset: 0x00108410
	[Token(Token = "0x60032D3")]
	[Address(RVA = "0x759780", Offset = "0x757D80", VA = "0x180759780", Slot = "8")]
	public override List<SynergyLevelData> GetAllData()
	{
		List<SynergyLevelData> list = new List();
		SynergyLevelData synergyLevelData = new SynergyLevelData();
		synergyLevelData.<ActiveCount>k__BackingField = (int)((ulong)2L);
		synergyLevelData.<Value>k__BackingField = 0.1f;
		synergyLevelData.<Description>k__BackingField = "我方小队获得10%积分获取加成，每轮开始获得1次免费刷新";
		int size = list._size;
		list._size = synergyLevelData;
		synergyLevelData.<Value>k__BackingField = synergyLevelData;
		SynergyLevelData synergyLevelData2 = new SynergyLevelData();
		synergyLevelData2.<ActiveCount>k__BackingField = (int)((ulong)4L);
		synergyLevelData2.<Value>k__BackingField = 0.2f;
		synergyLevelData2.<Description>k__BackingField = "20%积分获取加成，2次免费刷新";
		int size2 = list._size;
		list._size = synergyLevelData2;
		synergyLevelData2.<Value>k__BackingField = synergyLevelData2;
		SynergyLevelData synergyLevelData3 = new SynergyLevelData();
		synergyLevelData3.<ActiveCount>k__BackingField = (int)((ulong)6L);
		synergyLevelData3.<Value>k__BackingField = 0.4f;
		synergyLevelData3.<Description>k__BackingField = "40%积分获取加成，3次免费刷新";
		int size3 = list._size;
		list._size = synergyLevelData3;
		synergyLevelData3.<Value>k__BackingField = synergyLevelData3;
		SynergyLevelData synergyLevelData4 = new SynergyLevelData();
		synergyLevelData4.<ActiveCount>k__BackingField = (int)((ulong)8L);
		synergyLevelData4.<Value>k__BackingField = 0.6f;
		synergyLevelData4.<Description>k__BackingField = "60%积分获取加成，4次免费刷新";
		int size4 = list._size;
		list._size = synergyLevelData4;
		synergyLevelData4.<Value>k__BackingField = synergyLevelData4;
		SynergyLevelData synergyLevelData5 = new SynergyLevelData();
		synergyLevelData5.<ActiveCount>k__BackingField = (int)((ulong)11L);
		synergyLevelData5.<Value>k__BackingField = 1f;
		synergyLevelData5.<Description>k__BackingField = "100%积分获取加成，5次免费刷新";
		int size5 = list._size;
		list._size = synergyLevelData5;
		synergyLevelData5.<Value>k__BackingField = synergyLevelData5;
		SynergyLevelData synergyLevelData6 = new SynergyLevelData();
		synergyLevelData6.<ActiveCount>k__BackingField = (int)((ulong)15L);
		synergyLevelData6.<Value>k__BackingField = 2f;
		synergyLevelData6.<Description>k__BackingField = "200%积分获取加成，8次免费刷新";
		int size6 = list._size;
		return list;
	}

	// Token: 0x060032D4 RID: 13012 RVA: 0x0010A3AC File Offset: 0x001085AC
	[Token(Token = "0x60032D4")]
	[Address(RVA = "0x759C30", Offset = "0x758230", VA = "0x180759C30", Slot = "4")]
	public override void OnBoardStart(Board board)
	{
		SynergyLevelData data = base.GetData();
		TravelData data2 = TravelMgr.Instance.data;
		float pointsBonus = data2.pointsBonus;
		data2.pointsBonus = pointsBonus;
		TravelData data3 = TravelMgr.Instance.data;
		int <ActiveCount>k__BackingField = data.<ActiveCount>k__BackingField;
	}

	// Token: 0x060032D5 RID: 13013 RVA: 0x0010A3FC File Offset: 0x001085FC
	[Token(Token = "0x60032D5")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Synergy_战术小队()
	{
		int num = 0;
		base.OnBoardStart(num);
	}
}
