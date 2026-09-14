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

// Token: 0x02000802 RID: 2050
[Token(Token = "0x2000802")]
public class AlmanacBuffMenu : AlmanacSecondMenu
{
	// Token: 0x0600297C RID: 10620 RVA: 0x000E008C File Offset: 0x000DE28C
	[Token(Token = "0x600297C")]
	[Address(RVA = "0x6833C0", Offset = "0x6819C0", VA = "0x1806833C0", Slot = "6")]
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

	// Token: 0x0600297D RID: 10621 RVA: 0x000E00D0 File Offset: 0x000DE2D0
	[Token(Token = "0x600297D")]
	[Address(RVA = "0x684820", Offset = "0x682E20", VA = "0x180684820")]
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

	// Token: 0x0600297E RID: 10622 RVA: 0x000E018C File Offset: 0x000DE38C
	[Token(Token = "0x600297E")]
	[Address(RVA = "0x687340", Offset = "0x685940", VA = "0x180687340")]
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

	// Token: 0x0600297F RID: 10623 RVA: 0x000E01E0 File Offset: 0x000DE3E0
	[Token(Token = "0x600297F")]
	[Address(RVA = "0x683CD0", Offset = "0x6822D0", VA = "0x180683CD0")]
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

	// Token: 0x06002980 RID: 10624 RVA: 0x000E0244 File Offset: 0x000DE444
	[Token(Token = "0x6002980")]
	[Address(RVA = "0x6849F0", Offset = "0x682FF0", VA = "0x1806849F0")]
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

	// Token: 0x06002981 RID: 10625 RVA: 0x000E02B4 File Offset: 0x000DE4B4
	[Token(Token = "0x6002981")]
	[Address(RVA = "0x6857B0", Offset = "0x683DB0", VA = "0x1806857B0")]
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

	// Token: 0x06002982 RID: 10626 RVA: 0x000E0338 File Offset: 0x000DE538
	[Token(Token = "0x6002982")]
	[Address(RVA = "0x685D20", Offset = "0x684320", VA = "0x180685D20")]
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

	// Token: 0x06002983 RID: 10627 RVA: 0x000E03A0 File Offset: 0x000DE5A0
	[Token(Token = "0x6002983")]
	[Address(RVA = "0x6841D0", Offset = "0x6827D0", VA = "0x1806841D0")]
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

	// Token: 0x06002984 RID: 10628 RVA: 0x000E0408 File Offset: 0x000DE608
	[Token(Token = "0x6002984")]
	[Address(RVA = "0x684CC0", Offset = "0x6832C0", VA = "0x180684CC0")]
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

	// Token: 0x06002985 RID: 10629 RVA: 0x000E0470 File Offset: 0x000DE670
	[Token(Token = "0x6002985")]
	[Address(RVA = "0x683E00", Offset = "0x682400", VA = "0x180683E00")]
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

	// Token: 0x06002986 RID: 10630 RVA: 0x000E0500 File Offset: 0x000DE700
	[Token(Token = "0x6002986")]
	[Address(RVA = "0x6853E0", Offset = "0x6839E0", VA = "0x1806853E0")]
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

	// Token: 0x06002987 RID: 10631 RVA: 0x000E0590 File Offset: 0x000DE790
	[Token(Token = "0x6002987")]
	[Address(RVA = "0x685020", Offset = "0x683620", VA = "0x180685020")]
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

	// Token: 0x06002988 RID: 10632 RVA: 0x000E0618 File Offset: 0x000DE818
	[Token(Token = "0x6002988")]
	[Address(RVA = "0x684530", Offset = "0x682B30", VA = "0x180684530")]
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

	// Token: 0x06002989 RID: 10633 RVA: 0x000E0668 File Offset: 0x000DE868
	[Token(Token = "0x6002989")]
	[Address(RVA = "0x683910", Offset = "0x681F10", VA = "0x180683910")]
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

