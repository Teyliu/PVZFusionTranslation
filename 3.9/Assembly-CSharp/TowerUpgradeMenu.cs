using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020008BD RID: 2237
[Token(Token = "0x20008BD")]
public class TowerUpgradeMenu : BaseMenu
{
	// Token: 0x06002DA3 RID: 11683 RVA: 0x000F96C4 File Offset: 0x000F78C4
	[Token(Token = "0x6002DA3")]
	[Address(RVA = "0x6FFF00", Offset = "0x6FE500", VA = "0x1806FFF00", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		TowerUpgradeMenu.Instance = this;
	}

	// Token: 0x06002DA4 RID: 11684 RVA: 0x000F96E0 File Offset: 0x000F78E0
	[Token(Token = "0x6002DA4")]
	[Address(RVA = "0x701630", Offset = "0x6FFC30", VA = "0x180701630")]
	private void Start()
	{
		int thePlantType = (int)this.plant.thePlantType;
		PlantDataManager.PlantData plantData;
		int cost = plantData.cost;
		this.basicCost = cost;
		this.SetText();
		TowerPlant towerPlant = this.plant;
		GameObject gameObject = this.shootButton;
		int num = 0;
		gameObject.SetActive(num != 0);
	}

	// Token: 0x06002DA5 RID: 11685 RVA: 0x000F9738 File Offset: 0x000F7938
	[Token(Token = "0x6002DA5")]
	[Address(RVA = "0x700620", Offset = "0x6FEC20", VA = "0x180700620")]
	private void SetText()
	{
		uint num;
		TextMeshProUGUI component = this.upgrade1.transform.GetChild((int)num).GetComponent<TextMeshProUGUI>();
		Transform transform = this.upgrade1.transform;
		int num2 = 0;
		TextMeshProUGUI component2 = transform.GetChild(num2).GetComponent<TextMeshProUGUI>();
		uint num3;
		Transform child = this.upgrade1.transform.GetChild((int)num3);
		int num4 = 0;
		TextMeshProUGUI component3 = child.GetChild(num4).GetComponent<TextMeshProUGUI>();
		component.text = "基础强化";
		string text = component.text;
		component2.text = text;
		text += text;
		text += text;
		string text2 = string.Format("{0}", text);
		component3.text = text2;
		if (this.plant.upgradeType != TowerUpgradeType.Default)
		{
		}
		TowerPlant towerPlant = this.plant;
		Dictionary<PlantType, ValueTuple<string, string>> towerUpgradeDescription = TowerData.TowerUpgradeDescription;
		bool flag;
		if (flag)
		{
			uint num5;
			TextMeshProUGUI component4 = this.upgrade2.transform.GetChild((int)num5).GetComponent<TextMeshProUGUI>();
			Transform transform2 = this.upgrade2.transform;
			int num6 = 0;
			TextMeshProUGUI component5 = transform2.GetChild(num6).GetComponent<TextMeshProUGUI>();
			uint num7;
			Transform child2 = this.upgrade2.transform.GetChild((int)num7);
			int num8 = 0;
			TextMeshProUGUI component6 = child2.GetChild(num8).GetComponent<TextMeshProUGUI>();
			component4.text = "分支一，";
			string text3 = component4.text;
			string text4;
			component4.text = text4;
			int num9 = this.basicCost;
			string text5 = string.Format("{0}", num9);
			component6.text = text5;
			string text6 = component4.text;
			component5.text = text6;
			if (this.plant.upgradeType == TowerUpgradeType.BranchA)
			{
			}
		}
		TowerPlant towerPlant2 = this.plant;
		Dictionary<PlantType, ValueTuple<string, string>> towerUpgradeDescription2 = TowerData.TowerUpgradeDescription;
		bool flag2;
		if (flag2)
		{
			uint num10;
			TextMeshProUGUI component7 = this.upgrade3.transform.GetChild((int)num10).GetComponent<TextMeshProUGUI>();
			Transform transform3 = this.upgrade3.transform;
			int num11 = 0;
			TextMeshProUGUI component8 = transform3.GetChild(num11).GetComponent<TextMeshProUGUI>();
			uint num12;
			Transform child3 = this.upgrade3.transform.GetChild((int)num12);
			int num13 = 0;
			TextMeshProUGUI component9 = child3.GetChild(num13).GetComponent<TextMeshProUGUI>();
			component7.text = "分支二，";
			string text7 = component7.text;
			string text8;
			component7.text = text8;
			int num14 = this.basicCost;
			string text9 = string.Format("{0}", num14);
			component9.text = text9;
			string text10 = component7.text;
			component8.text = text10;
			if (this.plant.upgradeType == TowerUpgradeType.BranchB)
			{
			}
		}
		TowerPlant towerPlant3 = this.plant;
		float basicDamage = towerPlant3.basicDamage;
		float attackSpeed = towerPlant3.attackSpeed;
		TextMeshProUGUI textMeshProUGUI = this.des;
		float num15 = basicDamage * 100f;
		float num16 = attackSpeed * 100f;
		textMeshProUGUI.text = "当前数据：\n";
		TextMeshProUGUI textMeshProUGUI2 = this.des;
		string text11 = textMeshProUGUI2.text;
		int damage = this.plant.Damage;
		int num17;
		float num18;
		string text12 = string.Format("攻击力：{0}(+{1:F0}%)\n", num17, num18);
		string text13 = text11 + text12;
		textMeshProUGUI2.text = text13;
		TextMeshProUGUI textMeshProUGUI3 = this.des;
		string text14 = textMeshProUGUI3.text;
		TowerPlant towerPlant4 = this.plant;
		string text15 = string.Format("射速：{0:F2}(+{1:F0}%)\n", text14, text14);
		string text16 = text14 + text15;
		textMeshProUGUI3.text = text16;
		TextMeshProUGUI textMeshProUGUI4 = this.des;
		string text17 = textMeshProUGUI4.text;
		string uniqueText = this.plant.GetUniqueText();
		string text18 = text17 + uniqueText;
		textMeshProUGUI4.text = text18;
		this.des2.text = "当前数据：\n";
		TextMeshProUGUI textMeshProUGUI5 = this.des2;
		string text19 = textMeshProUGUI5.text;
		object[] array = new object[4];
		int num19 = 0;
		if (num15 <= (float)num19)
		{
		}
		if ("white" != 0)
		{
		}
		array[0] = "white";
		int damage2 = this.plant.Damage;
		int num20;
		if (num20 != 0)
		{
		}
		array[1] = num20;
		if ("white" != 0)
		{
		}
		array[2] = "white";
		if (num20 != 0)
		{
		}
		array[3] = num20;
		string text20 = string.Format("攻击力：<color={0}>{1}</color><color={2}>(+{3:F0}%)</color>\n", array);
		string text21 = "攻击力：<color={0}>{1}</color><color={2}>(+{3:F0}%)</color>\n" + text20;
		textMeshProUGUI5.text = text21;
		TextMeshProUGUI textMeshProUGUI6 = this.des2;
		string text22 = textMeshProUGUI6.text;
		object[] array2 = new object[4];
		if (num16 <= (float)num19)
		{
		}
		if ("white" != 0)
		{
		}
		array2[0] = "white";
		TowerPlant towerPlant5 = this.plant;
		if (array2 != 0)
		{
		}
		array2[1] = array2;
		if ("white" != 0)
		{
		}
		array2[2] = "white";
		if (array2 != 0)
		{
		}
		array2[3] = array2;
		string text23 = string.Format("射速：<color={0}>{1:F2}</color><color={2}>(+{3:F0}%)</color>\n", array2);
		string text24 = "射速：<color={0}>{1:F2}</color><color={2}>(+{3:F0}%)</color>\n" + text23;
		textMeshProUGUI6.text = text24;
		TextMeshProUGUI textMeshProUGUI7 = this.des2;
		string text25 = textMeshProUGUI7.text;
		string uniqueText2 = this.plant.GetUniqueText();
		string text26 = text25 + uniqueText2;
		textMeshProUGUI7.text = text26;
	}

	// Token: 0x06002DA6 RID: 11686 RVA: 0x000F9C04 File Offset: 0x000F7E04
	[Token(Token = "0x6002DA6")]
	[Address(RVA = "0x6FFFD0", Offset = "0x6FE5D0", VA = "0x1806FFFD0")]
	public void Select1()
	{
		TowerPlant towerPlant = this.plant;
		if (towerPlant.upgradeType == TowerUpgradeType.Default)
		{
			Board board = towerPlant.board;
			uint num;
			GameAPP.PlaySound((int)num, 0.5f, 1f);
			InGameText instance = InGameText.Instance;
			return;
		}
		InGameText instance2 = InGameText.Instance;
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
	}

	// Token: 0x06002DA7 RID: 11687 RVA: 0x000F9C98 File Offset: 0x000F7E98
	[Token(Token = "0x6002DA7")]
	[Address(RVA = "0x7001C0", Offset = "0x6FE7C0", VA = "0x1807001C0")]
	public void Select2()
	{
		TowerUpgradeType upgradeType = this.plant.upgradeType;
		if (upgradeType == TowerUpgradeType.Default)
		{
			InGameText instance = InGameText.Instance;
			uint num;
			GameAPP.PlaySound((int)num, 0.5f, 1f);
			return;
		}
		if (upgradeType != TowerUpgradeType.Default)
		{
			if (upgradeType != TowerUpgradeType.Default)
			{
				if (upgradeType != TowerUpgradeType.Upgraded)
				{
					goto IL_0030;
				}
				InGameText instance2 = InGameText.Instance;
			}
			InGameText instance3 = InGameText.Instance;
		}
		IL_0030:
		Board board = this.plant.board;
		int num2 = this.basicCost;
		if (board.theSun < num2)
		{
			uint num3;
			GameAPP.PlaySound((int)num3, 0.5f, 1f);
			InGameText instance4 = InGameText.Instance;
			return;
		}
		TowerPlant towerPlant = this.plant;
		uint num4;
		this.plant.board.UseSun((float)num4);
		this.SetText();
	}

	// Token: 0x06002DA8 RID: 11688 RVA: 0x000F9D54 File Offset: 0x000F7F54
	[Token(Token = "0x6002DA8")]
	[Address(RVA = "0x7003F0", Offset = "0x6FE9F0", VA = "0x1807003F0")]
	public void Select3()
	{
		TowerUpgradeType upgradeType = this.plant.upgradeType;
		if (upgradeType == TowerUpgradeType.Default)
		{
			InGameText instance = InGameText.Instance;
			uint num;
			GameAPP.PlaySound((int)num, 0.5f, 1f);
			return;
		}
		if (upgradeType != TowerUpgradeType.Default)
		{
			if (upgradeType != TowerUpgradeType.Default)
			{
				if (upgradeType != TowerUpgradeType.Upgraded)
				{
					goto IL_0030;
				}
				InGameText instance2 = InGameText.Instance;
			}
			InGameText instance3 = InGameText.Instance;
		}
		IL_0030:
		Board board = this.plant.board;
		int num2 = this.basicCost;
		if (board.theSun < num2)
		{
			uint num3;
			GameAPP.PlaySound((int)num3, 0.5f, 1f);
			InGameText instance4 = InGameText.Instance;
			return;
		}
		TowerPlant towerPlant = this.plant;
		uint num4;
		this.plant.board.UseSun((float)num4);
		this.SetText();
	}

	// Token: 0x06002DA9 RID: 11689 RVA: 0x000F9E10 File Offset: 0x000F8010
	[Token(Token = "0x6002DA9")]
	[Address(RVA = "0x6FFF60", Offset = "0x6FE560", VA = "0x1806FFF60")]
	public void Quit()
	{
		CursorChange.SetDefaultCursor();
		GameAPP.UIManager.Pop();
	}

	// Token: 0x06002DAA RID: 11690 RVA: 0x000F9E34 File Offset: 0x000F8034
	[Token(Token = "0x6002DAA")]
	[Address(RVA = "0x7016E0", Offset = "0x6FFCE0", VA = "0x1807016E0")]
	private void Update()
	{
		if (!Input.GetKeyDownInt((KeyCode)((uint)27)))
		{
			TowerPlant towerPlant = this.plant;
			int num = 0;
			if (!(towerPlant == num))
			{
				goto IL_002F;
			}
		}
		CursorChange.SetDefaultCursor();
		GameAPP.UIManager.Pop();
		IL_002F:
		if (Input.GetMouseButtonDown(0))
		{
			Camera main = Camera.main;
			float z = Input.mousePosition.z;
			this.Quit();
		}
	}

	// Token: 0x06002DAB RID: 11691 RVA: 0x000F9E9C File Offset: 0x000F809C
	[Token(Token = "0x6002DAB")]
	[Address(RVA = "0x7015A0", Offset = "0x6FFBA0", VA = "0x1807015A0")]
	public void Shoot()
	{
		TowerPlant towerPlant = this.plant;
		int num = 0;
		if (towerPlant != num)
		{
			this.plant.Shoot();
			this.Quit();
		}
	}

	// Token: 0x06002DAC RID: 11692 RVA: 0x000F9ED4 File Offset: 0x000F80D4
	[Token(Token = "0x6002DAC")]
	[Address(RVA = "0x667800", Offset = "0x665E00", VA = "0x180667800")]
	public TowerUpgradeMenu()
	{
	}

	// Token: 0x04001B7E RID: 7038
	[Token(Token = "0x4001B7E")]
	public static TowerUpgradeMenu Instance;

	// Token: 0x04001B7F RID: 7039
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001B7F")]
	public TowerPlant plant;

	// Token: 0x04001B80 RID: 7040
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001B80")]
	public GameObject upgrade1;

	// Token: 0x04001B81 RID: 7041
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001B81")]
	public GameObject upgrade2;

	// Token: 0x04001B82 RID: 7042
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001B82")]
	public GameObject upgrade3;

	// Token: 0x04001B83 RID: 7043
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001B83")]
	public TextMeshProUGUI des;

	// Token: 0x04001B84 RID: 7044
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001B84")]
	public TextMeshProUGUI des2;

	// Token: 0x04001B85 RID: 7045
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001B85")]
	public GameObject shootButton;

	// Token: 0x04001B86 RID: 7046
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001B86")]
	private int basicCost;
}
