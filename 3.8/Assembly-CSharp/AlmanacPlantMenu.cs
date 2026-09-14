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

// Token: 0x020007CB RID: 1995
[Token(Token = "0x20007CB")]
public class AlmanacPlantMenu : AlmanacSecondMenu
{
	// Token: 0x06002871 RID: 10353 RVA: 0x000DC130 File Offset: 0x000DA330
	[Token(Token = "0x6002871")]
	[Address(RVA = "0x624FD0", Offset = "0x6235D0", VA = "0x180624FD0", Slot = "6")]
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

	// Token: 0x06002872 RID: 10354 RVA: 0x000DC1D4 File Offset: 0x000DA3D4
	[Token(Token = "0x6002872")]
	[Address(RVA = "0x627940", Offset = "0x625F40", VA = "0x180627940")]
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

	// Token: 0x06002873 RID: 10355 RVA: 0x000DC204 File Offset: 0x000DA404
	[Token(Token = "0x6002873")]
	[Address(RVA = "0x6255D0", Offset = "0x623BD0", VA = "0x1806255D0")]
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

	// Token: 0x06002874 RID: 10356 RVA: 0x000DC2D4 File Offset: 0x000DA4D4
	[Token(Token = "0x6002874")]
	[Address(RVA = "0x627270", Offset = "0x625870", VA = "0x180627270")]
	private void SetCard(Transform parent, PlantType thePlantType)
	{
		AlmanacCardUI component = global::UnityEngine.Object.Instantiate<GameObject>(this.cardPrefab, parent).GetComponent<AlmanacCardUI>();
		component.menu = this;
		component.realType = thePlantType;
		List<AlmanacCardUI> cards = this.cards;
		int size = cards._size;
	}

	// Token: 0x06002875 RID: 10357 RVA: 0x000DC320 File Offset: 0x000DA520
	[Token(Token = "0x6002875")]
	[Address(RVA = "0x625270", Offset = "0x623870", VA = "0x180625270")]
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

