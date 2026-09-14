using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020007E9 RID: 2025
[Token(Token = "0x20007E9")]
public class MultipleChoiceMenu : BaseMenu
{
	// Token: 0x170001A5 RID: 421
	// (get) Token: 0x0600295C RID: 10588 RVA: 0x000E161C File Offset: 0x000DF81C
	[Token(Token = "0x170001A5")]
	public int OptionCount
	{
		[Token(Token = "0x600295C")]
		[Address(RVA = "0x63F430", Offset = "0x63DA30", VA = "0x18063F430")]
		get
		{
			return this.optionDatas._size;
		}
	}

	// Token: 0x170001A6 RID: 422
	// (get) Token: 0x0600295D RID: 10589 RVA: 0x000E163C File Offset: 0x000DF83C
	// (set) Token: 0x0600295E RID: 10590 RVA: 0x000E1650 File Offset: 0x000DF850
	[Token(Token = "0x170001A6")]
	public bool KeySelect
	{
		[Token(Token = "0x600295D")]
		[Address(RVA = "0x63F420", Offset = "0x63DA20", VA = "0x18063F420")]
		get;
		[Token(Token = "0x600295E")]
		[Address(RVA = "0x63F470", Offset = "0x63DA70", VA = "0x18063F470")]
		set;
	}

