using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x0200063F RID: 1599
[Token(Token = "0x200063F")]
public class PropCard : MonoBehaviour
{
	// Token: 0x06001E2D RID: 7725 RVA: 0x000A0B08 File Offset: 0x0009ED08
	[Token(Token = "0x6001E2D")]
	[Address(RVA = "0x5754A0", Offset = "0x573AA0", VA = "0x1805754A0")]
	private void Start()
	{
		Garden instance = Garden.Instance;
		this.garden = instance;
		this.Init();
	}

	// Token: 0x06001E2E RID: 7726 RVA: 0x000A0B28 File Offset: 0x0009ED28
	[Token(Token = "0x6001E2E")]
	[Address(RVA = "0x575320", Offset = "0x573920", VA = "0x180575320")]
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
		List<EquipmentData> equipmentData = TreasureData.equipmentData;
		Func<EquipmentData, bool> func = delegate(EquipmentData data)
		{
			if (data.set)
			{
			}
			EquipmentType equipmentType = this.theEquipmentType;
			return data.theEquipmentType == equipmentType;
		};
		EquipmentData equipmentData2 = Enumerable.FirstOrDefault<EquipmentData>(equipmentData, func);
		this.data = equipmentData2;
		throw new NullReferenceException();
	}

	// Token: 0x06001E2F RID: 7727 RVA: 0x000A0BA0 File Offset: 0x0009EDA0
	[Token(Token = "0x6001E2F")]
	[Address(RVA = "0x5750F0", Offset = "0x5736F0", VA = "0x1805750F0")]
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
		int num2 = 0;
		ValueTuple<int, string> valueTuple;
		string text = string.Format("存货不足，是否以{0}的价格购买{1}？", valueTuple, num2);
		int cost;
		Action action = delegate
		{
			int cost2 = cost;
			TreasureData.treasureMoney = TreasureData.treasureMoney;
			List<EquipmentData> equipmentData = TreasureData.equipmentData;
			EquipmentData equipmentData2 = new EquipmentData();
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

	// Token: 0x06001E30 RID: 7728 RVA: 0x000A0C14 File Offset: 0x0009EE14
	[Token(Token = "0x6001E30")]
	[Address(RVA = "0x575530", Offset = "0x573B30", VA = "0x180575530")]
	public void UseOnce()
	{
		this.Init();
	}

	// Token: 0x06001E31 RID: 7729 RVA: 0x000A0C28 File Offset: 0x0009EE28
	[Token(Token = "0x6001E31")]
	[Address(RVA = "0x575460", Offset = "0x573A60", VA = "0x180575460")]
	private void OnMouseEnter()
	{
		if (this.garden.free)
		{
			CursorChange.SetClickCursor();
			return;
		}
	}

	// Token: 0x06001E32 RID: 7730 RVA: 0x000A0C54 File Offset: 0x0009EE54
	[Token(Token = "0x6001E32")]
	[Address(RVA = "0x575490", Offset = "0x573A90", VA = "0x180575490")]
	private void OnMouseExit()
	{
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06001E33 RID: 7731 RVA: 0x000A0C68 File Offset: 0x0009EE68
	[Token(Token = "0x6001E33")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public PropCard()
	{
	}

	// Token: 0x04001070 RID: 4208
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001070")]
	[Header("引用")]
	public Garden garden;

	// Token: 0x04001071 RID: 4209
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001071")]
	public GameObject shadow;

	// Token: 0x04001072 RID: 4210
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001072")]
	public EquipmentData data;

	// Token: 0x04001073 RID: 4211
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001073")]
	public TextMeshProUGUI countText;

	// Token: 0x04001074 RID: 4212
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001074")]
	[Header("属性")]
	public EquipmentType theEquipmentType;

	// Token: 0x04001075 RID: 4213
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4001075")]
	public int restCount;
}