	// Token: 0x06002876 RID: 10358 RVA: 0x000DC3C4 File Offset: 0x000DA5C4
	[Token(Token = "0x6002876")]
	[Address(RVA = "0x6273C0", Offset = "0x6259C0", VA = "0x1806273C0")]
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
				goto IL_0083;
			}
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
		IL_0083:
		throw new NullReferenceException();
	}

	// Token: 0x06002877 RID: 10359 RVA: 0x000DC460 File Offset: 0x000DA660
	[Token(Token = "0x6002877")]
	[Address(RVA = "0x6271B0", Offset = "0x6257B0", VA = "0x1806271B0")]
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

	// Token: 0x06002878 RID: 10360 RVA: 0x000DC4A8 File Offset: 0x000DA6A8
	[Token(Token = "0x6002878")]
	[Address(RVA = "0x627730", Offset = "0x625D30", VA = "0x180627730")]
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

	// Token: 0x06002879 RID: 10361 RVA: 0x000DC50C File Offset: 0x000DA70C
	[Token(Token = "0x6002879")]
	[Address(RVA = "0x626310", Offset = "0x624910", VA = "0x180626310")]
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

	// Token: 0x0600287A RID: 10362 RVA: 0x000DC590 File Offset: 0x000DA790
	[Token(Token = "0x600287A")]
	[Address(RVA = "0x6251B0", Offset = "0x6237B0", VA = "0x1806251B0")]
	public void BackLook()
	{
		Stack<PlantType> stack = this.plantStack;
		PlantType plantType = stack.Pop();
		Stack<PlantType> stack2 = this.plantStack;
		this.LookFirst();
	}

	// Token: 0x0600287B RID: 10363 RVA: 0x000DC5E0 File Offset: 0x000DA7E0
	[Token(Token = "0x600287B")]
	[Address(RVA = "0x625D80", Offset = "0x624380", VA = "0x180625D80")]
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

	// Token: 0x0600287C RID: 10364 RVA: 0x000DC63C File Offset: 0x000DA83C
	[Token(Token = "0x600287C")]
	[Address(RVA = "0x626620", Offset = "0x624C20", VA = "0x180626620")]
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

	// Token: 0x0600287D RID: 10365 RVA: 0x000DC678 File Offset: 0x000DA878
	[Token(Token = "0x600287D")]
	[Address(RVA = "0x626900", Offset = "0x624F00", VA = "0x180626900")]
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

	// Token: 0x0600287E RID: 10366 RVA: 0x000DC6B4 File Offset: 0x000DA8B4
	[Token(Token = "0x600287E")]
	[Address(RVA = "0x626840", Offset = "0x624E40", VA = "0x180626840")]
	public void LookTravelUlti(bool isStrongUltimate)
	{
		Func<PlantType, bool> func = delegate(PlantType p)
		{
			for (;;)
			{
				Dictionary<PlantType, ValueTuple<PlantType?, object, object, bool>> plantInfo = TravelDictionary.PlantInfo;
				bool flag;
				ulong num;
				if (flag)
				{
					if (isStrongUltimate)
					{
						break;
					}
				}
				else if (num == (ulong)0L)
				{
					goto Block_2;
				}
			}
			PlantType plantType;
			while (plantType != p)
			{
			}
			return true;
			Block_2:
			throw new NullReferenceException();
		};
		this.ShowPlants(func);
	}

	// Token: 0x0600287F RID: 10367 RVA: 0x000DC6EC File Offset: 0x000DA8EC
	[Token(Token = "0x600287F")]
	[Address(RVA = "0x626730", Offset = "0x624D30", VA = "0x180626730")]
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

	// Token: 0x06002880 RID: 10368 RVA: 0x000DC728 File Offset: 0x000DA928
	[Token(Token = "0x6002880")]
	[Address(RVA = "0x6260F0", Offset = "0x6246F0", VA = "0x1806260F0")]
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

	// Token: 0x06002881 RID: 10369 RVA: 0x000DC764 File Offset: 0x000DA964
	[Token(Token = "0x6002881")]
	[Address(RVA = "0x626400", Offset = "0x624A00", VA = "0x180626400")]
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

	// Token: 0x06002882 RID: 10370 RVA: 0x000DC7A0 File Offset: 0x000DA9A0
	[Token(Token = "0x6002882")]
	[Address(RVA = "0x626A10", Offset = "0x625010", VA = "0x180626A10")]
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

	// Token: 0x06002883 RID: 10371 RVA: 0x000DC810 File Offset: 0x000DAA10
	[Token(Token = "0x6002883")]
	[Address(RVA = "0x626C10", Offset = "0x625210", VA = "0x180626C10")]
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

	// Token: 0x06002884 RID: 10372 RVA: 0x000DC84C File Offset: 0x000DAA4C
	[Token(Token = "0x6002884")]
	[Address(RVA = "0x625C70", Offset = "0x624270", VA = "0x180625C70")]
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

	// Token: 0x06002885 RID: 10373 RVA: 0x000DC888 File Offset: 0x000DAA88
	[Token(Token = "0x6002885")]
	[Address(RVA = "0x626D20", Offset = "0x625320", VA = "0x180626D20")]
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

	// Token: 0x06002886 RID: 10374 RVA: 0x000DC8C4 File Offset: 0x000DAAC4
	[Token(Token = "0x6002886")]
	[Address(RVA = "0x625ED0", Offset = "0x6244D0", VA = "0x180625ED0")]
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

	// Token: 0x06002887 RID: 10375 RVA: 0x000DC900 File Offset: 0x000DAB00
	[Token(Token = "0x6002887")]
	[Address(RVA = "0x626200", Offset = "0x624800", VA = "0x180626200")]
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

	// Token: 0x06002888 RID: 10376 RVA: 0x000DC93C File Offset: 0x000DAB3C
	[Token(Token = "0x6002888")]
	[Address(RVA = "0x625B60", Offset = "0x624160", VA = "0x180625B60")]
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

	// Token: 0x06002889 RID: 10377 RVA: 0x000DC978 File Offset: 0x000DAB78
	[Token(Token = "0x6002889")]
	[Address(RVA = "0x625FE0", Offset = "0x6245E0", VA = "0x180625FE0")]
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

	// Token: 0x0600288A RID: 10378 RVA: 0x000DC9B4 File Offset: 0x000DABB4
	[Token(Token = "0x600288A")]
	[Address(RVA = "0x626510", Offset = "0x624B10", VA = "0x180626510")]
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

	// Token: 0x0600288B RID: 10379 RVA: 0x000DC9F0 File Offset: 0x000DABF0
	[Token(Token = "0x600288B")]
	[Address(RVA = "0x6270D0", Offset = "0x6256D0", VA = "0x1806270D0")]
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

	// Token: 0x0600288C RID: 10380 RVA: 0x000DCA50 File Offset: 0x000DAC50
	[Token(Token = "0x600288C")]
	[Address(RVA = "0x626E30", Offset = "0x625430", VA = "0x180626E30")]
	private IEnumerator PerformSearchDelayed(string searchText)
	{
		AlmanacPlantMenu.<PerformSearchDelayed>d__37 <PerformSearchDelayed>d__;
		<PerformSearchDelayed>d__.System.IDisposable.Dispose();
		<PerformSearchDelayed>d__.<>1__state = (int)((ulong)0L);
		<PerformSearchDelayed>d__.<>4__this = this;
		<PerformSearchDelayed>d__.searchText = searchText;
		return null;
	}

	// Token: 0x0600288D RID: 10381 RVA: 0x000DCA7C File Offset: 0x000DAC7C
	[Token(Token = "0x600288D")]
	[Address(RVA = "0x626EC0", Offset = "0x6254C0", VA = "0x180626EC0")]
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

	// Token: 0x0600288E RID: 10382 RVA: 0x000DCAF0 File Offset: 0x000DACF0
	[Token(Token = "0x600288E")]
	[Address(RVA = "0x627990", Offset = "0x625F90", VA = "0x180627990")]
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

	// Token: 0x040016D4 RID: 5844
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40016D4")]
	[Header("卡牌设置")]
	public RectTransform basicCardHead2;

	// Token: 0x040016D5 RID: 5845
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40016D5")]
	[Header("图鉴展示项")]
	public AlmanacPlantWindow window;

	// Token: 0x040016D6 RID: 5846
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40016D6")]
	public GameObject button_lookMix;

	// Token: 0x040016D7 RID: 5847
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40016D7")]
	public GameObject button_lookBack;

	// Token: 0x040016D8 RID: 5848
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40016D8")]
	[Header("资源")]
	public GameObject cardPrefab;

	// Token: 0x040016D9 RID: 5849
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40016D9")]
	[Header("其他显示")]
	public TextMeshProUGUI tips;

	// Token: 0x040016DA RID: 5850
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40016DA")]
	public UnityEvent<AlmanacCardUI> onClickPlantCard;

	// Token: 0x040016DB RID: 5851
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40016DB")]
	private readonly Stack<PlantType> plantStack;

	// Token: 0x040016DC RID: 5852
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40016DC")]
	[Header("输入相关")]
	private Coroutine _searchCoroutine;

	// Token: 0x040016DD RID: 5853
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40016DD")]
	private readonly float _searchDelay;

	// Token: 0x040016DE RID: 5854
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40016DE")]
	private readonly List<string> Tips;
}
