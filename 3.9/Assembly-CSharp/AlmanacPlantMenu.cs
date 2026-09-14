using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000804 RID: 2052
[Token(Token = "0x2000804")]
public class AlmanacPlantMenu : AlmanacSecondMenu
{
	// Token: 0x060029A0 RID: 10656 RVA: 0x000E10EC File Offset: 0x000DF2EC
	[Token(Token = "0x60029A0")]
	[Address(RVA = "0x6888D0", Offset = "0x686ED0", VA = "0x1806888D0", Slot = "6")]
	protected override void Awake()
	{
		base.GetCol();
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
		this.InitCards();
		List<AlmanacCardUI> cards = this.cards;
		int num = 0;
		AlmanacCardUI almanacCardUI = cards[num];
		AlmanacPlantWindow almanacPlantWindow = this.window;
		PlantType plantType = almanacCardUI._plantType;
		almanacPlantWindow.currentPlantType = plantType;
		Image background = almanacPlantWindow.background;
		bool flag;
		if (!flag)
		{
		}
		Sprite poolBackground = almanacPlantWindow.poolBackground;
		background.sprite = poolBackground;
		GameObject gameObject = this.button_lookBack;
		int num2 = 0;
		gameObject.SetActive(num2 != 0);
		TextMeshProUGUI textMeshProUGUI = this.tips;
		string random = ListExtensions.GetRandom<string>(this.Tips);
		throw new NullReferenceException();
	}

	// Token: 0x060029A1 RID: 10657 RVA: 0x000E1190 File Offset: 0x000DF390
	[Token(Token = "0x60029A1")]
	[Address(RVA = "0x68B240", Offset = "0x689840", VA = "0x18068B240")]
	private void Update()
	{
		if (Input.GetKeyDownInt((KeyCode)((uint)117)))
		{
			this.LookMix();
		}
		if (Input.GetKeyDownInt((KeyCode)((uint)27)))
		{
			this.LookFirst();
			return;
		}
	}

	// Token: 0x060029A2 RID: 10658 RVA: 0x000E11C0 File Offset: 0x000DF3C0
	[Token(Token = "0x60029A2")]
	[Address(RVA = "0x688ED0", Offset = "0x6874D0", VA = "0x180688ED0")]
	private void InitCards()
	{
		ulong num4;
		do
		{
			int num = 0;
			HashSet<PlantType> hashSet = Enumerable.ToHashSet<PlantType>(global::Lawnf.GetAllPlantTypes());
			Func<PlantType, bool> <>9__10_ = AlmanacPlantMenu.<>c.<>9__10_0;
			if (<>9__10_ == 0)
			{
				AlmanacPlantMenu.<>c.<>9__10_0 = delegate(PlantType c)
				{
					bool flag4;
					return flag4;
				};
			}
			IOrderedEnumerable<PlantType> orderedEnumerable = Enumerable.OrderByDescending<PlantType, bool>(hashSet, <>9__10_);
			Func<PlantType, bool> func;
			if (AlmanacPlantMenu.<>c.<>9__10_1 == 0)
			{
				func = (PlantType c) => c >= PlantType.PeaSunFlower;
				AlmanacPlantMenu.<>c.<>9__10_1 = func;
			}
			List<PlantType> list = Enumerable.ToList<PlantType>(Enumerable.ThenByDescending<PlantType, bool>(orderedEnumerable, func));
			AdvantureCardLayout[] enumValues = global::Core.Lawnf.GetEnumValues<AdvantureCardLayout>();
			int num2 = 0;
			int num3 = 0;
			if (num3 < enumValues.Length)
			{
				bool flag;
				bool flag2;
				if (!flag || flag2)
				{
				}
				num2++;
			}
			bool flag3;
			if (flag3)
			{
				RectTransform basicCardHead = this.basicCardHead;
				this.SetCard(basicCardHead, (PlantType)num);
			}
		}
		while (num4 != (ulong)0L);
	}

	// Token: 0x060029A3 RID: 10659 RVA: 0x000E1290 File Offset: 0x000DF490
	[Token(Token = "0x60029A3")]
	[Address(RVA = "0x68AB70", Offset = "0x689170", VA = "0x18068AB70")]
	private void SetCard(Transform parent, PlantType thePlantType)
	{
		AlmanacCardUI component = global::UnityEngine.Object.Instantiate<GameObject>(this.cardPrefab, parent).GetComponent<AlmanacCardUI>();
		component.menu = this;
		component.realType = thePlantType;
		List<AlmanacCardUI> cards = this.cards;
		int size = cards._size;
	}

