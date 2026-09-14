using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.UI;

// Token: 0x020007C9 RID: 1993
[Token(Token = "0x20007C9")]
public class AlmanacBuffMenu : AlmanacSecondMenu
{
	// Token: 0x0600284D RID: 10317 RVA: 0x000DB0D0 File Offset: 0x000D92D0
	[Token(Token = "0x600284D")]
	[Address(RVA = "0x61FAD0", Offset = "0x61E0D0", VA = "0x18061FAD0", Slot = "6")]
	protected override void Awake()
	{
		base.GetCol();
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
		GameObject gameObject = this.toolButton.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
		this.InitMenu();
	}

	// Token: 0x0600284E RID: 10318 RVA: 0x000DB114 File Offset: 0x000D9314
	[Token(Token = "0x600284E")]
	[Address(RVA = "0x620F30", Offset = "0x61F530", VA = "0x180620F30")]
	private void InitMenu()
	{
		if (!this.inited)
		{
			this.inited = true;
			List<AdvBuff> list = Enumerable.ToList<AdvBuff>(global::Core.Lawnf.GetEnumValues<AdvBuff>());
			List<AdvBuff> list2 = Enumerable.ToList<AdvBuff>(global::Core.Lawnf.GetEnumValues<AdvBuff>());
			this.InitWeakStrongUltiBuffs(list);
			this.InitGeneralBuffs(list);
			this.InitComboBuffs(list2, list);
			this.InitTinyBuffs(list2, list);
			this.InitShootingBuffs(list2, list);
			this.InitRandomBuffs(list);
			this.InitCurseBuffs(list);
			this.InitRogueBuffs(list);
			this.InitZombieBuffs();
			this.BindingButton();
			UnityEvent clickEvent = this.allBuff.clickEvent;
			if (clickEvent != 0)
			{
				clickEvent.Invoke();
			}
			List<AlmanacCardUI> cards = this.cards;
			int num = 0;
			AlmanacCardUI almanacCardUI = cards[num];
			int num2 = 0;
			this.OnCardClick(almanacCardUI, num2 != 0);
			return;
		}
	}

