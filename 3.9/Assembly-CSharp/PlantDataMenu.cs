using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020008A2 RID: 2210
[Token(Token = "0x20008A2")]
public class PlantDataMenu : BaseMenu
{
	// Token: 0x06002D28 RID: 11560 RVA: 0x000F6010 File Offset: 0x000F4210
	[Token(Token = "0x6002D28")]
	[Address(RVA = "0x6D4AD0", Offset = "0x6D30D0", VA = "0x1806D4AD0")]
	private void InitDataFromPlant()
	{
		Plant plant = this.plant;
		Toggle toggle = this.dieMeansLose;
		bool flag = plant.dieMeansLose;
		toggle.isOn = flag;
		Plant plant2 = this.plant;
		Toggle toggle2 = this.uncrashable;
		bool flag2 = plant2.uncrashable;
		toggle2.isOn = flag2;
	}

	// Token: 0x06002D29 RID: 11561 RVA: 0x000F6060 File Offset: 0x000F4260
	[Token(Token = "0x6002D29")]
	[Address(RVA = "0x6D4D50", Offset = "0x6D3350", VA = "0x1806D4D50")]
	private void SaveDataToPlant()
	{
		Toggle toggle = this.dieMeansLose;
		Plant plant = this.plant;
		bool isOn = toggle.m_IsOn;
		plant.dieMeansLose = isOn;
		Toggle toggle2 = this.uncrashable;
		Plant plant2 = this.plant;
		bool isOn2 = toggle2.m_IsOn;
		plant2.uncrashable = isOn2;
	}

	// Token: 0x06002D2A RID: 11562 RVA: 0x000F60B0 File Offset: 0x000F42B0
	[Token(Token = "0x6002D2A")]
	[Address(RVA = "0x6D4DA0", Offset = "0x6D33A0", VA = "0x1806D4DA0")]
	private void Start()
	{
		for (;;)
		{
			Plant plant = this.plant;
			int num = 0;
			if (plant == num)
			{
				break;
			}
			Board board = this.plant.board;
			this.toggles.SetActive(true);
			Toggle toggle = this.dieMeansLose;
			bool flag = this.plant.dieMeansLose;
			toggle.isOn = flag;
			Toggle toggle2 = this.uncrashable;
			bool flag2 = this.plant.uncrashable;
			toggle2.isOn = flag2;
			List<TextMeshProUGUI> list = this.nameText;
			bool flag3;
			string name;
			if (flag3)
			{
				name = Lawnf.GetName(this.plant.thePlantType);
			}
			ulong num2;
			if (num2 == (ulong)0L)
			{
				string text = string.Format("生命值：{0}/{1}\n", name, name);
				string text2 = "" + text;
				string text3 = string.Format("护盾量：{0}\n", text2);
				string text4 = text2 + text3;
				string text5 = string.Format("攻击力：{0}\n", text4);
				string text6 = text4 + text5;
				string text7 = string.Format("诅咒任务：{0}\n", text6);
				string text8 = text6 + text7;
				int num3 = 0;
				string text9 = string.Format("攻击间隔：{0}秒\n", text8);
				string text10 = text8 + text9;
				if (text10 == 0)
				{
				}
				string text11 = string.Format("攻速加成：{0:F0}%\n", text10);
				string text12 = text10 + text11;
				string text13 = string.Format("生产间隔：{0}秒\n", text12);
				string text14 = text12 + text13;
				string text15 = string.Format("属性倒计时：{0:F1}秒\n", text14);
				string text16 = text14 + text15;
				string text18;
				if (text16 != 0)
				{
					string text17 = string.Format("属性倒计速率：{0:F0}%\n", text16);
					text18 = text16 + text17;
				}
				string text22;
				if (TravelMgr.Instance.LuckyStrike > (float)num3)
				{
					TravelMgr instance = TravelMgr.Instance;
					float luckyStrike = instance.LuckyStrike;
					string text19 = string.Format("幸运一击率：{0:F0}%\n", instance);
					string text20 = text18 + text19;
					TravelMgr instance2 = TravelMgr.Instance;
					float luckyDamage = instance2.luckyDamage;
					string text21 = string.Format("幸运一击伤害：{0:F0}%\n", instance2);
					text22 = text20 + text21;
				}
				string text24;
				if (TravelMgr.Instance.DamageAmplification > (float)num3)
				{
					TravelMgr instance3 = TravelMgr.Instance;
					float damageAmplification = instance3.DamageAmplification;
					string text23 = string.Format("伤害增幅：{0:F0}%\n", instance3);
					text24 = text22 + text23;
				}
				string text25 = string.Format("磁力数量：{0}\n", text24);
				string text26 = text24 + text25;
				string text27 = string.Format("光照等级：{0}\n", text26);
				string text28 = text26 + text27;
				TravelMgr instance4 = TravelMgr.Instance;
				TravelData data = instance4.data;
				float num4;
				if (num4 > (float)num3)
				{
					string text29 = string.Format("独立伤害增幅：{0:F0}%\n", instance4);
					string text30 = text28 + text29;
				}
				bool flag4;
				if (flag4)
				{
				}
				ulong num5;
				if (num5 == (ulong)0L)
				{
					break;
				}
			}
		}
		base.PopMenu();
	}

