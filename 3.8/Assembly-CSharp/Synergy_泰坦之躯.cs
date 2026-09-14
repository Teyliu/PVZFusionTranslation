using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200096D RID: 2413
[Token(Token = "0x200096D")]
public class Synergy_泰坦之躯 : BaseSynergyData
{
	// Token: 0x060031D7 RID: 12759 RVA: 0x00106B0C File Offset: 0x00104D0C
	[Token(Token = "0x60031D7")]
	[Address(RVA = "0x3AB4C0", Offset = "0x3A9AC0", VA = "0x1803AB4C0", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.泰坦之躯;
	}

	// Token: 0x060031D8 RID: 12760 RVA: 0x00106B1C File Offset: 0x00104D1C
	[Token(Token = "0x60031D8")]
	[Address(RVA = "0x6F5410", Offset = "0x6F3A10", VA = "0x1806F5410", Slot = "8")]
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

	// Token: 0x060031D9 RID: 12761 RVA: 0x00106C34 File Offset: 0x00104E34
	[Token(Token = "0x60031D9")]
	[Address(RVA = "0x6F5890", Offset = "0x6F3E90", VA = "0x1806F5890", Slot = "5")]
	public override void ReinforcePlant(Board board, Plant plant)
	{
		SynergyLevelData data = base.GetData();
		int num = 0;
		float <Value>k__BackingField = data.<Value>k__BackingField;
		plant.ModifyHealth((PlantHealthAdder)((uint)4), <Value>k__BackingField, num != 0);
	}

	// Token: 0x060031DA RID: 12762 RVA: 0x00106C64 File Offset: 0x00104E64
	[Token(Token = "0x60031DA")]
	[Address(RVA = "0x6F5760", Offset = "0x6F3D60", VA = "0x1806F5760", Slot = "4")]
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

	// Token: 0x060031DB RID: 12763 RVA: 0x00106C94 File Offset: 0x00104E94
	[Token(Token = "0x60031DB")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Synergy_泰坦之躯()
	{
		int num = 0;
		base.OnBoardStart(num);
	}
}
