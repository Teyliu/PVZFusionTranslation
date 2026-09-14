using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using GameLevel;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020009D4 RID: 2516
[Token(Token = "0x20009D4")]
public class CustomMenu_page3 : CustomMenu_page
{
	// Token: 0x060033AE RID: 13230 RVA: 0x00112FEC File Offset: 0x001111EC
	[Token(Token = "0x60033AE")]
	[Address(RVA = "0x716B60", Offset = "0x715160", VA = "0x180716B60")]
	private void AddCard(TheCard theCard)
	{
		int num = 0;
		bool flag = theCard == num;
		if (!flag)
		{
			if (theCard.isZombieCard == flag)
			{
				Dictionary<PlantType, List<TheCard>> dictionary = this.cardsDic;
				PlantType thePlantType = theCard.thePlantType;
				bool flag2;
				if (!flag2)
				{
					List<TheCard> list = new List();
					Dictionary<PlantType, List<TheCard>> dictionary2 = this.cardsDic;
				}
				string text;
				theCard.costText.text = text;
			}
			Dictionary<ZombieType, List<TheCard>> dictionary3 = this.zombieCardsDic;
			ZombieType theZombieType = theCard.theZombieType;
			bool flag3;
			if (!flag3)
			{
				List<TheCard> list2 = new List();
				Dictionary<ZombieType, List<TheCard>> dictionary4 = this.zombieCardsDic;
			}
			string text2;
			theCard.costText.text = text2;
			return;
		}
		Debug.LogWarning("AddCard: 尝试添加空卡片");
	}

