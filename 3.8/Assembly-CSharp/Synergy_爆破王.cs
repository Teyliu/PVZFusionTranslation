using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200096A RID: 2410
[Token(Token = "0x200096A")]
public class Synergy_爆破王 : BaseSynergyData
{
	// Token: 0x060031C9 RID: 12745 RVA: 0x001063CC File Offset: 0x001045CC
	[Token(Token = "0x60031C9")]
	[Address(RVA = "0x3AC960", Offset = "0x3AAF60", VA = "0x1803AC960", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.爆破王;
	}

	// Token: 0x060031CA RID: 12746 RVA: 0x001063DC File Offset: 0x001045DC
	[Token(Token = "0x60031CA")]
	[Address(RVA = "0x6F5E20", Offset = "0x6F4420", VA = "0x1806F5E20", Slot = "8")]
	public override List<SynergyLevelData> GetAllData()
	{
		List<SynergyLevelData> list = new List();
		SynergyLevelData synergyLevelData = new SynergyLevelData();
		synergyLevelData.<ActiveCount>k__BackingField = (int)((ulong)2L);
		synergyLevelData.<Value>k__BackingField = 1f;
		synergyLevelData.<Value2>k__BackingField = 0.8f;
		synergyLevelData.<Description>k__BackingField = "羁绊队员造成伤害时，在每行发射一枚爆炸樱桃，伤害为本次伤害的100%，冷却0.8秒";
		int size = list._size;
		list._size = synergyLevelData;
		synergyLevelData.<Value>k__BackingField = synergyLevelData;
		SynergyLevelData synergyLevelData2 = new SynergyLevelData();
		synergyLevelData2.<ActiveCount>k__BackingField = (int)((ulong)4L);
		synergyLevelData2.<Value>k__BackingField = 2f;
		synergyLevelData2.<Value2>k__BackingField = 0.5f;
		synergyLevelData2.<Description>k__BackingField = "200%伤害，冷却0.5秒";
		int size2 = list._size;
		list._size = synergyLevelData2;
		synergyLevelData2.<Value>k__BackingField = synergyLevelData2;
		SynergyLevelData synergyLevelData3 = new SynergyLevelData();
		synergyLevelData3.<ActiveCount>k__BackingField = (int)((ulong)6L);
		synergyLevelData3.<Value>k__BackingField = 3f;
		synergyLevelData3.<Value2>k__BackingField = 0.3f;
		synergyLevelData3.<Description>k__BackingField = "300%伤害，冷却0.3秒";
		int size3 = list._size;
		list._size = synergyLevelData3;
		synergyLevelData3.<Value>k__BackingField = synergyLevelData3;
		SynergyLevelData synergyLevelData4 = new SynergyLevelData();
		synergyLevelData4.<ActiveCount>k__BackingField = (int)((ulong)10L);
		synergyLevelData4.<Value>k__BackingField = 8f;
		synergyLevelData4.<Value2>k__BackingField = 0.1f;
		synergyLevelData4.<Description>k__BackingField = "800%伤害，冷却0.1秒";
		int size4 = list._size;
		list._size = synergyLevelData4;
		synergyLevelData4.<Value>k__BackingField = synergyLevelData4;
		SynergyLevelData synergyLevelData5 = new SynergyLevelData();
		synergyLevelData5.<ActiveCount>k__BackingField = (int)((ulong)14L);
		synergyLevelData5.<Value>k__BackingField = 15f;
		synergyLevelData5.<Value2>k__BackingField = 0.05f;
		synergyLevelData5.<Description>k__BackingField = "1500%伤害，冷却0.05秒";
		int size5 = list._size;
		list._size = synergyLevelData5;
		synergyLevelData5.<Value>k__BackingField = synergyLevelData5;
		SynergyLevelData synergyLevelData6 = new SynergyLevelData();
		synergyLevelData6.<ActiveCount>k__BackingField = (int)((ulong)19L);
		synergyLevelData6.<Value>k__BackingField = 100f;
		synergyLevelData6.<Value2>k__BackingField = 0.01f;
		synergyLevelData6.<Description>k__BackingField = "10000%伤害，冷却0.01秒";
		int size6 = list._size;
		return list;
	}

	// Token: 0x060031CB RID: 12747 RVA: 0x001065C0 File Offset: 0x001047C0
	[Token(Token = "0x60031CB")]
	[Address(RVA = "0x6F6300", Offset = "0x6F4900", VA = "0x1806F6300", Slot = "4")]
	public override void OnBoardStart(Board board)
	{
		SynergyLevelData data = base.GetData();
		this.shootPos = (ulong)3231291802L;
		float <Value>k__BackingField = data.<Value>k__BackingField;
		this.damage = <Value>k__BackingField;
		float <Value2>k__BackingField = data.<Value2>k__BackingField;
		this.cool = <Value2>k__BackingField;
		int num = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)5), action, num != 0);
	}

	// Token: 0x060031CC RID: 12748 RVA: 0x00106614 File Offset: 0x00104814
	[Token(Token = "0x60031CC")]
	[Address(RVA = "0x6F63D0", Offset = "0x6F49D0", VA = "0x1806F63D0")]
	private void OnZombieTakeDamage(object obj)
	{
		HashSet<PlantType> plantsContained = this.plantsContained;
		bool flag;
		if (flag && Time.time > this.cool)
		{
			float num = Time.time;
			this.time = num;
			int num2 = 0;
			Board instance = Board.Instance;
			if (num2 < instance.rowNum)
			{
				Mouse instance2 = Mouse.Instance;
				float num3;
				this.shootPos.y = num3;
				CreateBullet instance3 = CreateBullet.Instance;
				Bullet bullet;
				bullet.Damage = num2;
				bullet.fromType = (PlantType)((ulong)264L);
				num2++;
				Board instance4 = Board.Instance;
			}
		}
	}

	// Token: 0x060031CD RID: 12749 RVA: 0x001066A8 File Offset: 0x001048A8
	[Token(Token = "0x60031CD")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Synergy_爆破王()
	{
		int num = 0;
		base.OnBoardStart(num);
	}

	// Token: 0x04001CA1 RID: 7329
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001CA1")]
	private float damage;

	// Token: 0x04001CA2 RID: 7330
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001CA2")]
	private float time;

	// Token: 0x04001CA3 RID: 7331
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001CA3")]
	private Vector2 shootPos;

	// Token: 0x04001CA4 RID: 7332
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001CA4")]
	private float cool;
}