	// Token: 0x0600295F RID: 10591 RVA: 0x000E1664 File Offset: 0x000DF864
	[Token(Token = "0x600295F")]
	[Address(RVA = "0x63D0A0", Offset = "0x63B6A0", VA = "0x18063D0A0", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		GameObject gameObject = this.sampleBaseWindow.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
		UnityEvent theEvent_up = this.refreshButton.theEvent_up;
		UnityAction unityAction = delegate
		{
			int num4 = 0;
			this.Refresh(num4 != 0);
		};
		theEvent_up.AddListener(unityAction);
		UnityEvent theEvent_up2 = this.cancelButton.theEvent_up;
		UnityAction unityAction2 = new UnityAction(this.Cancel);
		theEvent_up2.AddListener(unityAction2);
		TheButton theButton = this.turnPageButton;
		int num2 = 0;
		if (theButton != num2)
		{
			UnityEvent theEvent_up3 = this.turnPageButton.theEvent_up;
			UnityAction unityAction3 = new UnityAction(this.TurnPage);
			theEvent_up3.AddListener(unityAction3);
		}
		TheButton theButton2 = this.confirmButton;
		int num3 = 0;
		if (theButton2 != num3)
		{
			UnityEvent theEvent_up4 = this.confirmButton.theEvent_up;
			UnityAction unityAction4 = new UnityAction(this.Confirm);
			theEvent_up4.AddListener(unityAction4);
		}
	}

	// Token: 0x06002960 RID: 10592 RVA: 0x000E1750 File Offset: 0x000DF950
	[Token(Token = "0x6002960")]
	[Address(RVA = "0x63E7A0", Offset = "0x63CDA0", VA = "0x18063E7A0")]
	private void Start()
	{
		this.Refresh(true);
		this.quickSet = true;
		Time.timeScale = (float)0;
	}

	// Token: 0x06002961 RID: 10593 RVA: 0x000E177C File Offset: 0x000DF97C
	[Token(Token = "0x6002961")]
	[Address(RVA = "0x63F100", Offset = "0x63D700", VA = "0x18063F100")]
	private void Update()
	{
		if (this.<KeySelect>k__BackingField)
		{
			if (Input.GetKeyDownInt((KeyCode)((uint)49)))
			{
				int num = 0;
				this.SelectWindow(num);
			}
			if (Input.GetKeyDownInt((KeyCode)((uint)50)))
			{
				this.SelectWindow(1);
			}
			if (Input.GetKeyDownInt((KeyCode)((uint)51)))
			{
				this.SelectWindow(2);
			}
			if (Input.GetKeyDownInt((KeyCode)((uint)52)))
			{
				this.SelectWindow(3);
			}
			if (Input.GetKeyDownInt((KeyCode)((uint)53)))
			{
				this.SelectWindow(4);
			}
			if (Input.GetKeyDownInt((KeyCode)((uint)32)))
			{
				BaseWindow baseWindow = this.currentSelect;
				int num2 = 0;
				if (!(baseWindow == num2))
				{
					this.currentSelect.Confirm();
					return;
				}
				GameAPP.PlaySound(26, 0.5f, 1f);
				InGameText instance = InGameText.Instance;
				int num3 = 0;
				instance.ShowText("你还没有选择选项", 3f, num3 != 0);
				return;
			}
		}
	}

	// Token: 0x06002962 RID: 10594 RVA: 0x000E1854 File Offset: 0x000DFA54
	[Token(Token = "0x6002962")]
	[Address(RVA = "0x63DAB0", Offset = "0x63C0B0", VA = "0x18063DAB0")]
	public TheButton RegisterButton(string name, UnityAction<MultipleChoiceMenu, TheButton> onClick, bool interactable, bool left = false)
	{
		TheButton theButton = this.confirmButton;
		Transform parent = theButton.transform.parent;
		TheButton theButton2 = global::UnityEngine.Object.Instantiate<TheButton>(theButton, parent);
		TheButton button = theButton2;
		button.theEvent_up.RemoveAllListeners();
		UnityEvent theEvent_up = button.theEvent_up;
		UnityAction unityAction = delegate
		{
			if (onClick != 0)
			{
			}
		};
		theEvent_up.AddListener(unityAction);
		button.GetComponentInChildren<TextMeshProUGUI>().text = name;
		button.Interactable = interactable;
		button.transform.SetAsFirstSibling();
		return button;
	}

	// Token: 0x06002963 RID: 10595 RVA: 0x000E1908 File Offset: 0x000DFB08
	[Token(Token = "0x6002963")]
	[Address(RVA = "0x63E3F0", Offset = "0x63C9F0", VA = "0x18063E3F0")]
	public void SetOrdered(bool ordered)
	{
		this.ordered = ordered;
	}

	// Token: 0x06002964 RID: 10596 RVA: 0x000E191C File Offset: 0x000DFB1C
	[Token(Token = "0x6002964")]
	[Address(RVA = "0x63E400", Offset = "0x63CA00", VA = "0x18063E400")]
	public void SetRefreshable(bool refreshable, int refreshCount = 0, bool refreshDistinct = false, bool interactable = true, bool enableTurnPage = false)
	{
		this.refreshButton.gameObject.SetActive(refreshable);
		this.refreshCount = refreshCount;
		this.refreshDistinct = refreshDistinct;
		TheButton theButton = this.refreshButton;
		int num = 0;
		theButton.Interactable = num != 0;
		GameObject gameObject = this.turnPageButton.gameObject;
		int num2 = 0;
		gameObject.SetActive(num2 != 0);
	}

	// Token: 0x06002965 RID: 10597 RVA: 0x000E1980 File Offset: 0x000DFB80
	[Token(Token = "0x6002965")]
	[Address(RVA = "0x63E380", Offset = "0x63C980", VA = "0x18063E380")]
	public void SetCancelable(bool cancelable, bool interactable = true)
	{
		this.cancelButton.gameObject.SetActive(cancelable);
		if (!interactable)
		{
			TheButton theButton = this.cancelButton;
			int num = 0;
			theButton.Interactable = num != 0;
		}
	}

	// Token: 0x06002966 RID: 10598 RVA: 0x000E19B8 File Offset: 0x000DFBB8
	[Token(Token = "0x6002966")]
	[Address(RVA = "0x63E160", Offset = "0x63C760", VA = "0x18063E160")]
	public void RegisterWindow(int count)
	{
		int num = 0;
		if (num < count)
		{
			BaseWindow baseWindow = this.sampleBaseWindow;
			Transform parent = baseWindow.transform.parent;
			GameObject gameObject = global::UnityEngine.Object.Instantiate<BaseWindow>(baseWindow, parent).gameObject;
			ulong num2;
			gameObject.SetActive(num2 != 0UL);
			List<BaseWindow> list = this.windows;
			int size = list._size;
			num++;
			list._size = gameObject;
			num++;
		}
		this.pageSize = count;
		this.currentPage = (int)((ulong)0L);
		this.UpdateTurnPageButtonText();
	}

	// Token: 0x06002967 RID: 10599 RVA: 0x000E1A34 File Offset: 0x000DFC34
	[Token(Token = "0x6002967")]
	[Address(RVA = "0x63DCE0", Offset = "0x63C2E0", VA = "0x18063DCE0")]
	public void RegisterOption(string title, string text, UnityAction call, PlantType plantType = PlantType.EndoFlame, ZombieType zombieType = ZombieType.Nothing, Quality frameType = Quality.Default, bool interactable = true)
	{
		int num = 0;
		MultipleChoiceMenu.OptionData optionData;
		optionData.FieldGetter(num, text, call);
		optionData.title = title;
		optionData.text = text;
		optionData.call = call;
		optionData.thePlantType = PlantType.Peashooter;
		optionData.theZombieType = ZombieType.NormalZombie;
		optionData.quality = Quality.Default;
		optionData.interactable = false;
		List<MultipleChoiceMenu.OptionData> list = this.optionDatas;
		int size = list._size;
		list._size = 0;
		List<MultipleChoiceMenu.OptionData> list2 = this.restOptionDatas;
		int size2 = list2._size;
	}

	// Token: 0x06002968 RID: 10600 RVA: 0x000E1AB4 File Offset: 0x000DFCB4
	[Token(Token = "0x6002968")]
	[Address(RVA = "0x63DE90", Offset = "0x63C490", VA = "0x18063DE90")]
	public void RegisterOptions(List<MultipleChoiceOptionData> options)
	{
		ulong num;
		do
		{
			bool flag;
			if (flag)
			{
				MultipleChoiceMenu.OptionData optionData;
				optionData.quality = (Quality)((ulong)0L);
				optionData.interactable = true;
				optionData.call = optionData;
				optionData.call = optionData;
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06002969 RID: 10601 RVA: 0x000E1B24 File Offset: 0x000DFD24
	[Token(Token = "0x6002969")]
	[Address(RVA = "0x63D3A0", Offset = "0x63B9A0", VA = "0x18063D3A0")]
	public void ClearOptions()
	{
		List<MultipleChoiceMenu.OptionData> list = this.optionDatas;
		int size = list._size;
		list._size = (int)((ulong)0L);
		if (size > 0)
		{
			return;
		}
	}

	// Token: 0x0600296A RID: 10602 RVA: 0x000E1B58 File Offset: 0x000DFD58
	[Token(Token = "0x600296A")]
	[Address(RVA = "0x63EA70", Offset = "0x63D070", VA = "0x18063EA70")]
	private void UpdateWindow(BaseWindow window, MultipleChoiceMenu.OptionData optionData)
	{
		if (optionData != (ulong)0L)
		{
			BaseWindow window2 = window;
			bool flag;
			if (!flag)
			{
				window.clickEvent.RemoveAllListeners();
				BaseWindow window3 = window;
				int num = 0;
				window3.onAnimOver = num;
				MultipleChoiceMenu.OptionData optionData2 = optionData;
				UnityEvent clickEvent = window.clickEvent;
				UnityAction call = optionData.call;
				clickEvent.AddListener(call);
				UnityEvent clickEvent2 = window.clickEvent;
				UnityAction unityAction = new UnityAction(this.OnSelect);
				clickEvent2.AddListener(unityAction);
				if ((this.confirmMode ? 1 : 0) != num)
				{
					UnityAction<UIButton> unityAction2;
					window.onSelect.AddListener(unityAction2);
				}
				BaseWindow window4 = window;
				MultipleChoiceMenu.OptionData optionData3 = optionData;
				TextMeshProUGUI title = window4.title;
				string title2 = optionData3.title;
				title.text = title2;
				BaseWindow window5 = window;
				MultipleChoiceMenu.OptionData optionData4 = optionData;
				TextMeshProUGUI introduce = window5.introduce;
				string text = optionData4.text;
				introduce.text = text;
				MultipleChoiceMenu.OptionData optionData5 = optionData;
				BaseWindow window6 = window;
				Quality quality = optionData5.quality;
				Image frameImage = window6.frameImage;
				int num2 = 0;
				if (!(frameImage == num2))
				{
					if (quality == Quality.Default)
					{
					}
					string text3;
					string text2 = "UI/Img_Almanac/Frame_" + text3;
					Image frameImage2 = window6.frameImage;
					Sprite sprite = Resources.Load<Sprite>(text2);
					frameImage2.sprite = sprite;
				}
				MultipleChoiceMenu.OptionData optionData6 = optionData;
				BaseWindow window7 = window;
				bool interactable = optionData6.interactable;
				window7.Interactable = interactable;
				MultipleChoiceMenu.OptionData optionData7 = optionData;
				bool flag2 = this.quickSet;
				Delegate @delegate;
				if (optionData7.theZombieType == ZombieType.Nothing)
				{
					if (!flag2)
					{
						BaseWindow window8 = window;
						Action onAnimOver = window8.onAnimOver;
						Action action = delegate
						{
							MultipleChoiceMenu.OptionData optionData9 = optionData;
							BaseWindow window13 = window;
							PlantType thePlantType = optionData9.thePlantType;
							GameObject gameObject2 = window13.ResetPlant(thePlantType);
						};
						@delegate = Delegate.Combine(onAnimOver, action);
						if (@delegate == 0)
						{
							window8.onAnimOver = num;
						}
						if (@delegate != 0)
						{
							window8.onAnimOver = @delegate;
							if (@delegate != 0)
							{
								goto IL_020F;
							}
						}
						throw new InvalidCastException();
					}
					IL_020F:
					BaseWindow window9 = window;
				}
				GameObject gameObject;
				if (gameObject == 0)
				{
					BaseWindow window10 = window;
					Action onAnimOver2 = window10.onAnimOver;
					Action action2 = delegate
					{
						MultipleChoiceMenu.OptionData optionData10 = optionData;
						BaseWindow window14 = window;
						ZombieType theZombieType = optionData10.theZombieType;
						window14.SetZombie(theZombieType, 1f);
					};
					Delegate delegate2 = Delegate.Combine(onAnimOver2, action2);
					if (delegate2 == 0)
					{
						window10.onAnimOver = @delegate;
					}
					if (delegate2 != 0)
					{
						window10.onAnimOver = delegate2;
						if (delegate2 != 0)
						{
							goto IL_0267;
						}
					}
					throw new InvalidCastException();
				}
				IL_0267:
				BaseWindow window11 = window;
				Dictionary<BaseWindow, MultipleChoiceMenu.OptionData> dictionary = this.windowOptionPairs;
				MultipleChoiceMenu.OptionData optionData8 = optionData;
				BaseWindow window12 = window;
				dictionary[window12] = optionData8;
				return;
			}
		}
		Debug.LogWarning("没有找到window或选项数据");
		throw new NullReferenceException();
	}

	// Token: 0x0600296B RID: 10603 RVA: 0x000E1E14 File Offset: 0x000E0014
	[Token(Token = "0x600296B")]
	[Address(RVA = "0x63E300", Offset = "0x63C900", VA = "0x18063E300")]
	private void SelectWindow(int index)
	{
		this.windows[index].OnClicked();
	}

	// Token: 0x0600296C RID: 10604 RVA: 0x000E1E3C File Offset: 0x000E003C
	[Token(Token = "0x600296C")]
	[Address(RVA = "0x63D510", Offset = "0x63BB10", VA = "0x18063D510")]
	private void OnSelect()
	{
		Time.timeScale = GameAPP.config.gameSpeed;
		base.PopMenu();
		if (this.actionOnExit != 0)
		{
		}
	}

	// Token: 0x0600296D RID: 10605 RVA: 0x000E1E70 File Offset: 0x000E0070
	[Token(Token = "0x600296D")]
	[Address(RVA = "0x63D5D0", Offset = "0x63BBD0", VA = "0x18063D5D0")]
	private void Refresh(bool first)
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			this.currentPage = num2;
			if (this.refreshCount <= num)
			{
				goto IL_0105;
			}
			BaseWindow baseWindow = this.currentSelect;
			int num3 = 0;
			if (baseWindow != num3)
			{
				this.currentSelect.OnDisSelect();
				this.currentSelect = num2;
			}
			if (first || this.actionOnRefresh != 0)
			{
			}
			TextMeshProUGUI componentInChildren = this.refreshButton.GetComponentInChildren<TextMeshProUGUI>();
			int num4 = this.refreshCount;
			string text = string.Format("刷新({0})", componentInChildren);
			componentInChildren.text = text;
			TheButton theButton = this.turnPageButton;
			int num5 = 0;
			if (!(theButton != num5))
			{
			}
			if (this.turnPageButton.gameObject.activeSelf != first)
			{
				goto IL_0105;
			}
			if ((this.refreshDistinct ? 1 : 0) == num2)
			{
				List<MultipleChoiceMenu.OptionData> list = new List(this.optionDatas);
			}
			List<MultipleChoiceMenu.OptionData> list2 = this.restOptionDatas;
			List<BaseWindow> list3 = this.windows;
			bool flag;
			if (flag)
			{
				if (!this.ordered)
				{
					MultipleChoiceMenu.OptionData randomAndRemove = ListExtensions.GetRandomAndRemove<MultipleChoiceMenu.OptionData>(list2);
				}
				MultipleChoiceMenu.OptionData optionData = Enumerable.FirstOrDefault<MultipleChoiceMenu.OptionData>(list2);
				bool flag2 = list2.Remove(optionData);
				this.UpdateWindow(num, optionData);
			}
		}
		while (num2 != 0);
		return;
		IL_0105:
		GameAPP.PlaySound((SoundType)((uint)26), 0.5f, 1f);
		InGameText instance = InGameText.Instance;
		int num6 = 0;
		instance.ShowText("刷新次数已用完", 3f, num6 != 0);
		throw new NullReferenceException();
	}

	// Token: 0x0600296E RID: 10606 RVA: 0x000E1FC0 File Offset: 0x000E01C0
	[Token(Token = "0x600296E")]
	[Address(RVA = "0x63D2E0", Offset = "0x63B8E0", VA = "0x18063D2E0")]
	private void Cancel()
	{
		if (this.actionOnExit != 0)
		{
		}
		Time.timeScale = GameAPP.config.gameSpeed;
		throw new NullReferenceException();
	}

	// Token: 0x0600296F RID: 10607 RVA: 0x000E1FEC File Offset: 0x000E01EC
	[Token(Token = "0x600296F")]
	[Address(RVA = "0x63D410", Offset = "0x63BA10", VA = "0x18063D410")]
	private void Confirm()
	{
		BaseWindow baseWindow = this.currentSelect;
		int num = 0;
		if (!(baseWindow == num))
		{
			this.currentSelect.Confirm();
			return;
		}
		GameAPP.PlaySound(26, 0.5f, 1f);
		InGameText instance = InGameText.Instance;
		int num2 = 0;
		instance.ShowText("你还没有选择选项", 3f, num2 != 0);
	}

	// Token: 0x06002970 RID: 10608 RVA: 0x000E204C File Offset: 0x000E024C
	[Token(Token = "0x6002970")]
	[Address(RVA = "0x63E830", Offset = "0x63CE30", VA = "0x18063E830")]
	private void TurnPage()
	{
		List<MultipleChoiceMenu.OptionData> list = this.optionDatas;
		int num = this.currentPage;
		num++;
		this.totalPages = typeof(Math).TypeHandle;
		this.ShowCurrentPage();
	}

	// Token: 0x06002971 RID: 10609 RVA: 0x000E2084 File Offset: 0x000E0284
	[Token(Token = "0x6002971")]
	[Address(RVA = "0x63E540", Offset = "0x63CB40", VA = "0x18063E540")]
	private void ShowCurrentPage()
	{
		BaseWindow baseWindow = this.currentSelect;
		int num = 0;
		bool flag = baseWindow != num;
		int num2 = 0;
		if (flag)
		{
			this.currentSelect.OnDisSelect();
			this.currentSelect = num2;
		}
		List<MultipleChoiceMenu.OptionData> list = this.optionDatas;
		int num3 = this.pageSize;
		int num4 = this.pageSize;
		num4 += num3;
		List<BaseWindow> list2 = this.windows;
		int num5;
		if (0 < num5)
		{
			List<MultipleChoiceMenu.OptionData> list3 = this.optionDatas;
			BaseWindow baseWindow2 = this.windows[num2];
			MultipleChoiceMenu.OptionData optionData = this.optionDatas[0];
		}
		BaseWindow baseWindow3 = this.windows[num2];
		MultipleChoiceMenu.OptionData optionData2;
		this.UpdateWindow(baseWindow3, optionData2);
		List<BaseWindow> list4 = this.windows;
		num2++;
		this.UpdateTurnPageButtonText();
	}

	// Token: 0x06002972 RID: 10610 RVA: 0x000E213C File Offset: 0x000E033C
	[Token(Token = "0x6002972")]
	[Address(RVA = "0x63E900", Offset = "0x63CF00", VA = "0x18063E900")]
	private void UpdateTurnPageButtonText()
	{
		List<MultipleChoiceMenu.OptionData> list = this.optionDatas;
		this.totalPages = typeof(Math).TypeHandle;
		if (typeof(Math).TypeHandle > 0)
		{
			int num = this.currentPage;
			num++;
			int num2 = this.totalPages;
			string text = string.Format("翻页({0}/{1})", num, num);
		}
		this.turnPageButton.GetComponentInChildren<TextMeshProUGUI>().text = "翻页(0/0)";
	}

	// Token: 0x06002973 RID: 10611 RVA: 0x000E21A0 File Offset: 0x000E03A0
	[Token(Token = "0x6002973")]
	[Address(RVA = "0x63F2C0", Offset = "0x63D8C0", VA = "0x18063F2C0")]
	public MultipleChoiceMenu()
	{
		List<BaseWindow> list = new List();
		this.windows = list;
		Dictionary<BaseWindow, MultipleChoiceMenu.OptionData> dictionary = new Dictionary();
		this.windowOptionPairs = dictionary;
		List<MultipleChoiceMenu.OptionData> list2 = new List();
		this.optionDatas = list2;
		List<MultipleChoiceMenu.OptionData> list3 = new List();
		this.restOptionDatas = list3;
		base..ctor();
	}

	// Token: 0x0400179D RID: 6045
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400179D")]
	public BaseWindow sampleBaseWindow;

	// Token: 0x0400179E RID: 6046
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400179E")]
	public TheButton refreshButton;

	// Token: 0x0400179F RID: 6047
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400179F")]
	public TheButton cancelButton;

	// Token: 0x040017A0 RID: 6048
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40017A0")]
	public TheButton turnPageButton;

	// Token: 0x040017A1 RID: 6049
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40017A1")]
	public Action actionOnExit;

	// Token: 0x040017A2 RID: 6050
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40017A2")]
	public Action actionOnRefresh;

	// Token: 0x040017A4 RID: 6052
	[FieldOffset(Offset = "0x71")]
	[Token(Token = "0x40017A4")]
	private bool refreshDistinct;

	// Token: 0x040017A5 RID: 6053
	[FieldOffset(Offset = "0x72")]
	[Token(Token = "0x40017A5")]
	private bool quickSet;

	// Token: 0x040017A6 RID: 6054
	[FieldOffset(Offset = "0x73")]
	[Token(Token = "0x40017A6")]
	private bool ordered;

	// Token: 0x040017A7 RID: 6055
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x40017A7")]
	private int refreshCount;

	// Token: 0x040017A8 RID: 6056
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40017A8")]
	private int currentPage;

	// Token: 0x040017A9 RID: 6057
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x40017A9")]
	private int pageSize = (int)((ulong)5L);

	// Token: 0x040017AA RID: 6058
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40017AA")]
	private int totalPages = (int)((ulong)1L);

	// Token: 0x040017AB RID: 6059
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40017AB")]
	private readonly List<BaseWindow> windows;

	// Token: 0x040017AC RID: 6060
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40017AC")]
	public Dictionary<BaseWindow, MultipleChoiceMenu.OptionData> windowOptionPairs;

	// Token: 0x040017AD RID: 6061
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40017AD")]
	public readonly List<MultipleChoiceMenu.OptionData> optionDatas;

	// Token: 0x040017AE RID: 6062
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40017AE")]
	public readonly List<MultipleChoiceMenu.OptionData> restOptionDatas;

	// Token: 0x040017AF RID: 6063
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40017AF")]
	[Header("确认模式")]
	public bool confirmMode;

	// Token: 0x040017B0 RID: 6064
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40017B0")]
	public TheButton confirmButton;

	// Token: 0x040017B1 RID: 6065
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40017B1")]
	public BaseWindow currentSelect;

	// Token: 0x020007EA RID: 2026
	[Token(Token = "0x20007EA")]
	public class OptionData
	{
		// Token: 0x06002975 RID: 10613 RVA: 0x000E2214 File Offset: 0x000E0414
		[Token(Token = "0x6002975")]
		[Address(RVA = "0x63F510", Offset = "0x63DB10", VA = "0x18063F510")]
		public OptionData(string title, string text, UnityAction call, PlantType thePlantType, ZombieType theZombieType, Quality quality, bool interactable)
		{
			int num = 0;
			base.FieldGetter(num, text, call);
			this.title = title;
			this.text = text;
			this.call = call;
			this.thePlantType = PlantType.Peashooter;
			this.theZombieType = ZombieType.NormalZombie;
			this.quality = Quality.Default;
			this.interactable = false;
		}

		// Token: 0x040017B2 RID: 6066
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40017B2")]
		public string title;

		// Token: 0x040017B3 RID: 6067
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40017B3")]
		public string text;

		// Token: 0x040017B4 RID: 6068
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40017B4")]
		public UnityAction call;

		// Token: 0x040017B5 RID: 6069
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40017B5")]
		public PlantType thePlantType;

		// Token: 0x040017B6 RID: 6070
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40017B6")]
		public ZombieType theZombieType;

		// Token: 0x040017B7 RID: 6071
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40017B7")]
		public Quality quality;

		// Token: 0x040017B8 RID: 6072
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40017B8")]
		public bool interactable;
	}
}