	// Token: 0x0600298A RID: 10634 RVA: 0x000E073C File Offset: 0x000DE93C
	[Token(Token = "0x600298A")]
	[Address(RVA = "0x685FA0", Offset = "0x6845A0", VA = "0x180685FA0")]
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

	// Token: 0x0600298B RID: 10635 RVA: 0x000E07C0 File Offset: 0x000DE9C0
	[Token(Token = "0x600298B")]
	[Address(RVA = "0x686D30", Offset = "0x685330", VA = "0x180686D30")]
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

	// Token: 0x0600298C RID: 10636 RVA: 0x000E0848 File Offset: 0x000DEA48
	[Token(Token = "0x600298C")]
	[Address(RVA = "0x6870D0", Offset = "0x6856D0", VA = "0x1806870D0")]
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

	// Token: 0x0600298D RID: 10637 RVA: 0x000E08E0 File Offset: 0x000DEAE0
	[Token(Token = "0x600298D")]
	[Address(RVA = "0x683490", Offset = "0x681A90", VA = "0x180683490")]
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

	// Token: 0x0600298E RID: 10638 RVA: 0x000E0A9C File Offset: 0x000DEC9C
	[Token(Token = "0x600298E")]
	[Address(RVA = "0x686BF0", Offset = "0x6851F0", VA = "0x180686BF0")]
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

	// Token: 0x0600298F RID: 10639 RVA: 0x000E0AD8 File Offset: 0x000DECD8
	[Token(Token = "0x600298F")]
	[Address(RVA = "0x688360", Offset = "0x686960", VA = "0x180688360")]
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

