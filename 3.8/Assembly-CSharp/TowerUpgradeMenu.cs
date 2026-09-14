using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000881 RID: 2177
[Token(Token = "0x2000881")]
public class TowerUpgradeMenu : BaseMenu
{
	// Token: 0x06002C71 RID: 11377 RVA: 0x000F4A44 File Offset: 0x000F2C44
	[Token(Token = "0x6002C71")]
	[Address(RVA = "0x686930", Offset = "0x684F30", VA = "0x180686930", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		TowerUpgradeMenu.Instance = this;
	}

	// Token: 0x06002C72 RID: 11378 RVA: 0x000F4A60 File Offset: 0x000F2C60
	[Token(Token = "0x6002C72")]
	[Address(RVA = "0x688020", Offset = "0x686620", VA = "0x180688020")]
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

	// Token: 0x06002C73 RID: 11379 RVA: 0x000F4AB8 File Offset: 0x000F2CB8
	[Token(Token = "0x6002C73")]
	[Address(RVA = "0x687010", Offset = "0x685610", VA = "0x180687010")]
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

	// Token: 0x06002C74 RID: 11380 RVA: 0x000F4F84 File Offset: 0x000F3184
	[Token(Token = "0x6002C74")]
	[Address(RVA = "0x686A00", Offset = "0x685000", VA = "0x180686A00")]
	public void Select1()
	{
		TowerPlant towerPlant = this.plant;
		if (towerPlant.upgradeType == TowerUpgradeType.Default)
		{
			Board board = towerPlant.board;
			uint num;
			GameAPP.PlaySound((int)num, 0.5f, 1f);
			InGameText instance = InGameText.Instance;
			int num2 = 0;
			instance.ShowText("阳光不足", 3f, num2 != 0);
			return;
		}
		InGameText instance2 = InGameText.Instance;
		int num3 = 0;
		instance2.ShowText("你已经升级了该选项", 3f, num3 != 0);
		uint num4;
		GameAPP.PlaySound((int)num4, 0.5f, 1f);
	}

	// Token: 0x06002C75 RID: 11381 RVA: 0x000F5044 File Offset: 0x000F3244
	[Token(Token = "0x6002C75")]
	[Address(RVA = "0x686BD0", Offset = "0x6851D0", VA = "0x180686BD0")]
	public void Select2()
	{
		TowerUpgradeType upgradeType = this.plant.upgradeType;
		if (upgradeType == TowerUpgradeType.Default)
		{
			InGameText instance = InGameText.Instance;
			int num = 0;
			instance.ShowText("需要先升级基础强化", 3f, num != 0);
			uint num2;
			GameAPP.PlaySound((int)num2, 0.5f, 1f);
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
		int num3 = this.basicCost;
		if (board.theSun < num3)
		{
			uint num4;
			GameAPP.PlaySound((int)num4, 0.5f, 1f);
			InGameText instance4 = InGameText.Instance;
			int num5 = 0;
			instance4.ShowText("阳光不足", 3f, num5 != 0);
			return;
		}
		TowerPlant towerPlant = this.plant;
		uint num6;
		this.plant.board.UseSun((float)num6);
		this.SetText();
	}

	// Token: 0x06002C76 RID: 11382 RVA: 0x000F512C File Offset: 0x000F332C
	[Token(Token = "0x6002C76")]
	[Address(RVA = "0x686DF0", Offset = "0x6853F0", VA = "0x180686DF0")]
	public void Select3()
	{
		TowerUpgradeType upgradeType = this.plant.upgradeType;
		if (upgradeType == TowerUpgradeType.Default)
		{
			InGameText instance = InGameText.Instance;
			int num = 0;
			instance.ShowText("需要先升级基础强化", 3f, num != 0);
			uint num2;
			GameAPP.PlaySound((int)num2, 0.5f, 1f);
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
		int num3 = this.basicCost;
		if (board.theSun < num3)
		{
			uint num4;
			GameAPP.PlaySound((int)num4, 0.5f, 1f);
			InGameText instance4 = InGameText.Instance;
			int num5 = 0;
			instance4.ShowText("阳光不足", 3f, num5 != 0);
			return;
		}
		TowerPlant towerPlant = this.plant;
		uint num6;
		this.plant.board.UseSun((float)num6);
		this.SetText();
	}

	// Token: 0x06002C77 RID: 11383 RVA: 0x000F5214 File Offset: 0x000F3414
	[Token(Token = "0x6002C77")]
	[Address(RVA = "0x686990", Offset = "0x684F90", VA = "0x180686990")]
	public void Quit()
	{
		CursorChange.SetDefaultCursor();
		GameAPP.UIManager.Pop();
	}

	// Token: 0x06002C78 RID: 11384 RVA: 0x000F5238 File Offset: 0x000F3438
	[Token(Token = "0x6002C78")]
	[Address(RVA = "0x6880D0", Offset = "0x6866D0", VA = "0x1806880D0")]
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

	// Token: 0x06002C79 RID: 11385 RVA: 0x000F52A0 File Offset: 0x000F34A0
	[Token(Token = "0x6002C79")]
	[Address(RVA = "0x687F90", Offset = "0x686590", VA = "0x180687F90")]
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

	// Token: 0x06002C7A RID: 11386 RVA: 0x000F52D8 File Offset: 0x000F34D8
	[Token(Token = "0x6002C7A")]
	[Address(RVA = "0x603FF0", Offset = "0x6025F0", VA = "0x180603FF0")]
	public TowerUpgradeMenu()
	{
	}

	// Token: 0x04001A90 RID: 6800
	[Token(Token = "0x4001A90")]
	public static TowerUpgradeMenu Instance;

	// Token: 0x04001A91 RID: 6801
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001A91")]
	public TowerPlant plant;

	// Token: 0x04001A92 RID: 6802
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001A92")]
	public GameObject upgrade1;

	// Token: 0x04001A93 RID: 6803
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001A93")]
	public GameObject upgrade2;

	// Token: 0x04001A94 RID: 6804
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001A94")]
	public GameObject upgrade3;

	// Token: 0x04001A95 RID: 6805
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001A95")]
	public TextMeshProUGUI des;

	// Token: 0x04001A96 RID: 6806
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001A96")]
	public TextMeshProUGUI des2;

	// Token: 0x04001A97 RID: 6807
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001A97")]
	public GameObject shootButton;

	// Token: 0x04001A98 RID: 6808
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001A98")]
	private int basicCost;
}
