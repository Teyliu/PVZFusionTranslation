using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020008C7 RID: 2247
[Token(Token = "0x20008C7")]
public class TreasureConfirmMenu : BaseMenu
{
	// Token: 0x06002DD1 RID: 11729 RVA: 0x000FAF10 File Offset: 0x000F9110
	[Token(Token = "0x6002DD1")]
	[Address(RVA = "0x705C10", Offset = "0x704210", VA = "0x180705C10")]
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

	// Token: 0x06002DD2 RID: 11730 RVA: 0x000FB070 File Offset: 0x000F9270
	[Token(Token = "0x6002DD2")]
	[Address(RVA = "0x705AE0", Offset = "0x7040E0", VA = "0x180705AE0")]
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

	// Token: 0x06002DD3 RID: 11731 RVA: 0x000FB09C File Offset: 0x000F929C
	[Token(Token = "0x6002DD3")]
	[Address(RVA = "0x7055E0", Offset = "0x703BE0", VA = "0x1807055E0")]
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

	// Token: 0x06002DD4 RID: 11732 RVA: 0x000FB124 File Offset: 0x000F9324
	[Token(Token = "0x6002DD4")]
	[Address(RVA = "0x705750", Offset = "0x703D50", VA = "0x180705750")]
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
			return;
		}
		TreasureData.treasureMoney = TreasureData.treasureMoney;
		SaveInfo.Instance.SavePlayerData();
	}

	// Token: 0x06002DD5 RID: 11733 RVA: 0x000FB1FC File Offset: 0x000F93FC
	[Token(Token = "0x6002DD5")]
	[Address(RVA = "0x705350", Offset = "0x703950", VA = "0x180705350")]
	private void Buy()
	{
		int num = this.card.cost;
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
		InGameText instance = InGameText.Instance;
	}

	// Token: 0x06002DD6 RID: 11734 RVA: 0x000FB2A0 File Offset: 0x000F94A0
	[Token(Token = "0x6002DD6")]
	[Address(RVA = "0x706030", Offset = "0x704630", VA = "0x180706030")]
	public TreasureConfirmMenu()
	{
		List<TextMeshProUGUI> list = new List();
		this.description = list;
		base..ctor();
	}

	// Token: 0x04001BB6 RID: 7094
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001BB6")]
	public TreasureCard card;

	// Token: 0x04001BB7 RID: 7095
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001BB7")]
	public List<TextMeshProUGUI> description;

	// Token: 0x04001BB8 RID: 7096
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001BB8")]
	public GameObject CollectionButton;

	// Token: 0x04001BB9 RID: 7097
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001BB9")]
	public ConfirmType confirmType;

	// Token: 0x04001BBA RID: 7098
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001BBA")]
	public Action customAction;

	// Token: 0x04001BBB RID: 7099
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001BBB")]
	public string customText;

	// Token: 0x04001BBC RID: 7100
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001BBC")]
	private int cost;
}
