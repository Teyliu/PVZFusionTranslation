using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;

// Token: 0x02000897 RID: 2199
[Token(Token = "0x2000897")]
public class TreasureUpgradeMenu : BaseMenu
{
	// Token: 0x06002CD9 RID: 11481 RVA: 0x000F7560 File Offset: 0x000F5760
	[Token(Token = "0x6002CD9")]
	[Address(RVA = "0x690790", Offset = "0x68ED90", VA = "0x180690790")]
	private void Start()
	{
		this.InitWareHouseUpgrade();
	}

	// Token: 0x06002CDA RID: 11482 RVA: 0x000F7574 File Offset: 0x000F5774
	[Token(Token = "0x6002CDA")]
	[Address(RVA = "0x690790", Offset = "0x68ED90", VA = "0x180690790", Slot = "9")]
	public override void OnBackEnter()
	{
		this.InitWareHouseUpgrade();
	}

	// Token: 0x06002CDB RID: 11483 RVA: 0x000F7588 File Offset: 0x000F5788
	[Token(Token = "0x6002CDB")]
	[Address(RVA = "0x6907A0", Offset = "0x68EDA0", VA = "0x1806907A0")]
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
				goto IL_00F2;
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
		int num4 = 0;
		instance2.ShowText("成功升级仓库", 3f, num4 != 0);
		GameAPP.PlaySound(125, 0.5f, 1f);
		int num5 = TreasureData.wareHouseLevel;
		num5++;
		TreasureData.wareHouseLevel = num5;
		SaveInfo.Instance.SavePlayerData();
		return;
		IL_00F2:
		throw new NullReferenceException();
	}

	// Token: 0x06002CDC RID: 11484 RVA: 0x000F7690 File Offset: 0x000F5890
	[Token(Token = "0x6002CDC")]
	[Address(RVA = "0x690350", Offset = "0x68E950", VA = "0x180690350")]
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

	// Token: 0x06002CDD RID: 11485 RVA: 0x000F7768 File Offset: 0x000F5968
	[Token(Token = "0x6002CDD")]
	[Address(RVA = "0x690D60", Offset = "0x68F360", VA = "0x180690D60")]
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

	// Token: 0x04001AFC RID: 6908
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001AFC")]
	public TextMeshProUGUI wareHouseText;

	// Token: 0x04001AFD RID: 6909
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001AFD")]
	public List<TreasureCard> wareHouseCost;

	// Token: 0x04001AFE RID: 6910
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001AFE")]
	private readonly Dictionary<int, List<PlantType>> UpgradeCards;
}
