using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200096B RID: 2411
[Token(Token = "0x200096B")]
public class Synergy_磁力科技 : BaseSynergyData
{
	// Token: 0x060031CE RID: 12750 RVA: 0x001066C0 File Offset: 0x001048C0
	[Token(Token = "0x60031CE")]
	[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.磁力科技;
	}

	// Token: 0x060031CF RID: 12751 RVA: 0x001066D0 File Offset: 0x001048D0
	[Token(Token = "0x60031CF")]
	[Address(RVA = "0x6F7090", Offset = "0x6F5690", VA = "0x1806F7090", Slot = "8")]
	public override List<SynergyLevelData> GetAllData()
	{
		List<SynergyLevelData> list = new List();
		SynergyLevelData synergyLevelData = new SynergyLevelData();
		synergyLevelData.<ActiveCount>k__BackingField = (int)((ulong)2L);
		synergyLevelData.<Value>k__BackingField = 0.8f;
		synergyLevelData.<Description>k__BackingField = "羁绊队员命中僵尸时，为究极流星充能，充能满时流星落下造成80%基础伤害";
		int size = list._size;
		list._size = synergyLevelData;
		synergyLevelData.<Value>k__BackingField = synergyLevelData;
		SynergyLevelData synergyLevelData2 = new SynergyLevelData();
		synergyLevelData2.<ActiveCount>k__BackingField = (int)((ulong)4L);
		synergyLevelData2.<Value>k__BackingField = 1.6f;
		synergyLevelData2.<Description>k__BackingField = "160%基础伤害";
		int size2 = list._size;
		list._size = synergyLevelData2;
		synergyLevelData2.<Value>k__BackingField = synergyLevelData2;
		SynergyLevelData synergyLevelData3 = new SynergyLevelData();
		synergyLevelData3.<ActiveCount>k__BackingField = (int)((ulong)6L);
		synergyLevelData3.<Value>k__BackingField = 2.4f;
		synergyLevelData3.<Description>k__BackingField = "240%基础伤害";
		int size3 = list._size;
		list._size = synergyLevelData3;
		synergyLevelData3.<Value>k__BackingField = synergyLevelData3;
		SynergyLevelData synergyLevelData4 = new SynergyLevelData();
		synergyLevelData4.<ActiveCount>k__BackingField = (int)((ulong)8L);
		synergyLevelData4.<Value>k__BackingField = 4f;
		synergyLevelData4.<Description>k__BackingField = "400%基础伤害";
		int size4 = list._size;
		list._size = synergyLevelData4;
		synergyLevelData4.<Value>k__BackingField = synergyLevelData4;
		SynergyLevelData synergyLevelData5 = new SynergyLevelData();
		synergyLevelData5.<ActiveCount>k__BackingField = (int)((ulong)10L);
		synergyLevelData5.<Value>k__BackingField = 8f;
		synergyLevelData5.<Description>k__BackingField = "800%基础伤害";
		int size5 = list._size;
		list._size = synergyLevelData5;
		synergyLevelData5.<Value>k__BackingField = synergyLevelData5;
		SynergyLevelData synergyLevelData6 = new SynergyLevelData();
		synergyLevelData6.<ActiveCount>k__BackingField = (int)((ulong)12L);
		synergyLevelData6.<Value>k__BackingField = 16f;
		synergyLevelData6.<Description>k__BackingField = "1600%基础伤害";
		int size6 = list._size;
		return list;
	}

	// Token: 0x060031D0 RID: 12752 RVA: 0x0010686C File Offset: 0x00104A6C
	[Token(Token = "0x60031D0")]
	[Address(RVA = "0x6F7540", Offset = "0x6F5B40", VA = "0x1806F7540", Slot = "4")]
	public override void OnBoardStart(Board board)
	{
		int num = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)5), action, num != 0);
		int basicDamage = TravelMgr.Instance.BasicDamage;
		SynergyLevelData data = base.GetData();
		float num2;
		this.damage = num2;
	}

	// Token: 0x060031D1 RID: 12753 RVA: 0x001068A8 File Offset: 0x00104AA8
	[Token(Token = "0x60031D1")]
	[Address(RVA = "0x6F7650", Offset = "0x6F5C50", VA = "0x1806F7650")]
	private void OnZombieTakeDamage(object obj)
	{
		HashSet<PlantType> plantsContained = this.plantsContained;
		bool flag;
		if (flag)
		{
			int num = this.energy;
			num++;
			this.energy = num;
			num += -1000;
			this.energy = num;
			GameObject gameObject = GameAPP.itemPrefab[12];
			Transform transform = Board.Instance.transform;
			GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform);
			BigStar component = gameObject2.GetComponent<BigStar>();
			component.fromType = (PlantType)((ulong)265L);
			component.baseDamage = gameObject2;
		}
	}

	// Token: 0x060031D2 RID: 12754 RVA: 0x0010692C File Offset: 0x00104B2C
	[Token(Token = "0x60031D2")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Synergy_磁力科技()
	{
		int num = 0;
		base.OnBoardStart(num);
	}

	// Token: 0x04001CA5 RID: 7333
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001CA5")]
	private int energy;

	// Token: 0x04001CA6 RID: 7334
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001CA6")]
	private float damage;
}
