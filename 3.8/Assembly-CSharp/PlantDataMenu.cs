using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000866 RID: 2150
[Token(Token = "0x2000866")]
public class PlantDataMenu : BaseMenu
{
	// Token: 0x06002BF6 RID: 11254 RVA: 0x000F1398 File Offset: 0x000EF598
	[Token(Token = "0x6002BF6")]
	[Address(RVA = "0x66FF80", Offset = "0x66E580", VA = "0x18066FF80")]
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

	// Token: 0x06002BF7 RID: 11255 RVA: 0x000F13E8 File Offset: 0x000EF5E8
	[Token(Token = "0x6002BF7")]
	[Address(RVA = "0x670200", Offset = "0x66E800", VA = "0x180670200")]
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

	// Token: 0x06002BF8 RID: 11256 RVA: 0x000F1438 File Offset: 0x000EF638
	[Token(Token = "0x6002BF8")]
	[Address(RVA = "0x670250", Offset = "0x66E850", VA = "0x180670250")]
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
				int num3 = 0;
				string text7 = string.Format("攻击间隔：{0}秒\n", text6);
				string text8 = text6 + text7;
				if (text8 == 0)
				{
				}
				string text9 = string.Format("攻速加成：{0:F0}%\n", text8);
				string text10 = text8 + text9;
				string text11 = string.Format("生产间隔：{0}秒\n", text10);
				string text12 = text10 + text11;
				string text13 = string.Format("属性倒计时：{0:F1}秒\n", text12);
				string text14 = text12 + text13;
				string text16;
				if (text14 != 0)
				{
					string text15 = string.Format("属性倒计速率：{0:F0}%\n", text14);
					text16 = text14 + text15;
				}
				string text20;
				if (TravelMgr.Instance.LuckyStrike > (float)num3)
				{
					TravelMgr instance = TravelMgr.Instance;
					float luckyStrike = instance.LuckyStrike;
					string text17 = string.Format("幸运一击率：{0:F0}%\n", instance);
					string text18 = text16 + text17;
					TravelMgr instance2 = TravelMgr.Instance;
					float luckyDamage = instance2.luckyDamage;
					string text19 = string.Format("幸运一击伤害：{0:F0}%\n", instance2);
					text20 = text18 + text19;
				}
				string text22;
				if (TravelMgr.Instance.DamageAmplification > (float)num3)
				{
					TravelMgr instance3 = TravelMgr.Instance;
					float damageAmplification = instance3.DamageAmplification;
					string text21 = string.Format("伤害增幅：{0:F0}%\n", instance3);
					text22 = text20 + text21;
				}
				string text23 = string.Format("磁力数量：{0}\n", text22);
				string text24 = text22 + text23;
				string text25 = string.Format("光照等级：{0}\n", text24);
				string text26 = text24 + text25;
				TravelMgr instance4 = TravelMgr.Instance;
				TravelData data = instance4.data;
				float num4;
				if (num4 > (float)num3)
				{
					string text27 = string.Format("独立伤害增幅：{0:F0}%\n", instance4);
					string text28 = text26 + text27;
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

	// Token: 0x06002BF9 RID: 11257 RVA: 0x000F16E4 File Offset: 0x000EF8E4
	[Token(Token = "0x6002BF9")]
	[Address(RVA = "0x644900", Offset = "0x642F00", VA = "0x180644900")]
	private void Update()
	{
		if (Input.GetKeyDownInt((KeyCode)((uint)27)))
		{
		}
	}

	// Token: 0x06002BFA RID: 11258 RVA: 0x000F16FC File Offset: 0x000EF8FC
	[Token(Token = "0x6002BFA")]
	[Address(RVA = "0x670120", Offset = "0x66E720", VA = "0x180670120", Slot = "8")]
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

	// Token: 0x06002BFB RID: 11259 RVA: 0x000F1764 File Offset: 0x000EF964
	[Token(Token = "0x6002BFB")]
	[Address(RVA = "0x66FFE0", Offset = "0x66E5E0", VA = "0x18066FFE0")]
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

	// Token: 0x06002BFC RID: 11260 RVA: 0x000F17B8 File Offset: 0x000EF9B8
	[Token(Token = "0x6002BFC")]
	[Address(RVA = "0x670C30", Offset = "0x66F230", VA = "0x180670C30")]
	public PlantDataMenu()
	{
		List<TextMeshProUGUI> list = new List();
		this.nameText = list;
		List<TextMeshProUGUI> list2 = new List();
		this.infoText = list2;
		base..ctor();
	}

	// Token: 0x04001A1D RID: 6685
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001A1D")]
	public Plant plant;

	// Token: 0x04001A1E RID: 6686
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001A1E")]
	public List<TextMeshProUGUI> nameText;

	// Token: 0x04001A1F RID: 6687
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001A1F")]
	public List<TextMeshProUGUI> infoText;

	// Token: 0x04001A20 RID: 6688
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001A20")]
	public Toggle dieMeansLose;

	// Token: 0x04001A21 RID: 6689
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001A21")]
	public Toggle uncrashable;

	// Token: 0x04001A22 RID: 6690
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001A22")]
	public GameObject toggles;
}
