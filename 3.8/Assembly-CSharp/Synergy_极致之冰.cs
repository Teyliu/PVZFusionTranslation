using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000967 RID: 2407
[Token(Token = "0x2000967")]
public class Synergy_极致之冰 : BaseSynergyData
{
	// Token: 0x060031BB RID: 12731 RVA: 0x00105EA0 File Offset: 0x001040A0
	[Token(Token = "0x60031BB")]
	[Address(RVA = "0x56FE40", Offset = "0x56E440", VA = "0x18056FE40", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.极致之冰;
	}

	// Token: 0x060031BC RID: 12732 RVA: 0x00105EB0 File Offset: 0x001040B0
	[Token(Token = "0x60031BC")]
	[Address(RVA = "0x6F4EC0", Offset = "0x6F34C0", VA = "0x1806F4EC0", Slot = "8")]
	public override List<SynergyLevelData> GetAllData()
	{
		List<SynergyLevelData> list = new List();
		SynergyLevelData synergyLevelData = new SynergyLevelData();
		synergyLevelData.<ActiveCount>k__BackingField = (int)((ulong)3L);
		synergyLevelData.<Value>k__BackingField = 10f;
		synergyLevelData.<Value2>k__BackingField = 1f;
		synergyLevelData.<Description>k__BackingField = "羁绊队员造成伤害时，为僵尸附加10点冻结值，僵尸被冻结时额外造成100%伤害";
		int size = list._size;
		list._size = synergyLevelData;
		synergyLevelData.<Value>k__BackingField = synergyLevelData;
		SynergyLevelData synergyLevelData2 = new SynergyLevelData();
		synergyLevelData2.<ActiveCount>k__BackingField = (int)((ulong)5L);
		synergyLevelData2.<Value>k__BackingField = 20f;
		synergyLevelData2.<Value2>k__BackingField = 1.5f;
		synergyLevelData2.<Description>k__BackingField = "20冻结值，150%伤害";
		int size2 = list._size;
		list._size = synergyLevelData2;
		synergyLevelData2.<Value>k__BackingField = synergyLevelData2;
		SynergyLevelData synergyLevelData3 = new SynergyLevelData();
		synergyLevelData3.<ActiveCount>k__BackingField = (int)((ulong)7L);
		synergyLevelData3.<Value>k__BackingField = 50f;
		synergyLevelData3.<Value2>k__BackingField = 2f;
		synergyLevelData3.<Description>k__BackingField = "50冻结值，200%伤害";
		int size3 = list._size;
		list._size = synergyLevelData3;
		synergyLevelData3.<Value>k__BackingField = synergyLevelData3;
		SynergyLevelData synergyLevelData4 = new SynergyLevelData();
		synergyLevelData4.<ActiveCount>k__BackingField = (int)((ulong)10L);
		synergyLevelData4.<Value>k__BackingField = 100f;
		synergyLevelData4.<Value2>k__BackingField = 3f;
		synergyLevelData4.<Description>k__BackingField = "100冻结值，300%伤害";
		int size4 = list._size;
		return list;
	}

	// Token: 0x060031BD RID: 12733 RVA: 0x00105FF8 File Offset: 0x001041F8
	[Token(Token = "0x60031BD")]
	[Address(RVA = "0x6F5230", Offset = "0x6F3830", VA = "0x1806F5230", Slot = "4")]
	public override void OnBoardStart(Board board)
	{
		SynergyLevelData data = base.GetData();
		this.freezeLevel = this;
		float <Value2>k__BackingField = data.<Value2>k__BackingField;
		this.realDamage = <Value2>k__BackingField;
		int num = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)5), action, num != 0);
	}

	// Token: 0x060031BE RID: 12734 RVA: 0x00106034 File Offset: 0x00104234
	[Token(Token = "0x60031BE")]
	[Address(RVA = "0x6F5300", Offset = "0x6F3900", VA = "0x1806F5300")]
	private void OnZombieTakeDamage(object obj)
	{
		HashSet<PlantType> plantsContained = this.plantsContained;
		bool flag;
		if (flag)
		{
			int num = this.freezeLevel;
			if (obj == 0)
			{
			}
		}
	}

	// Token: 0x060031BF RID: 12735 RVA: 0x00106068 File Offset: 0x00104268
	[Token(Token = "0x60031BF")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Synergy_极致之冰()
	{
		int num = 0;
		base.OnBoardStart(num);
	}

	// Token: 0x04001C9D RID: 7325
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001C9D")]
	private int freezeLevel;

	// Token: 0x04001C9E RID: 7326
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001C9E")]
	private float realDamage;
}
