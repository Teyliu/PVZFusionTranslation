using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000999 RID: 2457
[Token(Token = "0x2000999")]
public class Synergy_蘑菇岛 : BaseSynergyData
{
	// Token: 0x060032C4 RID: 12996 RVA: 0x00109C60 File Offset: 0x00107E60
	[Token(Token = "0x60032C4")]
	[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.蘑菇岛;
	}

	// Token: 0x060032C5 RID: 12997 RVA: 0x00109C70 File Offset: 0x00107E70
	[Token(Token = "0x60032C5")]
	[Address(RVA = "0x75CBC0", Offset = "0x75B1C0", VA = "0x18075CBC0", Slot = "8")]
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

	// Token: 0x060032C6 RID: 12998 RVA: 0x00109DCC File Offset: 0x00107FCC
	[Token(Token = "0x60032C6")]
	[Address(RVA = "0x75CFC0", Offset = "0x75B5C0", VA = "0x18075CFC0", Slot = "4")]
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

	// Token: 0x060032C7 RID: 12999 RVA: 0x00109E2C File Offset: 0x0010802C
	[Token(Token = "0x60032C7")]
	[Address(RVA = "0x75D0F0", Offset = "0x75B6F0", VA = "0x18075D0F0")]
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

	// Token: 0x060032C8 RID: 13000 RVA: 0x00109E9C File Offset: 0x0010809C
	[Token(Token = "0x60032C8")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Synergy_蘑菇岛()
	{
		int num = 0;
		base.OnBoardStart(num);
	}

	// Token: 0x04001D7D RID: 7549
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001D7D")]
	private int count;

	// Token: 0x04001D7E RID: 7550
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001D7E")]
	private float damageMultiplier;
}