	// Token: 0x06002D2B RID: 11563 RVA: 0x000F6374 File Offset: 0x000F4574
	[Token(Token = "0x6002D2B")]
	[Address(RVA = "0x6A9060", Offset = "0x6A7660", VA = "0x1806A9060")]
	private void Update()
	{
		if (Input.GetKeyDownInt((KeyCode)((uint)27)))
		{
		}
	}

	// Token: 0x06002D2C RID: 11564 RVA: 0x000F638C File Offset: 0x000F458C
	[Token(Token = "0x6002D2C")]
	[Address(RVA = "0x6D4C70", Offset = "0x6D3270", VA = "0x1806D4C70", Slot = "8")]
	public override void OnExit()
	{
		Time.timeScale = GameAPP.config.gameSpeed;
		Board board = this.plant.board;
		bool isOn = this.dieMeansLose.m_IsOn;
		this.plant.dieMeansLose = isOn;
		Toggle toggle = this.uncrashable;
		Plant plant = this.plant;
		bool isOn2 = toggle.m_IsOn;
		plant.uncrashable = isOn2;
	}

	// Token: 0x06002D2D RID: 11565 RVA: 0x000F63F4 File Offset: 0x000F45F4
	[Token(Token = "0x6002D2D")]
	[Address(RVA = "0x6D4B30", Offset = "0x6D3130", VA = "0x1806D4B30")]
	public void LookInAlmanac()
	{
		Plant plant = this.plant;
		int num = 0;
		if (plant != num)
		{
			UIResourcesLoader uimanager = GameAPP.UIManager;
			Transform canvasUp = GameAPP.canvasUp;
			int num2 = 0;
			BaseMenu baseMenu = uimanager.Push((UIType)((uint)56), canvasUp, num2 != 0);
			PlantType thePlantType = this.plant.thePlantType;
		}
	}

	// Token: 0x06002D2E RID: 11566 RVA: 0x000F6448 File Offset: 0x000F4648
	[Token(Token = "0x6002D2E")]
	[Address(RVA = "0x6D5800", Offset = "0x6D3E00", VA = "0x1806D5800")]
	public PlantDataMenu()
	{
		List<TextMeshProUGUI> list = new List();
		this.nameText = list;
		List<TextMeshProUGUI> list2 = new List();
		this.infoText = list2;
		base..ctor();
	}

	// Token: 0x04001B0B RID: 6923
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001B0B")]
	public Plant plant;

	// Token: 0x04001B0C RID: 6924
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001B0C")]
	public List<TextMeshProUGUI> nameText;

	// Token: 0x04001B0D RID: 6925
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001B0D")]
	public List<TextMeshProUGUI> infoText;

	// Token: 0x04001B0E RID: 6926
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001B0E")]
	public Toggle dieMeansLose;

	// Token: 0x04001B0F RID: 6927
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001B0F")]
	public Toggle uncrashable;

	// Token: 0x04001B10 RID: 6928
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001B10")]
	public GameObject toggles;
}
