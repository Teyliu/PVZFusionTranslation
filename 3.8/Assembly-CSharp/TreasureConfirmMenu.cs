using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x0200088B RID: 2187
[Token(Token = "0x200088B")]
public class TreasureConfirmMenu : BaseMenu
{
	// Token: 0x06002C9F RID: 11423 RVA: 0x000F635C File Offset: 0x000F455C
	[Token(Token = "0x6002C9F")]
	[Address(RVA = "0x68C560", Offset = "0x68AB60", VA = "0x18068C560")]
	private void Start()
	{
		if (this.confirmType <= ConfirmType.EnterFate)
		{
			int num = this.card.cost;
			string text = string.Format("你将花费{0}元以购买它", num);
			this.SetText(text);
			ulong num2;
			this.CollectionButton.SetActive(num2 != 0UL);
			TextMeshProUGUI[] componentsInChildren = this.CollectionButton.GetComponentsInChildren<TextMeshProUGUI>();
			int num3 = 0;
			if (num3 < componentsInChildren.Length)
			{
				TreasureCard treasureCard = this.card;
				HashSet<PlantType> collectedPlants = TreasureData.collectedPlants;
				PlantType plantType = treasureCard._plantType;
				if (collectedPlants.Contains(plantType))
				{
				}
				num3++;
				TreasureCard treasureCard2 = this.card;
				if (treasureCard2._maxDurability != 0)
				{
					int realCost = treasureCard2.RealCost;
				}
				this.SetText("出售该卡牌可以获得0元");
				this.SetText("你将进入普通难度，此难度禁用究极");
				this.SetText("进入困难难度需要消耗1000资产，通关后全额返还，此难度禁用究极");
				this.cost = (int)((ulong)1000L);
				this.SetText("进入炼狱难度需要消耗3000资产，通关后全额返还");
				this.cost = (int)((ulong)3000L);
				this.SetText("进入进化难度需要消耗10000资产，通关后全额返还");
				this.cost = (int)((ulong)10000L);
				this.SetText("重置后无法返回，重置后给999初始资金\n清除神秘仓库和大花园中的全部植物");
				int realCost2 = this.card.RealCost;
				string text2 = string.Format("该卡牌价值{0}元，是否丢弃？", realCost2);
				this.SetText(text2);
				string text3 = this.customText;
				this.SetText(text3);
				this.SetText("命运难度的卡牌不消耗耐久，但僵尸方获得随机强化");
				int num4 = 0;
				this.cost = num4;
			}
		}
	}

	// Token: 0x06002CA0 RID: 11424 RVA: 0x000F64BC File Offset: 0x000F46BC
	[Token(Token = "0x6002CA0")]
	[Address(RVA = "0x68C430", Offset = "0x68AA30", VA = "0x18068C430")]
	private void SetText(string text)
	{
		ulong num;
		do
		{
			List<TextMeshProUGUI> list = this.description;
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06002CA1 RID: 11425 RVA: 0x000F64E8 File Offset: 0x000F46E8
	[Token(Token = "0x6002CA1")]
	[Address(RVA = "0x68BF40", Offset = "0x68A540", VA = "0x18068BF40")]
	public void CollectPlant()
	{
		base.PopMenu();
		TreasureCard treasureCard = this.card;
		HashSet<PlantType> collectedPlants = TreasureData.collectedPlants;
		PlantType plantType = treasureCard._plantType;
		if (!collectedPlants.Contains(plantType))
		{
			TreasureCard treasureCard2 = this.card;
			HashSet<PlantType> collectedPlants2 = TreasureData.collectedPlants;
			PlantType plantType2 = treasureCard2._plantType;
			bool flag = collectedPlants2.Add(plantType2);
		}
		TreasureCard treasureCard3 = this.card;
		HashSet<PlantType> collectedPlants3 = TreasureData.collectedPlants;
		PlantType plantType3 = treasureCard3._plantType;
		bool flag2 = collectedPlants3.Remove(plantType3);
		SaveInfo.Instance.SavePlayerData();
	}

	// Token: 0x06002CA2 RID: 11426 RVA: 0x000F6570 File Offset: 0x000F4770
	[Token(Token = "0x6002CA2")]
	[Address(RVA = "0x68C0B0", Offset = "0x68A6B0", VA = "0x18068C0B0")]
	public void Confirm()
	{
		base.PopMenu();
		if (this.confirmType <= ConfirmType.EnterFate)
		{
			this.Buy();
			this.card.Sell();
			int num = this.cost;
			uint num2;
			GameAPP.PlaySound((int)num2, 0.5f, 1f);
			InGameText instance = InGameText.Instance;
			int num3 = 0;
			instance.ShowText("余额不足", 3f, num3 != 0);
			return;
		}
		TreasureData.treasureMoney = TreasureData.treasureMoney;
		SaveInfo.Instance.SavePlayerData();
	}

	// Token: 0x06002CA3 RID: 11427 RVA: 0x000F665C File Offset: 0x000F485C
	[Token(Token = "0x6002CA3")]
	[Address(RVA = "0x68BCD0", Offset = "0x68A2D0", VA = "0x18068BCD0")]
	private void Buy()
	{
		int num = this.card.cost;
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
		InGameText instance = InGameText.Instance;
		int num3 = 0;
		instance.ShowText("余额不足", 3f, num3 != 0);
	}

	// Token: 0x06002CA4 RID: 11428 RVA: 0x000F672C File Offset: 0x000F492C
	[Token(Token = "0x6002CA4")]
	[Address(RVA = "0x68C980", Offset = "0x68AF80", VA = "0x18068C980")]
	public TreasureConfirmMenu()
	{
		List<TextMeshProUGUI> list = new List();
		this.description = list;
		base..ctor();
	}

	// Token: 0x04001AC8 RID: 6856
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001AC8")]
	public TreasureCard card;

	// Token: 0x04001AC9 RID: 6857
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001AC9")]
	public List<TextMeshProUGUI> description;

	// Token: 0x04001ACA RID: 6858
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001ACA")]
	public GameObject CollectionButton;

	// Token: 0x04001ACB RID: 6859
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001ACB")]
	public ConfirmType confirmType;

	// Token: 0x04001ACC RID: 6860
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001ACC")]
	public Action customAction;

	// Token: 0x04001ACD RID: 6861
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001ACD")]
	public string customText;

	// Token: 0x04001ACE RID: 6862
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001ACE")]
	private int cost;
}
