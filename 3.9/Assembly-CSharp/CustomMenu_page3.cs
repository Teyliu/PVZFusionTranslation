using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using GameLevel;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000A10 RID: 2576
[Token(Token = "0x2000A10")]
public class CustomMenu_page3 : CustomMenu_page
{
	// Token: 0x060034E2 RID: 13538 RVA: 0x00117F60 File Offset: 0x00116160
	[Token(Token = "0x60034E2")]
	[Address(RVA = "0x77C0A0", Offset = "0x77A6A0", VA = "0x18077C0A0")]
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

	// Token: 0x060034E3 RID: 13539 RVA: 0x00117FFC File Offset: 0x001161FC
	[Token(Token = "0x60034E3")]
	[Address(RVA = "0x77F900", Offset = "0x77DF00", VA = "0x18077F900")]
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

	// Token: 0x060034E4 RID: 13540 RVA: 0x00118048 File Offset: 0x00116248
	[Token(Token = "0x60034E4")]
	[Address(RVA = "0x77CB80", Offset = "0x77B180", VA = "0x18077CB80")]
	private PlantDataManager.PlantData GetTempPlantData(PlantType thePlantType)
	{
		List<PlantDataManager.PlantData> plantDatas = CustomMenu._levelData.plantDatas;
		Func<PlantDataManager.PlantData, bool> func = delegate(PlantDataManager.PlantData a)
		{
			PlantType thePlantType3 = thePlantType;
			return a.thePlantType == thePlantType3;
		};
		PlantDataManager.PlantData plantData = Enumerable.FirstOrDefault<PlantDataManager.PlantData>(plantDatas, func);
		if (plantData == 0)
		{
			PlantType thePlantType2 = thePlantType;
		}
		return plantData;
	}

	// Token: 0x060034E5 RID: 13541 RVA: 0x0011809C File Offset: 0x0011629C
	[Token(Token = "0x60034E5")]
	[Address(RVA = "0x77CCC0", Offset = "0x77B2C0", VA = "0x18077CCC0")]
	private ZombieDataManager.ZombieData GetTempZombieData(ZombieType theZombieType)
	{
		List<ZombieDataManager.ZombieData> zombieDatas = CustomMenu._levelData.zombieDatas;
		Func<ZombieDataManager.ZombieData, bool> func = delegate(ZombieDataManager.ZombieData a)
		{
			ZombieType theZombieType4 = theZombieType;
			return a.theZombieType == theZombieType4;
		};
		ZombieDataManager.ZombieData zombieData = Enumerable.FirstOrDefault<ZombieDataManager.ZombieData>(zombieDatas, func);
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

	// Token: 0x060034E6 RID: 13542 RVA: 0x00118110 File Offset: 0x00116310
	[Token(Token = "0x60034E6")]
	[Address(RVA = "0x77EE00", Offset = "0x77D400", VA = "0x18077EE00")]
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
	}

	// Token: 0x060034E7 RID: 13543 RVA: 0x001181F0 File Offset: 0x001163F0
	[Token(Token = "0x60034E7")]
	[Address(RVA = "0x77EF70", Offset = "0x77D570", VA = "0x18077EF70")]
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

	// Token: 0x060034E8 RID: 13544 RVA: 0x001182B0 File Offset: 0x001164B0
	[Token(Token = "0x60034E8")]
	[Address(RVA = "0x77ED00", Offset = "0x77D300", VA = "0x18077ED00")]
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

	// Token: 0x060034E9 RID: 13545 RVA: 0x0011837C File Offset: 0x0011657C
	[Token(Token = "0x60034E9")]
	[Address(RVA = "0x77C6D0", Offset = "0x77ACD0", VA = "0x18077C6D0")]
	private PlantDataManager.PlantData GetOrCreatePlantData(PlantType plantType)
	{
		List<PlantDataManager.PlantData> plantDatas = CustomMenu._levelData.plantDatas;
		Func<PlantDataManager.PlantData, bool> func = delegate(PlantDataManager.PlantData data)
		{
			PlantType plantType3 = plantType;
			return data.thePlantType == plantType3;
		};
		PlantDataManager.PlantData plantData = Enumerable.FirstOrDefault<PlantDataManager.PlantData>(plantDatas, func);
		if (plantData == 0)
		{
			PlantType plantType2 = plantType;
			PlantDataManager.PlantData plantData3;
			PlantDataManager.PlantData plantData2 = new PlantDataManager.PlantData(plantData3);
			List<PlantDataManager.PlantData> plantDatas2 = CustomMenu._levelData.plantDatas;
			int size = plantDatas2._size;
			plantDatas2._size = typeof(CustomMenu).TypeHandle;
		}
		return plantData;
	}

