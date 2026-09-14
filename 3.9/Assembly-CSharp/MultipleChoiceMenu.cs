using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000824 RID: 2084
[Token(Token = "0x2000824")]
public class MultipleChoiceMenu : BaseMenu
{
	// Token: 0x170001EF RID: 495
	// (get) Token: 0x06002A92 RID: 10898 RVA: 0x000E675C File Offset: 0x000E495C
	[Token(Token = "0x170001EF")]
	public int OptionCount
	{
		[Token(Token = "0x6002A92")]
		[Address(RVA = "0x6A3A00", Offset = "0x6A2000", VA = "0x1806A3A00")]
		get
		{
			return this.optionDatas._size;
		}
	}

	// Token: 0x170001F0 RID: 496
	// (get) Token: 0x06002A93 RID: 10899 RVA: 0x000E677C File Offset: 0x000E497C
	// (set) Token: 0x06002A94 RID: 10900 RVA: 0x000E6790 File Offset: 0x000E4990
	[Token(Token = "0x170001F0")]
	public bool KeySelect
	{
		[Token(Token = "0x6002A93")]
		[Address(RVA = "0x6A39F0", Offset = "0x6A1FF0", VA = "0x1806A39F0")]
		get;
		[Token(Token = "0x6002A94")]
		[Address(RVA = "0x6A3A40", Offset = "0x6A2040", VA = "0x1806A3A40")]
		set;
	}

	// Token: 0x06002A95 RID: 10901 RVA: 0x000E67A4 File Offset: 0x000E49A4
	[Token(Token = "0x6002A95")]
	[Address(RVA = "0x6A1610", Offset = "0x69FC10", VA = "0x1806A1610", Slot = "6")]
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

	// Token: 0x06002A96 RID: 10902 RVA: 0x000E688C File Offset: 0x000E4A8C
	[Token(Token = "0x6002A96")]
	[Address(RVA = "0x6A2D20", Offset = "0x6A1320", VA = "0x1806A2D20")]
	private void Start()
	{
		this.Refresh(true);
		this.quickSet = true;
		Time.timeScale = (float)0;
	}