	// Token: 0x060029A4 RID: 10660 RVA: 0x000E12DC File Offset: 0x000DF4DC
	[Token(Token = "0x60029A4")]
	[Address(RVA = "0x688B70", Offset = "0x687170", VA = "0x180688B70")]
	public void ClassicMix(PlantType thePlantType)
	{
		int num;
		do
		{
			num = 0;
			GameObject gameObject = this.basicCardHead.gameObject;
			int num2 = 0;
			gameObject.SetActive(num2 != 0);
			ulong num3;
			this.basicCardHead2.gameObject.SetActive(num3 != 0UL);
			IEnumerator enumerator = this.basicCardHead2.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				bool flag;
				while (!flag)
				{
				}
				bool flag2;
				if (!flag2)
				{
				}
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x060029A5 RID: 10661 RVA: 0x000E1380 File Offset: 0x000DF580
	[Token(Token = "0x60029A5")]
	[Address(RVA = "0x68ACC0", Offset = "0x6892C0", VA = "0x18068ACC0")]
	private void ShowPlants(List<PlantType> plantTypes)
	{
		ulong num4;
		do
		{
			AlmanacPlantMenu.<>c__DisplayClass13_0 CS$<>8__locals1;
			CS$<>8__locals1.plantTypes = plantTypes;
			this.basicCardHead.gameObject.SetActive(true);
			GameObject gameObject = this.basicCardHead2.gameObject;
			int num = 0;
			gameObject.SetActive(num != 0);
			List<AlmanacCardUI> cards = this.cards;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				GameObject gameObject2;
				gameObject2.SetActive(num2 != 0);
			}
			ulong num3;
			if (num3 != (ulong)0L)
			{
				goto IL_0094;
			}
			Func<AlmanacCardUI, bool> func = delegate(AlmanacCardUI c)
			{
				List<PlantType> plantTypes2 = CS$<>8__locals1.plantTypes;
				PlantType plantType = c._plantType;
				return plantTypes2.Contains(plantType);
			};
			IEnumerable<AlmanacCardUI> enumerable;
			List<AlmanacCardUI> list = Enumerable.ToList<AlmanacCardUI>(enumerable);
			bool flag2;
			if (flag2)
			{
				GameObject gameObject3;
				gameObject3.SetActive(true);
			}
		}
		while (num4 != (ulong)0L);
		return;
		IL_0094:
		throw new NullReferenceException();
	}

	// Token: 0x060029A6 RID: 10662 RVA: 0x000E1430 File Offset: 0x000DF630
	[Token(Token = "0x60029A6")]
	[Address(RVA = "0x68AAB0", Offset = "0x6890B0", VA = "0x18068AAB0")]
	public void SelectCard(AlmanacCardUI card)
	{
		AlmanacPlantWindow almanacPlantWindow = this.window;
		PlantType plantType = card._plantType;
		almanacPlantWindow.currentPlantType = plantType;
		Image background = almanacPlantWindow.background;
		bool flag;
		if (!flag)
		{
		}
		Sprite poolBackground = almanacPlantWindow.poolBackground;
		background.sprite = poolBackground;
	}

	// Token: 0x060029A7 RID: 10663 RVA: 0x000E1478 File Offset: 0x000DF678
	[Token(Token = "0x60029A7")]
	[Address(RVA = "0x68B030", Offset = "0x689630", VA = "0x18068B030")]
	public void ShowPlants(Func<PlantType, bool> condition)
	{
		ulong num2;
		do
		{
			this.basicCardHead.gameObject.SetActive(true);
			GameObject gameObject = this.basicCardHead2.gameObject;
			int num = 0;
			gameObject.SetActive(num != 0);
			List<AlmanacCardUI> cards = this.cards;
			bool flag;
			if (flag)
			{
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x060029A8 RID: 10664 RVA: 0x000E14DC File Offset: 0x000DF6DC
	[Token(Token = "0x60029A8")]
	[Address(RVA = "0x689C10", Offset = "0x688210", VA = "0x180689C10")]
	public void LookMix()
	{
		AlmanacPlantWindow almanacPlantWindow = this.window;
		Stack<PlantType> stack = this.plantStack;
		PlantType currentPlantType = almanacPlantWindow.currentPlantType;
		if (!stack.Contains(currentPlantType))
		{
			PlantType currentPlantType2 = this.window.currentPlantType;
			int num = 0;
			List<PlantType> possibleUpgradeTypes = ElementUpgrade.GetPossibleUpgradeTypes(currentPlantType2, num != 0);
			AlmanacPlantWindow almanacPlantWindow2 = this.window;
			Stack<PlantType> stack2 = this.plantStack;
			PlantType currentPlantType3 = almanacPlantWindow2.currentPlantType;
			stack2.Push(currentPlantType3);
			this.ShowPlants(possibleUpgradeTypes);
			this.button_lookBack.SetActive(true);
		}
	}

	// Token: 0x060029A9 RID: 10665 RVA: 0x000E1560 File Offset: 0x000DF760
	[Token(Token = "0x60029A9")]
	[Address(RVA = "0x688AB0", Offset = "0x6870B0", VA = "0x180688AB0")]
	public void BackLook()
	{
		Stack<PlantType> stack = this.plantStack;
		PlantType plantType = stack.Pop();
		Stack<PlantType> stack2 = this.plantStack;
		this.LookFirst();
	}

	// Token: 0x060029AA RID: 10666 RVA: 0x000E15B0 File Offset: 0x000DF7B0
	[Token(Token = "0x60029AA")]
	[Address(RVA = "0x689680", Offset = "0x687C80", VA = "0x180689680")]
	public void LookFirst()
	{
		this.plantStack.Clear();
		Func<PlantType, bool> <>9__18_ = AlmanacPlantMenu.<>c.<>9__18_0;
		if (<>9__18_ == 0)
		{
			AlmanacPlantMenu.<>c.<>9__18_0 = (PlantType a) => true;
		}
		this.ShowPlants(<>9__18_);
		GameObject gameObject = this.button_lookBack;
		int num = 0;
		gameObject.SetActive(num != 0);
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x060029AB RID: 10667 RVA: 0x000E160C File Offset: 0x000DF80C
	[Token(Token = "0x60029AB")]
	[Address(RVA = "0x689F20", Offset = "0x688520", VA = "0x180689F20")]
	public void LookSuper()
	{
		Func<PlantType, bool> <>9__19_ = AlmanacPlantMenu.<>c.<>9__19_0;
		if (<>9__19_ == 0)
		{
			AlmanacPlantMenu.<>c.<>9__19_0 = delegate(PlantType p)
			{
				bool flag;
				return flag;
			};
		}
		this.ShowPlants(<>9__19_);
	}

	// Token: 0x060029AC RID: 10668 RVA: 0x000E1648 File Offset: 0x000DF848
	[Token(Token = "0x60029AC")]
	[Address(RVA = "0x68A200", Offset = "0x688800", VA = "0x18068A200")]
	public void LookUlti()
	{
		Func<PlantType, bool> <>9__20_ = AlmanacPlantMenu.<>c.<>9__20_0;
		if (<>9__20_ == 0)
		{
			AlmanacPlantMenu.<>c.<>9__20_0 = delegate(PlantType p)
			{
				bool flag;
				return flag;
			};
		}
		this.ShowPlants(<>9__20_);
	}

	// Token: 0x060029AD RID: 10669 RVA: 0x000E1684 File Offset: 0x000DF884
	[Token(Token = "0x60029AD")]
	[Address(RVA = "0x68A140", Offset = "0x688740", VA = "0x18068A140")]
	public void LookTravelUlti(bool isStrongUltimate)
	{
		Func<PlantType, bool> func = delegate(PlantType p)
		{
			bool flag;
			for (;;)
			{
				Dictionary<PlantType, ValueTuple<PlantType?, object, object, bool>> plantInfo = TravelDictionary.PlantInfo;
				if (flag)
				{
					break;
				}
				ulong num;
				if (num == (ulong)0L)
				{
					goto Block_3;
				}
			}
			if (flag != isStrongUltimate)
			{
				while (!isStrongUltimate)
				{
				}
				HashSet<PlantType> spPlants = TravelDictionary.SpPlants;
				bool flag2;
				while (!flag2)
				{
				}
			}
			while (!flag)
			{
			}
			PlantType plantType;
			while (plantType != p)
			{
			}
			return true;
			Block_3:
			throw new NullReferenceException();
		};
		this.ShowPlants(func);
	}

	// Token: 0x060029AE RID: 10670 RVA: 0x000E16BC File Offset: 0x000DF8BC
	[Token(Token = "0x60029AE")]
	[Address(RVA = "0x68A030", Offset = "0x688630", VA = "0x18068A030")]
	public void LookTower()
	{
		Func<PlantType, bool> <>9__22_ = AlmanacPlantMenu.<>c.<>9__22_0;
		if (<>9__22_ == 0)
		{
			AlmanacPlantMenu.<>c.<>9__22_0 = delegate(PlantType p)
			{
				bool flag;
				return flag;
			};
		}
		this.ShowPlants(<>9__22_);
	}

	// Token: 0x060029AF RID: 10671 RVA: 0x000E16F8 File Offset: 0x000DF8F8
	[Token(Token = "0x60029AF")]
	[Address(RVA = "0x6899F0", Offset = "0x687FF0", VA = "0x1806899F0")]
	public void LookIron()
	{
		Func<PlantType, bool> <>9__23_ = AlmanacPlantMenu.<>c.<>9__23_0;
		if (<>9__23_ == 0)
		{
			AlmanacPlantMenu.<>c.<>9__23_0 = delegate(PlantType p)
			{
				Dictionary<ValueTuple<PlantType, BucketType>, PlantType> recipes = Bucket.Recipes;
				bool flag;
				return flag;
			};
		}
		this.ShowPlants(<>9__23_);
	}

	// Token: 0x060029B0 RID: 10672 RVA: 0x000E1734 File Offset: 0x000DF934
	[Token(Token = "0x60029B0")]
	[Address(RVA = "0x689D00", Offset = "0x688300", VA = "0x180689D00")]
	public void LookNut()
	{
		Func<PlantType, bool> <>9__24_ = AlmanacPlantMenu.<>c.<>9__24_0;
		if (<>9__24_ == 0)
		{
			AlmanacPlantMenu.<>c.<>9__24_0 = delegate(PlantType p)
			{
				bool flag;
				return flag;
			};
		}
		this.ShowPlants(<>9__24_);
	}

	// Token: 0x060029B1 RID: 10673 RVA: 0x000E1770 File Offset: 0x000DF970
	[Token(Token = "0x60029B1")]
	[Address(RVA = "0x68A310", Offset = "0x688910", VA = "0x18068A310")]
	public void LookUnlocked()
	{
		ulong num2;
		do
		{
			this.basicCardHead.gameObject.SetActive(true);
			GameObject gameObject = this.basicCardHead2.gameObject;
			int num = 0;
			gameObject.SetActive(num != 0);
			List<AlmanacCardUI> cards = this.cards;
			bool flag;
			if (flag)
			{
				GameObject gameObject2;
				bool flag2;
				gameObject2.SetActive(flag2);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x060029B2 RID: 10674 RVA: 0x000E17E0 File Offset: 0x000DF9E0
	[Token(Token = "0x60029B2")]
	[Address(RVA = "0x68A510", Offset = "0x688B10", VA = "0x18068A510")]
	public void LookWater()
	{
		Func<PlantType, bool> <>9__26_ = AlmanacPlantMenu.<>c.<>9__26_0;
		if (<>9__26_ == 0)
		{
			AlmanacPlantMenu.<>c.<>9__26_0 = delegate(PlantType p)
			{
				bool flag;
				return flag;
			};
		}
		this.ShowPlants(<>9__26_);
	}

	// Token: 0x060029B3 RID: 10675 RVA: 0x000E181C File Offset: 0x000DFA1C
	[Token(Token = "0x60029B3")]
	[Address(RVA = "0x689570", Offset = "0x687B70", VA = "0x180689570")]
	public void LookColorFul()
	{
		Func<PlantType, bool> <>9__27_ = AlmanacPlantMenu.<>c.<>9__27_0;
		if (<>9__27_ == 0)
		{
			AlmanacPlantMenu.<>c.<>9__27_0 = delegate(PlantType p)
			{
				HashSet<PlantType> specialCardPlants = TypeData.SpecialCardPlants;
				bool flag;
				return flag;
			};
		}
		this.ShowPlants(<>9__27_);
	}

	// Token: 0x060029B4 RID: 10676 RVA: 0x000E1858 File Offset: 0x000DFA58
	[Token(Token = "0x60029B4")]
	[Address(RVA = "0x68A620", Offset = "0x688C20", VA = "0x18068A620")]
	public void LookWhite()
	{
		Func<PlantType, bool> <>9__28_ = AlmanacPlantMenu.<>c.<>9__28_0;
		if (<>9__28_ == 0)
		{
			AlmanacPlantMenu.<>c.<>9__28_0 = delegate(PlantType p)
			{
				HashSet<PlantType> whiteCardPlants = TypeData.WhiteCardPlants;
				bool flag;
				return flag;
			};
		}
		this.ShowPlants(<>9__28_);
	}

	// Token: 0x060029B5 RID: 10677 RVA: 0x000E1894 File Offset: 0x000DFA94
	[Token(Token = "0x60029B5")]
	[Address(RVA = "0x6897D0", Offset = "0x687DD0", VA = "0x1806897D0")]
	public void LookFly()
	{
		Func<PlantType, bool> <>9__29_ = AlmanacPlantMenu.<>c.<>9__29_0;
		if (<>9__29_ == 0)
		{
			AlmanacPlantMenu.<>c.<>9__29_0 = delegate(PlantType p)
			{
				bool flag;
				return flag;
			};
		}
		this.ShowPlants(<>9__29_);
	}

	// Token: 0x060029B6 RID: 10678 RVA: 0x000E18D0 File Offset: 0x000DFAD0
	[Token(Token = "0x60029B6")]
	[Address(RVA = "0x689B00", Offset = "0x688100", VA = "0x180689B00")]
	public void LookMagnet()
	{
		Func<PlantType, bool> <>9__30_ = AlmanacPlantMenu.<>c.<>9__30_0;
		if (<>9__30_ == 0)
		{
			AlmanacPlantMenu.<>c.<>9__30_0 = delegate(PlantType p)
			{
				bool flag;
				return flag;
			};
		}
		this.ShowPlants(<>9__30_);
	}

	// Token: 0x060029B7 RID: 10679 RVA: 0x000E190C File Offset: 0x000DFB0C
	[Token(Token = "0x60029B7")]
	[Address(RVA = "0x689460", Offset = "0x687A60", VA = "0x180689460")]
	public void LookBig()
	{
		Func<PlantType, bool> <>9__31_ = AlmanacPlantMenu.<>c.<>9__31_0;
		if (<>9__31_ == 0)
		{
			AlmanacPlantMenu.<>c.<>9__31_0 = delegate(PlantType p)
			{
				bool flag;
				return flag;
			};
		}
		this.ShowPlants(<>9__31_);
	}

	// Token: 0x060029B8 RID: 10680 RVA: 0x000E1948 File Offset: 0x000DFB48
	[Token(Token = "0x60029B8")]
	[Address(RVA = "0x6898E0", Offset = "0x687EE0", VA = "0x1806898E0")]
	public void LookGold()
	{
		Func<PlantType, bool> <>9__32_ = AlmanacPlantMenu.<>c.<>9__32_0;
		if (<>9__32_ == 0)
		{
			AlmanacPlantMenu.<>c.<>9__32_0 = delegate(PlantType p)
			{
				bool flag;
				return flag;
			};
		}
		this.ShowPlants(<>9__32_);
	}

	// Token: 0x060029B9 RID: 10681 RVA: 0x000E1984 File Offset: 0x000DFB84
	[Token(Token = "0x60029B9")]
	[Address(RVA = "0x689E10", Offset = "0x688410", VA = "0x180689E10")]
	public void LookRed()
	{
		Func<PlantType, bool> <>9__33_ = AlmanacPlantMenu.<>c.<>9__33_0;
		if (<>9__33_ == 0)
		{
			AlmanacPlantMenu.<>c.<>9__33_0 = delegate(PlantType p)
			{
				HashSet<PlantType> redPlant = TypeMgr.RedPlant;
				bool flag;
				return flag;
			};
		}
		this.ShowPlants(<>9__33_);
	}

	// Token: 0x060029BA RID: 10682 RVA: 0x000E19C0 File Offset: 0x000DFBC0
	[Token(Token = "0x60029BA")]
	[Address(RVA = "0x68A9D0", Offset = "0x688FD0", VA = "0x18068A9D0")]
	public void SearchChanged(TMP_InputField inputField)
	{
		if (this._searchCoroutine != (ulong)0L)
		{
			Coroutine searchCoroutine = this._searchCoroutine;
			base.StopCoroutine(searchCoroutine);
		}
		string text = inputField.m_Text;
		AlmanacPlantMenu.<PerformSearchDelayed>d__37 <PerformSearchDelayed>d__;
		<PerformSearchDelayed>d__.System.IDisposable.Dispose();
		<PerformSearchDelayed>d__.<>1__state = (int)((ulong)0L);
		<PerformSearchDelayed>d__.<>4__this = this;
		<PerformSearchDelayed>d__.searchText = text;
		Coroutine coroutine = base.StartCoroutine(<PerformSearchDelayed>d__);
		this._searchCoroutine = coroutine;
		throw new NullReferenceException();
	}

	// Token: 0x060029BB RID: 10683 RVA: 0x000E1A20 File Offset: 0x000DFC20
	[Token(Token = "0x60029BB")]
	[Address(RVA = "0x68A730", Offset = "0x688D30", VA = "0x18068A730")]
	private IEnumerator PerformSearchDelayed(string searchText)
	{
		AlmanacPlantMenu.<PerformSearchDelayed>d__37 <PerformSearchDelayed>d__;
		<PerformSearchDelayed>d__.System.IDisposable.Dispose();
		<PerformSearchDelayed>d__.<>1__state = (int)((ulong)0L);
		<PerformSearchDelayed>d__.<>4__this = this;
		<PerformSearchDelayed>d__.searchText = searchText;
		return null;
	}

	// Token: 0x060029BC RID: 10684 RVA: 0x000E1A4C File Offset: 0x000DFC4C
	[Token(Token = "0x60029BC")]
	[Address(RVA = "0x68A7C0", Offset = "0x688DC0", VA = "0x18068A7C0")]
	private void PerformSearch(string searchText)
	{
		AlmanacPlantMenu.<>c__DisplayClass38_0 CS$<>8__locals1;
		for (;;)
		{
			CS$<>8__locals1.searchText = searchText;
			this.plantStack.Clear();
			if (!string.IsNullOrEmpty(CS$<>8__locals1.searchText))
			{
				break;
			}
			List<AlmanacCardUI> cards = this.cards;
			bool flag;
			if (flag)
			{
				GameObject gameObject;
				gameObject.SetActive(true);
			}
			ulong num;
			if (num == (ulong)0L)
			{
				goto Block_2;
			}
		}
		Func<PlantType, bool> func = delegate(PlantType p)
		{
			string text = CS$<>8__locals1.searchText.ToLowerInvariant();
			string text2;
			return text2.Contains(text, (StringComparison)((uint)5));
		};
		this.ShowPlants(func);
		return;
		Block_2:
		throw new NullReferenceException();
	}

	// Token: 0x060029BD RID: 10685 RVA: 0x000E1AC0 File Offset: 0x000DFCC0
	[Token(Token = "0x60029BD")]
	[Address(RVA = "0x68B290", Offset = "0x689890", VA = "0x18068B290")]
	public AlmanacPlantMenu()
	{
		Stack<PlantType> stack = new Stack();
		this.plantStack = stack;
		this._searchDelay = 0.3f;
		List<string> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		this.Tips = list;
		base..ctor();
	}

	// Token: 0x040017B0 RID: 6064
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40017B0")]
	[Header("卡牌设置")]
	public RectTransform basicCardHead2;

	// Token: 0x040017B1 RID: 6065
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40017B1")]
	[Header("图鉴展示项")]
	public AlmanacPlantWindow window;

	// Token: 0x040017B2 RID: 6066
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40017B2")]
	public GameObject button_lookMix;

	// Token: 0x040017B3 RID: 6067
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40017B3")]
	public GameObject button_lookBack;

	// Token: 0x040017B4 RID: 6068
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40017B4")]
	[Header("资源")]
	public GameObject cardPrefab;

	// Token: 0x040017B5 RID: 6069
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40017B5")]
	[Header("其他显示")]
	public TextMeshProUGUI tips;

	// Token: 0x040017B6 RID: 6070
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40017B6")]
	public UnityEvent<AlmanacCardUI> onClickPlantCard;

	// Token: 0x040017B7 RID: 6071
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40017B7")]
	private readonly Stack<PlantType> plantStack;

	// Token: 0x040017B8 RID: 6072
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40017B8")]
	[Header("输入相关")]
	private Coroutine _searchCoroutine;

	// Token: 0x040017B9 RID: 6073
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40017B9")]
	private readonly float _searchDelay;

	// Token: 0x040017BA RID: 6074
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40017BA")]
	private readonly List<string> Tips;
}