	// Token: 0x060034EA RID: 13546 RVA: 0x001183FC File Offset: 0x001165FC
	[Token(Token = "0x60034EA")]
	[Address(RVA = "0x77C910", Offset = "0x77AF10", VA = "0x18077C910")]
	private ZombieDataManager.ZombieData GetOrCreateZombieData(ZombieType zombieType)
	{
		List<ZombieDataManager.ZombieData> zombieDatas = CustomMenu._levelData.zombieDatas;
		Func<ZombieDataManager.ZombieData, bool> func = delegate(ZombieDataManager.ZombieData data)
		{
			ZombieType zombieType5 = zombieType;
			return data.theZombieType == zombieType5;
		};
		ZombieDataManager.ZombieData zombieData = Enumerable.FirstOrDefault<ZombieDataManager.ZombieData>(zombieDatas, func);
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
			List<ZombieDataManager.ZombieData> zombieDatas2 = CustomMenu._levelData.zombieDatas;
		}
		return zombieData;
	}

	// Token: 0x060034EB RID: 13547 RVA: 0x001184F0 File Offset: 0x001166F0
	[Token(Token = "0x60034EB")]
	[Address(RVA = "0x77FAE0", Offset = "0x77E0E0", VA = "0x18077FAE0")]
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

	// Token: 0x060034EC RID: 13548 RVA: 0x0011853C File Offset: 0x0011673C
	[Token(Token = "0x60034EC")]
	[Address(RVA = "0x77C350", Offset = "0x77A950", VA = "0x18077C350")]
	public void AdvancedMode()
	{
		bool flag = !this.advancedMode;
		this.advancedMode = flag;
		this.advancedContainer.SetActive(flag);
	}

	// Token: 0x060034ED RID: 13549 RVA: 0x0011856C File Offset: 0x0011676C
	[Token(Token = "0x60034ED")]
	[Address(RVA = "0x77F7E0", Offset = "0x77DDE0", VA = "0x18077F7E0")]
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

	// Token: 0x060034EE RID: 13550 RVA: 0x001185D0 File Offset: 0x001167D0
	[Token(Token = "0x60034EE")]
	[Address(RVA = "0x77F6C0", Offset = "0x77DCC0", VA = "0x18077F6C0")]
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

	// Token: 0x060034EF RID: 13551 RVA: 0x00118634 File Offset: 0x00116834
	[Token(Token = "0x60034EF")]
	[Address(RVA = "0x77E9D0", Offset = "0x77CFD0", VA = "0x18077E9D0")]
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

	// Token: 0x060034F0 RID: 13552 RVA: 0x001186FC File Offset: 0x001168FC
	[Token(Token = "0x60034F0")]
	[Address(RVA = "0x77E400", Offset = "0x77CA00", VA = "0x18077E400")]
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

	// Token: 0x060034F1 RID: 13553 RVA: 0x00118828 File Offset: 0x00116A28
	[Token(Token = "0x60034F1")]
	[Address(RVA = "0x77C6C0", Offset = "0x77ACC0", VA = "0x18077C6C0")]
	public void Dirty()
	{
		this.dirty = true;
	}

	// Token: 0x060034F2 RID: 13554 RVA: 0x0011883C File Offset: 0x00116A3C
	[Token(Token = "0x60034F2")]
	[Address(RVA = "0x77D680", Offset = "0x77BC80", VA = "0x18077D680", Slot = "4")]
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

	// Token: 0x060034F3 RID: 13555 RVA: 0x00118898 File Offset: 0x00116A98
	[Token(Token = "0x60034F3")]
	[Address(RVA = "0x77E2C0", Offset = "0x77C8C0", VA = "0x18077E2C0")]
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

	// Token: 0x060034F4 RID: 13556 RVA: 0x001188EC File Offset: 0x00116AEC
	[Token(Token = "0x60034F4")]
	[Address(RVA = "0x77D7D0", Offset = "0x77BDD0", VA = "0x18077D7D0")]
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

	// Token: 0x060034F5 RID: 13557 RVA: 0x00118AA4 File Offset: 0x00116CA4
	[Token(Token = "0x60034F5")]
	[Address(RVA = "0x77D470", Offset = "0x77BA70", VA = "0x18077D470", Slot = "5")]
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

	// Token: 0x060034F6 RID: 13558 RVA: 0x00118B44 File Offset: 0x00116D44
	[Token(Token = "0x60034F6")]
	[Address(RVA = "0x77CE70", Offset = "0x77B470", VA = "0x18077CE70")]
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

	// Token: 0x060034F7 RID: 13559 RVA: 0x00118C50 File Offset: 0x00116E50
	[Token(Token = "0x60034F7")]
	[Address(RVA = "0x77C380", Offset = "0x77A980", VA = "0x18077C380")]
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

	// Token: 0x060034F8 RID: 13560 RVA: 0x00118CC0 File Offset: 0x00116EC0
	[Token(Token = "0x60034F8")]
	[Address(RVA = "0x77C520", Offset = "0x77AB20", VA = "0x18077C520")]
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

	// Token: 0x060034F9 RID: 13561 RVA: 0x00118D38 File Offset: 0x00116F38
	[Token(Token = "0x60034F9")]
	[Address(RVA = "0x77F300", Offset = "0x77D900", VA = "0x18077F300")]
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

	// Token: 0x060034FA RID: 13562 RVA: 0x00118DFC File Offset: 0x00116FFC
	[Token(Token = "0x60034FA")]
	[Address(RVA = "0x77E030", Offset = "0x77C630", VA = "0x18077E030")]
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

	// Token: 0x060034FB RID: 13563 RVA: 0x00118E60 File Offset: 0x00117060
	[Token(Token = "0x60034FB")]
	[Address(RVA = "0x77BE60", Offset = "0x77A460", VA = "0x18077BE60")]
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

	// Token: 0x060034FC RID: 13564 RVA: 0x00118EF8 File Offset: 0x001170F8
	[Token(Token = "0x60034FC")]
	[Address(RVA = "0x77E180", Offset = "0x77C780", VA = "0x18077E180")]
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

	// Token: 0x060034FD RID: 13565 RVA: 0x00118F50 File Offset: 0x00117150
	[Token(Token = "0x60034FD")]
	[Address(RVA = "0x77FCD0", Offset = "0x77E2D0", VA = "0x18077FCD0")]
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

	// Token: 0x0400265C RID: 9820
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400265C")]
	[Header("预选植物")]
	public GameObject plantView;

	// Token: 0x0400265D RID: 9821
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400265D")]
	public RectTransform plantViewContent;

	// Token: 0x0400265E RID: 9822
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400265E")]
	public List<RectTransform> selectPlantHeads;

	// Token: 0x0400265F RID: 9823
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400265F")]
	[Header("高级选项")]
	public bool advancedMode;

	// Token: 0x04002660 RID: 9824
	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x4002660")]
	public bool dirty;

	// Token: 0x04002661 RID: 9825
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4002661")]
	public GameObject advancedContainer;

	// Token: 0x04002662 RID: 9826
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4002662")]
	public TextMeshProUGUI nameText;

	// Token: 0x04002663 RID: 9827
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002663")]
	public TMP_InputField costInput;

	// Token: 0x04002664 RID: 9828
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002664")]
	public TMP_InputField cdInput;

	// Token: 0x04002665 RID: 9829
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4002665")]
	public TheCard advancedCard;

	// Token: 0x04002666 RID: 9830
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4002666")]
	private bool isEditingZombie;

	// Token: 0x04002667 RID: 9831
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4002667")]
	private readonly Dictionary<PlantType, List<TheCard>> cardsDic;

	// Token: 0x04002668 RID: 9832
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4002668")]
	private readonly Dictionary<ZombieType, List<TheCard>> zombieCardsDic;
}
