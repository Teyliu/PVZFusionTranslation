using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000971 RID: 2417
[Token(Token = "0x2000971")]
public class Synergy_召唤师 : BaseSynergyData
{
	// Token: 0x060031EC RID: 12780 RVA: 0x001071CC File Offset: 0x001053CC
	[Token(Token = "0x60031EC")]
	[Address(RVA = "0x69BB30", Offset = "0x69A130", VA = "0x18069BB30", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.召唤师;
	}

	// Token: 0x060031ED RID: 12781 RVA: 0x001071DC File Offset: 0x001053DC
	[Token(Token = "0x60031ED")]
	[Address(RVA = "0x6F2B80", Offset = "0x6F1180", VA = "0x1806F2B80", Slot = "8")]
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

	// Token: 0x060031EE RID: 12782 RVA: 0x00107270 File Offset: 0x00105470
	[Token(Token = "0x60031EE")]
	[Address(RVA = "0x6F2D70", Offset = "0x6F1370", VA = "0x1806F2D70", Slot = "4")]
	public override void OnBoardStart(Board board)
	{
		float <Value>k__BackingField = base.GetData().<Value>k__BackingField;
		this.damage = <Value>k__BackingField;
		int num = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)2), action, num != 0);
		this.x = -4.8f;
	}

	// Token: 0x060031EF RID: 12783 RVA: 0x001072B0 File Offset: 0x001054B0
	[Token(Token = "0x60031EF")]
	[Address(RVA = "0x6F2E40", Offset = "0x6F1440", VA = "0x1806F2E40")]
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

	// Token: 0x060031F0 RID: 12784 RVA: 0x00107300 File Offset: 0x00105500
	[Token(Token = "0x60031F0")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Synergy_召唤师()
	{
		int num = 0;
		base.OnBoardStart(num);
	}

	// Token: 0x04001CAC RID: 7340
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001CAC")]
	private float damage;

	// Token: 0x04001CAD RID: 7341
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001CAD")]
	private float x;
}
