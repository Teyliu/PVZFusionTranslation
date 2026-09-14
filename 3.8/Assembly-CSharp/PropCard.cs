using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x0200060A RID: 1546
[Token(Token = "0x200060A")]
public class PropCard : MonoBehaviour
{
	// Token: 0x06001D2E RID: 7470 RVA: 0x0009C02C File Offset: 0x0009A22C
	[Token(Token = "0x6001D2E")]
	[Address(RVA = "0x51B310", Offset = "0x519910", VA = "0x18051B310")]
	private void Start()
	{
		Garden instance = Garden.Instance;
		this.garden = instance;
		this.Init();
	}

	// Token: 0x06001D2F RID: 7471 RVA: 0x0009C04C File Offset: 0x0009A24C
	[Token(Token = "0x6001D2F")]
	[Address(RVA = "0x51B190", Offset = "0x519790", VA = "0x18051B190")]
	private void Init()
	{
		int num = (int)this.theEquipmentType;
		TextMeshProUGUI textMeshProUGUI = this.countText;
		ValueTuple<int, int> valueTuple;
		this.restCount = valueTuple;
		string text;
		textMeshProUGUI.text = text;
		GameObject gameObject = this.shadow;
		bool flag = this.restCount <= 0;
		gameObject.SetActive(flag);
		Func<EquipmentData, bool> func;
		EquipmentData equipmentData = Enumerable.FirstOrDefault<EquipmentData>(TreasureData.equipmentData, func);
		this.data = equipmentData;
		throw new NullReferenceException();
	}

	// Token: 0x06001D30 RID: 7472 RVA: 0x0009C0B0 File Offset: 0x0009A2B0
	[Token(Token = "0x6001D30")]
	[Address(RVA = "0x51AEA0", Offset = "0x5194A0", VA = "0x18051AEA0")]
	public bool Check()
	{
		if (this.restCount > 0)
		{
			return true;
		}
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)47), canvasUp, num != 0);
		EquipmentType equipmentType = this.theEquipmentType;
		Dictionary<EquipmentType, ValueTuple<int, string>> equipmentCost = TreasureData.EquipmentCost;
		bool flag;
		if (!flag)
		{
		}
		string text = string.Format("存货不足，是否以{0}的价格购买{1}？", flag, "未命名");
		int cost;
		Action action = delegate
		{
			int cost2 = cost;
			TreasureData.treasureMoney = TreasureData.treasureMoney;
			List<EquipmentData> equipmentData = TreasureData.equipmentData;
			EquipmentData equipmentData2 = new EquipmentData();
			equipmentData2.level = (int)((ulong)1L);
			EquipmentType equipmentType2 = this.theEquipmentType;
			equipmentData2.theEquipmentType = equipmentType2;
			equipmentData2.level = (int)((ulong)1L);
			int size = equipmentData._size;
			equipmentData._size = equipmentData2;
			equipmentData2.set = equipmentData2 != null;
			this.Init();
		};
		throw new NullReferenceException();
	}

	// Token: 0x06001D31 RID: 7473 RVA: 0x0009C138 File Offset: 0x0009A338
	[Token(Token = "0x6001D31")]
	[Address(RVA = "0x51B3A0", Offset = "0x5199A0", VA = "0x18051B3A0")]
	public void UseOnce()
	{
		this.Init();
	}

	// Token: 0x06001D32 RID: 7474 RVA: 0x0009C14C File Offset: 0x0009A34C
	[Token(Token = "0x6001D32")]
	[Address(RVA = "0x51B2D0", Offset = "0x5198D0", VA = "0x18051B2D0")]
	private void OnMouseEnter()
	{
		if (this.garden.free)
		{
			CursorChange.SetClickCursor();
			return;
		}
	}

	// Token: 0x06001D33 RID: 7475 RVA: 0x0009C178 File Offset: 0x0009A378
	[Token(Token = "0x6001D33")]
	[Address(RVA = "0x51B300", Offset = "0x519900", VA = "0x18051B300")]
	private void OnMouseExit()
	{
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06001D34 RID: 7476 RVA: 0x0009C18C File Offset: 0x0009A38C
	[Token(Token = "0x6001D34")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public PropCard()
	{
	}

	// Token: 0x04000FA8 RID: 4008
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000FA8")]
	[Header("引用")]
	public Garden garden;

	// Token: 0x04000FA9 RID: 4009
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000FA9")]
	public GameObject shadow;

	// Token: 0x04000FAA RID: 4010
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000FAA")]
	public EquipmentData data;

	// Token: 0x04000FAB RID: 4011
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000FAB")]
	public TextMeshProUGUI countText;

	// Token: 0x04000FAC RID: 4012
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000FAC")]
	[Header("属性")]
	public EquipmentType theEquipmentType;

	// Token: 0x04000FAD RID: 4013
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000FAD")]
	public int restCount;
}
