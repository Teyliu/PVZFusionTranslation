using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020009AD RID: 2477
[Token(Token = "0x20009AD")]
public class Synergy_召唤师 : BaseSynergyData
{
	// Token: 0x0600331F RID: 13087 RVA: 0x0010BF50 File Offset: 0x0010A150
	[Token(Token = "0x600331F")]
	[Address(RVA = "0x715C90", Offset = "0x714290", VA = "0x180715C90", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.召唤师;
	}

	// Token: 0x06003320 RID: 13088 RVA: 0x0010BF60 File Offset: 0x0010A160
	[Token(Token = "0x6003320")]
	[Address(RVA = "0x757F10", Offset = "0x756510", VA = "0x180757F10", Slot = "8")]
	public override List<SynergyLevelData> GetAllData()
	{
		List<SynergyLevelData> list = new List();
		SynergyLevelData synergyLevelData = new SynergyLevelData();
		synergyLevelData.<ActiveCount>k__BackingField = (int)((ulong)2L);
		synergyLevelData.<Value>k__BackingField = 2f;
		synergyLevelData.<Description>k__BackingField = "魅惑僵尸死亡时，在本行发射一个200%基础伤害的超级魅惑子弹";
		int size = list._size;
		list._size = synergyLevelData;
		synergyLevelData.<Value>k__BackingField = synergyLevelData;
		SynergyLevelData synergyLevelData2 = new SynergyLevelData();
		synergyLevelData2.<ActiveCount>k__BackingField = (int)((ulong)4L);
		synergyLevelData2.<Value>k__BackingField = 8f;
		synergyLevelData2.<Description>k__BackingField = "500%基础伤害";
		int size2 = list._size;
		return list;
	}

	// Token: 0x06003321 RID: 13089 RVA: 0x0010BFF4 File Offset: 0x0010A1F4
	[Token(Token = "0x6003321")]
	[Address(RVA = "0x758100", Offset = "0x756700", VA = "0x180758100", Slot = "4")]
	public override void OnBoardStart(Board board)
	{
		float <Value>k__BackingField = base.GetData().<Value>k__BackingField;
		this.damage = <Value>k__BackingField;
		int num = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)2), action, num != 0);
		this.x = -4.8f;
	}

	// Token: 0x06003322 RID: 13090 RVA: 0x0010C034 File Offset: 0x0010A234
	[Token(Token = "0x6003322")]
	[Address(RVA = "0x7581D0", Offset = "0x7567D0", VA = "0x1807581D0")]
	private void OnZombieDeath(object obj)
	{
		CreateBullet instance = CreateBullet.Instance;
		Mouse instance2 = Mouse.Instance;
		TravelMgr instance3 = TravelMgr.Instance;
		int num = 0;
		int basicDamage = instance3.BasicDamage;
		Bullet bullet;
		bullet.Damage = num;
		bullet.fromType = (PlantType)((ulong)267L);
	}

	// Token: 0x06003323 RID: 13091 RVA: 0x0010C084 File Offset: 0x0010A284
	[Token(Token = "0x6003323")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Synergy_召唤师()
	{
		int num = 0;
		base.OnBoardStart(num);
	}

	// Token: 0x04001D9C RID: 7580
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001D9C")]
	private float damage;

	// Token: 0x04001D9D RID: 7581
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001D9D")]
	private float x;
}