	// Token: 0x060033AF RID: 13231 RVA: 0x00113088 File Offset: 0x00111288
	[Token(Token = "0x60033AF")]
	[Address(RVA = "0x71A390", Offset = "0x718990", VA = "0x18071A390")]
	private void UpdateCardsText(PlantType thePlantType)
	{
		ulong num3;
		do
		{
			int num = 0;
			Dictionary<PlantType, List<TheCard>> dictionary = this.cardsDic;
			bool flag;
			if (!flag)
			{
				break;
			}
			bool flag2;
			if (flag2)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x060033B0 RID: 13232 RVA: 0x001130D4 File Offset: 0x001112D4
	[Token(Token = "0x60033B0")]
	[Address(RVA = "0x717640", Offset = "0x715C40", VA = "0x180717640")]
	private PlantDataManager.PlantData GetTempPlantData(PlantType thePlantType)
	{
		Func<PlantDataManager.PlantData, bool> func;
		PlantDataManager.PlantData plantData = Enumerable.FirstOrDefault<PlantDataManager.PlantData>(CustomMenu._levelData.plantDatas, func);
		if (plantData == 0)
		{
			PlantType thePlantType2 = thePlantType;
		}
		return plantData;
	}

	// Token: 0x060033B1 RID: 13233 RVA: 0x00113118 File Offset: 0x00111318
	[Token(Token = "0x60033B1")]
	[Address(RVA = "0x717780", Offset = "0x715D80", VA = "0x180717780")]
	private ZombieDataManager.ZombieData GetTempZombieData(ZombieType theZombieType)
	{
		Func<ZombieDataManager.ZombieData, bool> func;
		ZombieDataManager.ZombieData zombieData = Enumerable.FirstOrDefault<ZombieDataManager.ZombieData>(CustomMenu._levelData.zombieDatas, func);
		if (zombieData == 0)
		{
			ZombieType theZombieType2 = theZombieType;
			Dictionary<ZombieType, ZombieDataManager.ZombieData> zombieDataDic = ZombieDataManager.zombieDataDic;
			ZombieDataManager.ZombieData zombieData2 = new ZombieDataManager.ZombieData();
			ZombieType theZombieType3 = theZombieType;
			zombieData2.theZombieType = theZombieType3;
		}
		return zombieData;
	}

	// Token: 0x060033B2 RID: 13234 RVA: 0x0011317C File Offset: 0x0011137C
	[Token(Token = "0x60033B2")]
	[Address(RVA = "0x7198A0", Offset = "0x717EA0", VA = "0x1807198A0")]
	public void SaveModify()
	{
		this.SavePreSelectCards();
		if (this.dirty)
		{
			ulong num;
			bool flag = int.TryParse(this.costInput.m_Text, (int)num);
			ulong num2;
			bool flag2 = float.TryParse(this.cdInput.m_Text, (float)num2);
			TheCard theCard = this.advancedCard;
			int num3 = 0;
			if ((this.isEditingZombie ? 1 : 0) == num3)
			{
				PlantType thePlantType = theCard.thePlantType;
				PlantDataManager.PlantData orCreatePlantData = this.GetOrCreatePlantData(thePlantType);
				orCreatePlantData.cost = (int)num;
				orCreatePlantData.cd = (float)num2;
				PlantType thePlantType2 = this.advancedCard.thePlantType;
				this.UpdateCardsText(thePlantType2);
			}
			ZombieType theZombieType = theCard.theZombieType;
			ZombieDataManager.ZombieData orCreateZombieData = this.GetOrCreateZombieData(theZombieType);
			orCreateZombieData.cost = (int)num;
			orCreateZombieData.cd = (float)num2;
			ZombieType theZombieType2 = this.advancedCard.theZombieType;
			this.UpdateZombieCardsText(theZombieType2);
			this.dirty = false;
		}
		InGameText instance = InGameText.Instance;
		int num4 = 0;
		instance.ShowText("已保存卡牌数据", 3f, num4 != 0);
	}

	// Token: 0x060033B3 RID: 13235 RVA: 0x00113274 File Offset: 0x00111474
	[Token(Token = "0x60033B3")]
	[Address(RVA = "0x719A00", Offset = "0x718000", VA = "0x180719A00")]
	private void SavePreSelectCards()
	{
		int num;
		do
		{
			num = 0;
			CustomMenu._levelData.preSelectCards._size = num;
			CustomMenu._levelData.preSelectCards_zombie._size = num;
			SerializedLevelData levelData = CustomMenu._levelData;
			int size = this.selectPlantHeads._size;
			levelData.cardCount = size;
			List<RectTransform> list = this.selectPlantHeads;
			bool flag;
			if (flag)
			{
				int i;
				while (i <= 0)
				{
				}
				Transform transform;
				if (!transform.TryGetComponent<TheCard>(num))
				{
					continue;
				}
				CustomMenu menu = this.menu;
			}
		}
		while (num != 0);
	}

	// Token: 0x060033B4 RID: 13236 RVA: 0x00113334 File Offset: 0x00111534
	[Token(Token = "0x60033B4")]
	[Address(RVA = "0x7197A0", Offset = "0x717DA0", VA = "0x1807197A0")]
	private void SaveAdvancedModify()
	{
		ulong num;
		bool flag = int.TryParse(this.costInput.m_Text, (int)num);
		ulong num2;
		bool flag2 = float.TryParse(this.cdInput.m_Text, (float)num2);
		TheCard theCard = this.advancedCard;
		int num3 = 0;
		if ((this.isEditingZombie ? 1 : 0) == num3)
		{
			PlantType thePlantType = theCard.thePlantType;
			PlantDataManager.PlantData orCreatePlantData = this.GetOrCreatePlantData(thePlantType);
			orCreatePlantData.cost = (int)num;
			orCreatePlantData.cd = (float)num2;
			PlantType thePlantType2 = this.advancedCard.thePlantType;
			this.UpdateCardsText(thePlantType2);
			this.dirty = false;
			return;
		}
		ZombieType theZombieType = theCard.theZombieType;
		ZombieDataManager.ZombieData orCreateZombieData = this.GetOrCreateZombieData(theZombieType);
		orCreateZombieData.cost = (int)num;
		orCreateZombieData.cd = (float)num2;
		ZombieType theZombieType2 = this.advancedCard.theZombieType;
		this.UpdateZombieCardsText(theZombieType2);
		this.dirty = false;
	}

	// Token: 0x060033B5 RID: 13237 RVA: 0x00113400 File Offset: 0x00111600
	[Token(Token = "0x60033B5")]
	[Address(RVA = "0x717190", Offset = "0x715790", VA = "0x180717190")]
	private PlantDataManager.PlantData GetOrCreatePlantData(PlantType plantType)
	{
		Func<PlantDataManager.PlantData, bool> func;
		PlantDataManager.PlantData plantData = Enumerable.FirstOrDefault<PlantDataManager.PlantData>(CustomMenu._levelData.plantDatas, func);
		if (plantData == 0)
		{
			PlantType plantType2 = plantType;
			PlantDataManager.PlantData plantData3;
			PlantDataManager.PlantData plantData2 = new PlantDataManager.PlantData(plantData3);
			List<PlantDataManager.PlantData> plantDatas = CustomMenu._levelData.plantDatas;
			int size = plantDatas._size;
			plantDatas._size = typeof(CustomMenu).TypeHandle;
		}
		return plantData;
	}

	// Token: 0x060033B6 RID: 13238 RVA: 0x0011346C File Offset: 0x0011166C
	[Token(Token = "0x60033B6")]
	[Address(RVA = "0x7173D0", Offset = "0x7159D0", VA = "0x1807173D0")]
	private ZombieDataManager.ZombieData GetOrCreateZombieData(ZombieType zombieType)
	{
		Func<ZombieDataManager.ZombieData, bool> func;
		ZombieDataManager.ZombieData zombieData = Enumerable.FirstOrDefault<ZombieDataManager.ZombieData>(CustomMenu._levelData.zombieDatas, func);
		if (zombieData == 0)
		{
			ZombieType zombieType2 = zombieType;
			Dictionary<ZombieType, ZombieDataManager.ZombieData> zombieDataDic = ZombieDataManager.zombieDataDic;
			ZombieType zombieType3;
			if (zombieType3 == ZombieType.NormalZombie)
			{
				ZombieDataManager.ZombieData zombieData2 = new ZombieDataManager.ZombieData();
				ZombieType zombieType4 = zombieType;
				zombieData2.theZombieType = zombieType4;
				zombieData2.cd = 10f;
			}
			ZombieDataManager.ZombieData zombieData3 = new ZombieDataManager.ZombieData();
			zombieData3.theZombieType = zombieData3;
			zombieData3.theAttackDamage = zombieData3;
			zombieData3.theMaxHealth = zombieData3;
			zombieData3.theFirstArmorMaxHealth = zombieData3;
			zombieData3.theSecondArmorMaxHealth = zombieData3;
			zombieData3.cost = zombieData3;
			zombieData3.summonLevel = zombieData3;
			zombieData3.summonWeight = zombieData3;
			zombieData3.armor = zombieData3;
			zombieData3.cd = zombieData3;
			List<ZombieDataManager.ZombieData> zombieDatas = CustomMenu._levelData.zombieDatas;
		}
		return zombieData;
	}

	// Token: 0x060033B7 RID: 13239 RVA: 0x00113550 File Offset: 0x00111750
	[Token(Token = "0x60033B7")]
	[Address(RVA = "0x71A570", Offset = "0x718B70", VA = "0x18071A570")]
	private void UpdateZombieCardsText(ZombieType theZombieType)
	{
		ulong num3;
		do
		{
			int num = 0;
			Dictionary<ZombieType, List<TheCard>> dictionary = this.zombieCardsDic;
			bool flag;
			if (!flag)
			{
				break;
			}
			bool flag2;
			if (flag2)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x060033B8 RID: 13240 RVA: 0x0011359C File Offset: 0x0011179C
	[Token(Token = "0x60033B8")]
	[Address(RVA = "0x716E10", Offset = "0x715410", VA = "0x180716E10")]
	public void AdvancedMode()
	{
		bool flag = !this.advancedMode;
		this.advancedMode = flag;
		this.advancedContainer.SetActive(flag);
	}

	// Token: 0x060033B9 RID: 13241 RVA: 0x001135CC File Offset: 0x001117CC
	[Token(Token = "0x60033B9")]
	[Address(RVA = "0x71A270", Offset = "0x718870", VA = "0x18071A270")]
	public void UpdateAdvancedInfo(PlantType thePlantType)
	{
		TheCard theCard = this.advancedCard;
		this.isEditingZombie = false;
		theCard.thePlantType = thePlantType;
		this.advancedCard.isZombieCard = false;
		TheCard theCard2 = this.advancedCard;
		string text;
		this.nameText.text = text;
		string text2;
		this.costInput.text = text2;
		string text3;
		this.cdInput.text = text3;
	}

	// Token: 0x060033BA RID: 13242 RVA: 0x00113630 File Offset: 0x00111830
	[Token(Token = "0x60033BA")]
	[Address(RVA = "0x71A150", Offset = "0x718750", VA = "0x18071A150")]
	public void UpdateAdvancedInfoZombie(ZombieType theZombieType)
	{
		TheCard theCard = this.advancedCard;
		this.isEditingZombie = true;
		theCard.theZombieType = theZombieType;
		this.advancedCard.isZombieCard = true;
		TheCard theCard2 = this.advancedCard;
		string text;
		this.nameText.text = text;
		string text2;
		this.costInput.text = text2;
		string text3;
		this.cdInput.text = text3;
	}

	// Token: 0x060033BB RID: 13243 RVA: 0x00113694 File Offset: 0x00111894
	[Token(Token = "0x60033BB")]
	[Address(RVA = "0x719470", Offset = "0x717A70", VA = "0x180719470")]
	public void ResetCurrent()
	{
		if (!this.isEditingZombie)
		{
			int thePlantType = (int)this.advancedCard.thePlantType;
			string text;
			this.costInput.text = text;
			string text2;
			this.cdInput.text = text2;
			Predicate<PlantDataManager.PlantData> predicate;
			int num = CustomMenu._levelData.plantDatas.RemoveAll(predicate);
			PlantType thePlantType2 = this.advancedCard.thePlantType;
			this.UpdateAdvancedInfo(thePlantType2);
			return;
		}
		ZombieType theZombieType = this.advancedCard.theZombieType;
		if (CollectionExtensions.GetValueOrDefault<ZombieType, ZombieDataManager.ZombieData>(ZombieDataManager.zombieDataDic, theZombieType) != ZombieType.NormalZombie)
		{
			string text3;
			this.costInput.text = text3;
			string text4;
			this.cdInput.text = text4;
		}
		Predicate<ZombieDataManager.ZombieData> predicate2;
		int num2 = CustomMenu._levelData.zombieDatas.RemoveAll(predicate2);
		ZombieType theZombieType2 = this.advancedCard.theZombieType;
		this.UpdateAdvancedInfoZombie(theZombieType2);
	}

	// Token: 0x060033BC RID: 13244 RVA: 0x0011375C File Offset: 0x0011195C
	[Token(Token = "0x60033BC")]
	[Address(RVA = "0x718EA0", Offset = "0x7174A0", VA = "0x180718EA0")]
	public void ResetAll()
	{
		int num3;
		do
		{
			int num = 0;
			if ((this.isEditingZombie ? 1 : 0) != num)
			{
				List<ZombieDataManager.ZombieData> zombieDatas = CustomMenu._levelData.zombieDatas;
				Func<ZombieDataManager.ZombieData, ZombieType> <>9__27_ = CustomMenu_page3.<>c.<>9__27_0;
				if (<>9__27_ == 0)
				{
					Func<ZombieDataManager.ZombieData, ZombieType> func;
					CustomMenu_page3.<>c.<>9__27_0 = func;
				}
				List<ZombieType> list = Enumerable.ToList<ZombieType>(Enumerable.Select<ZombieDataManager.ZombieData, ZombieType>(zombieDatas, <>9__27_));
				List<ZombieDataManager.ZombieData> zombieDatas2 = CustomMenu._levelData.zombieDatas;
				int size = zombieDatas2._size;
				int num2 = 0;
				zombieDatas2._size = num2;
				if (size > 0)
				{
				}
				ZombieType theZombieType = this.advancedCard.theZombieType;
				this.UpdateAdvancedInfoZombie(theZombieType);
				this.dirty = num2 != 0;
				bool flag;
				if (flag)
				{
					this.UpdateZombieCardsText((ZombieType)num);
				}
				if (num2 != 0)
				{
					continue;
				}
			}
			List<PlantDataManager.PlantData> plantDatas = CustomMenu._levelData.plantDatas;
			Func<PlantDataManager.PlantData, PlantType> func2;
			if (CustomMenu_page3.<>c.<>9__27_1 == 0)
			{
				CustomMenu_page3.<>c.<>9__27_1 = func2;
			}
			List<PlantType> list2 = Enumerable.ToList<PlantType>(Enumerable.Select<PlantDataManager.PlantData, PlantType>(plantDatas, func2));
			List<PlantDataManager.PlantData> plantDatas2 = CustomMenu._levelData.plantDatas;
			int size2 = plantDatas2._size;
			num3 = 0;
			plantDatas2._size = num3;
			if (size2 > 0)
			{
			}
			PlantType thePlantType = this.advancedCard.thePlantType;
			this.UpdateAdvancedInfo(thePlantType);
			this.dirty = num3 != 0;
			bool flag2;
			if (flag2)
			{
				this.UpdateCardsText((PlantType)num);
			}
		}
		while (num3 != 0);
	}

	// Token: 0x060033BD RID: 13245 RVA: 0x00113888 File Offset: 0x00111A88
	[Token(Token = "0x60033BD")]
	[Address(RVA = "0x717180", Offset = "0x715780", VA = "0x180717180")]
	public void Dirty()
	{
		this.dirty = true;
	}

	// Token: 0x060033BE RID: 13246 RVA: 0x0011389C File Offset: 0x00111A9C
	[Token(Token = "0x60033BE")]
	[Address(RVA = "0x718140", Offset = "0x716740", VA = "0x180718140", Slot = "4")]
	public override void LoadOriginalSettings()
	{
		int i = this.selectPlantHeads._size;
		int cardCount = CustomMenu._levelData.cardCount;
		if (i > cardCount)
		{
			global::UnityEngine.Object.Destroy(this.selectPlantHeads[i].gameObject);
			this.selectPlantHeads.RemoveAt(i);
			while (i >= cardCount)
			{
			}
		}
		this.LoadPreSelectCards();
	}

	// Token: 0x060033BF RID: 13247 RVA: 0x001138F8 File Offset: 0x00111AF8
	[Token(Token = "0x60033BF")]
	[Address(RVA = "0x718D60", Offset = "0x717360", VA = "0x180718D60")]
	private void RemoveExcessCardSlots()
	{
		int i = this.selectPlantHeads._size;
		int cardCount = CustomMenu._levelData.cardCount;
		if (i > cardCount)
		{
			global::UnityEngine.Object.Destroy(this.selectPlantHeads[i].gameObject);
			this.selectPlantHeads.RemoveAt(i);
			while (i >= cardCount)
			{
			}
		}
	}

	// Token: 0x060033C0 RID: 13248 RVA: 0x0011394C File Offset: 0x00111B4C
	[Token(Token = "0x60033C0")]
	[Address(RVA = "0x718290", Offset = "0x716890", VA = "0x180718290")]
	private void LoadPreSelectCards()
	{
		ulong num6;
		do
		{
			int num = 0;
			GameObject gameObject = Resources.Load<GameObject>("UI/Cards/Prefab/SampleCard");
			int num2 = 0;
			if (gameObject == num2)
			{
				break;
			}
			int num3 = 0;
			List<PlantType> preSelectCards = CustomMenu._levelData.preSelectCards;
			bool flag;
			if (flag)
			{
				RectTransform rectTransform = this.selectPlantHeads[num3];
				if (rectTransform.childCount > 0)
				{
					int num4 = 0;
					global::UnityEngine.Object.Destroy(rectTransform.GetChild(num4).gameObject);
				}
				TheCard component = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, rectTransform).GetComponent<TheCard>();
				Transform transform = component.transform;
				component.thePlantType = (PlantType)num;
				UnityEvent<TheCard> clickEvent = component.clickEvent;
				UnityAction<TheCard> unityAction;
				if (CustomMenu_page3.<>c.<>9__31_0 == 0)
				{
					CustomMenu_page3.<>c.<>9__31_0 = unityAction;
				}
				clickEvent.AddListener(unityAction);
				this.AddCard(component);
				num3++;
			}
			if (num3 != 0)
			{
				goto IL_017E;
			}
			List<ZombieType> preSelectCards_zombie = CustomMenu._levelData.preSelectCards_zombie;
			bool flag2;
			if (flag2)
			{
				RectTransform rectTransform2;
				if (rectTransform2.childCount > 0)
				{
					int num5 = 0;
					global::UnityEngine.Object.Destroy(rectTransform2.GetChild(num5).gameObject);
				}
				TheCard component2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, rectTransform2).GetComponent<TheCard>();
				Transform transform2 = component2.transform;
				component2.theZombieType = (ZombieType)num;
				component2.isZombieCard = true;
				UnityEvent<TheCard> clickEvent2 = component2.clickEvent;
				UnityAction<TheCard> unityAction2;
				if (CustomMenu_page3.<>c.<>9__31_1 == 0)
				{
					CustomMenu_page3.<>c.<>9__31_1 = unityAction2;
				}
				clickEvent2.AddListener(unityAction2);
				num3++;
			}
		}
		while (num6 != (ulong)0L);
		Debug.LogError("无法加载卡片预制体");
		return;
		IL_017E:
		throw new NullReferenceException();
	}

	// Token: 0x060033C1 RID: 13249 RVA: 0x00113B04 File Offset: 0x00111D04
	[Token(Token = "0x60033C1")]
	[Address(RVA = "0x717F30", Offset = "0x716530", VA = "0x180717F30", Slot = "5")]
	public override void InitPage()
	{
		int num = 0;
		this.UpdateAdvancedInfo((PlantType)num);
		TheCard theCard = this.advancedCard;
		this.AddCard(theCard);
		GameObject gameObject = this.advancedContainer;
		int num2 = 0;
		gameObject.SetActive(num2 != 0);
		GameObject gameObject2 = Resources.Load<GameObject>("UI/Cards/Prefab/SampleCard");
		int num3 = 0;
		if (!(gameObject2 == num3))
		{
			int count = GameAPP.resourcesManager.plantPrefabs.Count;
			int num4 = GameAPP.resourcesManager.zombiePrefabs.Count;
			RectTransform rectTransform = this.plantViewContent;
			num4 += count;
			num4++;
			this.InitCards(gameObject2);
			return;
		}
		Debug.LogError("无法加载卡片预制体");
	}

	// Token: 0x060033C2 RID: 13250 RVA: 0x00113BA4 File Offset: 0x00111DA4
	[Token(Token = "0x60033C2")]
	[Address(RVA = "0x717930", Offset = "0x715F30", VA = "0x180717930")]
	private void InitCards(GameObject cardPrefab)
	{
		ulong num2;
		do
		{
			Dictionary<PlantType, GameObject> plantPrefabs = GameAPP.resourcesManager.plantPrefabs;
			bool flag;
			if (flag)
			{
				CustomMenu_page3.<>c__DisplayClass34_0 CS$<>8__locals1;
				CS$<>8__locals1.<>4__this = this;
				CS$<>8__locals1.cardPrefab = cardPrefab;
				GameObject cardPrefab2 = CS$<>8__locals1.cardPrefab;
				Transform transform = this.plantViewContent.transform;
				TheCard component = global::UnityEngine.Object.Instantiate<GameObject>(cardPrefab2, transform).GetComponent<TheCard>();
				this.AddCard(component);
				UnityAction<TheCard> unityAction;
				component.clickEvent.AddListener(unityAction);
			}
			ulong num;
			if (num != (ulong)0L)
			{
				goto IL_00DE;
			}
			Dictionary<ZombieType, GameObject> zombiePrefabs = GameAPP.resourcesManager.zombiePrefabs;
			bool flag2;
			if (flag2)
			{
				CustomMenu_page3.<>c__DisplayClass35_0 CS$<>8__locals2;
				CS$<>8__locals2.<>4__this = 0;
				CS$<>8__locals2.cardPrefab = 0;
				Transform transform2;
				TheCard component2 = global::UnityEngine.Object.Instantiate<GameObject>(CS$<>8__locals2.cardPrefab, transform2).GetComponent<TheCard>();
				component2.isZombieCard = true;
				UnityAction<TheCard> unityAction2;
				component2.clickEvent.AddListener(unityAction2);
			}
		}
		while (num2 != (ulong)0L);
		return;
		IL_00DE:
		throw new NullReferenceException();
	}

	// Token: 0x060033C3 RID: 13251 RVA: 0x00113CB0 File Offset: 0x00111EB0
	[Token(Token = "0x60033C3")]
	[Address(RVA = "0x716E40", Offset = "0x715440", VA = "0x180716E40")]
	private void CreatePlantCard(PlantType plantType, GameObject cardPrefab)
	{
		RectTransform rectTransform = this.plantViewContent;
		GameObject cardPrefab2 = cardPrefab;
		Transform transform = rectTransform.transform;
		TheCard component = global::UnityEngine.Object.Instantiate<GameObject>(cardPrefab2, transform).GetComponent<TheCard>();
		component.thePlantType = plantType;
		this.AddCard(component);
		UnityAction<TheCard> unityAction;
		component.clickEvent.AddListener(unityAction);
	}

	// Token: 0x060033C4 RID: 13252 RVA: 0x00113D20 File Offset: 0x00111F20
	[Token(Token = "0x60033C4")]
	[Address(RVA = "0x716FE0", Offset = "0x7155E0", VA = "0x180716FE0")]
	private void CreateZombieCard(ZombieType zombieType, GameObject cardPrefab)
	{
		RectTransform rectTransform = this.plantViewContent;
		GameObject cardPrefab2 = cardPrefab;
		Transform transform = rectTransform.transform;
		TheCard component = global::UnityEngine.Object.Instantiate<GameObject>(cardPrefab2, transform).GetComponent<TheCard>();
		component.theZombieType = zombieType;
		component.isZombieCard = true;
		this.AddCard(component);
		UnityAction<TheCard> unityAction;
		component.clickEvent.AddListener(unityAction);
	}

	// Token: 0x060033C5 RID: 13253 RVA: 0x00113D98 File Offset: 0x00111F98
	[Token(Token = "0x60033C5")]
	[Address(RVA = "0x719D90", Offset = "0x718390", VA = "0x180719D90")]
	private void TryAddToPreSelect(TheCard sampleCard, GameObject cardPrefab)
	{
		ulong num3;
		do
		{
			int num = 0;
			List<RectTransform> list = this.selectPlantHeads;
			bool flag;
			if (flag)
			{
				int num2;
				while (num2 != 0)
				{
				}
				TheCard component = global::UnityEngine.Object.Instantiate<GameObject>(cardPrefab, num).GetComponent<TheCard>();
				Transform transform = component.transform;
				PlantType thePlantType = sampleCard.thePlantType;
				component.thePlantType = thePlantType;
				ZombieType theZombieType = sampleCard.theZombieType;
				component.theZombieType = theZombieType;
				bool isZombieCard = sampleCard.isZombieCard;
				component.isZombieCard = isZombieCard;
				UnityEvent<TheCard> clickEvent = component.clickEvent;
				UnityAction<TheCard> unityAction;
				if (CustomMenu_page3.<>c.<>9__36_0 == 0)
				{
					CustomMenu_page3.<>c.<>9__36_0 = unityAction;
				}
				clickEvent.AddListener(unityAction);
				this.AddCard(component);
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x060033C6 RID: 13254 RVA: 0x00113E5C File Offset: 0x0011205C
	[Token(Token = "0x60033C6")]
	[Address(RVA = "0x718AF0", Offset = "0x7170F0", VA = "0x180718AF0")]
	public void ModifyCardCount(bool add)
	{
		if (!add)
		{
			List<RectTransform> list = this.selectPlantHeads;
			int size = list._size;
			int num = size - 1;
			global::UnityEngine.Object.Destroy(list[num].gameObject);
			List<RectTransform> list2 = this.selectPlantHeads;
			int num2 = size - 1;
			list2.RemoveAt(num2);
			return;
		}
		this.AddCardSlot();
	}

	// Token: 0x060033C7 RID: 13255 RVA: 0x00113ED4 File Offset: 0x001120D4
	[Token(Token = "0x60033C7")]
	[Address(RVA = "0x716930", Offset = "0x714F30", VA = "0x180716930")]
	private void AddCardSlot()
	{
		List<RectTransform> list = this.selectPlantHeads;
		int num = 0;
		RectTransform rectTransform = list[num];
		List<RectTransform> list2 = this.selectPlantHeads;
		int num2 = 0;
		Transform parent = list2[num2].transform.parent;
		RectTransform rectTransform2 = global::UnityEngine.Object.Instantiate<RectTransform>(rectTransform, parent);
		int childCount = rectTransform2.childCount;
		if (childCount > 0)
		{
			int num3 = 0;
			global::UnityEngine.Object.Destroy(rectTransform2.GetChild(num3).gameObject);
		}
		List<RectTransform> list3 = this.selectPlantHeads;
		int size = list3._size;
	}

	// Token: 0x060033C8 RID: 13256 RVA: 0x00113F80 File Offset: 0x00112180
	[Token(Token = "0x60033C8")]
	[Address(RVA = "0x718C30", Offset = "0x717230", VA = "0x180718C30")]
	private void RemoveCardSlot()
	{
		List<RectTransform> list = this.selectPlantHeads;
		int size = list._size;
		int num = size - 1;
		global::UnityEngine.Object.Destroy(list[num].gameObject);
		List<RectTransform> list2 = this.selectPlantHeads;
		int num2 = size - 1;
		list2.RemoveAt(num2);
	}

	// Token: 0x060033C9 RID: 13257 RVA: 0x00113FEC File Offset: 0x001121EC
	[Token(Token = "0x60033C9")]
	[Address(RVA = "0x71A760", Offset = "0x718D60", VA = "0x18071A760")]
	public CustomMenu_page3()
	{
		List<RectTransform> list = new List();
		this.selectPlantHeads = list;
		Dictionary<PlantType, List<TheCard>> dictionary = new Dictionary();
		this.cardsDic = dictionary;
		Dictionary<ZombieType, List<TheCard>> dictionary2 = new Dictionary();
		this.zombieCardsDic = dictionary2;
		base..ctor();
	}

	// Token: 0x0400254A RID: 9546
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400254A")]
	[Header("预选植物")]
	public GameObject plantView;

	// Token: 0x0400254B RID: 9547
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400254B")]
	public RectTransform plantViewContent;

	// Token: 0x0400254C RID: 9548
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400254C")]
	public List<RectTransform> selectPlantHeads;

	// Token: 0x0400254D RID: 9549
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400254D")]
	[Header("高级选项")]
	public bool advancedMode;

	// Token: 0x0400254E RID: 9550
	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x400254E")]
	public bool dirty;

	// Token: 0x0400254F RID: 9551
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400254F")]
	public GameObject advancedContainer;

	// Token: 0x04002550 RID: 9552
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4002550")]
	public TextMeshProUGUI nameText;

	// Token: 0x04002551 RID: 9553
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002551")]
	public TMP_InputField costInput;

	// Token: 0x04002552 RID: 9554
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002552")]
	public TMP_InputField cdInput;

	// Token: 0x04002553 RID: 9555
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4002553")]
	public TheCard advancedCard;

	// Token: 0x04002554 RID: 9556
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4002554")]
	private bool isEditingZombie;

	// Token: 0x04002555 RID: 9557
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4002555")]
	private readonly Dictionary<PlantType, List<TheCard>> cardsDic;

	// Token: 0x04002556 RID: 9558
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4002556")]
	private readonly Dictionary<ZombieType, List<TheCard>> zombieCardsDic;
}
