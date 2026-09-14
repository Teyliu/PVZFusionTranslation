using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020009A7 RID: 2471
[Token(Token = "0x20009A7")]
public class Synergy_磁力科技 : BaseSynergyData
{
	// Token: 0x06003301 RID: 13057 RVA: 0x0010B444 File Offset: 0x00109644
	[Token(Token = "0x6003301")]
	[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.磁力科技;
	}

	// Token: 0x06003302 RID: 13058 RVA: 0x0010B454 File Offset: 0x00109654
	[Token(Token = "0x6003302")]
	[Address(RVA = "0x75C440", Offset = "0x75AA40", VA = "0x18075C440", Slot = "8")]
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

	// Token: 0x06003303 RID: 13059 RVA: 0x0010B5F0 File Offset: 0x001097F0
	[Token(Token = "0x6003303")]
	[Address(RVA = "0x75C8F0", Offset = "0x75AEF0", VA = "0x18075C8F0", Slot = "4")]
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

	// Token: 0x06003304 RID: 13060 RVA: 0x0010B62C File Offset: 0x0010982C
	[Token(Token = "0x6003304")]
	[Address(RVA = "0x75CA00", Offset = "0x75B000", VA = "0x18075CA00")]
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

	// Token: 0x06003305 RID: 13061 RVA: 0x0010B6B0 File Offset: 0x001098B0
	[Token(Token = "0x6003305")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Synergy_磁力科技()
	{
		int num = 0;
		base.OnBoardStart(num);
	}

	// Token: 0x04001D95 RID: 7573
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001D95")]
	private int energy;

	// Token: 0x04001D96 RID: 7574
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001D96")]
	private float damage;
}