	// Token: 0x06002A97 RID: 10903 RVA: 0x000E68B8 File Offset: 0x000E4AB8
	[Token(Token = "0x6002A97")]
	[Address(RVA = "0x6A36C0", Offset = "0x6A1CC0", VA = "0x1806A36C0")]
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
				return;
			}
		}
	}

	// Token: 0x06002A98 RID: 10904 RVA: 0x000E697C File Offset: 0x000E4B7C
	[Token(Token = "0x6002A98")]
	[Address(RVA = "0x6A2030", Offset = "0x6A0630", VA = "0x1806A2030")]
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

	// Token: 0x06002A99 RID: 10905 RVA: 0x000E6A30 File Offset: 0x000E4C30
	[Token(Token = "0x6002A99")]
	[Address(RVA = "0x6A2970", Offset = "0x6A0F70", VA = "0x1806A2970")]
	public void SetOrdered(bool ordered)
	{
		this.ordered = ordered;
	}

	// Token: 0x06002A9A RID: 10906 RVA: 0x000E6A44 File Offset: 0x000E4C44
	[Token(Token = "0x6002A9A")]
	[Address(RVA = "0x6A2980", Offset = "0x6A0F80", VA = "0x1806A2980")]
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

	// Token: 0x06002A9B RID: 10907 RVA: 0x000E6AA8 File Offset: 0x000E4CA8
	[Token(Token = "0x6002A9B")]
	[Address(RVA = "0x6A2900", Offset = "0x6A0F00", VA = "0x1806A2900")]
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

	// Token: 0x06002A9C RID: 10908 RVA: 0x000E6AE0 File Offset: 0x000E4CE0
	[Token(Token = "0x6002A9C")]
	[Address(RVA = "0x6A26E0", Offset = "0x6A0CE0", VA = "0x1806A26E0")]
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

	// Token: 0x06002A9D RID: 10909 RVA: 0x000E6B5C File Offset: 0x000E4D5C
	[Token(Token = "0x6002A9D")]
	[Address(RVA = "0x6A2260", Offset = "0x6A0860", VA = "0x1806A2260")]
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

	// Token: 0x06002A9E RID: 10910 RVA: 0x000E6BDC File Offset: 0x000E4DDC
	[Token(Token = "0x6002A9E")]
	[Address(RVA = "0x6A2410", Offset = "0x6A0A10", VA = "0x1806A2410")]
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

	// Token: 0x06002A9F RID: 10911 RVA: 0x000E6C4C File Offset: 0x000E4E4C
	[Token(Token = "0x6002A9F")]
	[Address(RVA = "0x6A1910", Offset = "0x69FF10", VA = "0x1806A1910")]
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

	// Token: 0x06002AA0 RID: 10912 RVA: 0x000E6C80 File Offset: 0x000E4E80
	[Token(Token = "0x6002AA0")]
	[Address(RVA = "0x6A2FF0", Offset = "0x6A15F0", VA = "0x1806A2FF0")]
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
				Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
				MultipleChoiceMenu.OptionData optionData6 = optionData;
				BaseWindow window7 = window;
				bool interactable = optionData6.interactable;
				window7.Interactable = interactable;
				MultipleChoiceMenu.OptionData optionData7 = optionData;
				BaseWindow window8 = window;
				if (optionData7.quality != Quality.curse)
				{
					TextMeshProUGUI introduce2 = window8.introduce;
				}
				TextMeshProUGUI introduce3 = window8.introduce;
				MultipleChoiceMenu.OptionData optionData8 = optionData;
				bool flag2 = this.quickSet;
				Delegate @delegate;
				if (optionData8.theZombieType == ZombieType.Nothing)
				{
					if (!flag2)
					{
						BaseWindow window9 = window;
						Action onAnimOver = window9.onAnimOver;
						Action action = delegate
						{
							MultipleChoiceMenu.OptionData optionData10 = optionData;
							BaseWindow window14 = window;
							PlantType thePlantType = optionData10.thePlantType;
							GameObject gameObject2 = window14.ResetPlant(thePlantType);
						};
						@delegate = Delegate.Combine(onAnimOver, action);
						if (@delegate == 0)
						{
							window9.onAnimOver = num;
						}
						if (@delegate != 0)
						{
							window9.onAnimOver = @delegate;
							if (@delegate != 0)
							{
								goto IL_0209;
							}
						}
						throw new InvalidCastException();
					}
					IL_0209:
					BaseWindow window10 = window;
				}
				GameObject gameObject;
				if (gameObject == 0)
				{
					BaseWindow window11 = window;
					Action onAnimOver2 = window11.onAnimOver;
					Action action2 = delegate
					{
						MultipleChoiceMenu.OptionData optionData11 = optionData;
						BaseWindow window15 = window;
						ZombieType theZombieType = optionData11.theZombieType;
						window15.SetZombie(theZombieType, 1f);
					};
					Delegate delegate2 = Delegate.Combine(onAnimOver2, action2);
					if (delegate2 == 0)
					{
						window11.onAnimOver = @delegate;
					}
					if (delegate2 != 0)
					{
						window11.onAnimOver = delegate2;
						if (delegate2 != 0)
						{
							goto IL_0261;
						}
					}
					throw new InvalidCastException();
				}
				IL_0261:
				BaseWindow window12 = window;
				Dictionary<BaseWindow, MultipleChoiceMenu.OptionData> dictionary = this.windowOptionPairs;
				MultipleChoiceMenu.OptionData optionData9 = optionData;
				BaseWindow window13 = window;
				dictionary[window13] = optionData9;
				return;
			}
		}
		Debug.LogWarning("没有找到window或选项数据");
		throw new NullReferenceException();
	}

	// Token: 0x06002AA1 RID: 10913 RVA: 0x000E6F38 File Offset: 0x000E5138
	[Token(Token = "0x6002AA1")]
	[Address(RVA = "0x6A2880", Offset = "0x6A0E80", VA = "0x1806A2880")]
	private void SelectWindow(int index)
	{
		this.windows[index].OnClicked();
	}

	// Token: 0x06002AA2 RID: 10914 RVA: 0x000E6F60 File Offset: 0x000E5160
	[Token(Token = "0x6002AA2")]
	[Address(RVA = "0x6A1A90", Offset = "0x6A0090", VA = "0x1806A1A90")]
	private void OnSelect()
	{
		Time.timeScale = GameAPP.config.gameSpeed;
		base.PopMenu();
		if (this.actionOnExit != 0)
		{
		}
	}

	// Token: 0x06002AA3 RID: 10915 RVA: 0x000E6F94 File Offset: 0x000E5194
	[Token(Token = "0x6002AA3")]
	[Address(RVA = "0x6A1B50", Offset = "0x6A0150", VA = "0x1806A1B50")]
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
		throw new NullReferenceException();
	}

	// Token: 0x06002AA4 RID: 10916 RVA: 0x000E70D0 File Offset: 0x000E52D0
	[Token(Token = "0x6002AA4")]
	[Address(RVA = "0x6A1850", Offset = "0x69FE50", VA = "0x1806A1850")]
	private void Cancel()
	{
		Time.timeScale = GameAPP.config.gameSpeed;
		base.PopMenu();
		if (this.actionOnExit != 0)
		{
		}
	}

	// Token: 0x06002AA5 RID: 10917 RVA: 0x000E7104 File Offset: 0x000E5304
	[Token(Token = "0x6002AA5")]
	[Address(RVA = "0x6A1980", Offset = "0x69FF80", VA = "0x1806A1980")]
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
	}

	// Token: 0x06002AA6 RID: 10918 RVA: 0x000E7150 File Offset: 0x000E5350
	[Token(Token = "0x6002AA6")]
	[Address(RVA = "0x6A2DB0", Offset = "0x6A13B0", VA = "0x1806A2DB0")]
	private void TurnPage()
	{
		List<MultipleChoiceMenu.OptionData> list = this.optionDatas;
		int num = this.currentPage;
		num++;
		this.totalPages = typeof(Math).TypeHandle;
		this.ShowCurrentPage();
	}

	// Token: 0x06002AA7 RID: 10919 RVA: 0x000E7188 File Offset: 0x000E5388
	[Token(Token = "0x6002AA7")]
	[Address(RVA = "0x6A2AC0", Offset = "0x6A10C0", VA = "0x1806A2AC0")]
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

	// Token: 0x06002AA8 RID: 10920 RVA: 0x000E7240 File Offset: 0x000E5440
	[Token(Token = "0x6002AA8")]
	[Address(RVA = "0x6A2E80", Offset = "0x6A1480", VA = "0x1806A2E80")]
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

	// Token: 0x06002AA9 RID: 10921 RVA: 0x000E72A4 File Offset: 0x000E54A4
	[Token(Token = "0x6002AA9")]
	[Address(RVA = "0x6A3890", Offset = "0x6A1E90", VA = "0x1806A3890")]
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

	// Token: 0x04001886 RID: 6278
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001886")]
	public BaseWindow sampleBaseWindow;

	// Token: 0x04001887 RID: 6279
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001887")]
	public TheButton refreshButton;

	// Token: 0x04001888 RID: 6280
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001888")]
	public TheButton cancelButton;

	// Token: 0x04001889 RID: 6281
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001889")]
	public TheButton turnPageButton;

	// Token: 0x0400188A RID: 6282
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400188A")]
	public Action actionOnExit;

	// Token: 0x0400188B RID: 6283
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400188B")]
	public Action actionOnRefresh;

	// Token: 0x0400188D RID: 6285
	[FieldOffset(Offset = "0x71")]
	[Token(Token = "0x400188D")]
	private bool refreshDistinct;

	// Token: 0x0400188E RID: 6286
	[FieldOffset(Offset = "0x72")]
	[Token(Token = "0x400188E")]
	private bool quickSet;

	// Token: 0x0400188F RID: 6287
	[FieldOffset(Offset = "0x73")]
	[Token(Token = "0x400188F")]
	private bool ordered;

	// Token: 0x04001890 RID: 6288
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4001890")]
	private int refreshCount;

	// Token: 0x04001891 RID: 6289
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001891")]
	private int currentPage;

	// Token: 0x04001892 RID: 6290
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4001892")]
	private int pageSize = (int)((ulong)5L);

	// Token: 0x04001893 RID: 6291
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001893")]
	private int totalPages = (int)((ulong)1L);

	// Token: 0x04001894 RID: 6292
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001894")]
	private readonly List<BaseWindow> windows;

	// Token: 0x04001895 RID: 6293
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001895")]
	public Dictionary<BaseWindow, MultipleChoiceMenu.OptionData> windowOptionPairs;

	// Token: 0x04001896 RID: 6294
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001896")]
	public readonly List<MultipleChoiceMenu.OptionData> optionDatas;

	// Token: 0x04001897 RID: 6295
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4001897")]
	public readonly List<MultipleChoiceMenu.OptionData> restOptionDatas;

	// Token: 0x04001898 RID: 6296
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4001898")]
	[Header("确认模式")]
	public bool confirmMode;

	// Token: 0x04001899 RID: 6297
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4001899")]
	public TheButton confirmButton;

	// Token: 0x0400189A RID: 6298
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400189A")]
	public BaseWindow currentSelect;

	// Token: 0x02000825 RID: 2085
	[Token(Token = "0x2000825")]
	public class OptionData
	{
		// Token: 0x06002AAB RID: 10923 RVA: 0x000E7318 File Offset: 0x000E5518
		[Token(Token = "0x6002AAB")]
		[Address(RVA = "0x6A3AE0", Offset = "0x6A20E0", VA = "0x1806A3AE0")]
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

		// Token: 0x0400189B RID: 6299
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400189B")]
		public string title;

		// Token: 0x0400189C RID: 6300
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400189C")]
		public string text;

		// Token: 0x0400189D RID: 6301
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400189D")]
		public UnityAction call;

		// Token: 0x0400189E RID: 6302
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400189E")]
		public PlantType thePlantType;

		// Token: 0x0400189F RID: 6303
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x400189F")]
		public ZombieType theZombieType;

		// Token: 0x040018A0 RID: 6304
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40018A0")]
		public Quality quality;

		// Token: 0x040018A1 RID: 6305
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40018A1")]
		public bool interactable;
	}
}
