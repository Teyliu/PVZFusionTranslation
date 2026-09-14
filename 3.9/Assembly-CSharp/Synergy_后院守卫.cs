using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200099B RID: 2459
[Token(Token = "0x200099B")]
public class Synergy_后院守卫 : BaseSynergyData
{
	// Token: 0x060032CB RID: 13003 RVA: 0x00109EF4 File Offset: 0x001080F4
	[Token(Token = "0x60032CB")]
	[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.后院守卫;
	}

	// Token: 0x060032CC RID: 13004 RVA: 0x00109F04 File Offset: 0x00108104
	[Token(Token = "0x60032CC")]
	[Address(RVA = "0x758370", Offset = "0x756970", VA = "0x180758370", Slot = "8")]
	public override List<SynergyLevelData> GetAllData()
	{
		List<SynergyLevelData> list = new List();
		SynergyLevelData synergyLevelData = new SynergyLevelData();
		synergyLevelData.<ActiveCount>k__BackingField = (int)((ulong)2L);
		synergyLevelData.<Value>k__BackingField = 1f;
		synergyLevelData.<Value2>k__BackingField = 600f;
		synergyLevelData.<Description>k__BackingField = "我方每击杀600只僵尸，释放全屏火焰，造成100%的基础伤害";
		int size = list._size;
		list._size = synergyLevelData;
		synergyLevelData.<Value>k__BackingField = synergyLevelData;
		SynergyLevelData synergyLevelData2 = new SynergyLevelData();
		synergyLevelData2.<ActiveCount>k__BackingField = (int)((ulong)4L);
		synergyLevelData2.<Value>k__BackingField = 3f;
		synergyLevelData2.<Value2>k__BackingField = 500f;
		synergyLevelData2.<Description>k__BackingField = "500击杀，300%基础伤害";
		int size2 = list._size;
		list._size = synergyLevelData2;
		synergyLevelData2.<Value>k__BackingField = synergyLevelData2;
		SynergyLevelData synergyLevelData3 = new SynergyLevelData();
		synergyLevelData3.<ActiveCount>k__BackingField = (int)((ulong)6L);
		synergyLevelData3.<Value>k__BackingField = 6f;
		synergyLevelData3.<Value2>k__BackingField = 400f;
		synergyLevelData3.<Description>k__BackingField = "400击杀，600%基础伤害";
		int size3 = list._size;
		list._size = synergyLevelData3;
		synergyLevelData3.<Value>k__BackingField = synergyLevelData3;
		SynergyLevelData synergyLevelData4 = new SynergyLevelData();
		synergyLevelData4.<ActiveCount>k__BackingField = (int)((ulong)8L);
		synergyLevelData4.<Value>k__BackingField = 9f;
		synergyLevelData4.<Value2>k__BackingField = 300f;
		synergyLevelData4.<Description>k__BackingField = "300击杀，900%基础伤害";
		int size4 = list._size;
		list._size = synergyLevelData4;
		synergyLevelData4.<Value>k__BackingField = synergyLevelData4;
		SynergyLevelData synergyLevelData5 = new SynergyLevelData();
		synergyLevelData5.<ActiveCount>k__BackingField = (int)((ulong)11L);
		synergyLevelData5.<Value>k__BackingField = 12f;
		synergyLevelData5.<Value2>k__BackingField = 200f;
		synergyLevelData5.<Description>k__BackingField = "200击杀，1200%基础伤害";
		int size5 = list._size;
		list._size = synergyLevelData5;
		synergyLevelData5.<Value>k__BackingField = synergyLevelData5;
		SynergyLevelData synergyLevelData6 = new SynergyLevelData();
		synergyLevelData6.<ActiveCount>k__BackingField = (int)((ulong)14L);
		synergyLevelData6.<Value>k__BackingField = 20f;
		synergyLevelData6.<Value2>k__BackingField = 100f;
		synergyLevelData6.<Description>k__BackingField = "100击杀，2000%基础伤害";
		int size6 = list._size;
		return list;
	}

	// Token: 0x060032CD RID: 13005 RVA: 0x0010A0E8 File Offset: 0x001082E8
	[Token(Token = "0x60032CD")]
	[Address(RVA = "0x758850", Offset = "0x756E50", VA = "0x180758850", Slot = "4")]
	public override void OnBoardStart(Board board)
	{
		SynergyLevelData data = base.GetData();
		this.count = (int)((ulong)0L);
		this.maxCount = this;
		float <Value>k__BackingField = data.<Value>k__BackingField;
		this.damageMultiplier = <Value>k__BackingField;
		int num = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)2), action, num != 0);
	}

	// Token: 0x060032CE RID: 13006 RVA: 0x0010A12C File Offset: 0x0010832C
	[Token(Token = "0x60032CE")]
	[Address(RVA = "0x758920", Offset = "0x756F20", VA = "0x180758920")]
	public void OnZombieDeath(object obj)
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
			int num4 = 0;
			Board instance = Board.Instance;
			if (num4 < instance.rowNum)
			{
				BoardAction boardAction = instance.boardAction;
				num4++;
				Board instance2 = Board.Instance;
			}
		};
		int num3 = 0;
		delayAction.SetAction(action, (float)num3);
	}

	// Token: 0x060032CF RID: 13007 RVA: 0x0010A19C File Offset: 0x0010839C
	[Token(Token = "0x60032CF")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Synergy_后院守卫()
	{
		int num = 0;
		base.OnBoardStart(num);
	}

	// Token: 0x04001D80 RID: 7552
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001D80")]
	private int count;

	// Token: 0x04001D81 RID: 7553
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001D81")]
	private int maxCount;

	// Token: 0x04001D82 RID: 7554
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001D82")]
	private float damageMultiplier;
}
