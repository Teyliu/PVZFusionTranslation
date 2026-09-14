using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200095D RID: 2397
[Token(Token = "0x200095D")]
public class Synergy_蘑菇岛 : BaseSynergyData
{
	// Token: 0x06003191 RID: 12689 RVA: 0x00104EE0 File Offset: 0x001030E0
	[Token(Token = "0x6003191")]
	[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.蘑菇岛;
	}

	// Token: 0x06003192 RID: 12690 RVA: 0x00104EF0 File Offset: 0x001030F0
	[Token(Token = "0x6003192")]
	[Address(RVA = "0x6F7810", Offset = "0x6F5E10", VA = "0x1806F7810", Slot = "8")]
	public override List<SynergyLevelData> GetAllData()
	{
		List<SynergyLevelData> list = new List();
		SynergyLevelData synergyLevelData = new SynergyLevelData();
		synergyLevelData.<ActiveCount>k__BackingField = (int)((ulong)2L);
		synergyLevelData.<Value>k__BackingField = 0.6f;
		synergyLevelData.<Description>k__BackingField = "我方小队获得12%幸运一击率，我方每造成2000次伤害，对全场僵尸造成一次60%的基础伤害";
		int size = list._size;
		list._size = synergyLevelData;
		synergyLevelData.<Value>k__BackingField = synergyLevelData;
		SynergyLevelData synergyLevelData2 = new SynergyLevelData();
		synergyLevelData2.<ActiveCount>k__BackingField = (int)((ulong)4L);
		synergyLevelData2.<Value>k__BackingField = 0.12f;
		synergyLevelData2.<Description>k__BackingField = "24%幸运一击率，120%基础伤害";
		int size2 = list._size;
		list._size = synergyLevelData2;
		synergyLevelData2.<Value>k__BackingField = synergyLevelData2;
		SynergyLevelData synergyLevelData3 = new SynergyLevelData();
		synergyLevelData3.<ActiveCount>k__BackingField = (int)((ulong)6L);
		synergyLevelData3.<Value>k__BackingField = 0.18f;
		synergyLevelData3.<Description>k__BackingField = "36%幸运一击率，180%基础伤害";
		int size3 = list._size;
		list._size = synergyLevelData3;
		synergyLevelData3.<Value>k__BackingField = synergyLevelData3;
		SynergyLevelData synergyLevelData4 = new SynergyLevelData();
		synergyLevelData4.<ActiveCount>k__BackingField = (int)((ulong)8L);
		synergyLevelData4.<Value>k__BackingField = 0.24f;
		synergyLevelData4.<Description>k__BackingField = "48%幸运一击率，240%基础伤害";
		int size4 = list._size;
		list._size = synergyLevelData4;
		synergyLevelData4.<Value>k__BackingField = synergyLevelData4;
		SynergyLevelData synergyLevelData5 = new SynergyLevelData();
		synergyLevelData5.<ActiveCount>k__BackingField = (int)((ulong)11L);
		synergyLevelData5.<Value>k__BackingField = 0.6f;
		synergyLevelData5.<Description>k__BackingField = "60%幸运一击率，600%基础伤害";
		int size5 = list._size;
		return list;
	}

	// Token: 0x06003193 RID: 12691 RVA: 0x0010504C File Offset: 0x0010324C
	[Token(Token = "0x6003193")]
	[Address(RVA = "0x6F7C10", Offset = "0x6F6210", VA = "0x1806F7C10", Slot = "4")]
	public override void OnBoardStart(Board board)
	{
		SynergyLevelData data = base.GetData();
		TravelMgr instance = TravelMgr.Instance;
		float luckyStrike = instance.luckyStrike;
		instance.luckyStrike = luckyStrike;
		this.count = (int)((ulong)0L);
		if (data.<ActiveCount>k__BackingField != 12)
		{
			float num = data.<Value>k__BackingField * 100f;
		}
		int num2 = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)5), action, num2 != 0);
	}

	// Token: 0x06003194 RID: 12692 RVA: 0x001050AC File Offset: 0x001032AC
	[Token(Token = "0x6003194")]
	[Address(RVA = "0x6F7D40", Offset = "0x6F6340", VA = "0x1806F7D40")]
	public void OnZombieTakeDamage(object obj)
	{
		int num = this.count;
		num++;
		this.count = num;
		this.count = (int)((ulong)0L);
		int basicDamage = TravelMgr.Instance.BasicDamage;
		float num2;
		float damage = num2;
		DelayAction delayAction = GameAPP.delayAction;
		Action action = delegate
		{
			ulong num4;
			do
			{
				List<Zombie> allZombies = Lawnf.GetAllZombies(false);
				bool flag;
				if (flag)
				{
				}
			}
			while (num4 != (ulong)0L);
		};
		int num3 = 0;
		delayAction.SetAction(action, (float)num3);
	}

	// Token: 0x06003195 RID: 12693 RVA: 0x0010511C File Offset: 0x0010331C
	[Token(Token = "0x6003195")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Synergy_蘑菇岛()
	{
		int num = 0;
		base.OnBoardStart(num);
	}

	// Token: 0x04001C8D RID: 7309
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001C8D")]
	private int count;

	// Token: 0x04001C8E RID: 7310
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001C8E")]
	private float damageMultiplier;
}