	// Token: 0x06002990 RID: 10640 RVA: 0x000E0B88 File Offset: 0x000DED88
	[Token(Token = "0x6002990")]
	[Address(RVA = "0x686280", Offset = "0x684880", VA = "0x180686280")]
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
					goto IL_0112;
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
						goto IL_0112;
					}
					goto IL_0132;
				}
				IL_013A:
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
				goto IL_01AD;
				IL_0112:
				component = this.current.GetComponent<Image>();
				Dictionary<AlmanacCardUI, AlmanacBuffMenu.CardInfo> dictionary2 = this.cardInfos;
				bool flag4;
				if (!flag4)
				{
					goto IL_01AD;
				}
				int num7 = 0;
				IL_0132:
				PlantType plantType8 = almanacCardUI._plantType;
				goto IL_013A;
				IL_01AD:
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
		}
	}

	// Token: 0x06002991 RID: 10641 RVA: 0x000E0D58 File Offset: 0x000DEF58
	[Token(Token = "0x6002991")]
	[Address(RVA = "0x686F30", Offset = "0x685530", VA = "0x180686F30")]
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

	// Token: 0x06002992 RID: 10642 RVA: 0x000E0DB4 File Offset: 0x000DEFB4
	[Token(Token = "0x6002992")]
	[Address(RVA = "0x688850", Offset = "0x686E50", VA = "0x180688850")]
	public AlmanacBuffMenu()
	{
		Dictionary<AlmanacCardUI, AlmanacBuffMenu.CardInfo> dictionary = new Dictionary();
		this.cardInfos = dictionary;
		base..ctor();
	}

	// Token: 0x04001786 RID: 6022
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001786")]
	[Header("预制体")]
	public GameObject cardPrefab;

	// Token: 0x04001787 RID: 6023
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001787")]
	[Header("UI引用")]
	public RectTransform axis;

	// Token: 0x04001788 RID: 6024
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001788")]
	public RectTransform axis2;

	// Token: 0x04001789 RID: 6025
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001789")]
	public TextMeshProUGUI buffTitle;

	// Token: 0x0400178A RID: 6026
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400178A")]
	public TextMeshProUGUI buffDescription;

	// Token: 0x0400178B RID: 6027
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400178B")]
	public Image windowBackground;

	// Token: 0x0400178C RID: 6028
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400178C")]
	[Header("背景展示")]
	public Sprite day;

	// Token: 0x0400178D RID: 6029
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400178D")]
	public Sprite night;

	// Token: 0x0400178E RID: 6030
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400178E")]
	public Sprite pool;

	// Token: 0x0400178F RID: 6031
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400178F")]
	[Header("按钮绑定")]
	public UIButton allBuff;

	// Token: 0x04001790 RID: 6032
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4001790")]
	public UIButton weakUltiBuff;

	// Token: 0x04001791 RID: 6033
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4001791")]
	public UIButton strongUltiBuff;

	// Token: 0x04001792 RID: 6034
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4001792")]
	public UIButton generalBuff;

	// Token: 0x04001793 RID: 6035
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4001793")]
	public UIButton randomBuff;

	// Token: 0x04001794 RID: 6036
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4001794")]
	public UIButton zombieBuff;

	// Token: 0x04001795 RID: 6037
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4001795")]
	public UIButton curseBuff;

	// Token: 0x04001796 RID: 6038
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4001796")]
	public UIButton rogueBuff;

	// Token: 0x04001797 RID: 6039
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4001797")]
	public UIButton comboBuff;

	// Token: 0x04001798 RID: 6040
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4001798")]
	public UIButton tinyBuff;

	// Token: 0x04001799 RID: 6041
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4001799")]
	public UIButton shootingBuff;

	// Token: 0x0400179A RID: 6042
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x400179A")]
	private List<AlmanacCardUI> weakUltiBuffs;

	// Token: 0x0400179B RID: 6043
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x400179B")]
	private List<AlmanacCardUI> strongUltiBuffs;

	// Token: 0x0400179C RID: 6044
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x400179C")]
	private List<AlmanacCardUI> generalBuffs;

	// Token: 0x0400179D RID: 6045
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x400179D")]
	private List<AlmanacCardUI> randomBuffs;

	// Token: 0x0400179E RID: 6046
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x400179E")]
	private List<AlmanacCardUI> zombieBuffs;

	// Token: 0x0400179F RID: 6047
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x400179F")]
	private List<AlmanacCardUI> curseBuffs;

	// Token: 0x040017A0 RID: 6048
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x40017A0")]
	private List<AlmanacCardUI> rogueBuffs;

	// Token: 0x040017A1 RID: 6049
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x40017A1")]
	private List<AlmanacCardUI> comboBuffs;

	// Token: 0x040017A2 RID: 6050
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x40017A2")]
	private List<AlmanacCardUI> tinyBuffs;

	// Token: 0x040017A3 RID: 6051
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x40017A3")]
	private List<AlmanacCardUI> shootingBuffs;

	// Token: 0x040017A4 RID: 6052
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x40017A4")]
	private GameObject tempShow;

	// Token: 0x040017A5 RID: 6053
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x40017A5")]
	public readonly Dictionary<AlmanacCardUI, AlmanacBuffMenu.CardInfo> cardInfos;

	// Token: 0x040017A6 RID: 6054
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x40017A6")]
	private bool inited;

	// Token: 0x040017A7 RID: 6055
	[Token(Token = "0x40017A7")]
	public static bool lookBuff;

	// Token: 0x040017A8 RID: 6056
	[FieldOffset(Offset = "0x161")]
	[Token(Token = "0x40017A8")]
	public bool editMode;

	// Token: 0x040017A9 RID: 6057
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x40017A9")]
	public UIButton toolButton;

	// Token: 0x040017AA RID: 6058
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x40017AA")]
	private AlmanacCardUI current;

	// Token: 0x02000803 RID: 2051
	[Token(Token = "0x2000803")]
	public struct CardInfo
	{
		// Token: 0x040017AB RID: 6059
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40017AB")]
		public object buff;

		// Token: 0x040017AC RID: 6060
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40017AC")]
		public string description;

		// Token: 0x040017AD RID: 6061
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40017AD")]
		public PlantType plantType;

		// Token: 0x040017AE RID: 6062
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40017AE")]
		public ZombieType zombieType;

		// Token: 0x040017AF RID: 6063
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40017AF")]
		public bool isZombie;
	}
}
