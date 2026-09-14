using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;

// Token: 0x020008D3 RID: 2259
[Token(Token = "0x20008D3")]
public class TreasureUpgradeMenu : BaseMenu
{
	// Token: 0x06002E0B RID: 11787 RVA: 0x000FC0E8 File Offset: 0x000FA2E8
	[Token(Token = "0x6002E0B")]
	[Address(RVA = "0x709E40", Offset = "0x708440", VA = "0x180709E40")]
	private void Start()
	{
		this.InitWareHouseUpgrade();
	}

	// Token: 0x06002E0C RID: 11788 RVA: 0x000FC0FC File Offset: 0x000FA2FC
	[Token(Token = "0x6002E0C")]
	[Address(RVA = "0x709E40", Offset = "0x708440", VA = "0x180709E40", Slot = "9")]
	public override void OnBackEnter()
	{
		this.InitWareHouseUpgrade();
	}

	// Token: 0x06002E0D RID: 11789 RVA: 0x000FC110 File Offset: 0x000FA310
	[Token(Token = "0x6002E0D")]
	[Address(RVA = "0x709E50", Offset = "0x708450", VA = "0x180709E50")]
	public void UpgradeWareHouse()
	{
		ulong num3;
		do
		{
			int num = 0;
			List<TreasureCardData> treasureCards = TreasureData.treasureCards;
			List<TreasureCardData> list = new List();
			bool flag;
			if (flag)
			{
				TreasureUpgradeMenu.<>c__DisplayClass4_0 CS$<>8__locals1;
				CS$<>8__locals1.item = num;
				Predicate<TreasureCardData> predicate;
				if (treasureCards.Find(predicate) != 0)
				{
				}
			}
			ulong num2;
			if (num2 != (ulong)0L)
			{
				goto IL_00C6;
			}
			InGameText instance = InGameText.Instance;
			bool flag2;
			if (flag2)
			{
				bool flag3 = TreasureData.treasureCards.Remove(num);
			}
		}
		while (num3 != (ulong)0L);
		InGameText instance2 = InGameText.Instance;
		GameAPP.PlaySound(125, 0.5f, 1f);
		int num4 = TreasureData.wareHouseLevel;
		num4++;
		TreasureData.wareHouseLevel = num4;
		SaveInfo.Instance.SavePlayerData();
		return;
		IL_00C6:
		throw new NullReferenceException();
	}

	// Token: 0x06002E0E RID: 11790 RVA: 0x000FC1EC File Offset: 0x000FA3EC
	[Token(Token = "0x6002E0E")]
	[Address(RVA = "0x709A00", Offset = "0x708000", VA = "0x180709A00")]
	private void InitWareHouseUpgrade()
	{
		int num;
		do
		{
			num = 0;
			int wareHouseLevel = TreasureData.wareHouseLevel;
			TextMeshProUGUI textMeshProUGUI = this.wareHouseText;
			long num2 = (long)(wareHouseLevel * (int)((uint)44));
			string text;
			textMeshProUGUI.text = text;
			bool flag = this.UpgradeCards.TryGetValue(wareHouseLevel, num);
			List<TreasureCard> list = this.wareHouseCost;
			if (flag)
			{
				break;
			}
			bool flag2;
			if (flag2)
			{
			}
		}
		while (num != 0);
		TreasureCard treasureCard = this.wareHouseCost[num];
		TreasureUpgradeMenu.<>c__DisplayClass5_0 CS$<>8__locals1;
		CS$<>8__locals1.card = treasureCard;
		TreasureCard card = CS$<>8__locals1.card;
		CS$<>8__locals1.card.Init();
		CS$<>8__locals1.card.theStatus = (TreasureCard.Status)((ulong)4L);
		CS$<>8__locals1.card.MaxDurability = 1;
		TreasureCard card2 = CS$<>8__locals1.card;
		Predicate<TreasureCardData> predicate;
		int size = TreasureData.treasureCards.FindAll(predicate)._size;
		card2.Durability = size;
		num++;
		List<TreasureCard> list2 = this.wareHouseCost;
	}

	// Token: 0x06002E0F RID: 11791 RVA: 0x000FC2C4 File Offset: 0x000FA4C4
	[Token(Token = "0x6002E0F")]
	[Address(RVA = "0x70A430", Offset = "0x708A30", VA = "0x18070A430")]
	public TreasureUpgradeMenu()
	{
		List<TreasureCard> list = new List();
		this.wareHouseCost = list;
		Dictionary<int, List<PlantType>> dictionary = new Dictionary();
		List<PlantType> list2 = new List();
		int size = list2._size;
		int size2 = list2._size;
		int size3 = list2._size;
		int size4 = list2._size;
		int size5 = list2._size;
		dictionary.Add(1, list2);
		List<PlantType> list3 = new List();
		int size6 = list3._size;
		int size7 = list3._size;
		int size8 = list3._size;
		int size9 = list3._size;
		int size10 = list3._size;
		dictionary.Add(2, list3);
		List<PlantType> list4 = new List();
		int size11 = list4._size;
		int size12 = list4._size;
		int size13 = list4._size;
		int size14 = list4._size;
		int size15 = list4._size;
		dictionary.Add(3, list4);
		List<PlantType> list5 = new List();
		int size16 = list5._size;
		int size17 = list5._size;
		int size18 = list5._size;
		int size19 = list5._size;
		int size20 = list5._size;
		dictionary.Add(4, list5);
		this.UpgradeCards = dictionary;
		base..ctor();
	}

	// Token: 0x04001BEA RID: 7146
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001BEA")]
	public TextMeshProUGUI wareHouseText;

	// Token: 0x04001BEB RID: 7147
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001BEB")]
	public List<TreasureCard> wareHouseCost;

	// Token: 0x04001BEC RID: 7148
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001BEC")]
	private readonly Dictionary<int, List<PlantType>> UpgradeCards;
}
