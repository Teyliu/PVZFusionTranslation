using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020009A6 RID: 2470
[Token(Token = "0x20009A6")]
public class Synergy_爆破王 : BaseSynergyData
{
	// Token: 0x060032FC RID: 13052 RVA: 0x0010B14C File Offset: 0x0010934C
	[Token(Token = "0x60032FC")]
	[Address(RVA = "0x3F87C0", Offset = "0x3F6DC0", VA = "0x1803F87C0", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.爆破王;
	}

	// Token: 0x060032FD RID: 13053 RVA: 0x0010B15C File Offset: 0x0010935C
	[Token(Token = "0x60032FD")]
	[Address(RVA = "0x75B1B0", Offset = "0x7597B0", VA = "0x18075B1B0", Slot = "8")]
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

	// Token: 0x060032FE RID: 13054 RVA: 0x0010B340 File Offset: 0x00109540
	[Token(Token = "0x60032FE")]
	[Address(RVA = "0x75B690", Offset = "0x759C90", VA = "0x18075B690", Slot = "4")]
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

	// Token: 0x060032FF RID: 13055 RVA: 0x0010B394 File Offset: 0x00109594
	[Token(Token = "0x60032FF")]
	[Address(RVA = "0x75B760", Offset = "0x759D60", VA = "0x18075B760")]
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

	// Token: 0x06003300 RID: 13056 RVA: 0x0010B42C File Offset: 0x0010962C
	[Token(Token = "0x6003300")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Synergy_爆破王()
	{
		int num = 0;
		base.OnBoardStart(num);
	}

	// Token: 0x04001D91 RID: 7569
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001D91")]
	private float damage;

	// Token: 0x04001D92 RID: 7570
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001D92")]
	private float time;

	// Token: 0x04001D93 RID: 7571
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001D93")]
	private Vector2 shootPos;

	// Token: 0x04001D94 RID: 7572
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001D94")]
	private float cool;
}