	// Token: 0x0600284F RID: 10319 RVA: 0x000DB1D0 File Offset: 0x000D93D0
	[Token(Token = "0x600284F")]
	[Address(RVA = "0x623A40", Offset = "0x622040", VA = "0x180623A40")]
	private void Start()
	{
		ulong num;
		do
		{
			this.InitMenu();
			if (!this.editMode)
			{
				break;
			}
			List<AlmanacCardUI> cards = this.cards;
			bool flag;
			if (flag)
			{
				Dictionary<AlmanacCardUI, AlmanacBuffMenu.CardInfo> dictionary = this.cardInfos;
				bool flag2;
				if (flag2)
				{
				}
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06002850 RID: 10320 RVA: 0x000DB224 File Offset: 0x000D9424
	[Token(Token = "0x6002850")]
	[Address(RVA = "0x6203E0", Offset = "0x61E9E0", VA = "0x1806203E0")]
	private void InitCards()
	{
		List<AdvBuff> list = Enumerable.ToList<AdvBuff>(global::Core.Lawnf.GetEnumValues<AdvBuff>());
		List<AdvBuff> list2 = Enumerable.ToList<AdvBuff>(global::Core.Lawnf.GetEnumValues<AdvBuff>());
		this.InitWeakStrongUltiBuffs(list);
		this.InitGeneralBuffs(list);
		this.InitComboBuffs(list2, list);
		this.InitTinyBuffs(list2, list);
		this.InitShootingBuffs(list2, list);
		this.InitRandomBuffs(list);
		this.InitCurseBuffs(list);
		this.InitRogueBuffs(list);
		this.InitZombieBuffs();
	}

	// Token: 0x06002851 RID: 10321 RVA: 0x000DB288 File Offset: 0x000D9488
	[Token(Token = "0x6002851")]
	[Address(RVA = "0x621100", Offset = "0x61F700", VA = "0x180621100")]
	private void InitRandomBuffs(List<AdvBuff> advbuffs)
	{
		ulong num2;
		do
		{
			int num = 0;
			List<AlmanacCardUI> list = new List();
			this.randomBuffs = list;
			HashSet<AdvBuff> hashSet = TravelDictionary.RandomBuffs;
			bool flag;
			if (flag)
			{
				AdvBuff advBuff;
				string text = TravelMgr.Instance.GetText(advBuff);
				List<AlmanacCardUI> list2 = this.randomBuffs;
				AdvBuff advBuff2;
				this.CreateCardUI(advBuff2, list2);
				bool flag2 = advbuffs.Remove(num);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06002852 RID: 10322 RVA: 0x000DB2F8 File Offset: 0x000D94F8
	[Token(Token = "0x6002852")]
	[Address(RVA = "0x621EC0", Offset = "0x6204C0", VA = "0x180621EC0")]
	private void InitWeakStrongUltiBuffs(List<AdvBuff> advbuffs)
	{
		ulong num;
		do
		{
			List<AlmanacCardUI> list = new List();
			this.weakUltiBuffs = list;
			List<AlmanacCardUI> list2 = new List();
			this.strongUltiBuffs = list2;
			Dictionary<PlantType, ValueTuple<PlantType?, object, object, bool>> plantInfo = TravelDictionary.PlantInfo;
			bool flag;
			if (flag)
			{
				TravelMgr instance = TravelMgr.Instance;
				TravelMgr instance2 = TravelMgr.Instance;
				if (0 != 0)
				{
				}
				if (0 == 0)
				{
					continue;
				}
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06002853 RID: 10323 RVA: 0x000DB37C File Offset: 0x000D957C
	[Token(Token = "0x6002853")]
	[Address(RVA = "0x622430", Offset = "0x620A30", VA = "0x180622430")]
	private void InitZombieBuffs()
	{
		List<AlmanacCardUI> list = new List();
		this.zombieBuffs = list;
		TravelDebuff[] enumValues = global::Core.Lawnf.GetEnumValues<TravelDebuff>();
		int num = 0;
		if (num < enumValues.Length)
		{
			TravelMgr instance = TravelMgr.Instance;
			string text = instance.GetText(instance);
			Dictionary<TravelDebuff, ValueTuple<string, ZombieType>> debuffData = TravelDictionary.debuffData;
			List<AlmanacCardUI> list2 = this.zombieBuffs;
			this.CreateCardUI(num, list2);
			num++;
		}
	}

	// Token: 0x06002854 RID: 10324 RVA: 0x000DB3E4 File Offset: 0x000D95E4
	[Token(Token = "0x6002854")]
	[Address(RVA = "0x6208E0", Offset = "0x61EEE0", VA = "0x1806208E0")]
	private void InitCurseBuffs(List<AdvBuff> advbuffs)
	{
		ulong num2;
		do
		{
			int num = 0;
			List<AlmanacCardUI> list = new List();
			this.curseBuffs = list;
			HashSet<AdvBuff> hashSet = TravelDictionary.CurseBuffs;
			bool flag;
			if (flag)
			{
				AdvBuff advBuff;
				string text = TravelMgr.Instance.GetText(advBuff);
				AdvBuff advBuff2;
				PlantType plantTypeByAdvBuff = TravelMgr.GetPlantTypeByAdvBuff(advBuff2);
				bool flag2 = advbuffs.Remove(num);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06002855 RID: 10325 RVA: 0x000DB44C File Offset: 0x000D964C
	[Token(Token = "0x6002855")]
	[Address(RVA = "0x6213D0", Offset = "0x61F9D0", VA = "0x1806213D0")]
	private void InitRogueBuffs(List<AdvBuff> advbuffs)
	{
		ulong num2;
		do
		{
			int num = 0;
			List<AlmanacCardUI> list = new List();
			this.rogueBuffs = list;
			HashSet<AdvBuff> hashSet = TravelDictionary.RogueBuffs;
			bool flag;
			if (flag)
			{
				AdvBuff advBuff;
				string text = TravelMgr.Instance.GetText(advBuff);
				AdvBuff advBuff2;
				PlantType plantTypeByAdvBuff = TravelMgr.GetPlantTypeByAdvBuff(advBuff2);
				bool flag2 = advbuffs.Remove(num);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06002856 RID: 10326 RVA: 0x000DB4B4 File Offset: 0x000D96B4
	[Token(Token = "0x6002856")]
	[Address(RVA = "0x620510", Offset = "0x61EB10", VA = "0x180620510")]
	private void InitComboBuffs(IReadOnlyList<AdvBuff> allAdvBuffs, List<AdvBuff> advbuffs)
	{
		int num;
		do
		{
			num = 0;
			List<AlmanacCardUI> list = new List();
			this.comboBuffs = list;
			if (list != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					if (num == typeof(IEnumerator).TypeHandle)
					{
						goto IL_0054;
					}
					num++;
				}
				while (list > (ulong)999L)
				{
				}
				TravelMgr instance = TravelMgr.Instance;
				PlantType plantTypeByAdvBuff = TravelMgr.GetPlantTypeByAdvBuff(instance.GetText(instance));
				IL_0054:
				bool flag;
				flag += flag;
			}
			if ("{il2cpp array field local7->}" != (ulong)0L)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x06002857 RID: 10327 RVA: 0x000DB544 File Offset: 0x000D9744
	[Token(Token = "0x6002857")]
	[Address(RVA = "0x621AF0", Offset = "0x6200F0", VA = "0x180621AF0")]
	private void InitTinyBuffs(IReadOnlyList<AdvBuff> allAdvBuffs, List<AdvBuff> advbuffs)
	{
		int num;
		do
		{
			num = 0;
			List<AlmanacCardUI> list = new List();
			this.tinyBuffs = list;
			if (list != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					if (num == typeof(IEnumerator).TypeHandle)
					{
						goto IL_0054;
					}
					num++;
				}
				while (list > (ulong)999L)
				{
				}
				TravelMgr instance = TravelMgr.Instance;
				PlantType plantTypeByAdvBuff = TravelMgr.GetPlantTypeByAdvBuff(instance.GetText(instance));
				IL_0054:
				bool flag;
				flag += flag;
			}
			if ("{il2cpp array field local7->}" != (ulong)0L)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x06002858 RID: 10328 RVA: 0x000DB5D4 File Offset: 0x000D97D4
	[Token(Token = "0x6002858")]
	[Address(RVA = "0x621730", Offset = "0x61FD30", VA = "0x180621730")]
	private void InitShootingBuffs(IReadOnlyList<AdvBuff> allAdvBuffs, List<AdvBuff> advbuffs)
	{
		int num;
		do
		{
			num = 0;
			List<AlmanacCardUI> list = new List();
			this.shootingBuffs = list;
			if (list != 0)
			{
				if (num >= typeof(IEnumerator).TypeHandle)
				{
					goto IL_002D;
				}
				num += num;
				if (num != typeof(IEnumerator).TypeHandle)
				{
					num++;
					goto IL_002D;
				}
				IL_004A:
				bool flag;
				flag += flag;
				goto IL_0051;
				IL_002D:
				TravelMgr instance = TravelMgr.Instance;
				PlantType plantTypeByAdvBuff = TravelMgr.GetPlantTypeByAdvBuff(instance.GetText(instance));
				goto IL_004A;
			}
			IL_0051:
			if ("{il2cpp array field local7->}" != (ulong)0L)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x06002859 RID: 10329 RVA: 0x000DB65C File Offset: 0x000D985C
	[Token(Token = "0x6002859")]
	[Address(RVA = "0x620C40", Offset = "0x61F240", VA = "0x180620C40")]
	private void InitGeneralBuffs(List<AdvBuff> advbuffs)
	{
		ulong num;
		do
		{
			List<AlmanacCardUI> list = new List();
			this.generalBuffs = list;
			bool flag;
			if (flag)
			{
				AdvBuff advBuff;
				string text = TravelMgr.Instance.GetText(advBuff);
				AdvBuff advBuff2;
				PlantType plantTypeByAdvBuff = TravelMgr.GetPlantTypeByAdvBuff(advBuff2);
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x0600285A RID: 10330 RVA: 0x000DB6AC File Offset: 0x000D98AC
	[Token(Token = "0x600285A")]
	[Address(RVA = "0x620020", Offset = "0x61E620", VA = "0x180620020")]
	private void CreateCardUI(AlmanacBuffMenu.CardInfo cardInfo, List<AlmanacCardUI> listToAdd)
	{
		if (!this.editMode)
		{
			PlantType plantType = cardInfo.plantType;
			bool flag;
			if (!flag)
			{
				return;
			}
		}
		GameObject gameObject = this.cardPrefab;
		RectTransform basicCardContent = this.basicCardContent;
		AlmanacCardUI component = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, basicCardContent).GetComponent<AlmanacCardUI>();
		int size = listToAdd._size;
		component._plantType = component;
		Dictionary<AlmanacCardUI, AlmanacBuffMenu.CardInfo> dictionary = this.cardInfos;
		PlantType plantType2 = cardInfo.plantType;
		int size2 = this.cards._size;
		if (!cardInfo.isZombie)
		{
		}
		string text;
		component.cost.text = text;
		component.cost.fontSizeMax = 14.35f;
		Action<AlmanacCardUI> action;
		Delegate @delegate = Delegate.Combine(component.onMouseDown, action);
		if (@delegate == 0)
		{
			component.onMouseDown = @delegate;
		}
		if (@delegate != 0)
		{
			component.onMouseDown = @delegate;
			if (@delegate != 0)
			{
				return;
			}
		}
		throw new InvalidCastException();
	}

	// Token: 0x0600285B RID: 10331 RVA: 0x000DB780 File Offset: 0x000D9980
	[Token(Token = "0x600285B")]
	[Address(RVA = "0x6226B0", Offset = "0x620CB0", VA = "0x1806226B0")]
	private void OnCardClick(AlmanacCardUI card, bool playSound)
	{
		GameObject gameObject = this.tempShow;
		int num = 0;
		if (gameObject != num)
		{
			global::UnityEngine.Object.Destroy(this.tempShow);
		}
		Dictionary<AlmanacCardUI, AlmanacBuffMenu.CardInfo> dictionary = this.cardInfos;
		Image image = this.windowBackground;
		bool flag = flag + this != null;
		Image image2 = this.windowBackground;
		TextMeshProUGUI textMeshProUGUI = this.buffDescription;
		string text;
		this.buffTitle.text = text;
		if (this.toolButton.gameObject.activeSelf)
		{
			this.UpdateCurrent(card);
		}
		if (playSound)
		{
		}
	}

	// Token: 0x0600285C RID: 10332 RVA: 0x000DB804 File Offset: 0x000D9A04
	[Token(Token = "0x600285C")]
	[Address(RVA = "0x623430", Offset = "0x621A30", VA = "0x180623430")]
	private void SetPlant(Transform axis, PlantType thePlantType)
	{
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = new GameObject("plant");
		Transform transform = gameObject.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		GameObject gameObject2;
		Transform transform2 = gameObject2.transform;
		Transform transform3 = gameObject.transform;
		transform2.parentInternal = transform3;
		gameObject.transform.parentInternal = axis;
		this.tempShow = gameObject;
		SortingGroup sortingGroup = this.tempShow.AddComponent<SortingGroup>();
		sortingGroup.sortingLayerName = "up1";
		sortingGroup.sortingOrder = 20001;
	}

	// Token: 0x0600285D RID: 10333 RVA: 0x000DB88C File Offset: 0x000D9A8C
	[Token(Token = "0x600285D")]
	[Address(RVA = "0x6237D0", Offset = "0x621DD0", VA = "0x1806237D0")]
	private void SetZombie(Transform axis, ZombieType theZombieType)
	{
		Vector3 vector;
		float z = vector.z;
		Vector3 vector2;
		float z2 = vector2.z;
		GameObject gameObject = new GameObject("zombie");
		Transform transform = gameObject.transform;
		Vector3 vector3;
		float z3 = vector3.z;
		GameObject gameObject2;
		Transform transform2 = gameObject2.transform;
		Transform transform3 = gameObject.transform;
		transform2.parentInternal = transform3;
		gameObject.transform.parentInternal = axis;
		this.tempShow = gameObject;
		SortingGroup sortingGroup = this.tempShow.AddComponent<SortingGroup>();
		sortingGroup.sortingLayerName = "up1";
		sortingGroup.sortingOrder = 20001;
	}

	// Token: 0x0600285E RID: 10334 RVA: 0x000DB924 File Offset: 0x000D9B24
	[Token(Token = "0x600285E")]
	[Address(RVA = "0x61FBA0", Offset = "0x61E1A0", VA = "0x18061FBA0")]
	private void BindingButton()
	{
		UnityEvent clickEvent = this.allBuff.clickEvent;
		UnityAction unityAction = delegate
		{
			ulong num;
			do
			{
				List<AlmanacCardUI> cards = this.cards;
				bool flag;
				if (flag)
				{
					GameObject gameObject;
					gameObject.SetActive(true);
				}
			}
			while (num != (ulong)0L);
		};
		clickEvent.AddListener(unityAction);
		UnityEvent clickEvent2 = this.weakUltiBuff.clickEvent;
		UnityAction unityAction2 = delegate
		{
			ulong num3;
			do
			{
				int num2 = 0;
				this.SetAllCards(num2 != 0);
				List<AlmanacCardUI> list = this.weakUltiBuffs;
				bool flag2;
				if (flag2)
				{
					GameObject gameObject2;
					gameObject2.SetActive(true);
				}
			}
			while (num3 != (ulong)0L);
		};
		clickEvent2.AddListener(unityAction2);
		UnityEvent clickEvent3 = this.strongUltiBuff.clickEvent;
		UnityAction unityAction3 = delegate
		{
			ulong num5;
			do
			{
				int num4 = 0;
				this.SetAllCards(num4 != 0);
				List<AlmanacCardUI> list2 = this.strongUltiBuffs;
				bool flag3;
				if (flag3)
				{
					GameObject gameObject3;
					gameObject3.SetActive(true);
				}
			}
			while (num5 != (ulong)0L);
		};
		clickEvent3.AddListener(unityAction3);
		UnityEvent clickEvent4 = this.generalBuff.clickEvent;
		UnityAction unityAction4 = delegate
		{
			ulong num7;
			do
			{
				int num6 = 0;
				this.SetAllCards(num6 != 0);
				List<AlmanacCardUI> list3 = this.generalBuffs;
				bool flag4;
				if (flag4)
				{
					GameObject gameObject4;
					gameObject4.SetActive(true);
				}
			}
			while (num7 != (ulong)0L);
		};
		clickEvent4.AddListener(unityAction4);
		UnityEvent clickEvent5 = this.randomBuff.clickEvent;
		UnityAction unityAction5 = delegate
		{
			ulong num9;
			do
			{
				int num8 = 0;
				this.SetAllCards(num8 != 0);
				List<AlmanacCardUI> list4 = this.randomBuffs;
				bool flag5;
				if (flag5)
				{
					GameObject gameObject5;
					gameObject5.SetActive(true);
				}
			}
			while (num9 != (ulong)0L);
		};
		clickEvent5.AddListener(unityAction5);
		UnityEvent clickEvent6 = this.zombieBuff.clickEvent;
		UnityAction unityAction6 = delegate
		{
			ulong num11;
			do
			{
				int num10 = 0;
				this.SetAllCards(num10 != 0);
				List<AlmanacCardUI> list5 = this.zombieBuffs;
				bool flag6;
				if (flag6)
				{
					GameObject gameObject6;
					gameObject6.SetActive(true);
				}
			}
			while (num11 != (ulong)0L);
		};
		clickEvent6.AddListener(unityAction6);
		UnityEvent clickEvent7 = this.curseBuff.clickEvent;
		UnityAction unityAction7 = delegate
		{
			ulong num13;
			do
			{
				int num12 = 0;
				this.SetAllCards(num12 != 0);
				List<AlmanacCardUI> list6 = this.curseBuffs;
				bool flag7;
				if (flag7)
				{
					GameObject gameObject7;
					gameObject7.SetActive(true);
				}
			}
			while (num13 != (ulong)0L);
		};
		clickEvent7.AddListener(unityAction7);
		UnityEvent clickEvent8 = this.rogueBuff.clickEvent;
		UnityAction unityAction8 = delegate
		{
			ulong num15;
			do
			{
				int num14 = 0;
				this.SetAllCards(num14 != 0);
				List<AlmanacCardUI> list7 = this.rogueBuffs;
				bool flag8;
				if (flag8)
				{
					GameObject gameObject8;
					gameObject8.SetActive(true);
				}
			}
			while (num15 != (ulong)0L);
		};
		clickEvent8.AddListener(unityAction8);
		UnityEvent clickEvent9 = this.comboBuff.clickEvent;
		UnityAction unityAction9 = delegate
		{
			ulong num17;
			do
			{
				int num16 = 0;
				this.SetAllCards(num16 != 0);
				List<AlmanacCardUI> list8 = this.comboBuffs;
				bool flag9;
				if (flag9)
				{
					GameObject gameObject9;
					gameObject9.SetActive(true);
				}
			}
			while (num17 != (ulong)0L);
		};
		clickEvent9.AddListener(unityAction9);
		UnityEvent clickEvent10 = this.tinyBuff.clickEvent;
		UnityAction unityAction10 = delegate
		{
			ulong num19;
			do
			{
				int num18 = 0;
				this.SetAllCards(num18 != 0);
				List<AlmanacCardUI> list9 = this.tinyBuffs;
				bool flag10;
				if (flag10)
				{
					GameObject gameObject10;
					gameObject10.SetActive(true);
				}
			}
			while (num19 != (ulong)0L);
		};
		clickEvent10.AddListener(unityAction10);
		UnityEvent clickEvent11 = this.shootingBuff.clickEvent;
		UnityAction unityAction11 = delegate
		{
			ulong num21;
			do
			{
				int num20 = 0;
				this.SetAllCards(num20 != 0);
				List<AlmanacCardUI> list10 = this.shootingBuffs;
				bool flag11;
				if (flag11)
				{
					GameObject gameObject11;
					gameObject11.SetActive(true);
				}
			}
			while (num21 != (ulong)0L);
		};
		clickEvent11.AddListener(unityAction11);
		UnityEvent clickEvent12 = this.toolButton.clickEvent;
		UnityAction unityAction12 = delegate
		{
			UIButton uibutton = this.toolButton;
			this.OnToolClick(uibutton);
		};
		clickEvent12.AddListener(unityAction12);
	}

	// Token: 0x0600285F RID: 10335 RVA: 0x000DBAE0 File Offset: 0x000D9CE0
	[Token(Token = "0x600285F")]
	[Address(RVA = "0x6232F0", Offset = "0x6218F0", VA = "0x1806232F0")]
	private void SetAllCards(bool active)
	{
		ulong num;
		do
		{
			List<AlmanacCardUI> cards = this.cards;
			bool flag;
			if (flag)
			{
				GameObject gameObject;
				gameObject.SetActive(active);
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06002860 RID: 10336 RVA: 0x000DBB1C File Offset: 0x000D9D1C
	[Token(Token = "0x6002860")]
	[Address(RVA = "0x624A60", Offset = "0x623060", VA = "0x180624A60")]
	private void UpdateCurrent(AlmanacCardUI card)
	{
		this.current = card;
		Dictionary<AlmanacCardUI, AlmanacBuffMenu.CardInfo> dictionary = this.cardInfos;
		TravelMgr instance = TravelMgr.Instance;
		TextMeshProUGUI componentInChildren = this.toolButton.GetComponentInChildren<TextMeshProUGUI>();
		if (!this.editMode && componentInChildren == (ulong)4294967291L)
		{
			TravelData data = instance.data;
			componentInChildren.text = "已满级";
			return;
		}
		List<TravelUnlocks> unlockedPlants = instance.data.unlockedPlants;
		List<AdvBuff> advBuffs = instance.data.advBuffs;
		TravelData data2 = instance.data;
		List<TravelDebuff> travelDebuffs = instance.data.travelDebuffs;
		throw new NullReferenceException();
	}

	// Token: 0x06002861 RID: 10337 RVA: 0x000DBBCC File Offset: 0x000D9DCC
	[Token(Token = "0x6002861")]
	[Address(RVA = "0x622990", Offset = "0x620F90", VA = "0x180622990")]
	private void OnToolClick(UIButton button)
	{
		AlmanacCardUI almanacCardUI = this.current;
		int num = 0;
		if (!(almanacCardUI == num))
		{
			TravelMgr instance = TravelMgr.Instance;
			TextMeshProUGUI componentInChildren = button.GetComponentInChildren<TextMeshProUGUI>();
			Dictionary<AlmanacCardUI, AlmanacBuffMenu.CardInfo> dictionary = this.cardInfos;
			int num2 = 0;
			if ((this.editMode ? 1 : 0) != num2)
			{
				UIButton uibutton;
				if (uibutton == 0)
				{
					goto IL_0111;
				}
				if (uibutton != 0)
				{
					PlantType plantType = almanacCardUI._plantType;
					bool flag;
					if (!flag)
					{
						int num3 = 0;
						ulong num4;
						ulong num5;
						this.SetText(uibutton, num3, num4 != 0UL, (int)num5);
						goto IL_0111;
					}
					goto IL_0131;
				}
				IL_0139:
				Image component;
				while (component == 0)
				{
				}
				if (component != 0)
				{
					PlantType plantType2 = almanacCardUI._plantType;
					bool flag2;
					if (!flag2)
					{
					}
					PlantType plantType3 = almanacCardUI._plantType;
				}
				while (component == 0)
				{
				}
				int num6;
				if (component != 0 && num6 != 0 && num6 != 0)
				{
					while (num6 != 1)
					{
					}
					PlantType plantType4 = almanacCardUI._plantType;
					PlantType plantType5 = almanacCardUI._plantType;
				}
				while (component == 0)
				{
				}
				while (component == 0)
				{
				}
				PlantType plantType6 = almanacCardUI._plantType;
				bool flag3;
				if (!flag3)
				{
				}
				PlantType plantType7 = almanacCardUI._plantType;
				goto IL_01AC;
				IL_0111:
				component = this.current.GetComponent<Image>();
				Dictionary<AlmanacCardUI, AlmanacBuffMenu.CardInfo> dictionary2 = this.cardInfos;
				bool flag4;
				if (!flag4)
				{
					goto IL_01AC;
				}
				int num7 = 0;
				IL_0131:
				PlantType plantType8 = almanacCardUI._plantType;
				goto IL_0139;
				IL_01AC:
				component.color = num7;
				throw new NullReferenceException();
			}
			bool flag5;
			if (!flag5)
			{
			}
			Dictionary<TravelDebuff, ValueTuple<string, ZombieType>> debuffData = TravelDictionary.debuffData;
			bool flag6;
			if (!flag6)
			{
				List<TravelDebuff> travelDebuffs = instance.data.travelDebuffs;
				List<AdvBuff> advBuffs = instance.data.advBuffs;
				componentInChildren.text = "已消除";
			}
			uint num8;
			GameAPP.PlaySound((int)num8, 0.5f, 1f);
			InGameText instance2 = InGameText.Instance;
			int num9 = 0;
			instance2.ShowText("不可净化领袖词条", 3f, num9 != 0);
		}
	}

	// Token: 0x06002862 RID: 10338 RVA: 0x000DBD9C File Offset: 0x000D9F9C
	[Token(Token = "0x6002862")]
	[Address(RVA = "0x623630", Offset = "0x621C30", VA = "0x180623630")]
	private void SetText(object buff, TextMeshProUGUI text, bool have, int level = 1)
	{
		if (!have)
		{
			text.text = "已关闭";
			return;
		}
		text.text = "已开启";
		while (buff == 0)
		{
		}
		while (buff == 0)
		{
		}
		string text2 = text.text;
		string text3 = string.Format("（{0}级）", text2);
		string text4 = text2 + text3;
		text.text = text4;
	}

	// Token: 0x06002863 RID: 10339 RVA: 0x000DBDF8 File Offset: 0x000D9FF8
	[Token(Token = "0x6002863")]
	[Address(RVA = "0x624F50", Offset = "0x623550", VA = "0x180624F50")]
	public AlmanacBuffMenu()
	{
		Dictionary<AlmanacCardUI, AlmanacBuffMenu.CardInfo> dictionary = new Dictionary();
		this.cardInfos = dictionary;
		base..ctor();
	}

	// Token: 0x040016AA RID: 5802
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40016AA")]
	[Header("预制体")]
	public GameObject cardPrefab;

	// Token: 0x040016AB RID: 5803
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40016AB")]
	[Header("UI引用")]
	public RectTransform axis;

	// Token: 0x040016AC RID: 5804
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40016AC")]
	public RectTransform axis2;

	// Token: 0x040016AD RID: 5805
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40016AD")]
	public TextMeshProUGUI buffTitle;

	// Token: 0x040016AE RID: 5806
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40016AE")]
	public TextMeshProUGUI buffDescription;

	// Token: 0x040016AF RID: 5807
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40016AF")]
	public Image windowBackground;

	// Token: 0x040016B0 RID: 5808
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40016B0")]
	[Header("背景展示")]
	public Sprite day;

	// Token: 0x040016B1 RID: 5809
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40016B1")]
	public Sprite night;

	// Token: 0x040016B2 RID: 5810
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40016B2")]
	public Sprite pool;

	// Token: 0x040016B3 RID: 5811
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40016B3")]
	[Header("按钮绑定")]
	public UIButton allBuff;

	// Token: 0x040016B4 RID: 5812
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40016B4")]
	public UIButton weakUltiBuff;

	// Token: 0x040016B5 RID: 5813
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40016B5")]
	public UIButton strongUltiBuff;

	// Token: 0x040016B6 RID: 5814
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40016B6")]
	public UIButton generalBuff;

	// Token: 0x040016B7 RID: 5815
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40016B7")]
	public UIButton randomBuff;

	// Token: 0x040016B8 RID: 5816
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40016B8")]
	public UIButton zombieBuff;

	// Token: 0x040016B9 RID: 5817
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40016B9")]
	public UIButton curseBuff;

	// Token: 0x040016BA RID: 5818
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40016BA")]
	public UIButton rogueBuff;

	// Token: 0x040016BB RID: 5819
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40016BB")]
	public UIButton comboBuff;

	// Token: 0x040016BC RID: 5820
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x40016BC")]
	public UIButton tinyBuff;

	// Token: 0x040016BD RID: 5821
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40016BD")]
	public UIButton shootingBuff;

	// Token: 0x040016BE RID: 5822
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40016BE")]
	private List<AlmanacCardUI> weakUltiBuffs;

	// Token: 0x040016BF RID: 5823
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40016BF")]
	private List<AlmanacCardUI> strongUltiBuffs;

	// Token: 0x040016C0 RID: 5824
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x40016C0")]
	private List<AlmanacCardUI> generalBuffs;

	// Token: 0x040016C1 RID: 5825
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x40016C1")]
	private List<AlmanacCardUI> randomBuffs;

	// Token: 0x040016C2 RID: 5826
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x40016C2")]
	private List<AlmanacCardUI> zombieBuffs;

	// Token: 0x040016C3 RID: 5827
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x40016C3")]
	private List<AlmanacCardUI> curseBuffs;

	// Token: 0x040016C4 RID: 5828
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x40016C4")]
	private List<AlmanacCardUI> rogueBuffs;

	// Token: 0x040016C5 RID: 5829
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x40016C5")]
	private List<AlmanacCardUI> comboBuffs;

	// Token: 0x040016C6 RID: 5830
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x40016C6")]
	private List<AlmanacCardUI> tinyBuffs;

	// Token: 0x040016C7 RID: 5831
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x40016C7")]
	private List<AlmanacCardUI> shootingBuffs;

	// Token: 0x040016C8 RID: 5832
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x40016C8")]
	private GameObject tempShow;

	// Token: 0x040016C9 RID: 5833
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x40016C9")]
	public readonly Dictionary<AlmanacCardUI, AlmanacBuffMenu.CardInfo> cardInfos;

	// Token: 0x040016CA RID: 5834
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x40016CA")]
	private bool inited;

	// Token: 0x040016CB RID: 5835
	[Token(Token = "0x40016CB")]
	public static bool lookBuff;

	// Token: 0x040016CC RID: 5836
	[FieldOffset(Offset = "0x161")]
	[Token(Token = "0x40016CC")]
	public bool editMode;

	// Token: 0x040016CD RID: 5837
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x40016CD")]
	public UIButton toolButton;

	// Token: 0x040016CE RID: 5838
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x40016CE")]
	private AlmanacCardUI current;

	// Token: 0x020007CA RID: 1994
	[Token(Token = "0x20007CA")]
	public struct CardInfo
	{
		// Token: 0x040016CF RID: 5839
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40016CF")]
		public object buff;

		// Token: 0x040016D0 RID: 5840
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40016D0")]
		public string description;

		// Token: 0x040016D1 RID: 5841
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40016D1")]
		public PlantType plantType;

		// Token: 0x040016D2 RID: 5842
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40016D2")]
		public ZombieType zombieType;

		// Token: 0x040016D3 RID: 5843
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40016D3")]
		public bool isZombie;
	}
}
