using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020009A9 RID: 2473
[Token(Token = "0x20009A9")]
public class Synergy_泰坦之躯 : BaseSynergyData
{
	// Token: 0x0600330A RID: 13066 RVA: 0x0010B890 File Offset: 0x00109A90
	[Token(Token = "0x600330A")]
	[Address(RVA = "0x3F72C0", Offset = "0x3F58C0", VA = "0x1803F72C0", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.泰坦之躯;
	}

	// Token: 0x0600330B RID: 13067 RVA: 0x0010B8A0 File Offset: 0x00109AA0
	[Token(Token = "0x600330B")]
	[Address(RVA = "0x75A7A0", Offset = "0x758DA0", VA = "0x18075A7A0", Slot = "8")]
	public override List<SynergyLevelData> GetAllData()
	{
		List<SynergyLevelData> list = new List();
		SynergyLevelData synergyLevelData = new SynergyLevelData();
		synergyLevelData.<ActiveCount>k__BackingField = (int)((ulong)2L);
		synergyLevelData.<Value>k__BackingField = 0.15f;
		synergyLevelData.<Description>k__BackingField = "我方小队生命值上限提高15%";
		int size = list._size;
		list._size = synergyLevelData;
		synergyLevelData.<Value>k__BackingField = synergyLevelData;
		SynergyLevelData synergyLevelData2 = new SynergyLevelData();
		synergyLevelData2.<ActiveCount>k__BackingField = (int)((ulong)3L);
		synergyLevelData2.<Value>k__BackingField = 0.25f;
		synergyLevelData2.<Description>k__BackingField = "25%生命值上限提高";
		int size2 = list._size;
		list._size = synergyLevelData2;
		synergyLevelData2.<Value>k__BackingField = synergyLevelData2;
		SynergyLevelData synergyLevelData3 = new SynergyLevelData();
		synergyLevelData3.<ActiveCount>k__BackingField = (int)((ulong)5L);
		synergyLevelData3.<Value>k__BackingField = 0.35f;
		synergyLevelData3.<Description>k__BackingField = "35%生命值上限提高";
		int size3 = list._size;
		list._size = synergyLevelData3;
		synergyLevelData3.<Value>k__BackingField = synergyLevelData3;
		SynergyLevelData synergyLevelData4 = new SynergyLevelData();
		synergyLevelData4.<ActiveCount>k__BackingField = (int)((ulong)7L);
		synergyLevelData4.<Value>k__BackingField = 0.6f;
		synergyLevelData4.<Description>k__BackingField = "60%生命值上限提高";
		int size4 = list._size;
		return list;
	}

	// Token: 0x0600330C RID: 13068 RVA: 0x0010B9B8 File Offset: 0x00109BB8
	[Token(Token = "0x600330C")]
	[Address(RVA = "0x75AC20", Offset = "0x759220", VA = "0x18075AC20", Slot = "5")]
	public override void ReinforcePlant(Board board, Plant plant)
	{
		SynergyLevelData data = base.GetData();
		int num = 0;
		float <Value>k__BackingField = data.<Value>k__BackingField;
		plant.ModifyHealth((PlantHealthAdder)((uint)4), <Value>k__BackingField, num != 0);
	}

	// Token: 0x0600330D RID: 13069 RVA: 0x0010B9E8 File Offset: 0x00109BE8
	[Token(Token = "0x600330D")]
	[Address(RVA = "0x75AAF0", Offset = "0x7590F0", VA = "0x18075AAF0", Slot = "4")]
	public override void OnBoardStart(Board board)
	{
		ulong num2;
		do
		{
			int num = 0;
			List<Plant> allPlants = Lawnf.GetAllPlants();
			bool flag;
			if (flag)
			{
				this.ReinforcePlant(board, num);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x0600330E RID: 13070 RVA: 0x0010BA18 File Offset: 0x00109C18
	[Token(Token = "0x600330E")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Synergy_泰坦之躯()
	{
		int num = 0;
		base.OnBoardStart(num);
	}
}
