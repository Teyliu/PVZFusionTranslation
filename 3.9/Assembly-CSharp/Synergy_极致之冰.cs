using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020009A3 RID: 2467
[Token(Token = "0x20009A3")]
public class Synergy_极致之冰 : BaseSynergyData
{
	// Token: 0x060032EE RID: 13038 RVA: 0x0010AC20 File Offset: 0x00108E20
	[Token(Token = "0x60032EE")]
	[Address(RVA = "0x5D3550", Offset = "0x5D1B50", VA = "0x1805D3550", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.极致之冰;
	}

	// Token: 0x060032EF RID: 13039 RVA: 0x0010AC30 File Offset: 0x00108E30
	[Token(Token = "0x60032EF")]
	[Address(RVA = "0x75A250", Offset = "0x758850", VA = "0x18075A250", Slot = "8")]
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

	// Token: 0x060032F0 RID: 13040 RVA: 0x0010AD78 File Offset: 0x00108F78
	[Token(Token = "0x60032F0")]
	[Address(RVA = "0x75A5C0", Offset = "0x758BC0", VA = "0x18075A5C0", Slot = "4")]
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

	// Token: 0x060032F1 RID: 13041 RVA: 0x0010ADB4 File Offset: 0x00108FB4
	[Token(Token = "0x60032F1")]
	[Address(RVA = "0x75A690", Offset = "0x758C90", VA = "0x18075A690")]
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

	// Token: 0x060032F2 RID: 13042 RVA: 0x0010ADE8 File Offset: 0x00108FE8
	[Token(Token = "0x60032F2")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Synergy_极致之冰()
	{
		int num = 0;
		base.OnBoardStart(num);
	}

	// Token: 0x04001D8D RID: 7565
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001D8D")]
	private int freezeLevel;

	// Token: 0x04001D8E RID: 7566
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001D8E")]
	private float realDamage;
}
